using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("DIS", "Disney");
            stocks.Add("MAT", "Matel");
            stocks.Add("CAN", "Canon");
            
            //this is a list of value tuples
            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));
            purchases.Add((ticker: "CAT", shares: 40, price: 17.09));
            purchases.Add((ticker: "CAT", shares: 140, price: 14.09));
            purchases.Add((ticker: "DIS", shares: 60, price: 89.09));
            purchases.Add((ticker: "DIS", shares: 120, price: 98.09));
            purchases.Add((ticker: "MAT", shares: 50, price: 9.09));
            purchases.Add((ticker: "MAT", shares: 30, price: 21.09));
            purchases.Add((ticker: "CAN", shares: 900, price: 12.09));

                // dictionaries can only have 2 a key and a value. 
            Dictionary<string, double> totalShares = new Dictionary<string, double>();

            foreach((string ticker,int shares, double price)purchase in purchases){
                if (stocks.ContainsKey(purchase.ticker)){
                    if(totalShares.ContainsKey(purchase.ticker)){
                    totalShares[purchase.ticker]+= purchase.shares * purchase.price;
                    }
                    else
                    {
                        totalShares[stocks[purchase.ticker]] = purchase.shares * purchase.price;
                    }
                }
            }
            foreach(KeyValuePair<string, double>t in totalShares){
                Console.WriteLine($"{t.Key} {t.Value:C}");
            }
        }
    }
}
