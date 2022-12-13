using System;
using ToDoList.Models;
using System.Collections.Generic;

// namespace ToDoList.List
// {
//     public class List
//     {
//         static void Main()
//         {
//             Console.WriteLine("Welcome to your To Do List");
//             Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
//             string response = Console.ReadLine().ToUpper().Trim();

//             if (response == "ADD")
//             {
//                 AddItem();
//             }
//             else if (response == "VIEW")
//             {
//                 ViewItem();
//             }
//             else
//             {
//                 Console.WriteLine("Please enter 'Add' / 'View', or press enter to exit app");
//             }
//         }
//         public static void AddItem()
//         {
//             Console.WriteLine("Please enter the description for the new item.");
//             string addResponse = Console.ReadLine();
//             Item addDescription = new Item(addResponse);

//             Console.WriteLine($"'{addDescription.Description}' has been added to your list. Would you like to add an item to your list or view your list? (Add/View)");

//             string newResponse = Console.ReadLine().ToUpper().Trim();
//             if (newResponse == "ADD")
//             {
//                 AddItem();
//             }
//             else if (newResponse == "VIEW")
//             {
//                 ViewItem();
//             }
//             else
//             {
//                 Console.WriteLine("Please enter 'Add' / 'View', or press enter to exit app");
//             }
//         }

//         public static void ViewItem()
//         {
//             List<Item> newList = Item.GetAll();
//             foreach (Item li in newList)
//             {
//                 Console.WriteLine(li.Description + "\n ---------------");
//             }

//             Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View)");
//             string newResponse = Console.ReadLine().ToUpper().Trim();
//             if (newResponse == "ADD")
//             {
//                 AddItem();
//             }
//             else if (newResponse == "VIEW")
//             {
//                 ViewItem();
//             }
//             else
//             {
//                 Console.WriteLine("Please enter 'Add' / 'View', or press enter to exit app");
//             }
//         }
//     }
// }
