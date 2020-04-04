using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydra
{
    //Written in C#
    //Hydra virus: Cut off one head and three new ones appear
    class Program
    {
        static int count = 1;
        static void Main(string[] args)
        {
            CreateHydra(1); //creating the initial hydra
        }

        //function to create the hydra
        static void CreateHydra(int num)
        {
            //creating as many hydras as the num passed in
            for(int i = 0; i < num; i++)
            {
                
                Console.WriteLine("I am a hydra, cut off one of my heads and three will grow back...");
            }
            if (Console.ReadLine() != null)
            {
                int heads = count * 3;
                count++;
                CreateHydra(heads);
            }

        }
    }
}
