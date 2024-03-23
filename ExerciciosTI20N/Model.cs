using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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


        //Exercício 36: Uma revendedora de carros usados paga a seus funcionários vendedores um salário fixo por mês, mais uma comissão também fixa para cada carro vendido e mais 5% do valor das vendas por ele efetuadas.Escrever um algoritmo que leia o número de carros por ele vendidos, o valor total de suas vendas, o salário fixo e o valor que ele recebe por carro vendido. Calcule e escreva o salário final do vendedor.
        public void ExercicioTrintaSeis()
        {
            int carrosVendidos;
            double valorVendas, salarioFixo, valorPorCarro, salarioFinal;

            // Pedindo ao usuário para inserir o número de carros vendidos
            Console.WriteLine("Insira o número de carros vendidos:");
            carrosVendidos = Convert.ToInt32(Console.ReadLine());

            // Pedindo ao usuário para inserir o valor total das vendas
            Console.WriteLine("Insira o valor total das vendas:");
            valorVendas = Convert.ToDouble(Console.ReadLine());

            // Pedindo ao usuário para inserir o salário fixo
            Console.WriteLine("Insira o salário fixo:");
            salarioFixo = Convert.ToDouble(Console.ReadLine());

            // Pedindo ao usuário para inserir o valor recebido por carro vendido
            Console.WriteLine("Insira o valor recebido por carro vendido:");
            valorPorCarro = Convert.ToDouble(Console.ReadLine());

            // Calculando o salário final do vendedor
            double comissaoFixaPorCarro = valorPorCarro * carrosVendidos;
            double comissaoPorVendas = valorVendas * 0.05; // 5% do valor das vendas

            salarioFinal = salarioFixo + comissaoFixaPorCarro + comissaoPorVendas;

            // Exibindo o salário final do vendedor
            Console.WriteLine($"O salário final do vendedor é: R${salarioFinal:F2}");
        }//Fim do Exercício Trinta e Seis

        //Exercício 37: Faça um programa que imprima os números de 1 a 100, mas substitua os múltiplos de 3 por "Fizz" e os múltiplos de 5 por "Buzz". Para números que são múltiplos de ambos (3 e 5), imprima "FizzBuzz".
        public void ExercicioTrintaSete()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }//Fim do If
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }//Fim do Else If
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }//Fim do Else If
                else
                {
                    Console.WriteLine(i);
                }//Fim do Else
            }//Fim do For
        }//Fim do Exercício Trinta e Sete

        //Exercício 38: Faça um programa que imprima os números de 100 a 1, em ordem decrescente.
        public void ExercicioTrintaOito()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }//Fim do Exercício Trinta e Oito

        //Exercício 39: Faça um programa que peça ao usuário uma palavra e imprima cada letra dela em uma linha.
        public void ExercicioTrintaNove()
        {
            // Solicita ao usuário uma palavra
            Console.WriteLine("Digite uma palavra:");
            string palavra = Console.ReadLine();

            // Itera sobre cada letra da palavra e imprime em uma linha
            foreach (char letra in palavra)
            {
                Console.WriteLine(letra);
            }
        }//Fim do Exercício Trinta e Nove

        //Exercício 40: Faça um programa que peça ao usuário um número e imprima a soma dos números pares até esse número.
        public void ExercicioQuarenta()
        {
            // Solicita ao usuário um número
            Console.WriteLine("Digite um número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            int somaPares = 0;

            // Itera de 1 até o número fornecido pelo usuário
            for (int i = 1; i <= numero; i++)
            {
                // Verifica se o número atual é par
                if (i % 2 == 0)
                {
                    somaPares += i; // Adiciona o número par à soma
                }//Fim do If
            }//Fim do For

            // Imprime a soma dos números pares
            Console.WriteLine($"A soma dos números pares até {numero} é: {somaPares}");
        }//Fim do Exercício Quarenta

        //Exercício 41: Faça um algoritmo que leia os valores de A, B, C e em seguida imprima na tela a soma entre A e B é mostre se a soma é menor que C.
        public void ExercicioQuarentaUm()
        {
            // Solicita ao usuário os valores de A, B e C
            Console.WriteLine("Digite o valor de A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            int C = Convert.ToInt32(Console.ReadLine());

            // Calcula a soma de A e B
            int soma = A + B;

            // Verifica se a soma é menor que C
            if (soma < C)
            {
                Console.WriteLine($"A soma entre {A} e {B} é menor que {C}");
            }//Fim do If
            else
            {
                Console.WriteLine($"A soma entre {A} e {B} não é menor que {C}");
            }//Fim do Else
        }//Fim do Exercício Quarenta e Um

        //Exercício 42: Faça um algoritmo que leia dois valores inteiros A e B, se os valores de A e B forem iguais, deverá somar os dois valores, senão deverá multiplicar. Ao final de qualquer um dos cálculos deve-se atribuir o resultado a uma variável C e imprimir na tela.
        public void ExercicioQuarentaDois()
        {
            // Solicita ao usuário os valores de A e B
            Console.WriteLine("Digite o valor de A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int B = Convert.ToInt32(Console.ReadLine());

            int C; // Variável para armazenar o resultado

            // Verifica se A e B são iguais
            if (A == B)
            {
                // Se forem iguais, soma os dois valores
                C = A + B;
            }//Fim do If
            else
            {
                // Se forem diferentes, multiplica os dois valores
                C = A * B;
            }//Fim do Else

            // Imprime o resultado
            Console.WriteLine($"O resultado é: {C}");
        }//Fim do Exercício Quarenta e Dois

        //Exercício 43: Faça um algoritmo que receba um número inteiro e imprima na tela o seu antecessor e o seu sucessor.
        public void ExercicioQuarentaTres()
        {
            // Solicita ao usuário um número inteiro
            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Calcula o antecessor e o sucessor do número
            int antecessor = numero - 1;
            int sucessor = numero + 1;

            // Imprime o antecessor e o sucessor na tela
            Console.WriteLine($"O antecessor de {numero} é: {antecessor}");
            Console.WriteLine($"O sucessor de {numero} é: {sucessor}");
        }//Fim do Exercício Quarenta e Três

        //Exercício 44: Faça um algoritmo que leia o valor do salário mínimo e o valor do salário de um usuário, calcule quantos salários mínimos esse usuário ganha e imprima na tela o resultado.
        public void ExercicioQuarentaQuatro()
        {
            // Solicita ao usuário o valor do salário mínimo
            Console.WriteLine("Digite o valor do salário mínimo:");
            double salarioMinimo = Convert.ToDouble(Console.ReadLine());

            // Solicita ao usuário o valor do seu salário
            Console.WriteLine("Digite o valor do seu salário:");
            double salarioUsuario = Convert.ToDouble(Console.ReadLine());

            // Calcula quantos salários mínimos o usuário ganha
            double salariosMinimosGanhos = salarioUsuario / salarioMinimo;

            // Imprime o resultado na tela
            Console.WriteLine($"Você ganha {salariosMinimosGanhos:F2} salários mínimos.");
        }//Fim do Exercício Quarenta e Quatro

        //Exercício 45: Faça um algoritmo que leia três valores inteiros diferentes e imprima na tela os valores em ordem decrescente.
        public void ExercicioQuarentaCinco()
        {
            // Solicita ao usuário os três valores inteiros diferentes
            Console.WriteLine("Digite o primeiro valor inteiro:");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor inteiro:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor inteiro:");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            // Armazena os valores em um array
            int[] valores = { valor1, valor2, valor3 };

            // Ordena o array em ordem decrescente
            Array.Sort(valores);
            Array.Reverse(valores);

            // Imprime os valores em ordem decrescente
            Console.WriteLine("Os valores em ordem decrescente são:");
            foreach (int valor in valores)
            {
                Console.WriteLine(valor);
            }//Fim do Foreach 
        }//Fim do Exercício Quarenta e Cinco

        //Exercício 46: Faça um algoritmo que leia quatro notas obtidas por um aluno, calcule a média das nota obtidas, imprima na tela o nome do aluno e se o aluno foi aprovado ou reprovado. Para o aluno ser considerado aprovado sua média final deve ser maior ou igual a 7.
        public void ExercicioQuarentaSeis()
        {
            //Solicita ao usuário o nome do aluno
            Console.WriteLine("Digite o nome do aluno:");
            string nomeAluno = Console.ReadLine();

            //Solicita ao usuário as quatro notas do aluno
            Console.WriteLine("Digite a primeira nota:");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta nota:");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            //Calcula a média das notas do aluno
            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            //Verifica se o aluno foi aprovado ou reprovado
            string situacao;
            if (media >= 7)
            {
                situacao = "aprovado";
            }//Fim do If
            else
            {
                situacao = "reprovado";
            }//Fim do Else

            //Imprime na tela o nome do aluno e sua situação
            Console.WriteLine($"O aluno {nomeAluno} foi {situacao} com média {media:F2}");
        }//Fim do Exercício Quarenta e Seis

        //Exercício 47: Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.
        public void ExercicioQuarentaSete()
        {
            //Solicita ao usuário os valores de A e B
            Console.WriteLine("Digite o valor de A:");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int B = Convert.ToInt32(Console.ReadLine());

            //Troca os valores de A e B usando uma variável temporária
            int temp = A;
            A = B;
            B = temp;

            //Imprime os valores trocados na tela
            Console.WriteLine($"Valor de A após troca: {A}");
            Console.WriteLine($"Valor de B após troca: {B}");
        }//Fim do Exercício Quarenta e Sete

        //Exercício 48: Faça um algoritmo que leia o ano em que uma pessoa nasceu, imprima na tela quantos anos, meses e dias essa pessoa ja viveu. Leve em consideração o ano com 365 dias e o mês com 30 dias. (Ex: 5 anos, 2 meses e 15 dias de vida)
        public void ExercicioQuarentaOito()
        {
            //Solicita ao usuário o ano de nascimento
            Console.WriteLine("Digite o ano de nascimento:");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());

            //Obtém a data atual
            DateTime dataAtual = DateTime.Today;

            //Calcula a diferença em anos, meses e dias
            int anos = dataAtual.Year - anoNascimento;
            int meses = dataAtual.Month - 1;
            int dias = dataAtual.Day;

            //Ajusta a diferença se ainda não tiver feito aniversário este ano
            if (dataAtual.Month < anoNascimento)
            {
                anos--;
                meses = 12 - (anoNascimento - dataAtual.Month) - 1;
            }//Fim do If

            //Ajusta a diferença se ainda não tiver completado o mês atual
            if (dataAtual.Day < anoNascimento)
            {
                dias = 30 - (anoNascimento - dataAtual.Day);
            }//Fim do If

            //Imprime na tela a idade da pessoa
            Console.WriteLine($"Você tem {anos} anos, {meses} meses e {dias} dias de vida.");
        }//Fim do Exercício Quarenta e Oito

        //Exercício 49: Faça um algoritmo que leia três valores que representam os três lados de um triângulo e verifique se são válidos, determine se o triângulo é equilátero, isósceles ou escaleno.
        public void ExercicioQuarentaNove()
        {
            //Solicita ao usuário os três lados do triângulo
            Console.WriteLine("Digite o comprimento do primeiro lado:");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do segundo lado:");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o comprimento do terceiro lado:");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            //Verifica se os três valores fornecidos formam um triângulo
            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
                // Verifica se é um triângulo equilátero
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }//Fim do If
                // Verifica se é um triângulo isósceles
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }//FIm do Else If
                //Caso contrário, é um triângulo escaleno
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }//Fim do Else
            }//Fim do If
            else
            {
                Console.WriteLine("Os valores fornecidos não formam um triângulo válido.");
            }//Fim do Else
        }//Fim do Exercício Quarenta e Nove

        //Exercício 50: Faça um algoritmo que calcule a quantidade de litros de combustível
        //gastos em uma viagem, sabendo que o carro faz 12km com um litro.
        //Deve-se fornecer ao usuário o tempo que será gasto na viagem a sua velocidade média,
        //distância percorrida e a quantidade de litros utilizados para fazer a viagem.
        //Fórmula: distância = tempo x velocidade.  litros usados = distância / 12.
        public void ExercicioCinquenta()
        {
            //Solicita ao usuário o tempo gasto na viagem (em horas)
            Console.WriteLine("Digite o tempo gasto na viagem (em horas):");
            double tempoViagem = Convert.ToDouble(Console.ReadLine());

            //Solicita ao usuário a velocidade média durante a viagem (em km/h)
            Console.WriteLine("Digite a velocidade média durante a viagem (em km/h):");
            double velocidadeMedia = Convert.ToDouble(Console.ReadLine());

            //Calcula a distância percorrida (distância = velocidade * tempo)
            double distanciaPercorrida = velocidadeMedia * tempoViagem;

            //Calcula a quantidade de litros de combustível utilizada (litros = distância / autonomia)
            double autonomia = 12; // O carro faz 12km por litro
            double litrosUtilizados = distanciaPercorrida / autonomia;

            //Exibe os resultados
            Console.WriteLine($"Tempo gasto na viagem: {tempoViagem} horas");
            Console.WriteLine($"Velocidade média: {velocidadeMedia} km/h");
            Console.WriteLine($"Distância percorrida: {distanciaPercorrida} km");
            Console.WriteLine($"Quantidade de litros utilizada na viagem: {litrosUtilizados:F2} litros");
        }//Fim do Exercício Cinquenta


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
        public int ExercicioCinquentaSeis()
        {
            int[] vet = new int[5];
            int soma = 0;
            int i = 0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(i + 1 + "º número: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
                soma += vet[i];
            }
            return soma;
        }//Fim do Exercicio 56

        //Exercício 57: Faça um programa que crie dois vetores de números inteiros com o mesmo tamanho e
        //realize a soma elemento por elemento desses vetores, armazenando o resultado em um terceiro vetor.
        public void ExercicioCinquentaSete()
        {
            int[] vet1 = new int[5];
            int[] vet2 = new int[5];
            int[] vet3 = new int[5];
            int i = 0;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + "º número: ");
                vet1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + "º número: ");
                vet2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0;i < 5; i++)
            {
                vet3[i] += vet1[i] + vet2[i];
                Console.WriteLine(vet3[i]);
            }
        }//Fim do Exercicio 57

        //Exercicio 58:Faça um programa que crie um vetor de números inteiros e
        //verifique se ele está em ordem crescente.
       

        //Fim do Exercicio 58

        //Exercicio 59:Faça um programa que crie um vetor de números inteiros e remova todos os
        //elementos repetidos desse vetor, deixando apenas uma ocorrência de cada valor.
        public void ExercicioCinquentaNove()
        {
            int[] vet = new int[5];
            int i = 0;
            int j = 4;
            for(i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1) + "º número: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
                if (vet[i] == vet[j])
                {

                }//fim do if  
            }
            for(i = 0; i < 5; i++)
            {
                Console.WriteLine(vet[i]);
            }
        }

        //Fim do Exercicio 59

        //Exercício 60: Faça um programa que crie um vetor de strings e
        //imprima todos os elementos desse vetor em ordem alfabética.

        public void ExercicioSesenta()
        {
            string[] vet = { "maçã", "uva", "laranja", "jabuticaba", "abacaxi" };

            //Ordenando o vetor em ordem alfabética
            Array.Sort(vet);

            Console.WriteLine("Elemento do Vetor em ordem alfabética: ");
            foreach (string elemento in vet)
            {
                Console.WriteLine(elemento);
            }
        }//Fim do Exercicio 60
        public void ExercicioSessenta()
        {
            string[] vet = { "maçã", "uva", "laranja", "jabuticaba", "abacaxi" };

            //Ordenando o vetor em ordem alfabética
            Array.Sort(vet);

            Console.WriteLine("Elemento do Vetor em ordem alfabética: ");
            foreach (string elemento in vet)
            {
                Console.WriteLine(elemento);
            }

        }//Fim do Exercicio 60

        // //Exercício 61: Faça um programa que crie um vetor de números inteiros e
        //verifique quantas vezes um determinado valor aparece no vetor.



    }//Fim da Classe
}//Fim do Projeto
