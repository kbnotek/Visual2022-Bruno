using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Curso_C_
{
    // o Exercício: Declare uma variável var
    //  para um tipo complexo, como um Dictionary ou uma 
    //  instância de uma classe personalizada.Mostre como a 
    //  inferência de tipo funciona com tipos mais complexos.
    public class Marcos 
    {
        public void Marquinhos() 
        {
            var mk = new pessoaMarcos
            {
                Nome = "Marcos",
                Idade = 15

            };
            Console.WriteLine($"O nome e: {mk.Nome} A idade e: {mk.Idade}");
        }
           
    }

    public class pessoaMarcos
    {
        public string Nome;
        public int Idade;

    }
}
