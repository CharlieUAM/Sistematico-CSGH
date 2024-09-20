using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.Write("Ingresa el primer numero del rango (X) ");
           int x = int.Parse(Console.ReadLine());


          Console.Write("Ingresa el primer numero del rango (Y) ");
          int y = int.Parse(Console.ReadLine());


            if (x < y)
            {
                Console.WriteLine("Numeros en orden inverso");
                for (int i = x; i >= y; i--) ;
                {
                    Console.WriteLine(i);
                }

            }

            {
             else
            }
            Console.WriteLine("Numeros en orden normal");
            for (int i = x; i <= y; i++) ;
            {
                Console.WriteLine(i);
            }



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
