using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasics
{
  class Variables
    {
        static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal");
            }
            else
            {
                Console.WriteLine("The samples are not equal");
            }
            int heartRate = 85;
            if(heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart Rate is normal");
            }
            else
            {
                Console.WriteLine("Hear Rate is not normal");
            }
            double deposits = 135002796;
            Console.WriteLine(deposits);
            if( deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor");
            }
            const float acceleration = (float) 9.800;
            float mass =(float) 14.6;
            float force = mass * acceleration;
            Console.WriteLine("force = {0}",force);
            double distance = 129.763001;
            Console.WriteLine("{0} is the distance",distance);
            bool lost = true;
            bool expensive = true;
            if(lost == true && expensive == true)
            {
                Console.WriteLine("I am really sorry I will get the manager");
            }
            else if(lost == true && expensive != true)
            {
                Console.WriteLine("Here is a coupon for 10% off");
            }
            int choice = 2;
            switch(choice)
            {
                case 1:
                    Console.WriteLine("You chose 1");
                    break;
                case 2:
                    Console.WriteLine("You chose 2");
                    break;
                case 3:
                    Console.WriteLine("You chose 3");
                    break;
                default:
                    Console.WriteLine("You made an unknown choice");
                    break;
            }
            int i;
            for(i=5;i<11;i++)
            {
                Console.WriteLine("i = {0}",i);
            }
            char []intergal = {'\u222B'};
            const string greeting = "Hello";
            string name = "Karen";
            Console.WriteLine("{0} is a string",intergal);
            int age = 0;
            while(age < 6)
            {
                Console.WriteLine("age= {0}",age);
                age++;
            }
            Console.WriteLine("{0} {1}",greeting,name);
            Console.ReadKey();
        }
    }
}
