using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
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

        //Exercicio 17: Faça um programa que peça ao usuário um número e imprima o dobro desse número

        public int ExercicioDezessete(int num)
        {
            int Dobro = 0;

            Dobro = num * 2;
          
            return Dobro;

        }//Fim do Exercicio 17.

        //Exercicio 18:Faça um programa que peça ao usuário dois números e imprima a média deles

        public double ExercicioDezoito(double num1, double num2)
        {
            double media = 0;

            media = (num1 + num2) / 2;

            return media;
        }

        //Fim do Exercicio 18.

        //Exercicio 19:Faça um programa que converta a temperatura de Celsius para fahrenheit
        //A fórmula é F = C * 9/5 + 32.

        public double ExercicioDezenove(double Celsius)
        {
            double fahrenheit = 0;

            fahrenheit = Celsius * 9 / 5 + 32;

            return fahrenheit;

        }//Fim do exercicio 19

        //Exercicio 20:Faça um programa que peça o raio de um círculo e imprima a área.
        //A fromula é A = pi * raio^2.

        public double ExercicioVinte(double Raio)
        {
            return Math.PI * Math.Pow(Raio, 2);

        }//Fim do método

        //Fim do Exercicio 20

        //Exercicio 21:Faça um programa que um número e imprima o seu quadrado

        public double ExercicioVinteUm(double num)
        {
            return num * 2;
        }

        //Fim do Exercicio 21

        //Exercicio 22:Faça um programa que peça dois números e imprima o maior deles

        public double ExercicioVinteDois(double num3, double num4)
        {
            if (num3 > num4)
            {
                return num3;
            }
            else
            {
                return num4;
            }//Fim do If

        }//Fim do Exercicio 22

        //Exercicio 23:Faça um programa que peça dois números e imprima "São iguais" se os números forem iguais ou imprima "São Diferentes" se forem difetentes
        public string ExercicioVinteTres(double num5, double num6)
        {
            string resposta = "";
            if (num5 == num6)
            {
                resposta = "É igual";
            }
            else
            {
                resposta = "É diferente";
            }
            return resposta;
        }
        
        //Fim Exercicio 23

        //Exercicio 24:Faça um programa que peça a idade do usuário e imprima se ele é maior de idade ou menor de idade

        public string ExercicioVinteQuatro(int num)
        {
            string resposta = "";
            if (num >= 18)
            {
                resposta = "É de maior";
            }
            else
            {
                resposta = "É de menor";

            }//Fim If
            return resposta;
        }//Fim do Exercicio 24

        //Exercicio 25:Faça um programa que peça dois números e imprima o menor deles
        public double ExercicioVinteCinco(double num7, double num8)
        {
            if (num7 < num8)
            {
                return num7;
            }
            else
            {
                return num8;
            }//Fim do If

        }//Fim do Exercicio 25

        //Exercicio 26:Faça um programa que peça a altura e o peso de uma pessoa e calcule o IMC (Índice de Massa Corporal)
        //A formula é IMC = peso / altura ^ 2
        public double ExercicioVinteSeis(double peso, double altura)
        {

            return peso / Math.Pow(altura, 2);

        }//Fim do Exercicio 26


        //Exercicio 27:Faça um algoritmo que leia a idade de uma pessoa expressa em anos,
        //meses e dias e escreva a idade dessa pessoa expressa apenas em dias.
        //Considerar ano com 365 dias e mês com 30 dias.
        public double ExercicioVinteSete(double ano, double mes, double dia)
        {
           
            return (ano * 365) + (mes * 30) + dia;

        }//Fim do Exercicio 27

        //Exercicio 28:Faça Ler o salário fixo e o valor das vendas efetuadas pelo
        //vendedor de uma empresa. Sabendo-se que ele recebe uma
        //comissão de 3% sobre o total das vendas até R$ 1.500,00
        //mais 5% sobre o que ultrapassar este valor, calcular e
        //escrever o seu salário total
        public double ExercicioVinteOito(double SalarioFixo, double ValorVendas)
        {
            double SalarioFinal = 0;
            if(ValorVendas <= 1500)
            {
                SalarioFinal = (ValorVendas * 0.03) + SalarioFixo;
            }
            else
            {
                SalarioFinal = (1500 * 0.03) + ((ValorVendas - 1500) * 0.05) + SalarioFixo;
            }
            return SalarioFinal;

        }//Fim do Exercicio 28

        //Exercicio 29:Ler 10 valores e escrever quantos desses valores lidos são NEGATIVOS
        public int ExercicioVinteNove()
        {
            int num = 0;
            int cont = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + " Número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                {
                    cont++;
                }
            }
            return cont;

        }//Fim do Exercicio 29

        //Exercicio 30:Escreva um algoritmo para ler 10 números. Todos os
        //números lidos com valor inferior a 40 devem ser somados.
        //Escreva o valor final da soma efetuada
        public void ExercicioTrinta()
        {
            int num = 0;
            int soma = 0;

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine((i + 1) + " Número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if(num < 40)
                {
                    soma += num;
                }
            }

            Console.WriteLine("A soma dos valores inferiores a 40 é: " + soma);

        }//Fim Exercicio 30

        //Exercicio 31:Escreva um algoritmo que permita a leitura das notas de
        //uma turma de 20 alunos.Calcular a média da turma.Escrever a média da turma.
        public int ExercicioTrintaUm()
        {
            int soma = 0;
            int media = 0;
            int nota = 0;

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine("Informe um número: ");
                nota = Convert.ToInt32(Console.ReadLine());

                soma += nota;
            }
            media = soma / 20;

            return media;

        }//Fim do Exercicio 31 

        //Exercicio 32:Faça um algoritmo que calcule a quantidade de litros de
        //combustível gasta em uma viagem, utilizando um automóvel
        //que faz 12Km por litro.Para obter o cálculo, o usuário deve
        //fornecer o tempo gasto na viagem e a velocidade média
        //durante ela. Desta forma, será possível obter a distância
        //percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.

        //Tendo o valor da distância, basta calcular a quantidade de
        //litros de combustível utilizada na viagem com a fórmula:
        //LITROS_USADOS = DISTANCIA / 12.O programa deve
        //apresentar os valores da velocidade média, tempo gasto na
        //viagem, a distância percorrida e a quantidade de litros
        //utilizada na viagem
        public string ExercicioTrintaDois(int tempo, int VelocidadeMedia)
        {
            int LitrosUsados = 0;
            int Distancia = 0;

            Distancia = tempo * VelocidadeMedia;

            LitrosUsados = Distancia / 12;

            return "A velocidade média é: " + VelocidadeMedia + "A Distancia percorrida é: " + Distancia + "O tempo gasto é: " + tempo + "A quantidade de litros usados foi: " + LitrosUsados;

        }//Fim Exercicio 32

        //Exercício 33: Escreva um algoritmo para ler as dimensões de um retângulo (base e
        //altura), calcular e escrever a área do retângulo
        public int ExercicioTrintaTres(int Base, int Altura)
        {
            int area = 0;
            area = Base * Altura;
            return area;

        }//Fim do Exercicio 33

        //Exercício 34:Escreva um algoritmo para ler o número total de eleitores de um
        //município, o número de votos brancos, nulos e válidos.Calcular e
        //escrever o percentual que cada um representa em relação ao total de eleitores
        public string ExercicioTrintaQuatro(double TotalEleitores, double VotosBrancos, double VotosNulos, double VotosValidos)
        {
            return "O número total de Eleitores é: " + TotalEleitores + "\n O porcentual de Votos Brancos é: " + (VotosBrancos / TotalEleitores) * 100 + "\n O porcentual de Votos Nulos é: " + (VotosNulos / TotalEleitores) * 100 + "\n O porcentual de votos válidos é: " + (VotosValidos / TotalEleitores) * 100;
        }
        //Fim do Exercicio 34

        //Exercicio 35:O custo de um carro novo ao consumidor é a soma do custo de fábrica
        //com a porcentagem do distribuidor e dos impostos(aplicados ao custo
        //de fábrica). Supondo que o percentual do distribuidor seja de 28% e os
        //impostos de 45%, escrever um algoritmo para ler o custo de fábrica de
        //um carro, calcular e escrever o custo final ao consumidor.
        public void ExercicioTrintaCinco()
        {
            Console.WriteLine("Digite o custo de fábrica de um carro: ");
            double custoFabrica = 0;
            double percentualDistribuidor = 0.28;
            double percentualImpostos = 0.45;


            double custoDistribuidor = custoFabrica * percentualDistribuidor;
            double custoImpostos = custoFabrica * percentualImpostos;
            double custoConsumidor = custoFabrica + custoDistribuidor + custoImpostos;

            Console.WriteLine("O custo final ao consumidor é: " + custoConsumidor);
        }
        //Fim do Exercicio 35


        //Exercicio 36:Uma revendedora de carros usados paga a seus funcionários
        //vendedores um salário fixo por mês, mais uma comissão também fixa
        //para cada carro vendido e mais 5% do valor das vendas por ele
        //efetuadas.Escrever um algoritmo que leia o número de carros por ele
        //vendidos, o valor total de suas vendas, o salário fixo e o valor que ele
        //recebe por carro vendido. Calcule e escreva o salário final do vendedor.


        //Fim do Exercicio 36


        //Exercício 51: Faça um programa que crie um vetor de números inteiros e
        //imprima todos os elementos desse vetor.
        public void ExercicioCinquentaUm()
        {
            int[] vet = new int[4]; //Declaração do vetor
            //Preenchendo o vetor
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine((i + 1) + " Número: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            //Mostrar o vetor
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine((i + 1) + " Posição: " + vet[i]);
            }
        }
        //Fim do Exercicio 51

        //Exercício 52: Faça um programa que crie um vetor de números inteiros e
        //calcule a média dos valores presentes no vetor.
        public int ExercicioCinquentaDois()
        {
            int[] vet = new int[4];
            int soma = 0;
            int i = 0;
            for(i = 0; i < 4; i++)
            {
                Console.WriteLine((i + 1) + " Posição: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
                soma += vet[i]; //Somando
            }
            return soma / i;
        }
        //Fim do Exercicio 52

        //Exercício 53:  Faça um programa que crie um vetor de números inteiros e
        //imprima apenas os valores pares desse vetor.
        public void ExercicioCinquentaTres()
        {
            int[] vet = new int[10];
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + "Informe um número: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());

                if (vet[i] % 2 == 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }
        //Fim do Exercicio 53


        //Exercício 54: Faça um programa que crie um vetor de números inteiros e
        //imprima o maior e o menor valor presente no vetor.
        public void ExercicioCinquentaQuatro()
        {
            int[] vet = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + "Informe um número: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maior = vet[0];
            int menor = vet[0];

            for (int i = 0; i < 5; i++)
            {
                if (vet[i] < menor)
                {
                    menor = vet[i];
                }
                else
                {
                    maior = vet[i];
                }
            }
        }//Fim do Exercicio 54

        //Exercicio 55:Faça um programa que crie um vetor de números inteiros e
        //imprima os elementos na ordem inversa.
        public void ExercicioCinquentaCinco()
        {
            int[] vet = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + "Informe um número: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            int aux = 0;
            int r = 9;

            for(int i = 0; i < 4; i++)
            {
                aux = vet[r];
                vet[r] = vet[i];
                vet[i] = aux;
                r = r - 1;
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine((i + 1) + "ª Posição: " + vet[i]);
            }
        }//Fim do Exercicio 55

        //Exercicio 56:Faça um programa que crie um vetor de números inteiros e
        //calcule a soma de todos os valores presentes no vetor.
        

        //Fim do Exercicio 56

    }//Fim da Classe
}//Fim do Projeto
