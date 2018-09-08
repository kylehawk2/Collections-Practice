using System;
using System.Collections.Generic;

namespace Collections_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
        // Create an array to hold integer values 0 to 9
        int[] numarray = {1,2,3,4,5,6,7,8,9};
        // Create an array of the names "Tim" "Martin" "Nikki" and "Sara"
        string[] namearray = {"Tim", "Martin", "Nikki", "Sara"};
        // Create an array of length of 10 that alternates between true and false statements
        Boolean[] boolarray = new Boolean[10];
        boolarray[0] = true;
        for(int i = 1; i < boolarray.Length; i++){
            if(boolarray[i-1] == true){
                boolarray[i] = false;
            }else{
                boolarray[i] = true;
            }
        }
        for(int i = 0; i < boolarray.Length; i++){
            Console.WriteLine(boolarray[i]);
        }
        // Create a list of ice cream flavors that holds at least 5 differnet flavors
        List<string> iceCream = new List<string>();
        iceCream.Add("Vanilla");
        iceCream.Add("Chocolate");
        iceCream.Add("Stawberry");
        iceCream.Add("Rocky Road");
        iceCream.Add("Coffee");
        Console.WriteLine("");
        // Output the length of this list after building it
        Console.WriteLine(iceCream.Count);
        // Output the third flavor in the list, then remove this value
        Console.WriteLine(iceCream[3]);
        // Output the third flavor in the list, then remove this value
        iceCream.RemoveAt(3);
        // Output the new length of the list (It should just be one fewer!)
        Console.WriteLine(iceCream.Count);
        
        // Create a dictionary that will store both string keys as well as string values
        Dictionary<string,string> name = new Dictionary<string,string>();
        Random rand = new Random();
        foreach(string key in namearray){
            name.Add(key, iceCream[rand.Next(0,4)]);
        }
        foreach(KeyValuePair<string,string> key in name){
            Console.WriteLine(key.Key + " " + key.Value);
        }
        }
    }
}
