using System;
using System.Reflection.Metadata;

namespace Collections
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Airport Queue
            Console.WriteLine("----------Queue Collection----------");

            //Adding a Queue and adding items to the queue
            Queue<string> airportQueue = new Queue<string>();
            string airportPeek;
            airportQueue.Enqueue("Hannah Montana");
            airportQueue.Enqueue("Travis Tritt");
            airportQueue.Enqueue("Braid Paisley");
            airportQueue.Enqueue("Rodney Carrington");
            airportQueue.Enqueue("Taylor Swift");

            //Checking to see if the queue contains something and displaying it
            if (airportQueue.Contains("Rodney Carrington"))
            {
                Console.WriteLine($"Rodney Carrington is in your queue!");
            }

            //Removing someone from the queue
            airportQueue.Dequeue();
            //Displaying the count of the queue and the number of people in the queue.
            Console.WriteLine($"The airport queue contains {airportQueue.Count()} people.");
            Console.WriteLine("Here is a list of all of the people in the airport queue:");

            foreach (var people in airportQueue)
            {
                Console.WriteLine(people);
            }
            Console.WriteLine();

            //Priority Queue
            Console.WriteLine("----------Priority Queue Collection----------");

            //Creating the priority queue and adding bills to the queue
            PriorityQueue<string, int> bills = new PriorityQueue<string, int>();
            bills.Enqueue("Roof Repair", 1);
            bills.Enqueue("Phone Bill", 4);
            bills.Enqueue("Music Concert", 5);
            bills.Enqueue("Furnace Repair", 2);
            bills.Enqueue("Steam Library", 3);

            //Removing everything from the queue
            while (bills.TryDequeue(out string bill, out int priority))
                Console.WriteLine($"The highest priority bill: {bill} has been removed with a priority level of: {priority}.");
            Console.WriteLine();

            //Stack collection
            Console.WriteLine("----------Stack Collection----------");

            //Creating the stack and adding cookies to it
            Stack<string> cookies = new Stack<string>();
            cookies.Push("Chocolate Chip");
            cookies.Push("Sugar Cookie");
            cookies.Push("Molasses");
            cookies.Push("Peanut Butter");
            cookies.Push("Chocolate");

            if (cookies.Contains("Peanut Butter"))
                Console.WriteLine("There are peanut butter cookies available!");

            cookies.Pop();
            cookies.Pop();

            Console.WriteLine($"There are {cookies.Count()} types of cookies available.");
            Console.WriteLine("Here are the types of cookies available: ");

            foreach (var cookie in cookies)
            {
                Console.WriteLine(cookie);
            }
            Console.WriteLine();


            //Linked List and Linked NodeList collections
            Console.WriteLine("----------Linked List and Linked NodeList Collections----------");
            string[] consoles = { "Xbox 360", "Xbox One", "Xbox Series X", "Xbox Series S", "Playstation 5" };
            LinkedList<string> consoleList = new LinkedList<string>(consoles);

            //Finding and displaying the first node
            Console.WriteLine($"The first node in the list is: {consoleList.First()}");

            //Finding and displaying the last node
            Console.WriteLine($"The last node in the list is: {consoleList.Last()}");

            //Adding a 6th item to the middle of the list
            LinkedListNode<string> target = consoleList.Find("Xbox Series X");
            consoleList.AddAfter(target, "Playstation 4");

            //Removing a node from the list
            consoleList.Remove("Xbox 360");

            //Counting the items in the list and displaying the count
            Console.WriteLine($"The nodelist contains {consoleList.Count()} nodes.");

            //Displaying all items in the linked list
            Console.WriteLine("Here are the list of consoles currently in the list:");
            foreach(var console in consoleList)
            {
                Console.WriteLine(console);
            }
            Console.WriteLine();

            //Dictionary Collection
            Console.WriteLine("----------Dictionary Collection----------");

            //Creating a dictionary and adding values
            Dictionary <int, string> GameTitles = new Dictionary<int, string>();
            GameTitles.Add(1, "Call of Duty Modern Warfare 2");
            GameTitles.Add(2, "Call of the Mountain");
            GameTitles.Add(3, "Horizon Zero Dawn");
            GameTitles.Add(4, "Perfect Dark");
            GameTitles.Add(5, "Super Mario 64");

            //Retrieving and displaying all keys
            Console.WriteLine("Game Title Keys: ");
            Dictionary<int, string>.KeyCollection keys = GameTitles.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine($"Key: {key}");
            }

            //Retrieving and displaying all values
            Console.WriteLine("Game Title Values: ");
            Dictionary<int, string>.ValueCollection values = GameTitles.Values;
            foreach (var value in values)
            {
                Console.WriteLine($"Value: {value}"); 
            }

            //Retrieving and displaying both the keys and the values
            Console.WriteLine("Game Title and Key Pairs: ");
            foreach(KeyValuePair <int, string> kvp in GameTitles)
            {
                Console.WriteLine($"Game ID: {kvp.Key}     Game Title: {kvp.Value}");
            }

            //Removing an item from the dictionary
            Console.WriteLine("Removing one item from the dictionary....");
            GameTitles.Remove(1);

            //Displaying a count of the dictionary items
            Console.WriteLine($"There are a total of {GameTitles.Count()} items in the dictionary.");
            Console.WriteLine();

            //Sorted List Collection
            Console.WriteLine("----------Sorted List Collection----------");

            //Creating the sorted list and adding items to it
            string christmasItem = string.Empty;
            string numstring = string.Empty;
            string toRemove = string.Empty;
            double christmasPrice = 0;
            bool canConvert = false;

            SortedList <string, double> christmasList = new SortedList <string, double>();
            christmasList.Add("Robot Vacuum", 329.99);
            christmasList.Add("Gaming Desktop", 1229.99);
            christmasList.Add("Ninja Blender", 119.99);
            christmasList.Add("Ice Maker", 98.86);
            christmasList.Add("Treadmill", 359.97);

            //Allowing the user to enter a key and value with error handing
            Console.WriteLine("Please enter an item to go into the Christmas list.");
            christmasItem = Console.ReadLine();
            Console.WriteLine("Please enter the price of the item.");
            while (canConvert == false)
            {
                numstring = Console.ReadLine();
                canConvert = double.TryParse(numstring, out christmasPrice);

                if (canConvert == false)
                    Console.WriteLine("You need to supply a valid number. Please try again.");
            }

            if(christmasList.ContainsKey(christmasItem))
            {
                Console.WriteLine("The Christmas list already contains that item.");
            }
            else
            {
                christmasList.Add(christmasItem, christmasPrice);
            }

            //Allowing the user to remove an item from the list
            Console.WriteLine("The items in my sorted Christmas list are:");
            foreach(KeyValuePair <string, double> cl in christmasList)
            {
                Console.WriteLine($"Price = {cl.Value} Item = {cl.Key}");
            }
            while (christmasList.ContainsKey(toRemove) == false)
            {
                Console.WriteLine("Please choose an item to remove");
                toRemove = Console.ReadLine();
            }
            Console.WriteLine($"{toRemove} was removed from the list.");

            //Printing the key and value for the sorted list
            Console.WriteLine("Here is the updated christmas list:");
            foreach (KeyValuePair<string, double> cl in christmasList)
            {
                Console.WriteLine($"Price = {cl.Value} Item = {cl.Key}");
            }
            Console.WriteLine();

            //HashSet Collection
            Console.WriteLine("----------HashSet Collection----------");

            //Creating 3 similar HashSet collections
            HashSet<string> myFavoriteArtists = new HashSet<string>();
            myFavoriteArtists.Add("Disturbed");
            myFavoriteArtists.Add("Linkin Park");
            myFavoriteArtists.Add("Eminem");
            myFavoriteArtists.Add("Three Days Grace");
            myFavoriteArtists.Add("Breaking Benjamin");

            HashSet<string> top2021Artists = new HashSet<string>();
            top2021Artists.Add("Taylor Swift");
            top2021Artists.Add("Ed Sheeran");
            top2021Artists.Add("Kanye West");
            top2021Artists.Add("BTS");
            top2021Artists.Add("Drake");

            HashSet<string> top2022Artists = new HashSet<string>();
            top2022Artists.Add("Ed Sheeran");
            top2022Artists.Add("Eminem");
            top2022Artists.Add("Taylor Swift");
            top2022Artists.Add("Imagine Dragons");
            top2022Artists.Add("Coldplay");

            //Combining the first two collections and displaying them
            myFavoriteArtists.UnionWith(top2021Artists);
            Console.WriteLine("Here is the combined list of my favorite artists and top 2021 artists according to Spotify:");
            foreach(var artist in  myFavoriteArtists)
            {
                Console.WriteLine(artist);
            }
            Console.WriteLine();
            Console.WriteLine("Artists that are in my combined collection and in the top 2022 position according to Spotify:");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = myFavoriteArtists;
            bothLists.IntersectWith(top2022Artists);
            foreach(var artist in bothLists)
            {
                Console.WriteLine(artist);
            }

            //List Collection
            Console.WriteLine("----------List Collection----------");

            //Adding 5 items to the list
            List<string> movieCollection = new List<string>();
            movieCollection.Add("No Time to Die");
            movieCollection.Add("Spectre");
            movieCollection.Add("Skyfall");
            movieCollection.Add("Quantum of Solace");
            movieCollection.Add("The World Is Not Enough");

            //Using AddRange to add 3 more items to the list
            string[] movieArray = new string[] { "Die Another Day", "Tomorrow Never Dies", "GoldenEye" };
            movieCollection.AddRange(movieArray);

            //Sorting the list and printing the items
            movieCollection.Sort();
            Console.WriteLine("----------Sorted List----------");
            foreach(var movie in movieCollection)
            {
                Console.WriteLine(movie);
            }
            //Removing one item from list
            Console.WriteLine("Removing Quantum of Solace");
            movieCollection.Remove("Quantom of Solace");

            //Sorting the list in reverse order and print all items
            Console.WriteLine("---------Reversed List---------");
            movieCollection.Reverse();
            foreach(var movie in movieCollection)
            {
                Console.WriteLine(movie);
            }

        }
    }
}

        