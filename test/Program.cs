using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            myclass m = new myclass();
            //Console.WriteLine("Hello World!");
            /* Console.WriteLine(sumar(456, 58));
            Console.WriteLine(m.hi());
            m.CallMe(15); */
            m.MayorValor();
            Console.ReadLine();
        }

        static int sumar(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    interface IMyclass
    {
        void CallMe(int a);
        void MayorValor();
    }

    class myclass : IMyclass
    {
        public string hi()
        {
            return "Hi!";
        }

        public void CallMe(int a)
        {
            Console.WriteLine("alo");
        }

        public void MayorValor()
        {
            int[] iValor = new int[5];
            iValor[0] = 20;
            iValor[1] = 15;
            iValor[2] = 5;
            iValor[3] = 25;
            iValor[4] = 50;

            int iValorActual=0;
            int iValorMayor=0;
            int iValorMenor=iValor[0];

            for (int x = 0; x<4;x++)
            {
                iValorActual = iValor[x];

                    //ValorMayor
                    if (iValor[x+1] > iValorActual )
                    {
                        if (iValorMayor < iValor[x+1])
                        {
                        iValorMayor  = iValor[x+1];}
                    }
                    else
                    {
                        if (iValorMayor < iValorActual)
                        {
                        iValorMayor  = iValorActual;}
                    }

                    //ValorMenor
                    if (iValor[x+1] < iValorActual )
                    {
                        if (iValorMenor > iValor[x+1])
                        {
                        iValorMenor  =  iValor[x+1];
                        }
                    }
                    else
                    {
                        if (iValorMenor > iValorActual)
                        {
                        iValorMenor  = iValorActual;
                        }
                    }

            }

            Console.WriteLine("Valor Mayor: "+ iValorMayor.ToString());
            Console.WriteLine("Valor Menor: "+ iValorMenor.ToString());

        }

    }
}