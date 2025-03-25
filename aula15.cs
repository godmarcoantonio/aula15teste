using System;

namespace aula15
{
    class aula15
    {
        static void Main(string[] args)
        {
            //switch case e break estrutura de seleção multipla comparando uma variavel a uma constante nos cases
            
            int tempo;
            char escolha;
            Console.WriteLine("Escolha o transposte");
            Console.WriteLine("a para avião");
            Console.WriteLine("c para carro");
            Console.WriteLine("o para ônibus");
            escolha = char.Parse(Console.ReadLine());
            
            switch(escolha){
                case 'a':
                case 'A':
                    tempo = 50;
                    Console.WriteLine("O tempo é {0}", tempo);
                    break;
                case 'c':
                case 'C':
                    tempo = 200;
                    Console.WriteLine("O tempo é {0}", tempo);
                    break;
                case 'o':
                case 'O':
                    tempo = 400;
                    Console.WriteLine("O tempo é {0}", tempo);
                    break;
                default:
                    Console.WriteLine("opção invalida");
                    break;
            }
        }
    }
}
