using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 0;
            double valor2 = 0;
            double opcao = 0;
            


            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());
            
            
            
            Console.WriteLine("Escolha sua operação." + "\n");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - divisão");
            Console.WriteLine("4 - multiplicação");
            Console.WriteLine("5 - Sair.");
            Console.WriteLine("Número do teclado");
          
            opcao = Convert.ToDouble(Console.ReadLine());





            if (opcao == 1)
            {

                Console.WriteLine(valor1 + valor2);



            }

            else if (opcao == 2)
            {

                Console.WriteLine(valor1 - valor2);



            }

            else if (opcao == 3)
            {


                if (valor1 >= valor2)
                {
                    Console.WriteLine(valor1 / valor2);
                }

                else
                {
                    Console.WriteLine("Socorro!");



                }
                
                



            }
            else if (opcao == 4)
            {

                Console.WriteLine(valor1* valor2);



            }

            else if (opcao == 5)
            {

                Console.WriteLine("Obrigado, volte sempre!");


                
                    
               
                        
                            


               

            }
        }
    }
}
