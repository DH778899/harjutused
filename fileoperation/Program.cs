using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace fileoperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("kirjuta siia oma postkasti aadress");

            // string filepath = "C:\\Users\\opilane\\source\\repos\\harjutused\\fileoperation\\postkastiaadress.txt";
            //string aadress = Console.ReadLine();

            // File.WriteAllText(filepath, aadress);

            Console.WriteLine("kõik laulu sõnad");

            DisplayThisFile();
            findword("kill");




        }

        public static void findword(string findthisword)
        {
            using (StreamReader readfile = new StreamReader(
                "C:\\Users\\opilane\\source\\repos\\harjutused\\fileoperation\\postkastiaadress.txt"))
            {
                int lnr = 0;
                while (readfile.EndOfStream == false)
                {
                    string line = readfile.ReadLine();
                    lnr++;

                    if (line.Contains(findthisword) == true)
                    {
                        Console.WriteLine(findthisword + " leiti reast" + lnr);
                    }
                }
                readfile.Close();
            }
        }
        private static void DisplayThisFile()
        {
            string line = "";
            try

                
            {
                using (
                    StreamReader readthisthing = new StreamReader
                    ("C:\\Users\\opilane\\source\\repos\\harjutused\\fileoperation\\postkastiaadress.txt"))
                {
                    int linecount = 0;
                    while (readthisthing.EndOfStream == false) 
                    { 

                        linecount++;
                    line = readthisthing.ReadLine();
                    int pikkus = line.Length;
                    Console.WriteLine(linecount + "" + line + " . reapikkus on" + pikkus);
                    }
                    readthisthing.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ei saa lugeda sest:" + e.Message);
                throw;
            }
            
        }
    }
}



