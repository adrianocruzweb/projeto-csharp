/*using projeto_csharp.Models;

Pessoa pessoaUm = new Pessoa();

pessoaUm.Nome = "Adriano";
pessoaUm.Idade = 35;

pessoaUm.Apresentar();*/

/*using Microsoft.Win32.SafeHandles;

string apresentacao = "Olá, Seja bem vindo";
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
int quantidade = 2;
Console.WriteLine("Valor da variavel quantidade: "+quantidade);
quantidade = 10;
Console.WriteLine("Valor da variavel quantidade: "+quantidade);
Console.WriteLine("Valor da variavel altura: "+altura.ToString("0.00"));
Console.WriteLine("Valor da variavel preco: "+preco);
Console.WriteLine("Valor da variavel condicao: "+condicao);*/

DateTime dataAtual = DateTime.Now.AddDays(5);

Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));