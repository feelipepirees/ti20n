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
        }//Fim do método

    }//Fim da Classe
}//Fim do Projeto
