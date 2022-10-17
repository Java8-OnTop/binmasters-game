using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;

/*
MADE BY: Bin Studios
http://binmasters.tk/

Copyright 2022 Bin Studios
Support@binmasters.tk
*/
public static class binmasters {
    public static T RandomElement<T>(this IEnumerable<T> coll) {
        var rnd = new Random();
        return coll.ElementAt(rnd.Next(coll.Count()));
    }

    //custom threading
    public static int Sleep(int ms) {
        Thread.Sleep(ms);
        return 1;
    }

    //main method
    public static void Main() {

        //start messages
        Console.WriteLine("-------------");
        Console.WriteLine("");
        Console.WriteLine("Started game.");
        Console.WriteLine("");
        Console.WriteLine("-------------");
        Console.WriteLine("");
        Console.WriteLine("-----HOW-TO-----");
        Console.WriteLine("");
        Console.WriteLine("Every 100 bins you get +1 Bins Per Second (BPS). The best tip is just to wait");
        Console.WriteLine("");
        Console.WriteLine("-------------");
        Console.WriteLine("");

        //end of start messages
        Sleep(2850);
        Console.Clear();
        
        // profile creation
        Console.WriteLine("What is your name?: ");
        string name = Console.ReadLine();
        Sleep(750);
        Console.Clear();

        //lists
        int[] price_per_bins = new[] { 200, 275, 822, 921, 112, 223, 375, 456, 765, 491, 379 };

        //variables
        int price = price_per_bins.RandomElement();
        int money = 0;
        int bins_per_second = 1;
        int bins = 0;
        int x = 1;


        
        //maingame
        Main:
            // main gui
            Console.WriteLine("Bins per second: " + bins_per_second);
            Console.WriteLine("Bins: " + bins);
            Console.WriteLine("Money: $" + money);
            Console.WriteLine("1 Bin = $" + price);
            Console.WriteLine("Binmasters Profile: " + name);

            //bin updating / main loop
            while(x <= 4) {
                
                Sleep(775);

                //declare bin additions
                int newbins = bins + bins_per_second;
                bins = newbins;
                Console.Clear();

                //declare money additions
                int addedmoney = money + price;
                money = addedmoney;

                // for if your bps is equal to or under 2
                if(bins >= 100) {
                    bins_per_second++;
                    int addbins = bins - 100;
                    bins = addbins;
                    goto Main;
                }
                
                else {
                    goto Main;
                }
            }
    } 
}
