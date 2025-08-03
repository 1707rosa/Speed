using System;
using Speed.Class;


namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Distancias");
            Console.WriteLine("------------------------");
            Console.Write("Ingresa la distancia: ");
            string input = Console.ReadLine();

            if (!double.TryParse(input, out double valor))
            {
                Console.WriteLine("Error: Debes ingresar un número válido.");
                return;
            }

            Console.Write("¿La unidad es (K)ilómetros o (M)illas? ");
            string unidad = Console.ReadLine().Trim().ToUpper();

            if (unidad == "K")
            {
                Kilometros km = new Kilometros(valor);
                Console.WriteLine($"{km} son {km.A_Millas():F2} millas");
            }
            else if (unidad == "M")
            {
                Millas mi = new Millas(valor);
                Console.WriteLine($"{mi} son {mi.A_Kilometros():F2} kilómetros");
            }
            else
            {
                Console.WriteLine("Unidad no reconocida. Usa 'K' para kilómetros o 'M' para millas.");
            }

        }

    }

}