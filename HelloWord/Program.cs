using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String texto, nomeAmigo;
            const String nome= "Edvaldo";
            int idade = 22;
            float altura = 1.89f;
            bool fazAcademia = true;
            var horaTrabalho = 4;
            var curso = "Connect Biopark";
            texto = "Tudo bem?";
            dynamic corFavorita = "red";


            Console.WriteLine("Hello World  ");
            Console.WriteLine("\nMeu nome é " + nome + " :) ");
            Console.WriteLine(texto);
            Console.WriteLine("Eu tenho " + idade + " anos");
            Console.WriteLine("Tenho " + altura + " de altura");
            Console.WriteLine("Faz academia? " + fazAcademia);
            Console.WriteLine("Curso: " + curso);
            Console.WriteLine("Trabalho " + horaTrabalho + " horas por dia");
            Console.WriteLine("Cor Favorita: " + corFavorita);
            corFavorita = 4;
            Console.WriteLine("Pra falar a verdade possuo umas: " + corFavorita + " cores favoritas :D");

            texto = "\n\n\nObrigado por ler até aqui :)";
            Console.Write("\n\n\nMas vamos falar sobre você agora!!!!") ;
            Console.Write("\nQual o seu nome?\n");
            nomeAmigo = Console.ReadLine();

            Console.Write("Olá " + nomeAmigo + " Tudo bem com você?");
            Console.WriteLine(texto);
            Console.ReadLine();
        }
    }
}
