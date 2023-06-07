using System;
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


    private Uri GetServerUri(string path)
    {
        return new Uri($"ftp://{server}/{path}");
    }

    public string CheckConnectionState()
    {
        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(GetServerUri(""));
        request.Method = WebRequestMethods.Ftp.ListDirectory;
        request.Credentials = new NetworkCredential(username, password);

        using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
        {
            return response.StatusDescription;
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
