using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI20N
{
    class Control
    {
        Model modelo;
        public Control() 
        {
            modelo = new Model();

            
        }//Fim do Construtor

        public void Menu()
        {
            Console.WriteLine("\n\nEscolha uma das opções abaixo: \n" +
                              "0. Sair\n" +
                              "1. Exercicio 1\n" +
                              "2. Exercicio 2\n" +
                              "3. Exercicio 3\n" +
                              "4. Exercicio 4\n"+
                              "5. Exercicio 5\n"+
                              "6. Exercicio 6\n"+
                              "7. Exercicio 7\n"+
                              "8. Exercicio 8\n"+
                              "9. Exercicio 9\n"+
                              "10.Exercicio 10\n"+
                              "11.Exercicio 11\n"+
                              "12.Exercicio 12\n"+
                              "13.Exercicio 13\n"+
                              "14.Exercicio 14\n"+
                              "15.Exercicio 15\n"+
                              "16.Exercicio 16\n"+
                              "17.Exercicio 17\n"+
                              "18.Exercicio 18\n"+
                              "19.Exercicio 19\n"+
                              "20.Exercicio 20\n"+
                              "21.Exercicio 21\n"+
                              "22.Exercicio 22\n"+
                              "23.Exercicio 23\n"+
                              "24.Exercicio 24\n"+
                              "25.Exercicio 25\n"+
                              "26.Exercicio 26\n");
        }//Fim do Menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {

                Menu();//Mostrando as opções
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.WriteLine(modelo.ExercicioUm());
                        break;
                    case 2:
                        Console.WriteLine(modelo.ExercicioDois());
                        break;
                    case 3:
                        Console.WriteLine("A Soma dos números entre 1 a 100 é: " + modelo.ExercicioTres());
                        break;
                    case 4:
                        Console.WriteLine("Os multiplos de 5 de 1 até 50 são: " + modelo.ExercicioQuatro());
                        break;
                    case 5:
                        Console.WriteLine("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioCinco(num));
                        break;
                    case 6:
                        Console.WriteLine("Informe um número: ");
                        int Num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioSeis(Num));
                        break;
                    case 7:
                        Console.WriteLine("Informe um número para fazer a tabuada dele: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioSete(num));
                        break;
                    case 8:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioOito(num));
                        break;
                    case 9:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("A Soma do número 1 ao número escolhido é: " + modelo.ExercicioNove(num));
                        break;
                    case 10:
                        Console.WriteLine("Os números primos de 1 a 20 são: " + modelo.ExercicioDez());
                        break;
                    case 11:
                        Console.WriteLine("Informe um número para ver se ele é primo ou não");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioOnze(num));
                        break;
                    case 12:
                        Console.WriteLine("Informe um número para calcular o fatorial");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioDoze(num));
                        break;
                    case 13:
                        Console.WriteLine("Informe um número: ");
                        
                        Console.WriteLine(modelo.ExercicioTreze());
                        break;
                    case 14:
                        Console.WriteLine("informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioQuatorze(num));
                        break;
                    case 15:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioQuinze(num));
                        break;
                    case 16:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioDezesseis(num));
                        break;
                    case 17:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioDezessete(num));
                        break;
                    case 18:
                        Console.WriteLine("Informe o primeiro número: ");
                        double num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        double num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioDezoito(num1,num2));
                        break;
                    case 19:
                        Console.WriteLine("Informe o primeiro número: ");
                        double Celsius = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioDezenove(Celsius));
                        break;
                    case 20:
                        Console.WriteLine("Informe úm número: ");
                        double Raio = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinte(Raio));
                        break;
                    case 21:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteUm(num));
                        break;
                    case 22:
                        Console.WriteLine("Informe o primeiro número: ");
                        double num3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        double num4 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteDois(num3, num4));
                        break;
                    case 23:
                        Console.WriteLine("Informe o primeiro número: ");
                        double num5 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        double num6 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteTres(num5, num6));
                        break;
                    case 24:
                        Console.WriteLine("Infome sua idade: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteQuatro(num));
                        break;
                    case 25:
                        Console.WriteLine("Informe o primeiro número: ");
                        double num7 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o segundo número: ");
                        double num8 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteCinco(num7, num8));
                        break;
                    case 26:
                        Console.WriteLine("Informe o seu peso");
                        double peso = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a sua altura");
                        double altura = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteSeis(peso, altura));
                        break;
                    default:
                        Console.WriteLine("Código digitado não é válido! ");
                        break;
                   

                }//Fim do método
            } while (opcao != 0);
        }//Fim do Operacao

    }//Fim da Classe
}//Fim do Projeto
