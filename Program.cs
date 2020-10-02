using System;
using System.Diagnostics;
using System.Threading;

namespace Giraffe
{

    class Program
    {
        static void Main(string[] args)
        {



                String Name = "John";
                int year = 1992;
                int yearTwo = 1995;


                year = 1992;
                yearTwo = 1997;
                Name = "Duow Steyn";
                Console.WriteLine(year + " - " + yearTwo + ": ");
                Thread.Sleep(2000);
                Console.WriteLine(Name + ", Establishes the budget insurance company in the UK, laying the first foundations for the group.");
                Thread.Sleep(5000);
                Name = "Peter Winslow";
                Console.WriteLine(Name + " Joins BGL as Chief Exec and the company progresses from underwriter to insurance Distributor");

                Thread.Sleep(7000);
                year = 2001;
                yearTwo = 2004;
                Name = "Duow Steyn";
                Console.WriteLine(year + " - " + yearTwo + ": ");
                Thread.Sleep(2000);
                Console.WriteLine("Continuing its growth journey, the Group acquires Dial Direct, an Insurance intermediary which included the brands Dial and Bennetts.");
                Thread.Sleep(5000);
                Console.WriteLine("Junction was formed which would go on to be the UK’s leading insurance company outsourcing partnerships amounting more than 2.4 million customers.");
                Thread.Sleep(7000);
                Console.WriteLine("And Last but not least – Comparethemarket.com is registered, in just a few years the iconic Meerkats would take the world by storm!");

                year = 2005;
                yearTwo = 2010;
                Name = "Aleksandr Orlov";
                Thread.Sleep(7000);

                Console.WriteLine(year + " - " + yearTwo + ": ");
                Thread.Sleep(2000);
                Console.WriteLine("The Group celebrates reaching 1 million policies and Aleksandr Orlov makes his first TV appearance, with the help of his furry friend he will go on to help comparethemarket.com become one of the most loved brands in the UK.");
                Thread.Sleep(6000);
                Console.WriteLine("BGL also goes international and acquires the French brand Courtanet which will later become LesFutets.com");

                year = 2011;
                yearTwo = 2015;
                Name = "Aleksandr Orlov";
                Thread.Sleep(7000);

                Console.WriteLine(year + " - " + yearTwo + ": ");
                Thread.Sleep(2000);
                Console.WriteLine("A comparethemarket.com loyalty campaign is introduced where Aleksander makes his transition to cuddly toy and customers are offered 2-for-1 cinema tickets, backed by an app serving regular movie content. ");
                Thread.Sleep(5000);
                Console.WriteLine("BeagleStreet.com is also launched with the goal of disrupting the life insurance market.");
                Thread.Sleep(5000);

                year = 2016;
                yearTwo = 2018;
                Thread.Sleep(7000);

                Console.WriteLine(year + " - " + yearTwo + ": ");
                Thread.Sleep(2000);
                Console.WriteLine("The meerkats are at it again with their movie app downloads reaching 2 million, and the year ending with the biggest campaign yet - partnership with Disney’s Frozen.");
                Thread.Sleep(5000);
                Console.WriteLine("More success as BeagleStreet.com introduces its new direct response advertising campaign and BGL adding SunLife to its portfolio of brands. ");
                Thread.Sleep(5000);
                Console.WriteLine("A hugely successful BGL celebrates 25 years of trading and enters the open banking market.");

                year = 2018;
                yearTwo = 2020;
                Thread.Sleep(7000);

                Console.WriteLine(year + " - " + yearTwo + ": ");
                Thread.Sleep(2000);

                Console.WriteLine("Debbie Hewitt is appointed Independent Non-Executive Chairman, taking over from Peter Winslow.");
                Console.WriteLine("BGL group celebrates smashing three out of four strategic goals a year ahead of schedule – positively impacting 281,000 lives smashing it’s 250k target.");
                Thread.Sleep(5000);
                Console.WriteLine("Over 10 million customers and firmly in the top FinTec companies for colleages engagement.");
                Thread.Sleep(5000);
                Console.WriteLine("The meerkats celebrate their 10-year anniversary.");
                Thread.Sleep(5000);
                Console.WriteLine("The Group is leading digital distributer of household financial services to 11 million customers.");
                Thread.Sleep(5000);
                Console.WriteLine("BGL group enhances it’s CSR program by launching a 1.5m campaign to support community causes impacted by coronavirus. ");
                Thread.Sleep(5000);
                Console.WriteLine("BGL was awarded a bronze accreditation from Peterborough Environmental City Trust.");
                Thread.Sleep(5000);

                Console.WriteLine("Here's to the next 28 years!");

                Console.Write("Be...");
                string[] words = { "BGL", "United", "Creative", "Ambitious", "Authentic", };
                int toGoBack = 0;
                foreach (var i in words)
                {
                    // Go to last occurence of '.' and add i to it
                    Console.SetCursorPosition(Console.CursorLeft - toGoBack, Console.CursorTop);
                    toGoBack = i.Length;
                    Console.Write(i);
                    Thread.Sleep(2000);


                }
        }
    }
}

