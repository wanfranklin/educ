using var httpClient = new HttpClient();
string url = "https://google.com"; // Exemplo de URL
HttpResponseMessage resposta = await httpClient.GetAsync(url);

if (resposta.IsSuccessStatusCode)
{
    string corpoResposta = await resposta.Content.ReadAsStringAsync();
    Console.WriteLine(corpoResposta);
}
else
{
    Console.WriteLine($"Não foi possível realizar conexão. Status code: {resposta.StatusCode}");
}