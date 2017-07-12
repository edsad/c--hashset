using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
         // create an empty hashset and add four cars and models to it

          HashSet<string> Showroom = new HashSet<string>();

          Showroom.Add("G35 Infiniti");
          Showroom.Add("F-150 Ford");
          Showroom.Add("GranTurismo Maserati");
          Showroom.Add("GTO Pontiac");

        //   pick one of the items and add it to the list again

          Showroom.Add("G35 Infiniti");

        //   create another hashset and add two cars and models to it

          HashSet<string> UsedLot = new HashSet<string>();

          UsedLot.Add("Van Chevy");
          UsedLot.Add("Pacer AMC");

        //   use unionWith() and add the two together

          Showroom.UnionWith(UsedLot);

        //   use remove() to remove one from the list

          Showroom.Remove("F-150 Ford");

        //   create a new hashset named Junkyard and add cars to it, make sure two are the same

          HashSet<string> Junkyard = new HashSet<string>();

          Junkyard.Add("G35 Infiniti");
          Junkyard.Add("Pacer AMC");
          Junkyard.Add("Corvette Stingray GM");
          Junkyard.Add("Legend Acura");
          Junkyard.Add("Charger Dodge");

        //   use IntersectWith() to see which cars are in showroom and junkyard

        //   Showroom.IntersectWith(Junkyard);

        // join showroom to junkyard using unionwith()

          Showroom.UnionWith(Junkyard);

          foreach (string cars in Showroom)  
            Console.WriteLine(cars);
        }
    }
}
