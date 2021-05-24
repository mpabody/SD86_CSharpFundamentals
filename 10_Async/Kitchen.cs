using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Async
{
    public class Kitchen
    {
        public async Task<Fries> FryPotatoesAsync(Potato potato)
        {
            if (potato.IsPeeled)
            {
                PrettyPrint("Dropping in the fries", 14);
                // await, move on bro, but it's local to the method
                await Task.Delay(5000);
                PrettyPrint("Fries are frying", 14);
                await Task.Delay(5000);
                PrettyPrint("DING! Fries are done!",14);
                return new Fries(potato);
            }
            else
            {
                Console.WriteLine("This potato isn't peeled");
                return null;
            }
        }

        public Hamburger AssembleBurger()
        {
            var time = 2000;
            PrettyPrint("Assembling the burger", 13);
            PrettyPrint("Setting the bun down", 4);
            Task.Delay(time).Wait();
            PrettyPrint("Set the patty down gently", 12);
            Task.Delay(time).Wait();
            PrettyPrint("Placing down some cheese", 6);
            Task.Delay(time).Wait();
            PrettyPrint("Lettuce, it's there now", 10);
            Task.Delay(time).Wait();
            PrettyPrint("Remember the pickles", 2);
            Task.Delay(time).Wait();
            PrettyPrint("Adding the sauce", 12);
            Task.Delay(time).Wait();
            PrettyPrint("Slap the top bun on there", 4);
            PrettyPrint("Burger assembled!!", 13);
            return new Hamburger();
        }

        public bool ServeMeal(Fries fries, Hamburger hamburger)
        {
            if(fries == null)
            {
                Console.WriteLine("The fries aren't ready");
                return false;
            }
            else
            {
                Console.WriteLine("You combine the burger and fries, and serve the meal");
                return true;
            }
        }

        public void PrettyPrint(string step, int color)
        {
            //Black       0
            //DarkBlue    1
            //DarkGreen   2
            //DarkCyan    3
            //DarkRed     4
            //DarkMagenta 5
            //DarkYellow  6
            //Gray        7
            //DarkGray    8
            //Blue    9
            //Green   10
            //Cyan    11
            //Red     12
            //Magenta 13
            //Yellow  14
            //White   15
            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(step);
            Console.ResetColor();
        }

    }
}
