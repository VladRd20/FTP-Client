﻿using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

public class FTPConnection
{
    private string server;
    private string username;
    private string password;

    public FTPConnection(string server, string username, string password)
    {
        this.server = server;
        this.username = username;
        this.password = password;
    }

    public void Disconnect()
    {
        server = null;
        username = null;
        password = null;
    }


    public void UploadFile(string localFilePath, string remoteFilePath)
    {
        using (WebClient client = new WebClient())
        {
            client.Credentials = new NetworkCredential(username, password);
            client.UploadFile(GetServerUri(remoteFilePath), WebRequestMethods.Ftp.UploadFile, localFilePath);
        }
    }

    public void DownloadFile(string remoteFilePath, string localFilePath)
    {
        using (WebClient client = new WebClient())
        {
            client.Credentials = new NetworkCredential(username, password);
            client.DownloadFile(GetServerUri(remoteFilePath), localFilePath);
        }
    }

    public void DeleteFile(string remoteFilePath)
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(GetServerUri(remoteFilePath));
        request.Method = WebRequestMethods.Ftp.DeleteFile;
        request.Credentials = new NetworkCredential(username, password);

        using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
        {
            Console.WriteLine($"Delete status: {response.StatusDescription}");
        }
    }

    //Function to get all the files in the current directory
    public string[] GetDirectoryList(string directoryPath)
    {
        try
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(GetServerUri(directoryPath));
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            request.Credentials = new NetworkCredential(username, password);
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                string directoryList = reader.ReadToEnd();
                return directoryList.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return null;
        }
    }


    private Uri GetServerUri(string path)
    {
        
        try
        {
            return new Uri($"ftp://{server}/{path}");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return null;
        }

    }

    public string CheckConnectionState()
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(GetServerUri(""));
        request.Method = WebRequestMethods.Ftp.ListDirectory;
        request.Credentials = new NetworkCredential(username, password);
        try
        {
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                return response.StatusDescription;
            }
        }
        catch (WebException ex)
        {
            FtpWebResponse response = (FtpWebResponse)ex.Response;
            return response.StatusDescription;
        }
    }

    public bool FileExists(string filePath)
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(GetServerUri(filePath));
        request.Method = WebRequestMethods.Ftp.GetFileSize;
        request.Credentials = new NetworkCredential(username, password);
        try
        {
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                return true;
            }
        }
        catch (WebException ex)
        {
            FtpWebResponse response = (FtpWebResponse)ex.Response;
            if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
            {
                return false;
            }
            else
            {
                throw;
            }
        }
    }


    public long GetFileSize(string filePath)
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(GetServerUri(filePath));
        request.Method = WebRequestMethods.Ftp.GetFileSize;
        request.Credentials = new NetworkCredential(username, password);
        try
        {
            using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
            {
                return response.ContentLength;
            }
        }
        catch (WebException ex)
        {
            FtpWebResponse response = (FtpWebResponse)ex.Response;
            if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
            {
                return -1;
            }
            else
            {
                throw;
            }
        }
    }


}
