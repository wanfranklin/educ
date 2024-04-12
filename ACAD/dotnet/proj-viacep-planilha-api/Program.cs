
using ClosedXML.Excel;
using Newtonsoft.Json;

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

    using (var workbook = new XLWorkbook())
    {
        var worksheet = workbook.Worksheets.Add("CEP");
        worksheet.Cells("A1").Value = viaCepModel.Cep;
        worksheet.Cells("B1").Value = viaCepModel.Logradouro;
        workbook.SaveAs("Planilha.xlsx");

    }
}

