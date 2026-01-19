using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicios LINQ

            //Filtrar números pares
            List<int> lista = new List<int>() { 1, 2, 20, 1, 20 };
            var pares = lista.Where((x) => x % 2 == 0).ToList();
            foreach (var par in pares)
            {
                Console.WriteLine(par);
            };

            //Ordenar ordem crescente
            var ordemCres = lista.OrderBy((x) => x).ToList();
            foreach (var ordem in ordemCres)
            {
                Console.WriteLine(ordem);
            }

            //Calcular a soma dos números maiores que 10
            var maioresQueDez = lista.Where(x => x > 10).Sum();
            Console.WriteLine(maioresQueDez);

            //Filtros

            List<int> numeros = new List<int> { 1, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            Console.WriteLine($"[{string.Join(", ", numeros)}]\n"); //juntar coleções

            Func<int, bool> ehPar = n => n % 2 == 0;
            Func<int, bool> ehMaiorQue20 = n => n > 20;
            Func<int, bool> ehMenorQue30 = n => n < 30;
            Func<int, bool> ehDivisivelPor5 = n => n % 5 == 0;
            Func<int, bool> ehDivisivelPor10 = n => n % 10 == 0;

            Console.WriteLine($"[{string.Join(", ", pares)}]"); //Pares
            Console.WriteLine($"[{string.Join(", ", ehMaiorQue20)}]"); //Maiores do que 20
            Console.WriteLine($"[{string.Join(", ", ehMenorQue30)}]"); //Menores do que 30
            Console.WriteLine($"[{string.Join(", ", ehDivisivelPor5)}]"); //É divisível por 5
            Console.WriteLine($"[{string.Join(", ", ehDivisivelPor10)}]"); //É divisível por 10

            var vendas = new List<Venda>
            {
                new Venda { Produto = "Notebook", Quantidade = 5, PrecoUnitario = 3200.00m },
                new Venda { Produto = "Mouse", Quantidade = 25, PrecoUnitario = 45.00m },
                new Venda { Produto = "Teclado", Quantidade = 15, PrecoUnitario = 120.00m },
                new Venda { Produto = "Monitor", Quantidade = 8, PrecoUnitario = 850.00m },
                new Venda { Produto = "Mouse", Quantidade = 10, PrecoUnitario = 45.00m },
                new Venda { Produto = "Webcam", Quantidade = 12, PrecoUnitario = 180.00m },
                new Venda { Produto = "Notebook", Quantidade = 3, PrecoUnitario = 3200.00m },
                new Venda { Produto = "HD Externo", Quantidade = 20, PrecoUnitario = 280.00m }
            };

            Console.WriteLine("\n");

            //Filtrar produtos com preco > 50
            Console.WriteLine("Filtrar produtos com preco > 50");
            var resultado = vendas.Where(p => p.PrecoUnitario > 50).ToList();
            foreach (var result in resultado)
            {
                Console.WriteLine(result);
            }

            Console.WriteLine("\n");

            //Projetar apenas nome e preco
            Console.WriteLine("Projetar apenas nome e preco");
            var nomesEPrecos = vendas.Select(p => new { p.Produto, p.PrecoUnitario }).ToList();
            foreach (var nomeEPreco in nomesEPrecos)
            {
                Console.WriteLine(nomeEPreco);
            }

            Console.WriteLine("\n");

            //Ordenar por preco crescente
            Console.WriteLine("Ordenar por preco crescente");
            var precosCrescentes = vendas.OrderBy(p => p.PrecoUnitario).ToList();
            foreach (var precoCrescente in precosCrescentes)
            {
                Console.WriteLine(precoCrescente);
            }

            Console.WriteLine("\n");

            //Calcular total de vendas
            Console.WriteLine("Calcular total de vendas");
            var totalVendas = vendas.Sum(p => p.Quantidade * p.PrecoUnitario);
            Console.WriteLine(totalVendas);

            Console.WriteLine("\n");

            //Média de Vendas por produto
            Console.WriteLine("Média de Vendas por produto");
            var gruposProdutos = vendas.GroupBy(p => p.Produto);
            List<Tuple<string, decimal>> mediaVendas = new List<Tuple<string, decimal>>();

            foreach (var grupo in gruposProdutos)
            {
                mediaVendas.Add(new Tuple<string, decimal>(grupo.Key, grupo.Average(p => p.Quantidade * p.PrecoUnitario)));
            }

            foreach (var mediaVenda in mediaVendas)
            {
                Console.WriteLine(mediaVenda);
            }

            Console.WriteLine("\n");

            //Produto mais vendido
            Console.WriteLine("Produto mais vendido");
            var maisVendido = vendas.Max(p => p.Quantidade);
            var vendaMaiorQuantidade = vendas.FirstOrDefault(p => p.Quantidade == maisVendido);

            Console.WriteLine(vendaMaiorQuantidade);

        }
    }



}
