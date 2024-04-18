
using ClosedXML.Excel;
using Newtonsoft.Json;
using Models;

Console.WriteLine("Digite o CEP: ");

string cep = Console.ReadLine();
string viaCepUrl = $"https://viacep.com.br/ws/{cep}/json/";

HttpClient client = new();
HttpResponseMessage response = await client.GetAsync(viaCepUrl);

if (response.IsSuccessStatusCode)
{
    string responseBody = await response.Content.ReadAsStringAsync();

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
    workbook.SaveAs($"Planilha_{DateTime.Now.ToString("ddMMyyyyHHmmss")}.xlsx");
}

