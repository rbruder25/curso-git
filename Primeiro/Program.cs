
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Primeiro
{
    class Program
    {
        public static object Triangulo { get; private set; }

        static void Main(string[] args)

        {
            /*          int intnumero1 = 5;
                      int intnumero2 = 10;
                      long variavel = 12302303233230L;
                      int total;
                      char letra = '\u0041';
                      object obj1 = "roberto";
                      int n1 = int.MinValue;
                      int n2 = int.MaxValue;
                      decimal dec = decimal.MaxValue;

                      total = intnumero1 + intnumero2; */

            // Console.WriteLine("Olá Mundo");
            /*   Console.WriteLine("O total é "+total);
               Console.WriteLine(variavel);
               Console.WriteLine(letra);
               Console.WriteLine(obj1);
               Console.WriteLine(dec); */

            // Console.WriteLine("Entre com uma hora");
            // int x = int.Parse(Console.ReadLine());
            //    int hora = int.Parse(Console.ReadLine());
            //   double preco = double.Parse(Console.ReadLine());
            /*           double desconto = 0.00;
                       double saldo = 10.45605;
                       int idade = 55;
                       string nome = "Roberto";

                       string produto1 = "Computador";
                       string produto2 = "Mesa de escritorio"; */

            //   byte idade = 30;
            //   int codigo = 5290;
            //    char genero = "M";

            // double preco1 = 2100.00;
            //double preco2 = 650.0;
            //   double medida = 53.234567;


            //if (preco > 100)
            //   desconto = preco * 0.1;
            /*  Console.WriteLine("VALOR COM DESCONTO É  " + desconto);
              Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
              Console.WriteLine("{0} tem {1} anos e tambem tem {2:F2} de saldo de banco", nome, idade, saldo);
              Console.WriteLine($"{nome} tem {idade} anos e tem um saldo de {saldo:F2} REAIS");
              Console.WriteLine(nome + "tem" + idade + "anos de tem um saldo de " + saldo.ToString("F2", CultureInfo.InvariantCulture));

              //--------------------------------------------------------------------------------
              Console.WriteLine("{0}  preço é ${1:f2}",produto1,preco1);
              Console.WriteLine("{0}  cujo preco é {1:F2}",produto2,preco2); *


              /*           if (x%2 == 0) //Se o Numero for par ou impar
                         {
                             Console.WriteLine("Este Numero é Par");
                         }else
                         {
                             Console.WriteLine("Este numero é impar");
                         }*/
            /*           
                        if (hora < 12)
                            Console.WriteLine("Bom dia");
                         else if ( hora < 18) 
                            Console.WriteLine("Boa tarde");
                         else
                            Console.WriteLine("Boa Noite"); */
            /*
                        string[] v = Console.ReadLine().Split(' ');

                        string a = v[0];
                        string b = v[1];
                        string c = v[2];

                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);


            */
            //  string[] vet = Console.ReadLine().Split(' ');
            //  int numero = int.Parse(Console.ReadLine());
            //   string nome = vet[0];
            //   char sexo = char.Parse(vet[1]);
            //   int idade = int.Parse(vet[2]);
            //   double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            // double dobro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //    Console.WriteLine("Digite algima coisa ");
            //   Console.WriteLine(numero);
            //   Console.WriteLine(dobro.ToString("F2", CultureInfo.InvariantCulture));
            /*            Console.WriteLine(nome);
                        Console.WriteLine(sexo);
                        Console.WriteLine(idade);
                        Console.WriteLine(altura.ToString("F2"),CultureInfo.InvariantCulture);  */

            //Função

            /*            Console.WriteLine("Digite tres numeros");
                        int n1 = int.Parse(Console.ReadLine());
                        int n2 = int.Parse(Console.ReadLine());
                        int n3 = int.Parse(Console.ReadLine());

                        Double resultado = Maior(n1, n2, n3);

                        Console.WriteLine("Maior ==> "+resultado);
                    } */
            /*       static int Maior(int a,int b,int c)
                   {
                       int m;
                       if (a > b && a > c) {
                           m = a;
                       } else if (b > c) {
                           m = b;
                       } else {  
                           m = c;
                       }
                       return m;
                   } */
            /*
                        Console.WriteLine("Digite um número");
                        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        while (x >= 0.00)
                        {
                            double raiz = Math.Sqrt(x);
                            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                            Console.WriteLine("DIGITE OUTRO NUMERO");
                            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        }
                        Console.WriteLine("Numero negativo !"); */
// Exemplo de For
 /*           Console.Write("Quanto numeros inteiro você vai digitar => ");
            int valores = int.Parse(Console.ReadLine());
            int soma = 0;
            

            for (int  i = 1;i <= valores;i++)
            {
                 Console.Write("Valor #{0}: ",i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
                }
            Console.Write("Soma {0} = ",soma); */
 //Objeto Triangulo
         Triangulo  x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do trigulo X : ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            x.B    = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C    = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do trigulo Y : ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (x.A + x.b + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - char.C));
            p = (y.A + y.B + y, C);
            double areaY = Math.Sqrt(p*(p-y.A)*(p-y.B)*(p-y.C))
            Console.WriteLine("Acresentada a mensagem nova para teste");

        }
    }
}
