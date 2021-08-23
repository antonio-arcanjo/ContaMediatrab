using System;
using System.Linq;

namespace ContaMediatrab
{
    class Program
    {
        static void Main()
        {
            int cont = 0;
            int med;
            int i;
            int j;



            Console.WriteLine("informe a quantidade de numeros");
            int n1 = Int32.Parse(Console.ReadLine());
           

               int[] a = new int[n1];

            for (j = 0; j < n1; j++)
            {
                Console.WriteLine("informe os valores");
                a[j] = Int32.Parse(Console.ReadLine());
            }

                int soma = a.Sum();
                med = soma / a.Length;

               Console.WriteLine("a media é "+med);

              

                for (i = 0; i < n1; i++)
           {
                if(a[i] == med)
                   {
                cont++;
                    }

                
            }


            Console.WriteLine("a quantidade de numeros igual a media é: "+cont);
        }

        
    }
}
