/*using projeto_csharp.Models;

Pessoa pessoaUm = new Pessoa();

pessoaUm.Nome = "Adriano";
pessoaUm.Idade = 35;

pessoaUm.Apresentar();*/

using Microsoft.Win32.SafeHandles;

string apresentacao = "Olá, Seja bem vindo";
int quantidade = 2;
quantidade = 10;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variavel quantidade: "+quantidade);
Console.WriteLine("Valor da variavel altura: "+altura.ToString("0.00"));
Console.WriteLine("Valor da variavel preco: "+preco);
Console.WriteLine("Valor da variavel condicao: "+condicao);