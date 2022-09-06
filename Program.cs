using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaraçao de variaveis
            string formatacaoDados = "Inicialização de Variável...\n"; 
            string nomeUsuario, cidadeUsuario;

            
            // Entrada de Dados
            Console.WriteLine("Informe seu nome: ");
            nomeUsuario = Console.ReadLine();

            // Processamento
            formatacaoDados += "Seja bem vindo, " + nomeUsuario + "!";

            // Apresentaçao dos dados
            Console.WriteLine(formatacaoDados);
           
            // Pausa antes de encerrar aplicaçao 
            Console.WriteLine("Pressione qualquer tecla para sair...");
            var input = Console.ReadLine();
        }
    }
}
