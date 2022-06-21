using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviosEContentores
{
    class MenuContentores
    {
        private List<Container> Containers;
        private List<Ship> ships;

        private void CriarContentores()
        {
            Console.WriteLine("--INSERIR CONTENTORES--\n");
            //declarar as variáveis a introduzir para os contentores
            int opcao;
            bool success;
            int Number;
            string Destination;
            float Weight;
            string Description;
            string IsRefrigerated;
            string Type;
            string IsPlasticExplosive;

            //menu - pergunta ao utilizador que contentor quer adicionar
            Console.WriteLine("Que tipo de contentor quer adicionar? ");
            Console.WriteLine("1 -> Regular");
            Console.WriteLine("2 -> Explosivo");
            Console.WriteLine("3 -> Quimico");
            Console.WriteLine("0 -> Sair");
            do
            {//ler a opção escolhida pelo utilizador e enquanto não introduzir o pretendido, volta a pedir para introduzir
                success = int.TryParse(Console.ReadLine(), out opcao);
                if (success && (opcao < 0 || opcao > 3))
                {
                    success = false;
                    Console.WriteLine("Opção Inválida");
                    Console.WriteLine("\n-------------------------");
                }
            } while (!success);


            switch (opcao)
            {
                case 0://opção para sair do menu
                    return;

                case 1:
                    Console.WriteLine("--Inserir Contentores Regulares--\n");
                    do
                    {//pergunta ao utilizador o numero do contentor                                    
                        Console.WriteLine("Introduza o numero do contentor: ");
                        success = int.TryParse(Console.ReadLine(), out Number);
                    } while (!success);
                    do
                    {//pergunta ao utilizador o destino do contentor
                        Console.WriteLine("Introduza o destino: ");
                        Destination = Console.ReadLine();
                    } while (!success);
                    do
                    {//pergunta ao utilizador o peso do contentor
                        Console.WriteLine("Introduza o peso do contentor: ");
                        success = float.TryParse(Console.ReadLine(), out Weight);
                    } while (!success);
                    do
                    {//pergunta ao utilizador a descrição do contentor
                        Console.WriteLine("Introduza a descrição do contentor: ");
                        Description = Console.ReadLine();
                    } while (!success);
                    do
                    {//pergunta ao utilizador o contentor é refrigerado
                        Console.WriteLine("O contentor é refrigerado: ");
                        IsRefrigerated = Console.ReadLine();
                    } while (!success);
                    //adiciona os dados que são inseridos pelo utilizador na lista de contentores
                    Regular c = new Regular(Number, Destination, Weight, Description, IsRefrigerated);
                    Containers.Add(c);
                    Console.WriteLine("\nContentor adicionado com sucesso! ");
                    break;

                case 2:
                    Console.WriteLine("--Inserir Contentores Explosivos--\n");
                    do
                    {//pergunta ao utilizador o numero do contentor
                        Console.WriteLine("Introduza o numero do contentor: ");
                        success = int.TryParse(Console.ReadLine(), out Number);
                    } while (!success);
                    do
                    {//pergunta ao utilizador o destino do contentor
                        Console.WriteLine("Introduza o destino: ");
                        Destination = Console.ReadLine();
                    } while (!success);
                    do
                    {//pergunta ao utilizador o peso do contentor
                        Console.WriteLine("Introduza o peso do contentor: ");
                        success = float.TryParse(Console.ReadLine(), out Weight);
                    } while (!success);
                    do
                    {//pergunta ao utilizador o tipo do contentor
                        Console.WriteLine("Introduza o tipo de contentor: ");
                        Type = Console.ReadLine();
                    } while (!success);
                    do
                    {//pergunta ao utilizador o destino do contentor
                        Console.WriteLine("É explosivo Plástico: ");
                        IsPlasticExplosive = Console.ReadLine();
                    } while (!success);
                    //adiciona os contentores explosivos à lista de contentores
                    Explosive e = new Explosive(Number, Destination, Weight, Type, IsPlasticExplosive);
                    Containers.Add(e);
                    Console.WriteLine("\nContentor adicionado com sucesso! ");
                    break;

                case 3:
                    Console.WriteLine("--Inserir Contentores Quimicos--\n");
                    do
                    {//pergunta ao utilizador o numero do contentor
                        Console.WriteLine("Introduza o numero do contentor: ");
                        success = int.TryParse(Console.ReadLine(), out Number);
                    } while (!success);
                    do
                    {//pergunta ao utilizador o destino do contentor
                        Console.WriteLine("Introduza o destino: ");
                        Destination = Console.ReadLine();
                    } while (!success);
                    do
                    {//pergunta ao utilizador o peso do contentor
                        Console.WriteLine("Introduza o peso do contentor: ");
                        success = float.TryParse(Console.ReadLine(), out Weight);
                    } while (!success);
                    do
                    {//pergunta ao utilizador a descrição do contentor
                        Console.WriteLine("Introduza a descrição do contentor: ");
                        Type = Console.ReadLine();
                    } while (!success);
                    //adiciona os contentores quimicos à lista de contentores
                    Chemical q = new Chemical(Number, Destination, Weight, Type);
                    Containers.Add(q);
                    Console.WriteLine("\nContentor adicionado com sucesso! ");
                    break;
            }
        }

        private void EliminarContentor()
        {
            int Number;
            bool success;


            Console.WriteLine("--Remover Contentores--\n");
            //mostra todos os contentores
            Console.WriteLine("--Lista de Contentores--\n");
            foreach (Container e in Containers)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("\n-------------------------");

            do
            {//introduzir o numero do contentor a eliminar
                Console.WriteLine("Introduza o numero do contentor a eliminar: ");
                success = int.TryParse(Console.ReadLine(), out Number);
                Container e = Containers.Find(e => e.GetNumber() == Number);//verifica se o contentor existe na lista
                if (e == null)//se o valor for nulo
                {
                    Console.WriteLine("\nContentor não encontrado!");
                    Console.WriteLine("Quer procurar novamente(s/n): ");
                    string confirmacao = Console.ReadLine();
                    if (confirmacao.Equals("S") || confirmacao == "s")
                    {
                        success = false;
                    }
                    else
                    {
                        success = true;
                    }
                }
                else
                {//confirmação para eliminar o contentor
                    Console.WriteLine(e);
                    Console.WriteLine("Tem a certeza que quer apagar?(s/n) ");
                    string confirmacao = Console.ReadLine();
                    if (confirmacao.Equals("S") || confirmacao == "s")
                    {
                        Containers.Remove(e);
                    }
                    //se for removido com sucesso mostra a mensagem
                    Console.WriteLine("\nContentor removido com sucesso!");
                    success = true;
                }
            } while (!success);
        }

        private void AdicionarContentorNavio()
        {
            bool success;
            int Number;

            Console.WriteLine("--Adicionar Contentores a um Navio--\n");
            //mostra todos os navios da lista
            Console.WriteLine("--Navios--\n");
            foreach (Ship d in ships)
            {
                Console.WriteLine("Navio: " + d.GetName());
                Console.WriteLine("\n-------------------------");
            }
            //pedir para introduzir o nome do navio
            Console.WriteLine("Introduza o nome do navio onde vamos introduzir o contentor");
            string Name = Console.ReadLine();
            success = false;
            foreach (Ship d in ships)
            {
                if (d.GetName().Equals(Name)) // encontramos o navio com o nome introduzido
                {
                    //mostra os contentores na lista de contentores
                    Console.WriteLine("--Contentores--\n");
                    foreach (Container st in Containers)
                    {
                        Console.WriteLine("Contentor Número: " + st.GetNumber());
                        Console.WriteLine("\n-------------------------");
                    }
                    //pedir para introduzir o numero do contentor a introduzir no navio
                    Console.WriteLine("Introduza o numero do contentor a adicionar ao navio: ");
                    success = int.TryParse(Console.ReadLine(), out Number);
                    foreach (Container st in Containers)
                    {
                        if (st.GetNumber().Equals(Number))
                        {
                            try
                            {
                                d.AddContainers(st);//adiciona o contentor ao navio
                                Console.WriteLine("Contentor adicionado com sucesso ao navio!");
                                success = true;
                            }
                            //lança as exceções se atingir o limite máximo de contentores
                            catch (MaxContainersException t)
                            {
                                Console.WriteLine(t.Message);
                                success = false;
                            }
                            catch (MaxExplosiveException t)
                            {
                                Console.WriteLine(t.Message);
                                success = false;
                            }
                            catch (MaxChemicalException t)
                            {
                                Console.WriteLine(t.Message);
                                success = false;
                            }
                            break; // break do foreach dos contentores
                        }
                    }
                    if (!success)
                    {
                        Console.WriteLine("Não foi possivel adicionar o contentor ao navio " + Name);
                        Console.WriteLine("\n-------------------------");
                        break;
                    }
                }
            }
        }

        private void RemoverContentorNavio()
        {
            bool success;

            Console.WriteLine("--Remover Contentores de um Navio--\n");
            //mostra a lista de navios
            Console.WriteLine("--Navios--\n");
            foreach (Ship d in ships)
            {
                Console.WriteLine("Navio: " + d.GetName());
                Console.WriteLine("\n-------------------------");
            }
            //pedir para introduzir o nome do navio
            Console.WriteLine("Introduza o nome do navio onde vamos eliminar o contentor");
            string Name = Console.ReadLine();
            success = false;
            foreach (Ship c in ships)
            {
                if (c.GetName().Equals(Name)) // encontramos o navio com o nome introduzido
                {
                    //mostra os contentores na lista de contentores
                    Console.WriteLine("--Contentores--\n");
                    foreach (var st in Containers)
                    {
                        Console.WriteLine("Contentor Numero: " + st.GetNumber());
                        Console.WriteLine("\n-------------------------");

                    }
                    //pedir para introduzir o numero do contentor a introduzir no navio
                    Console.WriteLine("Introduza o numero do contentor a eliminar do navio: ");
                    success = int.TryParse(Console.ReadLine(), out int Number);
                    foreach (Container st in Containers)
                    {
                        if (st.GetNumber().Equals(Number))//verifica se o numero introduzido está na lista
                        {
                            c.RemoveContainers(st);//elimina o contentor do navio
                            Console.WriteLine("Contentor Removido com Sucesso!");
                            success = true;
                            break; // break do foreach dos contentores
                        }
                    }
                    if (!success)
                    {
                        Console.WriteLine("Não foi possivel eliminar o contentor!");
                        Console.WriteLine("\n-------------------------");
                        break; // break do foreach dos contentores
                    }
                }
            }
            if (!success)
            {
                Console.WriteLine("Não foi possivel encontrar o navio " + Name);
                Console.WriteLine("\n-------------------------");
            }
        }

        private void ContentoresNaoAtribuidos()
        {
            Containers.ForEach(x => Console.WriteLine(x));
        }

        private void ContentoresNavio()
        {
            Console.WriteLine("--Quantidade de Contentores Existente nos Navios--\n");
            Console.WriteLine("--Navios--\n");
            foreach (Ship f in ships)
            {
                Console.WriteLine("Navio: " + f.GetName());
                Console.WriteLine("\n-------------------------");
            }
            //pedir para introduzir o nome do navio
            Console.WriteLine("Introduza o nome do navio que pretende ver: ");
            string Name = Console.ReadLine();
            Ship m = ships.Find(m => m.GetName() == Name);
            if (m == null)//se for nulo
            {
                Console.WriteLine("Esse navio não existe.\n");
            }
            else
            {
                if (m.GetContainersList().Count == 0)//se a contagem dos contentores for igual a 0 não exite contentores
                {
                    Console.WriteLine("O navio " + m.GetName() + " não possui contentores.");
                }
                else if (m.GetContainersList().Count == 1)//Se houver contentores passa  numero de contentores
                {
                    Console.WriteLine("O navio " + m.GetName() + " tem " + m.GetContainersList().Count + " contentor.");
                }
                else
                {
                    Console.WriteLine("O navio " + m.GetName() + " tem " + m.GetContainersList().Count + " contentores.");
                }
            }
        }


        public MenuContentores(List<Container> Containers)
        {
            this.Containers = Containers;
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
                    Console.WriteLine("1 -> Criar Contentores");
                    Console.WriteLine("2 -> Eliminar Contentor");
                    Console.WriteLine("3 -> Adicionar Contentor Navio");
                    Console.WriteLine("4 -> Remover Contentor Navio");
                    Console.WriteLine("5 -> Contentores Não Atribuidos");
                    Console.WriteLine("6 -> Contentores no Navio");
                    Console.WriteLine("\n\n0 -> Voltar atrás");
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
                        CriarContentores();
                        break;
                    case 2:
                        EliminarContentor();
                        break;
                    case 3:
                        AdicionarContentorNavio();
                        break;
                    case 4:
                        RemoverContentorNavio();
                        break;
                    case 5:
                        ContentoresNaoAtribuidos();
                        break;
                    case 6:
                        ContentoresNavio();
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
