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
            string[] times = new string[3] { "Flamengo", "Real Madrid", "Brasil" };
            string texto, nomeAmigo, torcer="";
            const string nome = "Edvaldo";
            int idade = 22, preco = 0;
            float altura = 1.89f;
            bool fazAcademia = true;
            var horaTrabalho = 4;
            var curso = "Connect Biopark";
            texto = "Tudo bem?";
            dynamic corFavorita = "red";
            int numeroTacasFlamengo = 3 + 8;


            Console.WriteLine("Hello World  ");
            Console.WriteLine($"\nMeu nome é {nome} :) ");
            Console.WriteLine(texto);
            Console.WriteLine($"Eu tenho {idade} anos");
            Console.WriteLine($"Tenho {altura} de altura");
            Console.WriteLine($"Faz academia? {fazAcademia}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Trabalho {horaTrabalho} horas por dia");
            Console.WriteLine("Cor Favorita: " + corFavorita);
            corFavorita = 4;
            Console.WriteLine($"Pra falar a verdade possuo umas: {corFavorita} cores favoritas :D");
            Console.WriteLine($"Sou Flamenguista maluco e meu time tem: {numeroTacasFlamengo} " +
                $"titulos, contando apenas Copa do Brasil e Libertadores :D");
            Console.WriteLine($"Mas se for contar os outros trofeus deve dar uns " +
                $"{numeroTacasFlamengo * 5} ou mais hahahaha ");

            texto = "\n\n\nObrigado por ler até aqui :)";
            Console.Write("\n\n\nMas vamos falar sobre você agora!!!!");
            Console.Write("\n\nQual o seu nome?\n");
            nomeAmigo = Console.ReadLine();
            Console.Write("\nQual a sua idade?\n");
            int idadeAmigo = int.Parse(Console.ReadLine());
            MostrarIdade(idade, idadeAmigo, nomeAmigo);

            Console.WriteLine("\nPara qual time voce torce?");
            string timeAmigo = Console.ReadLine();
            SeuTime(timeAmigo);
            PosicaoTime(torcer);
            GerarPreco(preco);
            CadastrotimesFavoritos(times);
            MostrarTimes(times);

            Console.WriteLine(texto);
            Console.ReadLine();
        }

        static void MostrarIdade(int idade, int idadeAmigo, string nomeAmigo) {
            if (idadeAmigo > idade)
            {
                Console.Write($"\nOlá  {nomeAmigo}  Tudo bem com você?");
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

        static void SeuTime(string timeAmigo)
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

        static void GerarPreco(float preco)
        {
            Console.WriteLine("\nQual o preço médio do ingresso do seu time??");
            preco = int.Parse(Console.ReadLine());
            float precoAbs = Math.Abs(preco);

            if (precoAbs < 50f)
            {
                Console.WriteLine($"UAU, seu time cobra muito baratoooooo!!! Apenas R${precoAbs}");
            } else
            {
                Console.WriteLine($"QUE CAROOOO R${precoAbs} é muita coisa");
            }
        }

        static void CadastrotimesFavoritos(string[] times)
        {
            Console.WriteLine("\nAgora vamos falar sobre seus três time favoritos!!!");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nDigite o {i + 1}° time favorito!");
                times[i]=Console.ReadLine();
            }

        }

        static void MostrarTimes(string[] times)
        {
            Console.WriteLine("\n\nEntão estes são seus times favoritos:");
            for(int i = 0; i < times.Length; i++)
            {
               Console.WriteLine($"\n{times[i]}");
            }
        }

        static void PosicaoTime(string estadio)
        {
            Console.WriteLine($"\nVoce ja foi assistir jogos do seu time no estadio??");
            estadio = Console.ReadLine();
            
            switch (estadio)
            {
                case "sim":
                        Console.WriteLine("\nUAUUUU, VOCÊ REALMENTE TORCE PARA SEU TIME!!!!!!");
                        break;
                    
                case "nao":
                    Console.WriteLine("\nVocê ainda vai ter essa oportunidade :(");
                    break;
                    
            }
        }



    }
}
