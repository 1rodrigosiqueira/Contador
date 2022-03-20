using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaClock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de variáveis

            int Segundo = 0;
            int Minuto = 0;
            int Hora = 0;

            // Programa
            while (Segundo <= 60)
            {
                //   Console.Clear();
                Console.WriteLine(Hora + ":" + Minuto + ":" + Segundo);
                Segundo++;
                //Console.ReadLine();
                if (Segundo == 60)
                {
                    Segundo = 0;
                    Minuto++;
                    if (Minuto == 60)
                    {
                        Segundo = 0;
                        Minuto = 0;
                        Hora++;
                        if (Hora == 24)
                        {
                            Segundo = 0;
                            Minuto = 0;
                            Hora = 0;
                        }
                    }

                }

            }
        }
    }
}

