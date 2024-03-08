using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI20N
{
    class Model
    {

        //Construtor
        public Model()
        {

        }//Fim do Método Construtor

        //Exercício 01: Faça um programa que imprima os números de 1 a 10.
        public string ExercicioUm()
        {
            string resultado = "";

            for (int i=0; i < 10; i++)
            {
                resultado += "\n" + (i+1);
            }

            return resultado;

        }//Fim do método

        //Faça um programa que imprima os números pares de 1 a 20.
        public string ExercicioDois()
        {
            string resultado = "";

            for(int i = 0; i < 20; i++)
            {
                if((i+1) % 2 == 0)
                {
                    resultado += "\n" + (i + 1);
                }//Fim do IF
            }//Fim do For

            return resultado;

        }//Fim do ExercicioDois

        //Faça um programa que some de 1 até 100
        public int ExercicioTres()
        {
            int resultado = 0;

            for(int i = 1; i <= 100; i++)
            {


                resultado += i;
            }//Fim do IF

            return resultado;
        }//Fim do For

        //Exercicio 4: Faça um programa que imprima os mútiplos de 5 de 1 a 50.

        public string ExercicioQuatro()
        {
            string resultado = "";

            for(int i = 0; i <= 50; i++)
            {

                if((i+1) % 5 == 0)
                {
                    resultado += "\n" + (i + 1);
                } //Fim do if
            }//Fim do For

            return resultado;
        }//Fim Exercicio 4

        //Faça um programa que peça ao usuário um número e imprima se é par ou impar.
        public string ExercicioCinco(int num)
        {
            if(num % 2 == 0)
            {
                return "É Par";
            }
            else
            {
                return "É Ímpar";
            }
        }//Fim do Exercicio 5

        //Exercicio 6 : Faça um programa que peça ao usuário um número e imprima se é positivo, negativo ou zero.
        public string ExercicioSeis(int num)
        {
            if (num == 0)
            {
                return "É Zero";
            }
            else if (num > 0)
            {
                return "É positivo";
            }
            else
            {
                return "É negativo";
            }

        }//Fim do Exercicio 6
        
        //Exercicio 7 : Faça um programa que peça ao usuário um número e imprima a tabuada desse número.

        public string ExercicioSete(int num)
        {
            string Resultado = "";

            for (int i = 0; i <=10; i++)
            {
                Resultado += "\n" + num + " * " + i + " = " + (num * i);
            }
            
            return Resultado;
        }//Fim do Exercicio 7

        //Exercicio 8 : Faça um programa que peça ao usuário um número e imprima os números de 1 até esse número.
        public string ExercicioOito(int num)
        {
            string Resultado = "";

            for (int i = 0; i <= num; i++)
            {
                Resultado += "\n" + i;
            }
            return Resultado;
        }//Fim do Exercicio 8


        //Exercicio 9 : Faça um programa que peça ao usuário um número e imprima a soma dos números de 1 até esse número.

        public int ExercicioNove(int num)
        {
            int Resultado = 0;

            for (int i = 0; i <= num; i++)
            {
                Resultado += i;
            }
            return Resultado;
        }

        //Fim do Exercicio 9

        //Exercicio 10 : Faça um programa que imprima os números primos de 1 a 20.

        public string ExercicioDez()
        {
            string primos = "2 3 5";

            for (int i = 2; i <= 20; i++)
            {
                if(i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    primos += " " + i ;
                }

            }//Fim do For

            return primos;

        }

        //Fim do Exercicio 10


        //Exercicio 11: Faça um programa que peça ao usuário um número e verifique se é primo.

        public string ExercicioOnze(int num)
        {
            if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0)
            {
                return "primos!";
            }
            else if (num == 2 || num == 3 || num == 5)
            {
                return "Primo!";
            }
            else
            {
                return "Não Primo!";
            }
        }

        //Fim Exercicio 11

        //Exercicio 12: Faça um programa que calcula o fatorial de um número:
        public int ExercicioDoze(int num)
        {
            int fatorial = 1;
            for (int i = num; i >= 1; i--)
            {
                fatorial *= i;
            }

            return fatorial;

        }//Fim do Exercicio 12

        //Exercicio 13: Faça um programa que imprima a sequência que imprima a frequencia de Fibonacci até o décimo termo.

        public string ExercicioTreze()
        {
            string resultado = "0 1";
            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;

            for(int i = 1; i <= 8; i++)
            {
                fib3 = fib1 + fib2;
                resultado += " " + fib3;
                fib1 = fib2;
                fib2 = fib3;

            }//Fim do For

            return resultado;

        }//Fim do Exercicio 13

        //Exercicio 14:Faça um programa que peça ao usuário um número e imprima se é um número de Fibonacci.
        public string ExercicioQuatorze(int num)
        {
            string resultado = "0 1";
            int fib1 = 0;
            int fib2 = 1;
            int fib3 = 0;
            
            for(int i = 1; i <= num-2; i++)
            {
                fib3 = fib1 + fib2;
                resultado += " " + fib3;
                fib1 = fib2;
                fib2 = fib3;
            }
            return resultado;
        }

        //Fim do Exercicio 14

        //Exercicio 15:Faça que o programa que peça ao usuário um número e imprima e calcule a soma dos seus dígitos.
        public int ExercicioQuinze(int num)
        {
            
            string resultado = "" + num; //Converte o número para texto
            int tamanho = resultado.Length; //Retorna o tamanho do texto
            int soma = 0;
            for(int i = 0; i < tamanho; i++)
            {
                soma += Convert.ToInt32(resultado.Substring(i, 1)); //Coletando um caracter por vez
            }
            return soma;   
        }

        //Fim do Exercicio 15.

        //length = Traz o tamanho

        //Exercicio 16: Faça um programa que peça ao usuário um número e imprima os números pares e ímpares de 1 até esse número.
        public string ExercicioDezesseis(int num)
        {
            string Pares = "";
            string Impar = "";
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Pares += " " + i;
                }   
                else
                {
                    Impar += " " + i;
                }

            }//Fim do For

            return "Pares: " + Pares + "\nImpares: " + Impar;

        }//Fim do Exercicio 16.

    }//Fim da Classe
}//Fim do Projeto
