using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace oneCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string:");
            string word = Console.ReadLine();


            string path = "C:\\Users\\wajid\\OneDrive\\Desktop\\Semester-2\\OOPS\\Week-1\\OneChar.txt";
            StreamWriter fileVariable = new StreamWriter(path);


            for (int i=0; i<word.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < word.Length; j++)
                {
                    if (word[i] == word[j])
                    {
                        count++;
                    }
                }

                if(count == 1) {
                    fileVariable.Write(word[i] + " ");
                }
            }

                fileVariable.Flush();
                fileVariable.Close();
            }
        }
    }
