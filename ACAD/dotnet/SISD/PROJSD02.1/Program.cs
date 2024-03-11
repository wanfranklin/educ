using System.Net;

string ftpUrl = "https://ftp.unicamp.br/pub/postfix/official/"; // URL do arquivo FTP
string downloadPath = "postfix-3.8.5.tar.gz"; // Caminho local para salvar o arquivo

using (WebClient client = new WebClient())
{
    client.DownloadFile(ftpUrl, downloadPath);
    Console.WriteLine("File downloaded successfully.");
}