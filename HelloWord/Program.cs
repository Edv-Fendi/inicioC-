using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {

        enum Cor {Vermelho, Preto}
        enum Opcao { Sim = 1, Não}
        static void Main(string[] args)
        {
            
            string[] times = new string[3] { "Flamengo", "Real Madrid", "Brasil" };
            string texto, nomeAmigo, torcer="" ;
            const string nome = "Edvaldo";
            int idade = 22, preco = 0, equipe = 0;
            float altura = 1.89f;
            bool fazAcademia = true;
            var horaTrabalho = 4;
            var curso = "Connect Biopark";
            texto = "Tudo bem?";
            Cor corFavorita = Cor.Vermelho;
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
            Console.WriteLine($"Pra falar a verdade possuo umas: {4} cores favoritas :D");
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
            Console.Write("\n\nVoce trabalha?\n1- Sim\n2- Não\n");
            int index= int.Parse(Console.ReadLine());
            Trabalha(index);


            Console.WriteLine("\nPara qual time voce torce?");
            string timeAmigo = Console.ReadLine();
            SeuTime(timeAmigo);
            PosicaoTime(torcer);
            GerarPreco(preco);
            CadastrotimesFavoritos(times);
            MostrarTimes(times);
            resultadoCopa(equipe);

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
                default:
                    Console.WriteLine("\nNão entendi sua resposta :(");
                break;
                    
            }
        }

        static void Trabalha (int trabalha)
        {
            switch (trabalha)
            {
                case 1:
                    {
                        Console.WriteLine("\nVoce trabalha, que maneiro");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("\nPessoa de sorte, só curte a vida haahahaha");
                        break;
                    }
            }
        }

        static void resultadoCopa(int equipe)
        {

            Console.WriteLine("\n\nVamos relembrar a epoca da copa? Aquele jogo que foi bem assim:\n");
            int contador = 0;
            while (contador != 8)
            {
                while (equipe != 7)
                {
                    Console.WriteLine("Gooooool do brasil, do menino NEYYYYYMAR");
                    equipe++;
                    contador++;
                }

                if(equipe == 7)
                {
                    Console.WriteLine("\nGol da Alemnha :X");
                    contador++;
                    

                }
            }
            Console.WriteLine("\nFim do jogo: Brasil 7 x 1 Alemanha\n");
        }





    }
}
