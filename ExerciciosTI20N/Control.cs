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
                              "26.Exercicio 26\n"+
                              "27.Exercicio 27\n"+
                              "28.Exercicio 28\n"+
                              "29.Exercicio 29\n"+
                              "30.Exercicio 30\n"+
                              "31.Exercicio 31\n"+
                              "32.Exercicio 32\n"+
                              "33.Exercicio 33\n"+
                              "34.Exercicio 34\n"+
                              "51.Exercicio 51\n"+
                              "52.Exercicio 52\n"+
                              "53.Exercicio 53\n"+
                              "54.Exercicio 54\n"+
                              "55.Exercicio 55\n"+
                              "56.Exercicio 56\n"+
                              "57.Exercicio 57\n"+
                              "58.Exercicio 58\n"+
                              "59.Exercicio 59\n"+
                              "60.Exercicio 60" );
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
                    case 27:
                        Console.WriteLine("Informe o seu Ano");
                        double ano = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o seu mês");
                        double mes = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o seu dia");
                        double dia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteSete(ano, mes, dia));
                        break;
                    case 28:
                        Console.WriteLine("Informe as suas vendas: ");
                        double ValorVendas = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o seu salario: ");
                        double SalarioFixo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioVinteOito(ValorVendas,SalarioFixo));
                        break;
                    case 29:
                        Console.WriteLine(modelo.ExercicioVinteNove());
                        break;
                    case 30:
                        modelo.ExercicioTrinta();
                        break;
                    case 31:
                        Console.WriteLine(modelo.ExercicioTrintaUm());
                        break;
                    case 32:
                        Console.WriteLine("Informe o tempo: ");
                        int tempo = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Infome a velocidade Média: ");
                        int VelocidadeMedia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioTrintaDois(tempo, VelocidadeMedia));
                        break;
                    case 33:
                        Console.WriteLine("Infome a Base do retângulo");
                        int Base = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe a Altura do retângulo");
                        int Altura = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioTrintaTres(Base,Altura));
                        break;
                    case 34:
                        Console.WriteLine("Informe o Total de eleitores");
                        double TotalEleitores = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de votos brancos");
                        double VotosBrancos = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de votos nulos");
                        double VotosNulos = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a quantidade de votos válidos");
                        double VotosValidos = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine(modelo.ExercicioTrintaQuatro(TotalEleitores, VotosBrancos, VotosNulos, VotosValidos));
                        break;
                    case 35:
                        Console.WriteLine("Digite o custo de fábrica de um carro:");
                        double custoFabrica = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("O custo final ao consumidor é: ");
                        double custoConsumidor = Convert.ToDouble(Console.ReadLine());

                        modelo.ExercicioTrintaCinco();
                        break;
                    case 36:
                        modelo.ExercicioTrintaSeis();
                        break;

                    case 37:
                        modelo.ExercicioTrintaSete();
                        break;

                    case 38:
                        modelo.ExercicioTrintaOito();
                        break;

                    case 39:
                        modelo.ExercicioTrintaNove();
                        break;

                    case 40:
                        modelo.ExercicioQuarenta();
                        break;

                    case 41:
                        modelo.ExercicioQuarentaUm();
                        break;

                    case 42:
                        modelo.ExercicioQuarentaDois();
                        break;

                    case 43:
                        modelo.ExercicioQuarentaTres();
                        break;

                    case 44:
                        modelo.ExercicioQuarentaQuatro();
                        break;

                    case 45:
                        modelo.ExercicioQuarentaCinco();
                        break;

                    case 46:
                        modelo.ExercicioQuarentaSeis();
                        break;

                    case 47:
                        modelo.ExercicioQuarentaSete();
                        break;

                    case 48:
                        modelo.ExercicioQuarentaOito();
                        break;

                    case 49:
                        modelo.ExercicioQuarentaNove();
                        break;

                    case 50:
                        modelo.ExercicioCinquenta();
                        break;
                    case 51:
                        modelo.ExercicioCinquentaUm();
                        break;
                    case 52:
                        Console.WriteLine("A média do vetor é: " + modelo.ExercicioCinquentaDois());
                        break;
                    case 53:
                        modelo.ExercicioCinquentaTres();
                        break;
                    case 54:
                        modelo.ExercicioCinquentaQuatro();
                        break;
                    case 55:
                        modelo.ExercicioCinquentaCinco();
                        break;
                    case 56:
                        Console.WriteLine("A soma dos vetores é: " + modelo.ExercicioCinquentaSeis());
                        break;
                    case 57:
                        modelo.ExercicioCinquentaSete();
                        break;
                    case 59:
                        modelo.ExercicioCinquentaNove();
                        break;
                    case 60:
                        modelo.ExercicioSessenta();
                        break;

                    default:
                        Console.WriteLine("Código digitado não é válido! ");
                        break;                 

                }//Fim do método
            } while (opcao != 0);
        }//Fim do Operacao

    }//Fim da Classe
}//Fim do Projeto
