using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;

public static class app {
    public static T RandomElement<T>(this IEnumerable<T> coll) {
        var rnd = new Random();
        return coll.ElementAt(rnd.Next(coll.Count()));
    }


    
    public static void Main() {
        
        Console.WriteLine("Started game.");
        Console.WriteLine("What is your name?: ");
        string name = Console.ReadLine();
        
        //lists
        int[] price_per_bins = new[] { 200, 275, 822, 921, 112, 223, 375, 456, 765, 491, 379 };

        //variables
        int price = price_per_bins.RandomElement();
        int money = 0;
        int bins_per_second = 1;
        int bins = 0;
        int x = 1;

        Console.WriteLine("Starting Binmasters profile for " + name);
        //maingame
        Main:
            Console.WriteLine("Bins per second: " + bins_per_second);
            Console.WriteLine("Bins: " + bins);
            Console.WriteLine("Money: $" + money);
            while(x <= 4) {
                
                Thread.Sleep(775);
                int newbins = bins + bins_per_second;
                bins = newbins;
                Console.Clear();
                int addedmoney = money + price;
                money = addedmoney;
                if(bins_per_second <= 2){
                    if(bins >= 100) {
                        bins_per_second++;
                        Console.WriteLine("- 100 Bins.");
                        int naenaebins = bins - 100;
                        bins = naenaebins;
                        goto Main;
                    }
                }
                if(bins_per_second >= 3) {
                    if(bins >= 115) {
                        bins_per_second++;
                        Console.WriteLine("-115 Bins.");
                        int manebins = bins - 150;
                        bins = manebins;
                        goto Main;
                    }
                }
                else {
                    goto Main;
                }
            }
    } 
}
