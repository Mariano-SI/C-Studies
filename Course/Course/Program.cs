﻿using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;


namespace Course {
    internal class Program {
        static void Main(string[] args) {

            /*
                Exercício 01
                Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
                int num = int.Parse(Console.ReadLine());

                if (num >= 0) {
                    Console.WriteLine("NÃO NEGATIVO");
                }
                else {
                    Console.WriteLine("NEGATIVO");
                }
            */

            /*
                Exercicío 02
                Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0) {
                    Console.WriteLine("Par");
                }
                else {
                    Console.WriteLine("Ímpar");
                }
            */

            /*
                Exercício 03
             
                Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
                Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
                ordem crescente ou decrescente
            

                string[] valores = Console.ReadLine().Split(' ');
                int firstNumber = int.Parse(valores[0]);
                int secondNumber = int.Parse(valores[1]);

                if (firstNumber % secondNumber == 0 || secondNumber % firstNumber == 0) {
                    Console.WriteLine("São Múltiplos");
                }
                else {
                    Console.WriteLine("Não são múltiplos");
                }
            */

            /*
                Exercício 04
                
                Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
                começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            */

            /*
                Exercício 04
                Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1046/uri1046/Program.cs
                Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
                começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
            

                string[] inicioEFim = Console.ReadLine().Split(" ");

                int inicio = int.Parse(inicioEFim[0]);
                int fim = int.Parse(inicioEFim[1]);
                int duracao;

                if (inicio < fim) {
                    duracao = fim - inicio;
                
                }
                else {
                    duracao = (24 + fim) - inicio;
                }
                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            */

            /*
                Exercício 05
                Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item.A
                seguir, calcule e mostre o valor da conta a pagar

                string[] entrada = Console.ReadLine().Split(" ");

                int codigo = int.Parse(entrada[0]);
                int quantidade = int.Parse(entrada[1]);
                double total;

                if (codigo == 1) {
                    total = quantidade * 4.0;
                }
                else if (codigo == 2) {
                    total = quantidade * 4.5;
                }
                else if (codigo == 3) {
                    total = quantidade * 5.0;
                }
                else if (codigo == 4) {
                    total = quantidade * 2.0;
                }else if (codigo == 5) {
                    total = quantidade * 1.5;
                }
                else {
                    total = 0;
                }

                Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            /*
             
            */

            /*
                Exercício 06
                Correção: https://github.com/acenelio/nivelamento-csharp/blob/master/uri1037/uri1037/Program.cs
                            Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
                seguintes intervalos([0,25], (25, 50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
                nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
                double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(num < 0 || num > 100) {
                    Console.WriteLine("Fora de intervalo");
                }
                else {
                    if (num >= 0 && num <= 25) {
                        Console.WriteLine("Intervalo [0,25]");
                    }else if(num > 25 && num <= 50) {
                        Console.WriteLine("Intervalo [25,50]");
                    }else if (num > 50 && num <= 75) {
                        Console.WriteLine("Intervalo [50,75]");
                    }
                    else {
                        Console.WriteLine("Intervalo [75,100]");
                    }
                }
            */



        }
    }
}
