// Tipos de Dados Textuais
string texto = "Olá, mundo!";
char caractere = 'A';

// Tipos de Dados Numéricos
byte byteNumero = 255;
short numeroPequeno = 12345;
int numeroInteiro = -1234567890;
long numeroLongo = 1234567890123456789;
float numeroFlutuante = 3.14f;
double numeroDecimal = 3.141592653589793238;
decimal numeroDecimalPreciso = 123.456m;

// Tipo de Dados Booleano
bool verdadeiro = true;
bool falso = false;

// Tipo de Dados Data e Hora
DateTime dataHoraAtual = DateTime.Now;

// Tipo de Dados de Coleções (Array)
int[] numeros = { 1, 2, 3, 4, 5 };

// Exibindo os valores
Console.WriteLine("Tipos de Dados Textuais:");
Console.WriteLine("Texto: " + texto);
Console.WriteLine("Caractere: " + caractere);

Console.WriteLine("\nTipos de Dados Numéricos:");
Console.WriteLine("Byte: " + byteNumero);
Console.WriteLine("Short: " + numeroPequeno);
Console.WriteLine("Int: " + numeroInteiro);
Console.WriteLine("Long: " + numeroLongo);
Console.WriteLine("Float: " + numeroFlutuante);
Console.WriteLine("Double: " + numeroDecimal);
Console.WriteLine("Decimal: " + numeroDecimalPreciso);

Console.WriteLine("\nTipo de Dados Booleano:");
Console.WriteLine("Verdadeiro: " + verdadeiro);
Console.WriteLine("Falso: " + falso);

Console.WriteLine("\nTipo de Dados Data e Hora:");
Console.WriteLine("Data e Hora Atuais: " + dataHoraAtual);

Console.WriteLine("\nTipo de Dados de Coleções (Array):");
Console.WriteLine("Array de Números:");

foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}

Console.WriteLine("Pressione qualquer tecla para sair...");

Console.ReadKey();