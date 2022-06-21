using System;
using System.Collections.Generic;


namespace NaviosEContentores
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success;
            int option;

            List<Container> Containers = new List<Container>();
            List<Ship> ships = new List<Ship>();        

            MenuNavios menuNavio = new MenuNavios(ships);
            MenuContentores menuContentor = new MenuContentores(Containers);
            

            while (true)
            {
                do
                {
                    Console.WriteLine("Introduza a opção desejada:");
                    Console.WriteLine("1 -> Navios");
                    Console.WriteLine("2 -> Contentores");
                    //Console.WriteLine("3 -> Ficheiros");
                    Console.WriteLine("\n\n0 -> Sair");
                    /*
                     * lemos a uma linha inteira do teclado (Console.ReadLine())
                     * tentamos ler um inteiro nessa linha (TryParse)
                     *  em caso de sucesso o "booleano" success fica com o valor true
                     *  e o valor lido fica guardado na variavel option
                     */
                    success = int.TryParse(Console.ReadLine(), out option);
                } while (!success);

                switch (option)
                {
                    case 1:
                        menuNavio.menu();
                        break;
                    case 2:
                        menuContentor.menu();
                        break;
                    //case 3:
                    //    menuFicheiro.menu();
                        //break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Opção Inválida!");
                        break;
                }
            }
        }













    }
}
