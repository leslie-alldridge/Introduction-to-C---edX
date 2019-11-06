using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            string output = "";
            for (x=0; x <8; x++)
            {
                output = "";
                for (y=0; y <8; y++)
                {
                    if (x%2 == 0)
                    {
                        if (y % 2 == 0)
                        {
                            output += "X";
                        }
                        else
                        {
                            output += "O";
                        }
                    }
                    else
                    {
                        if (y % 2 != 0)
                        {
                            output += "X";
                        }
                        else
                        {
                            output += "O";
                        }
                    }
                    
                   
                }
                Console.WriteLine(output);
            }
            
        }
    }
}
