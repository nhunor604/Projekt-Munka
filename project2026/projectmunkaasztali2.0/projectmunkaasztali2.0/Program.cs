namespace projectmunkaasztali2._0
{
        internal class Program
        {
            static void Main(string[] args)
            {
                List<string> nevek = new List<string>();
                List<int> evek = new List<int>();
                List<string> ertekelesek = new List<string>();
                List<string> platformok = new List<string>();
                StreamReader beolvas = new StreamReader("adatok.txt");

                while (!beolvas.EndOfStream)
                {
                    string sor = beolvas.ReadLine();

                    string[] adatok = sor.Split(';');

                    nevek.Add(adatok[0]);
                    evek.Add(Convert.ToInt32(adatok[1]));
                    ertekelesek.Add(adatok[3]);
                    platformok.Add(adatok[4]);
                }

                beolvas.Close();

                Console.WriteLine("összes jatek a txtben");
                foreach (string nev in nevek)
                {
                    Console.WriteLine(nev);
                }

                int osszeg = 0;

                foreach (int ev in evek)
                {
                    osszeg = osszeg + ev;
                }

                double atlag = (double)osszeg / evek.Count;

                Console.WriteLine("A megjelenési évek átlaga: " + atlag);
                Console.WriteLine("Positive értékelésű játékok:");

                for (int i = 0; i < nevek.Count; i++)
                {
                    if (ertekelesek[i] == "Positive")
                    {
                        Console.WriteLine(nevek[i] + "" + ertekelesek[i]);
                    }
                }
                Console.WriteLine("macOSen futatthato jatekok");

                for (int i = 0; i < nevek.Count; i++)
                {
                    if (platformok[i] == "macOS")
                    {
                        Console.WriteLine(nevek[i]);
                    }
                }
                Console.ReadKey();
            }
        }
    }
