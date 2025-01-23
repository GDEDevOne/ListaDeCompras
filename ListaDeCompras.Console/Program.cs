using System.Text;
using ListaDeCompras.Application.Services;

namespace ListaDeCompras.App;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        
        ShoppingListService service = new();

        while (true)
        {
            // Console.Clear();

            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar item");
            Console.WriteLine("2 - Remover item");
            Console.WriteLine("3 - Marcar item como comprado");
            Console.WriteLine("4 - Listar os itens");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("\n");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Nome do item: ");
                    var addItem = Console.ReadLine();

                    bool add = service.AddItem(addItem);
                    if (add)
                        Console.WriteLine("Item cadastrado com sucesso!");
                    else
                        Console.WriteLine("Item cadastrado anteriormente.");
                        
                    break;

                case "2":
                    Console.Write("Nome do item a remover: ");
                    var removeItem = Console.ReadLine();

                    bool remove = service.RemoveItem(removeItem);
                    if (remove)
                        Console.WriteLine("Item removido com sucesso!");
                    else
                        Console.WriteLine("Item não encontrado.");

                    break;

                case "3":
                    Console.Write("Nome do item a marcar como comprado: ");
                    var markItem = Console.ReadLine();
                    service.MarkAsPurchased(markItem);
                    break;

                case "4":
                    Console.Write("Lista de Compras:\n");
                    var items = service.GetItems();
                    foreach (var item in items)
                        Console.Write($"{item.Name} - {(item.IsPurchased ? "Comprado" : "Pendente")}\n");

                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}