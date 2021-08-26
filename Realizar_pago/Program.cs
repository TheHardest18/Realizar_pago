using System;

namespace Realizar_pago
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir al usuario el precio de un producto(valor positivo) y la forma de pagar(efectivo o tarjeta)
            //si la forma de pago es mediante tarjeta, pedir el numero de cuenta(inventado
            pago();
        }
        public static void pago()
        {
            int producto, Forma_pago;
            long tarjeta;
            string seleccion="";
            
            do {
                Console.WriteLine("Ingrese precio de producto: ");
                producto = int.Parse(Console.ReadLine());
                Console.WriteLine("Seleccione forma de pagor: ");
                Console.WriteLine("1. Efectivo");
                Console.WriteLine("2. Tarjeta");
                Forma_pago = int.Parse(Console.ReadLine());
                switch (Forma_pago)
                {
                    case 1:
                        Console.WriteLine("Gracias por su compra");
                        Console.WriteLine("Desea realizar otra compra s/n");
                        seleccion = Console.ReadLine();
                        if (seleccion == "s" || seleccion == "S") Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Ingrese numero de tarjeta: ");
                        tarjeta = long.Parse(Console.ReadLine());
                      
                        if (tarjeta.ToString().Length > 10)
                        {
                            Console.WriteLine("Numero de Tarjeta invalido");
                            Console.WriteLine("Desea Contiuar s/n");
                            seleccion = Console.ReadLine();
                            if (seleccion == "s" || seleccion == "S") Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Gracias por su compra");
                            Console.WriteLine("Desea realizar otra compra s/n");
                            seleccion = Console.ReadLine();
                            if (seleccion == "s" || seleccion == "S") Console.Clear();
                        }
                        
                        break;
                }
            } while (seleccion == "s" || seleccion == "S");
        }
    }
}
