using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class Program
{
    static TcpListener server;

    static void Main(string[] args)
    {
        // Verifica se o argumento "server" foi passado para executar como servidor
        if (args.Length > 0 && args[0].ToLower() == "server")
        {
            StartServer();
        }
        // Se não, executa como cliente
        else
        {
            StartClient();
        }
    }

    static void StartServer()
    {
        try
        {
            // Definindo o endereço IP e a porta para o servidor
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            int port = 8888;

            // Criação do servidor TCP
            server = new TcpListener(ipAddress, port);

            // Iniciando o servidor
            server.Start();

            Console.WriteLine("Servidor iniciado...");

            // Esperando por uma conexão
            TcpClient client = server.AcceptTcpClient();
            Console.WriteLine("Cliente conectado!");

            // Obtendo o stream de dados para comunicação com o cliente
            NetworkStream stream = client.GetStream();

            // Lendo dados do cliente
            byte[] data = new byte[256];
            int bytes = stream.Read(data, 0, data.Length);
            string message = Encoding.ASCII.GetString(data, 0, bytes);
            Console.WriteLine($"Mensagem recebida do cliente: {message}");

            // Respondendo ao cliente
            byte[] response = Encoding.ASCII.GetBytes("Mensagem recebida pelo servidor.");
            stream.Write(response, 0, response.Length);
            Console.WriteLine("Resposta enviada ao cliente.");

            // Fechando conexões
            stream.Close();
            client.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
        finally
        {
            // Encerrando o servidor
            server?.Stop();
        }
    }

    static void StartClient()
    {
        try
        {
            // Conectando ao servidor
            TcpClient client = new TcpClient();
            client.Connect("127.0.0.1", 8888);
            Console.WriteLine("Conectado ao servidor!");

            // Obtendo o stream de dados para comunicação com o servidor
            NetworkStream stream = client.GetStream();

            // Enviando uma mensagem ao servidor
            string message = "Olá, servidor!";
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
            Console.WriteLine("Mensagem enviada ao servidor.");

            // Lendo a resposta do servidor
            data = new byte[256];
            string responseData = string.Empty;
            int bytes = stream.Read(data, 0, data.Length);
            responseData = Encoding.ASCII.GetString(data, 0, bytes);
            Console.WriteLine($"Resposta do servidor: {responseData}");

            // Fechando conexões
            stream.Close();
            client.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}
