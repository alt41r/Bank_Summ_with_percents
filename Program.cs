using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace bank_openedu_test
{
    class Program

    {
        static void Main(string[] args)
        {
            string UserInput = Console.ReadLine();

            Console.WriteLine(Calculate(UserInput));
            Console.ReadLine();
        }
        public static double Calculate(string UserInput)
        {
            var input_split = UserInput.Split(' ');
            double startProc = Convert.ToDouble(input_split[1]);
            double money = Convert.ToDouble(input_split[0]);            
            double proc = Convert.ToDouble(input_split[1]);
            proc = proc / 12;             
            double period = double.Parse(input_split[2]);


            if (period > 0)
            {
                money = money + ((money / 100) * proc);
                period -= 1;
                return Calculate(Convert.ToString(money) + " " + startProc + " " + Convert.ToString((period)));
                

            }
            else  return money; 


        }


    }
}

