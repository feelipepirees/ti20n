using System;
using System.Collections.Generic;
using System.Linq;
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

        
        
         

        //Fim do Exercicio 10


        //Exercicio 11: Faça um programa que peça ao usuário um número e verifique se é primo.

 



    }//Fim da Classe
}//Fim do Projeto
