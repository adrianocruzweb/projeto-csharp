﻿/*using projeto_csharp.Models;

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

// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

using System.Diagnostics.Contracts;

// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5;
// c +=5;

// Console.WriteLine(c);

//Cast - Casting
//int a = Convert.ToInt32(null);
// int a = int.Parse(null);

// Console.WriteLine(a);

// string a = (5).ToString();

// Console.WriteLine(a);

/*
int a = 5;
double b = a;
*/

/*
long a = long.MaxValue;
int b = a;
*/

/*
int a = int.MaxValue;
long b = a;


Console.WriteLine(b);
*/

// int a = 4 / 2 + 2;

// Console.WriteLine(a);

// int a2 = 4 / (2 + 2);

// Console.WriteLine(a2);

/*int quantidadeEstoque = 3;
int quantidadeVenda = 0;
bool possivelVenda = quantidadeVenda > 0 && quantidadeEstoque >= quantidadeVenda;

Console.WriteLine($"A quantidade de produto em estoque é {quantidadeEstoque}");
Console.WriteLine($"A quantidade de venda do produto é {quantidadeVenda}");
Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

if(quantidadeVenda == 0)
{
    Console.WriteLine("Venda Invalida");
}
else if(possivelVenda)
{
    Console.WriteLine("Venda Realizada");
}
else
{
    Console.WriteLine("Desulpe, Não temos a quantidade desejada no estoque");
}*/

/*


if(
    letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u"
)
{
    Console.WriteLine($"{letra} é uma vogal");
}
else
{
    Console.WriteLine($"{letra} não é uma vogal");
}
*/

/*
Console.WriteLine("Digita uma Letra");
string letra = Console.ReadLine();

switch(letra){
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é vogal");
        break;
}
*/

bool eMaiorIdade = true;
bool temAutorizacaoPais = false;

if(eMaiorIdade || temAutorizacaoPais)
{
    Console.WriteLine("Pode entrar no evento");
}
else
{
    Console.WriteLine("Não pose entrar no evento");
}