using System;
using System.ComponentModel.DataAnnotations;

namespace LogicaProgramacao2
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Estrutura de dados
            /// Pilha - LIFO -em ingles -ultimo que entra primeiro que sai
            /// Fila - FIFO - em ingles - primeiro que entra primeiro que sai
            /// Lista - - nao tem a definiçao de primeiro ultimo posso escolher qlqr um!
            /// Arvores e matriz outros conceitos de dados. 

            /// Conceito de Pilha
            int[] numeros = new int[10];

            ///Estrutura de atribuiçao de dados
            for (int i = 0; i < 10; i++)
            {
                numeros[i] = i;
            }
            for (int i = 9;  i >= 0;  i--)
            {
                Console.WriteLine(numeros[i]);
            }

            ///// Conceito de fila
            //int[] numeros = new int[10];

            /////Estrutura de atribuiçao de dados
            //for (int i = 0; i < 10; i++)
            //{
            //    numeros[i] = i;
            //}

            /////Estrutura de impressao de dados
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}      




            ////// Conceito de lista
            //int[] numeros = new int[5];
            //numeros[3] = 1;
            //numeros[4] = 10;
            //Console.WriteLine(numeros[3]);
            //Console.WriteLine(numeros[4]);


            // Estruturas de Repetição

            //int resposta = 0;
            //int erro = 0;
            //int count = 1;

            //while (resposta != 4)
            //{
            //    if (count >= 2)
            //        erro++;

            //    Console.WriteLine("Qual nome do atual pesidente do brasil");
            //    Console.WriteLine("1- Fernado Henrique");
            //    Console.WriteLine("2- Lula");
            //    Console.WriteLine("3- Enrico");
            //    Console.WriteLine("4- Jair Bolsonaro");
            //    Console.WriteLine("5- Dilma");
            //    Console.WriteLine("6- Castelo");
            //    Console.WriteLine("7-Sarnei");
            //    resposta = Convert.ToInt32(Console.ReadLine());

            //    count++;
            //}
            //double nota = 10;
            //     if (erro > 0)
            //    nota = nota / erro;

            //    Console.WriteLine($"Acertou Miseravi! Sua nota é : {nota}");

            //if (resposta == 4)

            //{
            //    Console.WriteLine("Acertou miseravel");
            //}
            //else 
            //{
            //    Console.WriteLine("Tu é burro eim!");

            //}
            //For

            //Console.WriteLine("Digite o numero inicial:");
            //int inicial = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite o numero Final:");
            //int final = Convert.ToInt32(Console.ReadLine());

            //if (final <= inicial)           
            //    Console.WriteLine("Tu é burro eim o inicial nao pode ser menor que o final");

            //else
            //{
            //    Console.WriteLine("Numeros impares(I) numeros pares (P):");
            //    string tipo = Console.ReadLine();
            //    switch (tipo.ToLower())
            //    {
            //        case "p":
            //            for (int i = inicial; i <= final; i++)

            //                if (i % 2 ==0)

            //                    Console.WriteLine(i);





            //            break;
            //        case "i":
            //            for (int i = inicial; i <= final; i++)

            //                if (i % 2 == 0)

            //                    Console.WriteLine(i);
            //            break;
            //        default:
            //            Console.WriteLine("Voce digitou o tipo de numero correto!!");
            //            break;






            //int numero = 1;
            //while (numero % 2 == 1) // resto impar
            //{
            //    Console.WriteLine("Digite um numero par");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("obrigado por digitar um numero par");

            //int inteiro = 13 % 2;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 2== 1) //par 0 impar 1
            //    {
            //        Console.WriteLine(i);
            //    }


            //}

            // While

            //int inteiro = 0;

            //while (inteiro < 10)
            //{
            //    Console.WriteLine(inteiro);
            //        inteiro++;
            //}
        }
        }
}
