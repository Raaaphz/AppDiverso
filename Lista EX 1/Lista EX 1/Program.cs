using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcao = 0;
        char resp = 'n';

        while (resp == 'n')
        {
            Console.Clear();
            //Criando o menu
            Console.WriteLine("LISTA");
            Console.WriteLine("EX 1 - CAIXA REGISTRADORA");
            Console.WriteLine("EX 2 - CALCULADORA FIBONACCI");
            Console.WriteLine("EX 3 - CALCULADORA DE TEMPERATURA");
            Console.WriteLine("EX 4 - EMPRESTIMO BANCARIO");
            Console.WriteLine("EX 5 - MEDIA PONDERADA DE NOTAS");
            Console.WriteLine("SAIR");

            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    ex1();
                    break;
                case 2:
                    ex2();
                    break;
                case 3:
                    ex3();
                    break;

                case 4:
                    ex4();
                    break;

                case 5:
                    ex5();
                    break;
                case 6:
                    Out();
                    break;
                default:
                    Console.WriteLine("Insira um numero valido");
                    Console.Beep();
                    break;

                    void ex1() //inicando o ex 1
                    {
                        Console.Clear();
                        int opcaoo = 0;
                        int total = 0;
                        char respp = 'n';

                        while (respp == 'n')
                        {
                            Console.Clear();
                            //Criando o menu
                            Console.WriteLine("##CAIXA REGISTRADORA##");
                            Console.WriteLine("1 - Adicionar Produto");
                            Console.WriteLine("2 - Calcular total");
                            Console.WriteLine("3 - Pagar e Receber troco");
                            Console.WriteLine("4 - Sair do Programa");

                            //criar a lista
                            List<string> prod = new List<string>(); //string = palavras
                            List<decimal> preco = new List<decimal>(); //decimal ou double = numeros


                            //selecionando para onde vamos 
                            opcaoo = int.Parse(Console.ReadLine());

                            switch (opcaoo)
                            {
                                case 1:
                                    Crialista();
                                    break;
                                case 2:
                                    Calcula();
                                    break;
                                case 3:
                                    Troco();
                                    break;
                                case 4:
                                    Sair();
                                    break;
                                default:
                                    Console.WriteLine("erro, tente novamente");
                                    Console.Beep();
                                    break;

                                    void Crialista()
                                    {
                                        //repetir sempre
                                        while (true)
                                        {
                                            //usuario adiciona os nomes e valores
                                            Console.WriteLine("Digite o nome do produto ou 'fim' para encerrar: ");
                                            string produtos = Console.ReadLine();

                                            //encerrar o loop
                                            if (produtos == "fim")
                                            {
                                                break;
                                            }
                                            prod.Add(produtos);


                                        }
                                        Console.WriteLine("Pressione qualquer tecla");
                                        Console.ReadKey();
                                    }
                                    void Calcula()
                                    {
                                        //usuario adiciona o valor do produto
                                        while (true)
                                        {
                                            Console.WriteLine("Digite o valor do produto ou 0 para parar: ");
                                            decimal valor = Convert.ToDecimal(Console.ReadLine());
                                            preco.Add(valor);

                                            if (valor == 0)
                                            {
                                                break;
                                            }
                                        }
                                        //fazer a soma
                                        decimal total = preco.Sum();
                                        Console.WriteLine("o valor foi: " + total);
                                        Console.WriteLine("Pressione qualquer tecla");
                                        Console.ReadKey();
                                    }
                                    void Troco()
                                    {
                                        //calcular o troco
                                        Console.WriteLine("insira o valor total da compra: ");
                                        decimal pagar = Convert.ToDecimal(Console.ReadLine());
                                        Console.WriteLine("insira o valor pago: ");
                                        decimal pagou = Convert.ToDecimal(Console.ReadLine());
                                        pagou -= pagar;

                                        Console.WriteLine("O troco é de: " + pagou);
                                        Console.WriteLine("Pressione qualquer tecla");
                                        Console.ReadKey();
                                    }
                                    void Sair()
                                    {
                                        return;
                                    }
                            }

                            return;
                        }


                    }
            }
            void ex2()
            {
                Console.Clear();
                double rep = 0;
                double exec = 0;
                double fibo = 0;
                double totalfibo = 1;
                double antefibo = 0;
                Console.WriteLine("##Calculadora de Fibonacci##");

                //determinando quantas casas de fibonacci
                Console.WriteLine("Deseja calcular quantos numeros da escala Fibonacci? ");
                exec = double.Parse(Console.ReadLine());
                Console.WriteLine("___________________________");
                Console.WriteLine("0");

                //executando fibonnaci
                while (rep <= exec - 2)
                {
                    Console.WriteLine(totalfibo);
                    fibo = totalfibo;
                    totalfibo = antefibo + fibo;
                    antefibo = fibo;
                    rep = rep + 1;
                }
                Console.WriteLine("____________________________");
                Console.WriteLine("Todas as " + exec + " casas foram calculadas com sucesso");
                Console.ReadKey();
            }
            void ex3()
            {
                double ce = 0; double fa = 0; char cont = 's'; int escolha = 0;
                Console.Clear();
                Console.WriteLine("##CALCULADORA DE TEMPERATURA##");
                Console.WriteLine("1- TRANSFORMAR CELSIUS EM FAHRENHEIT");
                Console.WriteLine("2- TRANSFORMAR FAHRENHEIT EM CELSIUS");
                Console.WriteLine("3- SAIR");

                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        CelsiusParaFahrenheit();
                        break;
                    case 2:
                        FahrenheitParaCelsius();
                        break;
                    case 3:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Insira um numero valido");
                        Console.Beep();
                        break;
                }

                void CelsiusParaFahrenheit()
                {

                    while (cont == 's')
                    {
                        Console.WriteLine("___________________________");
                        Console.WriteLine("Insira a temperatura em Celcius: ");
                        ce = double.Parse(Console.ReadLine());
                        double temptot1 = 9.0 / 5.0 * ce + 32.0;
                        Console.WriteLine(ce + " graus Celcius sao " + temptot1 + " graus Fahrenheit");
                        Console.WriteLine("Deseja continuar convertendo? (s/n) ");
                        cont = char.Parse(Console.ReadLine());
                    }
                }
                void FahrenheitParaCelsius()
                {
                    while (cont == 's')
                    {
                        Console.WriteLine("_______________________________");
                        Console.WriteLine("Insira a temperatura em Fahrenheit");
                        fa = double.Parse(Console.ReadLine());
                        double temptot2 = (fa - 32.0) * 5.0 / 9.0;
                        Console.WriteLine(fa + " graus Fahrenheit sao " + temptot2 + " graus Celcius");
                        Console.WriteLine("Deseja continuar convertendo? (s/n) ");
                        cont = char.Parse(Console.ReadLine());
                    }
                }
                void Exit()
                {
                    return;
                }
            }
            void ex4()
            {
                Console.Clear();
                Console.WriteLine("##SIMULADOR DE EMPRESTIMO##");

                //valor do emprestimo
                Console.WriteLine("insira o valor do emprestimo: ");
                double P = double.Parse(Console.ReadLine());

                //taxa de juros anual
                Console.WriteLine("insira a taxa de juros anual (em porcentagem sem o sinal)");
                double rA = double.Parse(Console.ReadLine());
                rA = rA / 100;
                //calculando a taxa de juros mensal
                double rM = rA / 12;

                //numero de parcelas
                Console.WriteLine("Insira o numero de parcelas:");
                double n = double.Parse(Console.ReadLine());

                //calculo parcela mensal
                double pmtpt1 = P * rM;
                double pmtpt2 = Math.Pow(1 + rM, n);
                double pmtpt3 = Math.Pow(1 + rM, n);
                double pmtpt4 = -1;

                double pmt = pmtpt1 * pmtpt2 / (pmtpt3 + pmtpt4);

                Console.WriteLine("O valor de cada parcela sera: " + pmt);
                Console.ReadKey();
            }
            void ex5()
            {
                Console.Clear();
                decimal notas = 1;
                decimal pesos = 0;
                decimal totalnotas = 0;
                decimal totalpesos = 0;
                decimal total = 0;

                List<decimal> armNotas = new List<decimal>();
                List<decimal> armPesos = new List<decimal>();

                Console.WriteLine("## Calculadora de Média Ponderada ##");
                Console.WriteLine("___________________________________");
                Console.WriteLine("1 - Listar as notas e pesos");

                while (notas >= 0) // Use >= para permitir 0 como nota válida.
                {
                    Console.WriteLine("Escreva uma nota ou qualquer negativo para sair: ");
                    notas = Convert.ToDecimal(Console.ReadLine());

                    if (notas < 0)
                    {
                        break;
                    }
                    else
                    {
                        armNotas.Add(notas);
                        Console.WriteLine("Escreva o peso referente à nota: ");
                        pesos = Convert.ToDecimal(Console.ReadLine());
                        armPesos.Add(pesos);
                    }
                }

                Console.WriteLine("Notas armazenadas:");
                foreach (decimal nota in armNotas)
                {
                    Console.WriteLine(nota);
                    totalnotas += nota;
                }

                Console.WriteLine("Pesos armazenados:");
                foreach (decimal peso in armPesos)
                {
                    Console.WriteLine(peso);
                    totalpesos += peso;
                }

                if (totalpesos > 0)
                {
                    total = totalnotas / totalpesos;
                    Console.WriteLine("Média ponderada: " + total);
                }
                else
                {
                    Console.WriteLine("Não é possível calcular a média ponderada com pesos iguais a zero.");
                }
                Console.ReadKey();
            }
            void Out()
            {
                Environment.Exit(1);
            }
        }
    }
}