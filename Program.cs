using System;
using TestesFundamentos;

// Criando o objeto cliente a partir da classe
Cliente meuCliente = new Cliente();

Console.WriteLine("=== CADASTRO DE CLIENTE ===");

// Recolhendo o Nome
Console.Write("Digite o nome do cliente: ");
meuCliente.Nome = Console.ReadLine();

// Recolhendo o Email
Console.Write("Digite o email do cliente: ");
meuCliente.Email = Console.ReadLine();

// Recolhendo a Idade (convertendo de string para int)
Console.Write("Digite a idade do cliente: ");
meuCliente.Idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n--- DADOS CADASTRADOS COM SUCESSO ---");
Console.WriteLine($"Nome: {meuCliente.Nome}");
Console.WriteLine($"Email: {meuCliente.Email}");
Console.WriteLine($"Idade: {meuCliente.Idade} anos");