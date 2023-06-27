using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CadastroDeUsuariosAula08
{
    internal class Program
    {
        static List<string> estacionamento = new List<string>(); // Lista para armazenar as placas dos veículos estacionados

        public static string nomeDaEmpresa = "MK Vrummmm";

        
        static void Main(string[] args)
        {
            Console.Title = "                                                  Estacionamento de Veículos - MK VRUMMMM - feito por MAICON CONSTANCIO ";
            //string nomeDaEmpresa = "MK Vrummmm";


            







            Console.WriteLine($"Nós da {nomeDaEmpresa}, temos um orgulho de ter você por aqui! :D");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor para Amarelo Escuro
                Console.WriteLine("\nSelecione uma opção:");
                //opção 1
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor para Amarelo Escuro
                Console.Write("1 - ");
                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                Console.WriteLine("Estacionar");
                //opção 2
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor para Amarelo Escuro
                Console.Write("2 - ");
                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                Console.WriteLine("Retirar veículo");
                //opção 3
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor para Amarelo Escuro
                Console.Write("3 - ");
                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                Console.WriteLine("Listar veículos");
                //opção 3
                Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor para Amarelo Escuro
                Console.Write("4 - ");
                Console.ForegroundColor = ConsoleColor.Red; // Mudou de cor para Amarelo
                Console.WriteLine("SAIR DO PROGRAMA");
                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco

                int escolha;
                if (int.TryParse(Console.ReadLine(), out escolha))
                {
                    switch (escolha)
                    {
                        case 1:
                            EstacionarVeiculo();
                            break;
                        case 2:
                            ListarVeiculos();
                            RetirarVeiculo();
                            break;
                        case 3:
                            ListarVeiculos();
                            break;
                        case 4:
                            SairDoPrograma();
                            break;
                        default:
                            Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                            Console.ForegroundColor = ConsoleColor.Red; // Mudou de cor para vermelho
                            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                }
            }
        }

        static void EstacionarVeiculo()
        {
            Console.Clear(); //Apagar msg anterior
            Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
            Console.WriteLine("Opção selecionada: Estacionar veículo\n");
            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco

            if (estacionamento.Count >= 5)
            {
                Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                Console.ForegroundColor = ConsoleColor.Red; // Mudou de cor para vermelho
                Console.WriteLine("Desculpe, todas as vagas estão ocupadas.");
                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                return;
            }

            Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
            Console.Write("Digite a placa do veículo ");
            Console.ForegroundColor = ConsoleColor.Red; // Mudou de cor para Vermelho
            Console.Write("(6 caracteres)");
            Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
            Console.WriteLine(":");
            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
            string placa = Console.ReadLine().ToUpper();

            if (placa.Length != 6)
            {
                Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                Console.ForegroundColor = ConsoleColor.Red; // Mudou de cor para vermelho
                Console.WriteLine("Placa inválida. A placa deve conter exatamente 6 caracteres.");
                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                return;
            }

            if (estacionamento.Contains(placa))
            {
                Console.Clear(); //Apagar msg anterior
                Console.ForegroundColor = ConsoleColor.Red; // Mudou de cor para Vermelho
                Console.WriteLine($"Veículo com placa {placa} já está estacionado.");
                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                return;
            }

            estacionamento.Add(placa);
            Console.Clear(); //Apagar msg anterior
            Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
            Console.WriteLine($"Veículo com placa {placa} estacionado com sucesso.");
            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
        }

        static void RetirarVeiculo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
            Console.Write("\nOpção selecionada:");
            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
            Console.WriteLine(" Retirar veículo");

            if (estacionamento.Count == 0)
            {
                Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                Console.ForegroundColor = ConsoleColor.Red; // Mudou de cor para Vermelho
                Console.WriteLine("Não há veículos estacionados no momento.");
                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                return;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow; // Mudou de cor para Vermelho
            Console.WriteLine("Digite a placa do veículo a ser retirado:");
            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
            string placa = Console.ReadLine().ToUpper();

            bool placaEncontrada = false;
            foreach (var veiculo in estacionamento)
            {
                if (veiculo.Equals(placa))
                {
                    placaEncontrada = true;
                    break;
                }
            }

            if (placaEncontrada)
            {
                estacionamento.Remove(placa);
                Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                Console.WriteLine($"Veículo com placa {placa} retirado com sucesso.");
                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
            }
            else
            {
                Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
                Console.ForegroundColor = ConsoleColor.Red; // Mudou de cor para Vermelho
                Console.WriteLine($"Veículo com placa {placa} não encontrado no estacionamento.");
                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
            }
        }

        static void ListarVeiculos()
        {
            Console.Clear(); //Apagar msg anterior
            Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
            Console.WriteLine("Opção selecionada: Listar veículos\n");
            Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco

            if (estacionamento.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; // Mudou de cor para Amarelo
                Console.WriteLine("Temos essas vagas disponiveis!");
                Console.ForegroundColor = ConsoleColor.Cyan; // Mudou de cor para Ciano
                Console.WriteLine("[ ____ ] [ ____ ] [ ____ ] [ ____ ] [ ____ ]");
                Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
            }
            else
            {
                foreach (var placa in estacionamento)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan; // Mudou de cor para Ciano
                    Console.Write($"[ {placa} ] ");
                    Console.ForegroundColor = ConsoleColor.White; // Mudou de cor para Branco
                }
                Console.WriteLine();
            }
        }

        static void SairDoPrograma()
        {
            Console.Clear(); // Apaga o resto das mensagens para parecer que mudou de pagina
            Console.ForegroundColor = ConsoleColor.Cyan; // Mudou de cor para ciano
            Console.WriteLine($"Nós da {nomeDaEmpresa}, agradecemos o seu contato, e esperamos que volte logo! :D");
            Console.ForegroundColor = ConsoleColor.Red; // Mudou de cor para Vermelho
            Console.WriteLine("Programa encerrando altomaticamente em 7 segundos!");
            Thread.Sleep(7000); // tempo
            Environment.Exit(0); // fechar janela

        }

    }
}
