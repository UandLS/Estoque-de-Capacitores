using System;
using System.Linq;
using System.Globalization;

namespace Estoque0
{

    public static class Program
    {
        public static void Main()
        {

            int add;
            int remov = 0;


            Console.Write("Digite o  codigo do componente: ");
            string codig = Console.ReadLine();

            Console.Write("Digite a capacitancia do componente: ");
            double tancia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite a quantidade no estoque: ");
            int quantcap = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Eletr c = new Eletr(codig, tancia, quantcap);




            Console.WriteLine(" " + c);

            Console.WriteLine();
            Console.Write(" adicionar estoque desse componente: ");
            add = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.addestq(add);
            Console.WriteLine("Estoque atualizado: " + c);


            Console.WriteLine();
            Console.Write(" remover estoque desse componente: ");
            remov = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.removstq(remov);
            Console.WriteLine("Estoque atualizado: " + c);

        }
    }
}