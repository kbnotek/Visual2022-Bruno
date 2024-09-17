using System;
using System.Collections.Generic;

namespace Curso_C_
{

    public class PessoaBilhete
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }

    public class Show
    {
        public string Nome { get; set; }
        public string Data { get; set; }
        public double PrecoIngresso { get; set; }
    }

    public class Ingresso
    {
        public int Id { get; set; }
        public Show Show { get; set; }
        public PessoaBilhete Pessoa { get; set; }
        public double Preco { get; set; }
    }
}