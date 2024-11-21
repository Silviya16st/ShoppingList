using System.Collections.Generic;
using System.Collections;
namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LinkedList<string> shoppingList = new LinkedList<string>();

            shoppingList.AddFirst("dubai chocolate");
            shoppingList.AddLast("tomatoes");
            shoppingList.AddLast("brawnies");
            shoppingList.AddLast("cheese");
            shoppingList.AddLast("potatoes");
            shoppingList.AddLast("oranges");
            Console.WriteLine(string.Join(" ", shoppingList));

            int choice = 0;


            do
            {
                Console.WriteLine();
                Console.WriteLine("Choices");
                Console.WriteLine("1. Add new product");
                Console.WriteLine("2. Delete purchased product");
                Console.WriteLine("3. Print all products");
                Console.WriteLine("4. Search for specific product");
                Console.WriteLine("5. Replace product");
                Console.WriteLine("6. END");
                Console.WriteLine();
                Console.WriteLine("Your choice");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter product to be added");
                    string product = Console.ReadLine();
                    shoppingList.AddLast(product);
                    Console.WriteLine(string.Join(" ", shoppingList));
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Shopping List before adding new product");
                    Console.WriteLine(string.Join(" ", shoppingList));
                    Console.WriteLine("Choose product from the shopping list to purchase:");
                    string product = Console.ReadLine();
                    shoppingList.Remove(product);
                    Console.WriteLine("Shopping list after purchasing product");

                }
                else if (choice == 3)
                {
                    int index = 1;
                    foreach (var item in shoppingList)
                    {
                        Console.WriteLine($"{index}. {item}");
                        index++;
                    }
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Enter product you are searching for");
                    string product = Console.ReadLine();
                    int index = 1;
                    foreach (var item in shoppingList)
                    {
                        if (item == product)
                        {
                            Console.WriteLine(index);
                        }
                        index++;
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Shopping list before replace");
                    Console.WriteLine(string.Join(" ", shoppingList));

                    Console.WriteLine("Enter product to be replaced");
                    string product = Console.ReadLine() ;
                    Console.WriteLine("Enter product's replacement");
                    string replacedP = Console.ReadLine() ;

                    LinkedListNode<string> node = shoppingList.Find(product);
                    node.Value = replacedP;
                    Console.WriteLine($"Product:{product} is replaced with {replacedP}");

                    Console.WriteLine("Shopping list after replace");
                    Console.WriteLine(string.Join(" ", shoppingList));
                }
            } while (choice != 6);
            

        }

    }
}