using System.Security.Cryptography.X509Certificates;

namespace filemethod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * programm küsib kasutajalt reahaaval luuletuse ridu, küsitakse 4 korda ja kontrollitakse kas kasutaja on sisestanud
             * keelatud sõnu, keelatud sõnad ise asuvad loenid, kui kasutaja on sisestanud keelatud sõna, küsitakse kogu rida
             * kasutajalt uuesti.
             * kuiküsimine on lõppenud, küsitakse kasutajalt failinime, ja luuletus salvestamiseks faili
             * pärast salvestust kuvatakse failisisu kasutajale tagasi
             * */

            Console.WriteLine("sisesta oma luuletus, salvesta see fail, ja vaata oma luuletus hiljem üle");
            int riduolemas = 0;
            string olemasolevsisu = "";
            while(riduolemas < 4)
            {
                Console.WriteLine("luuletuse järgmise rea sisestuseks kirjuta midagi.");
                List<string> keelatudsõna = new List<string>() { "fuck", "shit","alkohoolik" };

                string hetkesisestus = readanswer();
                while (hetkesisestus == "")
                {
                    foreach (var ks in keelatudsõna)
                    {
                        if (hetkesisestus.Contains(ks)) 
                        {
                            hetkesisestus = "";
                            Console.WriteLine("on leitud keelatud sõna, sisestus on tühistatud.");
                        }
                    }

                }
                olemasolevsisu += hetkesisestus;
                riduolemas++;
            }
            Console.WriteLine("sisesta failinimi, kuhu soovid oma luuletuse salvestada");
            string failinimi = readanswer();
            string filepath = "C:\\Users\\opilane\\source\\repos\\harjutused\\filemethod1\\" + failinimi + "txt";
            File.WriteAllText(filepath, olemasolevsisu);
            displayluuletus(filepath);
        }
                public static string readanswer()
        { 
            
            string vastus = "";
            while (vastus == "")
            {
                Console.WriteLine("tee bastav sisestus:");
                vastus = Console.ReadLine();
            }
            return vastus;
        }
        public static void displayluuletus(string location)
        {
            using (StreamReader readluuletus = new StreamReader(location))
            {
                while (readluuletus.EndOfStream == false)
                {
                }
                    readluuletus.Close();
            }
        }
    }
}
