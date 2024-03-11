using var httpClient = new HttpClient();
string url = "https://developer.mozilla.org/en-US/docs/Web/HTTP/Status"; // Exemplo de URL
HttpResponseMessage response = await httpClient.GetAsync(url);

if (response.IsSuccessStatusCode)
{
    string responseBody = await response.Content.ReadAsStringAsync();
    Console.WriteLine(responseBody);
}
else
{
    Console.WriteLine($"Failed to fetch data. Status code: {response.StatusCode}");
}