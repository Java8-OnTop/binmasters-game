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
public static class app {
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

            //start shop
        
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

                int price10 = price * 10;
                int price50 = price * 50;
                
                if(money == price10 ) {
                    Console.Clear();
                    Console.WriteLine("---SHOP---");
                    Console.WriteLine("1. || Buy more Bins Per Second (BPS)");
                    Console.WriteLine("2. || Trade bins for money");
                    Console.WriteLine("3. || Back");

                    string shopInput = Console.ReadLine();
                    
                    if(shopInput == "1") {
                        int bps_can_buy = money / price / 2;
                        int bps_can_buy_price = bps_can_buy * price;
                        Console.WriteLine(bps_can_buy);
                        Console.WriteLine("Would you like to buy " + bps_can_buy + " Bins per Second at: $" + bps_can_buy_price + " each?: (y/n)");
                        string bps_buy = Console.ReadLine();
                        
                        if(bps_buy == "y") {
                            Console.WriteLine("Bought " + bps_can_buy);
                            int newestbps = bins_per_second + bps_can_buy;
                            bins_per_second = newestbps;
                            int newestmoney = money - bps_can_buy_price;
                            money = newestmoney;
                            Console.Clear();
                            continue;
                        }

                        if(bps_buy == "n") {
                            Console.Clear();
                            continue;
                        }

                        else {
                            Console.WriteLine("Incorrect answer, use (y/n)");
                            Thread.Sleep(570);
                            Console.Clear();
                            continue;
                        }
                    }

                    if(shopInput == "2") {
                        int amount = bins * price;
                        Console.WriteLine("Are you sure you would like to trade your bins? (y/n)");
                        string tradeInput = Console.ReadLine();

                        if(tradeInput == "y") {
                            int addedmoneyv3 = amount + money;
                            money = addedmoneyv3;
                            continue;
                        }

                        if(tradeInput == "n") {
                            continue;
                        }

                        else {
                            continue;
                        }
                    }

                    if(shopInput == "3") {
                        continue;
                    }
                }

                if(money == price50) {
                    Console.Clear();
                    Console.WriteLine("---SHOP---");
                    Console.WriteLine("1. || Buy more Bins Per Second (BPS)");
                    Console.WriteLine("2. || Trade bins for money");
                    Console.WriteLine("3. || Back");

                    string shopInput1 = Console.ReadLine();
                    
                    if(shopInput1 == "1") {
                        int bps_can_buy = money / price / 2;
                        int bps_can_buy_price = bps_can_buy * price;
                        Console.WriteLine(bps_can_buy);
                        Console.WriteLine("Would you like to buy " + bps_can_buy + " Bins per Second at: $" + bps_can_buy_price + " each?: (y/n)");
                        string bps_buy1 = Console.ReadLine();
                        
                        if(bps_buy1 == "y") {
                            Console.WriteLine("Bought " + bps_can_buy);
                            int newestbps = bins_per_second + bps_can_buy;
                            bins_per_second = newestbps;
                            int newestmoney = money - bps_can_buy_price;
                            money = newestmoney;
                            Console.Clear();
                            continue;
                        }

                        if(bps_buy1 == "n") {
                            Console.Clear();
                            continue;
                        }

                        else {
                            Console.WriteLine("Incorrect answer, use (y/n)");
                            Thread.Sleep(570);
                            Console.Clear();
                            continue;
                        }
                    }

                    if(shopInput1 == "2") {
                        int amount = bins * price;
                        Console.WriteLine("Are you sure you would like to trade your bins? (y/n)");
                        string tradeInput1 = Console.ReadLine();

                        if(tradeInput1 == "y") {
                            int addedmoneyv2 = amount + money;
                            money = addedmoneyv2;
                            continue;
                        }

                        if(tradeInput == "n") {
                            continue;
                        }

                        else {
                            Console.WriteLine("Incorrect statement use (y/n)");
                            Thread.Sleep(750);
                            continue;
                        }
                    }

                    if(shopInput1 == "3") {
                        continue;
                    }
                }
                
                else {
                    goto Main;
                }
            }
    } 
}  
