using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviosEContentores
{
    class MenuNavios
    {
        private List<Ship> ships;        

        private void CriarNavios()
        {
            //declarar as variáveis a introduzir pelo utilizador
            int Number;
            int MaxContainers;
            int MaxExplosive;
            int MaxChemical;
            bool success;


            Console.WriteLine("--ADICIONAR NAVIOS--\n");

            Console.WriteLine("Introduza o nome do navio a adicionar: ");            
            string Name = Console.ReadLine();            

            do
            {//pedir para o utilizador introduzir o numero de navio                            
                Console.WriteLine("Introduza o numero do navio: ");
                success = int.TryParse(Console.ReadLine(), out Number);
            } while (!success);
            do
            {//pedir para o utilizador introduzir o numero máximo de contentores que o navio leva
                Console.WriteLine("Introduza o numero maximo de contentores do navio: ");
                success = int.TryParse(Console.ReadLine(), out MaxContainers);
            } while (!success);
            do
            {//pedir para o utilizador introduzir o numero máximo de contentores explosivos que o navio leva
                Console.WriteLine("Introduza o numero maximo de contentores Explosivos do navio: ");
                success = int.TryParse(Console.ReadLine(), out MaxExplosive);
            } while (!success);
            do
            {//pedir para o utilizador introduzir o numero máximo de contentores quimicos que o navio leva
                Console.WriteLine("Introduza o numero maximo de contentores Quimicos do navio: ");
                success = int.TryParse(Console.ReadLine(), out MaxChemical);
            } while (!success);
            //guardar os valores introduzidos na lista de navios
            Ship s = new Ship(Name, Number, MaxContainers, MaxExplosive, MaxChemical);
            ships.Add(s);
            Console.WriteLine("\nNavio adicionado com sucesso!");            
        }

        private void ListarNavios()
        {
            ships.ForEach(x => Console.WriteLine(x));
        }


        private void eliminarNavio()
        {
            // Pedimos o nome do navio a pesquisar
            Console.Write("Introduza o nome do navio a eliminar: ");
            string name = Console.ReadLine();
            // Pesquisámos a lista pelo primeiro navio cujo nome contenha o valor
            // inserido pelo utilizador
            Ship s = ships.Find(s => s.GetName().Contains(name));
            // O resultado do Find é null se não encontrar nada
            if (s == null)
            {
                Console.WriteLine("Navio não encontrado.");
            }
            else
            {
                // Imprimir o navio encontrado
                Console.WriteLine(s);
                Console.Write("Tem a certeza que quer apagar? ");
                string confirmacao = Console.ReadLine();
                if (confirmacao.Equals("S") || confirmacao.Equals("s"))
                {
                    // Remove a primeira ocorrência de s na lista
                    ships.Remove(s);
                }
                else
                {
                    eliminarNavio();
                }
            }
        }


        public MenuNavios(List<Ship> ships)
        {
            this.ships = ships;
        }

        public void menu()
        {
            while (true)
            {
                bool success;
                int option;
                do
                {
                    Console.WriteLine("Introduza a opção desejada:");
                    Console.WriteLine("1 -> Criar Navios");
                    Console.WriteLine("2 -> Listar Navios");                    
                    Console.WriteLine("3 -> Remover Navios");
                    Console.WriteLine("\n0 -> Voltar atrás");
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
                        CriarNavios();
                        break;
                    case 2:
                        ListarNavios();
                        break;                    
                    case 3:
                        eliminarNavio();
                        break;
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
