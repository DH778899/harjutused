namespace Meetod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> filmid = GetMovies();
            Console.WriteLine("Milline on sinu lemmikfilm");
            string lemmikFilm = ReadAnswer();
            DoesMovieExist(filmid, lemmikFilm);
            DoYouLikeThisMovie(filmid, "Cars 1");
            List<string> otsitavadfilmid = new List<string> { "terminator", "vanamehe film", "kratt" };
            identifymovies(filmid, otsitavadfilmid); 
            //foreach (string item in filmid)
            //{
            //    Console.WriteLine(item);
            //}
        }

        public static void identifymovies(List<string> collection, List<string> filter)
        {
            string messages = "";
            foreach (var movie in collection)
            {
                int itemnr = 0;
                foreach (var filteritem in filter)
                {
                    if (itemnr == 0)
                    {
                        messages += "il be back.\n";
                    }
                    else if (itemnr == 1)
                    {
                        messages += "sniggers\n";
                    }
                    else if (itemnr == 2)
                    {
                        messages += "vaata et ta sul tehisplära ajama ei hakka\n";
                    }
                    itemnr++;
                }
            }
        }

        public static List<string> DoYouLikeThisMovie(List<string> collection, string movieToAdd)
        {
            if (collection.Contains(movieToAdd) == false)
            {
                Console.WriteLine($"Kas sulle meeldib {movieToAdd}?");
                string vastus = ReadAnswer();
                if (vastus == "jah")
                {
                    collection.Add(movieToAdd);
                    Console.WriteLine("Lisasin filmi sulle");
                }
                else
                {
                    Console.WriteLine("aga miks?see on ju hea film?");
                }
            }
            return collection;

        }



        public static void DoesMovieExist(List<string> collection, string findThis)
        {
            bool itExists = false;
            foreach (var item in collection)
            {
                if (item == findThis)
                {
                    itExists = true;
                }
                if (itExists == true)
                {
                    Console.WriteLine("näe sa mäletad ikka");
                }
                else
                {
                    Console.WriteLine("kus sinu lemmikfilm?");
                }
            }
        }





        public static string ReadAnswer()
        {
            string sisend = "";
            while (sisend == "")
            {
                sisend = Console.ReadLine();
            }
            return sisend;
        }

        public static List<string> GetMovies()
        {
            Console.WriteLine("Mis on su lemmikfilmid sisesta ükshaaval kui sisestada rohkem ei teha\n sisesta \"ei ole\"");
            string sisestus = "";
            List<string> siinOnFilmid = new List<string>();
            while (sisestus != "ei ole")
            {
                Console.WriteLine("järgmine film:");
                sisestus = Console.ReadLine();
                if (sisestus != "ei ole")
                {
                    siinOnFilmid.Add(sisestus);
                }

            }






            return siinOnFilmid;
        }


    }

}

