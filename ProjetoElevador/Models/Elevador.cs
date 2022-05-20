using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Models
{
    public class Elevador
    {

        // Variáveis a serem utilizadas na programação.
        int maxAndar = 0, maxQtdPessoas = 0, qtdPessoas = 0, andar = 0;


        //Inicializamos o programa definindo a capacidade e quantidade de andares do elevador através dos dados fornecidos pelo usuário.
        public void Inicializar()
        {
            //Pede ao usuário para indicar a capacidade total.
            Console.Write("Digite o total de pessoas que cabem no elevador: ");

            //Loop while para válidar o valor inserido.
            do //Faz enquanto a condição do while não é atendida.
            {
                maxQtdPessoas = int.Parse(Console.ReadLine()); //Recebe o valor através do input do usuário e o guarda em uma variável.

                //Verificando se o valor fornecido pelo usuário é válido.
                if (maxQtdPessoas <= 0) 
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed; //Converte o texto para a cor vermelha, sinalizando algo errado.
                    Console.WriteLine($"Quantidade de pessoas inválida = {maxQtdPessoas}, informe um novo valor:"); //Informa que o valor inserido é inválido.
                    Console.ForegroundColor = ConsoleColor.Yellow; //Volta a cor padrão (Amarelo).
                }
            }
            while (maxQtdPessoas <= 0); //Repete o loop enquanto a quantidade informada for menor ou igual a zero.

            //Limpa o console.
            Console.Clear();


            //Repete-se o processo acima para determinar a quantidade de andares:
            //Pede ao usuário para indicar a quantidade máxima de andares.
            Console.Write("Digite a quantidade total de andares.\n" +
                "*(lembre-se que o térreo é o andar '0')\n" +
                "\n" +
                "Quantidade total de andares: ");

            //Loop while para válidar o valor inserido.
            do //Faz enquanto a condição do while não é atendida.
            {
                maxAndar = int.Parse(Console.ReadLine()); //Armazena o valor fornecido pelo usuário.
                
                //Verificando se o valor indicado é válido.
                if (maxAndar <= 0) {
                    Console.ForegroundColor = ConsoleColor.DarkRed; //Converte o texto para a cor vermelha, sinalizando algo errado.
                    Console.WriteLine($"O valor indicado = {maxAndar} é inválido, informe um novo valor:"); //Informa que o valor inserido é inválido.
                    Console.ForegroundColor = ConsoleColor.Yellow; //Volta a cor padrão (Amarelo).
                }
            }
            while (maxAndar <= 0); //Repete o loop enquanto a quantidade informada for menor ou igual a zero.
        }
        
        //Cria-se o método de entrada, que utilizaremos para adicionar uma pessoa ao elevador.
        public void Entrar()
        {
            if (qtdPessoas >= maxQtdPessoas) //Verifica se o elevador está lotado.
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Impossível, elevador lotado!!!"); //Informa que o elevador está lotado e que a ação não foi póssivel.
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else
            {
                qtdPessoas += 1; //Caso haja espaço livre dentro do elevador, adiciona mais uma pessoa.
            }

            Console.WriteLine($"Pessoas dentro do elevador: {qtdPessoas}, capacidade máx: {maxQtdPessoas}"); //Informa a quantidade atual de pessoas no elevador.
        }

        //Cria-se um método 'sair', respónsavel por remover uma pessoa de dentro do elevador.
        public void Sair()
        {
            if (qtdPessoas <= 0) //Verifica se ainda há pessoas para serem removidas do elevador.
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Impossível, elevador já está vazio!!!"); //Informa que o elevador está vazio.
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else //Caso ainda tenha, remove uma pessoa.
            {
                qtdPessoas -= 1;
            }

            Console.WriteLine($"Pessoas dentro do elevador: {qtdPessoas}, capacidade máx: {maxQtdPessoas}"); //Informa a quantidade atual de pessoas dentro do elevador.
        }

        //Método responsável por fazer o elevador subir um andar.
        public void Subir()
        {
            if (andar >= maxAndar) //Verifica se o elevador já está no último andar (mais alto).
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O elevador já está no último andar."); //Informa caso o elevador esteja no último andar (mais alto). 
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else //Caso não esteja no último, sobe mais um andar.
            {
                andar += 1;
            }
            Console.WriteLine($"Andar atual: {andar}"); //Informa o andar atual.
        }

        public void Descer()
        {
            if (andar <= 0) //Verifica se o elevador já está no térreo.
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O elevador já está no térreo."); //Informa que o elevador está no térreo.
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else //Caso não esteja no térreo, ele desce um andar.
            {
                andar -= 1;
            }
            Console.WriteLine($"Andar atual: {andar}"); //Informa o andar atual.
        }
    }
}
