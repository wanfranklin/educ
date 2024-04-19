using ClosedXML.Excel;
using Newtonsoft.Json;
using Models;
using System.Text.RegularExpressions;

try
{
    string cep = string.Empty;

    while (true)
    {
        Console.WriteLine("Digite o CEP: ");
        cep = Console.ReadLine(); 

        cep = cep.Replace(".", "").Replace("-", "");

        if (Regex.IsMatch(cep, @"^\d{8}$"))
        {
            break;
        }
        else
        {
            Console.WriteLine("Formato do CEP inválido.");
        }
    }

    string viaCepUrl = $"https://viacep.com.br/ws/{cep}/json/";

    HttpClient client = new();
    HttpResponseMessage response = await client.GetAsync(viaCepUrl);

    if (response.IsSuccessStatusCode)
    {
        string responseBody = await response.Content.ReadAsStringAsync();

        if (responseBody.Contains("\"erro\": true"))
        {
            Console.WriteLine("CEP não localizado.");
        }

        ViaCepModel viaCepModel = JsonConvert.DeserializeObject<ViaCepModel>(responseBody);
        Console.WriteLine("" + responseBody);

        using var workbook = new XLWorkbook();
        var worksheet = workbook.Worksheets.Add("CEP");
        worksheet.Cells("A1").Value = viaCepModel.Cep;
        worksheet.Cells("B1").Value = viaCepModel.Logradouro;
        worksheet.Cells("C1").Value = viaCepModel.Complemento;
        worksheet.Cells("D1").Value = viaCepModel.Bairro;
        worksheet.Cells("E1").Value = viaCepModel.Localidade;
        worksheet.Cells("F1").Value = viaCepModel.UF;
        workbook.SaveAs($"Planilha_{DateTime.Now:ddMMyyyyHHmmss}.xlsx");
    }
    else
    {
        Console.WriteLine($"Erro: {response.StatusCode}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($" Erro: {ex.Message}");
}
