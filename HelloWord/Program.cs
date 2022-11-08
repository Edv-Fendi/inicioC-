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
            int numeroTacasFlamengo = 3 + 8;


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
            Console.WriteLine("Sou Flamenguista maluco e meu time tem: " + numeroTacasFlamengo + 
                " titulos, contando apenas Copa do Brasil e Libertadores :D");
            Console.WriteLine("Mas se for contar os outros trofeus deve dar uns "  + 
                numeroTacasFlamengo * 5 + " ou mais hahahaha ");

            texto = "\n\n\nObrigado por ler até aqui :)";
            Console.Write("\n\n\nMas vamos falar sobre você agora!!!!") ;
            Console.Write("\n\nQual o seu nome?\n");
            nomeAmigo = Console.ReadLine();
            Console.Write("\nQual a sua idade?\n");
            int idadeAmigo = int.Parse(Console.ReadLine());
            mostrarIdade(idade, idadeAmigo, nomeAmigo);
            
            Console.WriteLine("\n\nPara qual time voce torce?");
            String timeAmigo = Console.ReadLine();
            seuTime(timeAmigo);

            Console.WriteLine(texto);
            Console.ReadLine();
        }

        static void mostrarIdade(int idade, int idadeAmigo, String nomeAmigo) {
            if (idadeAmigo > idade)
            {
                Console.Write("\nOlá " + nomeAmigo + " Tudo bem com você?");
                Console.WriteLine("\nVocê é mais velho que eu!!!");
            }
            else if (idadeAmigo < idade)
            {
                Console.Write("\nOlá " + nomeAmigo + " Tudo bem com você?");
                Console.WriteLine("\nVocê é mais novo que eu!!!");

            }
            else
            {
                Console.Write("\nOlá " + nomeAmigo + " Tudo bem com você?");
                Console.WriteLine("\nTemos a mesma idade!!!");
            }

        }

        static void seuTime(String timeAmigo)
        {

            if (timeAmigo != "Flamengo" && timeAmigo != "Vasco")
            {
                Console.WriteLine("\nVocê torce para o time errado!!!!");
            }
            else if (timeAmigo == "Vasco")
            {
                Console.WriteLine("\nVocê deve sofrer muito com seu time, forças guerreiro...");
            }
            else
            {
                Console.WriteLine("\nVocê é uma pessoa de sorte, bem vindo a vida de vencedor!!!");
            }
        }
    }
}
