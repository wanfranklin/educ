using System.Net;

string ftpUrl = "ftp://ftp.exemplo.br/pub/arquivo.pdf"; // URL do arquivo FTP
string downloadPath = "livro.pdf"; // Caminho local para salvar o arquivo

using (WebClient client = new WebClient())
{
    client.DownloadFile(ftpUrl, downloadPath);
    Console.WriteLine("Download realizado com sucesso.");
}