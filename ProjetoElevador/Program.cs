using ProjetoElevador.Models;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkGray; //Define a cor do plano de fundo do terminal.
            Console.ForegroundColor = ConsoleColor.Yellow; //Define a cor das letras.
            Console.WriteLine("Bem-vindo(a) ao aplicativo de gerencimento de elevadores. Divirta-se!\n");

            Elevador elevador = new Elevador(); //Inicia uma instância do objeto elevador.

            elevador.Inicializar(); //Inicia o programa utilizando-se da função presente em 'Models/Elevador.cs'.

            //Agora cria-se um menu para que o úsuario possa escolher dentre as opções.
            //Inicializa-se uma variavel de controle do loop e das escolhas.
            string opcaoEscolhida = "";
            
            Console.Clear(); //Limpa o console para exibir as opções de maneira clara.
            Console.WriteLine("O elevador começa no térreo.");

            do
            {
                Console.ForegroundColor = ConsoleColor.Green; //Define a cor do texto para verde.
                Console.WriteLine(@"Selecione o digito da opção que você deseja:
                                        1 - Adiciona uma pessoa ao elevador.
                                        2 - Remove uma pessoa do elevador.
                                        3 - Sobe um andar.
                                        4 - Desce um andar.
                                        5 - Encerrar aplicação");
                Console.ForegroundColor = ConsoleColor.Yellow; //Define a cor para DarkYellow (padrão).

                //Variavel que guarda a opção escolhida.
                opcaoEscolhida = Console.ReadLine();

                Console.Clear(); //Limpa as opções anteriores.

                //Utiliza-se um switch case para verificar e executar a opção escolhida.
                switch (opcaoEscolhida)
                {
                    case "1": //Opção que adiciona uma pessoa ao elevador.
                        {
                            Console.WriteLine("Você escolheu adicionar uma pessoa ao elevador!");
                            elevador.Entrar(); break;
                        }
                    case "2": //Opção que remove uma pessoa do elevador.
                        {
                            Console.WriteLine("Você escolheu remover uma pessoa de dentro do elevador.");
                            elevador.Sair(); break;
                        }
                    case "3": //Opção que faz o elevador subir um andar.
                        {
                            Console.WriteLine("Subindo . . .");
                            elevador.Subir(); break;
                        }
                    case "4": //Opção que faz o elevador descer um andar.
                        {
                            Console.WriteLine("Descendo . . .");
                            elevador.Descer(); break;
                        }
                    case "5": //Encerra o programa.
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Encerrando o programa.");
                            break;
                        }
                    default: //Caso a opção escolhida seja inválida.
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Opção inválida: {opcaoEscolhida}, digite uma opção válida."); break;
                        }
                }
            }
            while (opcaoEscolhida != "5"); //Repete as ações acima enquanto o número escolhido for diferente da opção '5'.
        }
    }
}
