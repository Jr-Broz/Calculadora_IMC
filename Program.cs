using System;

namespace IMC {

    internal class Program {

        static void Main(string[] args) {

            bool sair = false;

            while(!sair) {  

           Console.WriteLine("Escreva o Peso");
           String respostaPeso = Console.ReadLine();
            
            Double pesoNumero =   Double.Parse(respostaPeso);

            Console.WriteLine("Escreva sua altura");
            String respostaAltura = Console.ReadLine(); 

            Double alturaNumero = Double.Parse(respostaAltura);

            double operacao = pesoNumero/ alturaNumero;

                if(operacao < 17) {

                    Console.WriteLine("Muito abaixo do peso");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Obrigado por utilizar");
                }

                else if(operacao >= 17 && operacao <= 18.49) {

                    Console.WriteLine("Abaixo do peso");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Obrigado por utilizar");
                }

                else if(operacao >= 18.5 && operacao <= 24.99) {

                    Console.WriteLine("Peso normal");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Obrigado por utilizar");
                }

                else if(operacao >= 25 && operacao <= 29.99) {

                    Console.WriteLine("Acima do peso");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Obrigado por utilizar");
                }

                else if(operacao >= 30 && operacao <= 34.99) {


                    Console.WriteLine("Obesidade I");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Obrigado por utilizar");
                }
                
                else if (operacao >= 35 && operacao <= 39.99) {

                    Console.WriteLine("Obesidade II (Severa)");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Obrigado por utilizar");
                } 
                
                else if (operacao > 40) {

                    Console.WriteLine("Obesidade III (morbida)");
                    Console.WriteLine("=============================");
                    Console.WriteLine("Obrigado por utilizar");
                }

                 Console.WriteLine("Deseja Sair da Calculadora ? (Escreva sim, caso queira sair) || (Escreva não, caso queira continuar.) ");
                 String resposta =  Console.ReadLine();

                if(resposta == "Sim" || resposta == "sim") {

                    Console.WriteLine("Obrigado por utilizar Esta calculadora de IMC");
                    sair = true;
                }

                else {
                    Console.WriteLine("Certo, continuando com operaçoes ");
                }
            }

        }
    }
    }
/*
 Abaixo de 17	Muito abaixo do peso
Entre 17 e 18,49	Abaixo do peso
Entre 18,5 e 24,99	Peso normal
Entre 25 e 29,99	Acima do peso
Entre 30 e 34,99	Obesidade I
Entre 35 e 39,99	Obesidade II (severa)
Acima de 40	Obesidade III (mórbida)
*/
