using System;
using System.Collections.Generic;

namespace V1inlämningsUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Inlämningsuppgift:Spotify - Mohammad Sheikha";

            List<IInformation> informations = new List<IInformation>();
            bool runing = false;
            string tempArtistNamn, tempAlbumNamn;           

            while (!runing)
            {
                ConsoleColor originalColor = Console.ForegroundColor;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nHuvud Meny");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[1] Lägg till artist");
                Console.WriteLine("[2] Ändra artist");
                Console.WriteLine("[3] Ta bort artist");
                Console.WriteLine("[4] Lägg till Album");
                Console.WriteLine("[5] Ändra Album");
                Console.WriteLine("[6] Ta bort Album");
                Console.WriteLine("[7] Visa artister och album");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[8] Avsluta programet");
                Console.ForegroundColor = originalColor;

                int val;
                while(!int.TryParse(Console.ReadLine(), out val) || val < 1 || val > 8)
                {
                    Console.WriteLine("Fel, välj ett nummer mellan 1 - 8");
                }

                switch (val)
                {
                    case 1:
                        Console.Clear();
                        Artist artist = new Artist();
                        Console.WriteLine("Artistens namn");
                        artist.Name = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Ange artistens genre");
                        artist.Genre = Console.ReadLine();
                        Console.Clear();
                        informations.Add(artist);                        
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Sök artist");
                        tempArtistNamn = Console.ReadLine();
                        Artist artistUpdt = (Artist)informations.Find(x => x.Name.Equals(tempArtistNamn));
                        Console.Clear();
                        Console.WriteLine("Ange Nytt Namn:");
                        artistUpdt.Name = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Ny Genre");
                        artistUpdt.Genre = Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("Vilken artist vill du ta bort?");
                        tempArtistNamn = Console.ReadLine();
                        Console.Clear();
                        artist = (Artist)informations.Find(x => x.Name.Equals(tempArtistNamn));
                        informations.Remove(artist);
                        break;
                    case 4:
                        Console.Clear();
                        Album album = new Album();
                        Console.WriteLine("Ange albumets namn");
                        album.Name = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Ange året albumet släpptes");
                        album.Year = int.Parse(Console.ReadLine());
                        Console.Clear();
                        informations.Add(album);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Sök album");
                        tempAlbumNamn = Console.ReadLine();
                        Album albumUpdt = (Album)informations.Find(x => x.Name.Equals(tempAlbumNamn));                        
                        Console.Clear();
                        Console.WriteLine("Ange nytt album namn");
                        albumUpdt.Name = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Nytt album år");
                        albumUpdt.Year = int.Parse(Console.ReadLine());
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Vilken album vill du ta bort?");
                        tempAlbumNamn = Console.ReadLine();
                        Console.Clear();
                        album = (Album)informations.Find(x => x.Name.Equals(tempAlbumNamn));
                        informations.Remove(album);
                        break;
                    case 7:
                        Console.WriteLine("Innehåll");
                        foreach (IInformation i in informations)
                        {
                            Console.WriteLine(i.GetInformation());
                        }
                        break;

                    case 8:
                        runing = true;
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
