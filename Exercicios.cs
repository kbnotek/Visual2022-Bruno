using Curso_C_.Paradigmas;
using System;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Curso_C_
{

    public class Pessoa1
    {
        public string Nome;
        public int Idade;

        public Pessoa1(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        public void Falar()
        {
            Console.WriteLine($" Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }

    public class Calculadora2024
    {
        public int A;
        public int B;
        public int Soma;

        public Calculadora2024()
        {

            Soma = A + B;
        }

        public void Somar()
        {
            Console.WriteLine($"A Soma de a {A} + {B} o RESULTADO é {Soma}");
        }
        public void Subtrair()
        {
            Console.WriteLine($"A Subtração de a {A} - {B} o RESULTADO é {A - B}");
        }
    }
    public class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }

        private void ExibirInfo()
        {
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Preço: {Preco:C}");
        }

        public void MostrarInfo()
        {
            ExibirInfo();
        }
    }
    public class Aluno
    {
        public string Nome;
        public int Matricula;
        public string Genero;
        public long Telefone;
        public string Cidade;

        public Aluno(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        public Aluno(string nome, int matricula, string genero, long telefone, string cidade)
        {
            Nome = nome;
            Matricula = matricula;
            Genero = genero;
            Telefone = telefone;
            Cidade = cidade;
        }
        public string ExibirNomeMat(string nome, int matricula)
        {
            return $"Nome do Aluno{Nome} Matricula: {Matricula}";


        }

        public string ExibirTdInforma()
        {
            return $"Aluno: {Nome}\n" +
                $"Matricula:{Matricula} \n" +
                $"Genero: {Genero}\n" +
                $"Contato: {Telefone}\n" +
                $"Cidade: {Cidade}";
        }

    }

}







