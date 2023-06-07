using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {

            //Como declarar uma variável

            //O nome não pode ter:
            // - Acentos;
            // - Começar com números;
            // - Começar com maiúsculo;

            // ========================

            // - Separar Palavras com _ ou Maiúsculo;

            string dono_do_programa = "Miltom";
            int idade = 19;
           
            Console.WriteLine("Programa criado por "+ dono_do_programa);
            Console.WriteLine("Realmente, criado por " + dono_do_programa);
            Console.WriteLine(dono_do_programa + " criou o programa.");
            
            //CONCATENAÇÃO = JUNTAR PEDAÇOS DE TEXTOS PARA JUNTAR UM SÓ APENAS!

            // Este é o jeito véi cringe:
            Console.WriteLine (dono_do_programa +" tem "+ idade +" anos \n  \n" + "Sou " + dono_do_programa + ", tenho " + idade +" anos.");

            //Este aqui é o jeito novo poggers, chamado INTERPOLAÇÃO:

            Console.WriteLine($"Meu nome é {dono_do_programa} e eu tenho {idade} anos");

            Console.ReadKey();
            
        }
    }
}
