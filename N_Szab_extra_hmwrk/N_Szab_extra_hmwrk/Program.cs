﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Szab_extra_hmwrk
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = "hellooo aaaaaaaaaaaasddldd ";

            Process(input);

            Console.WriteLine($"\n-------\nEz a szöveg egy tömörített STRING , az eredeti szöveg : \n \"{input}\"\nA következőkben megadthat ön egy szöveg állományt amit le szeretne tömöríteni. \n-------");

            input = Console.ReadLine();

            Console.WriteLine("-------");

            Process(input);

            Console.ReadKey(true);
        }

        public static void Process (String input)
        {
            String[] output = new string[50];
            int tmp = 0, outpi = 0;


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (i == input.Length - 1)
                    {
                        tmp++;

                        output[outpi] = tmp.ToString();
                        outpi++;
                        output[outpi] = input[i].ToString();
                        outpi++;
                        tmp = 0;
                    }
                    else
                    {

                        tmp++;

                        if (input[i] != input[i + 1])
                        {
                            output[outpi] = tmp.ToString();
                            outpi++;
                            output[outpi] = input[i].ToString();
                            outpi++;
                            tmp = 0;
                        }
                    }

                }
                else
                {
                    output[outpi] = " ";
                    outpi++;
                }
            }

            for (int i = 0; i < output.Length; i++)
            {
                Console.Write(output[i]);
            }
        }
    }
}
