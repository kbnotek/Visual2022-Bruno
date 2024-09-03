using Curso_C_.Paradigmas;
using System;

namespace Curso_C_
{
    public class PessoaNova
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cidade { get; set; }
        public decimal Salario { get; set; }
    }

    public class Exercicio 
    {
        public void ExibirResultado() 
        {
            var pessoas = new List<PessoaNova>
            {
                new PessoaNova { Nome = "Alice", Idade = 30, Cidade = "São Paulo", Salario = 1.800M },
                new PessoaNova { Nome = "Bob", Idade = 25, Cidade = "Rio de Janeiro", Salario = 2.800M },
                new PessoaNova { Nome = "Charlie", Idade = 35, Cidade = "São Paulo", Salario = 3.800M },
                new PessoaNova { Nome = "Diana", Idade = 40, Cidade = "Belo Horizonte", Salario = 4.800M},
                new PessoaNova { Nome = "Eve", Idade = 28, Cidade = "São Paulo" , Salario = 5.800M}
            };

            var quantidadePessoasAcimaDe30 = pessoas.Count(p => p.Idade > 30);

            Console.WriteLine($"Quantidade de pessoas com mais de 30 anos: {quantidadePessoasAcimaDe30}");


        }
    }

}

