using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public enum category
        {
            A = 100,
            B = 80,
            C = 60,
            D = 40,
            E = 20,
            None = 0
        }

        public void Start()
        {
            int userInput = 0;
            do
            {
                Display();
                userInput = int.Parse(Console.ReadLine());
                Result(userInput);
            }

            while (userInput != -1);

        }
        public void Display()
        {
            int[] values = (int[])Enum.GetValues(typeof(category));
            string[] names = Enum.GetNames(typeof(category));

            int low = 0;
            int high;

            for (int i = 1; i < values.Length; i++)
            {
                high = values[i];

                Console.WriteLine($"Category {names[i]} is in range {low} - {high}");

                low = high + 1;
            }
        }

        public category Result(int value)
        {


            int[] values = (int[])Enum.GetValues(typeof(category));
            int low = 0;
            int high;

            for (int i = 1; i < values.Length; i++)
            {

                high = values[i];

                if (value >= low && value <= high)
                {
                    Console.WriteLine("Category: {0} has range of {1} - {2}", (category)values[i], low, high);
                }


                low = high + 1;
            }

            return category.None;
        }
    }
}
