
using BPlatvanyossagok.UzletiLogika;
using BPlatvanyossagok.UzletiLogika.Classes;
using BPlatvanyossagok.UzletiLogika.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPLatvanyossagok
{


    class Program
    {
        

        static void Main(string[] args)
        {
            #region Látványosságokat és csúcsokat létrehoz
            var budaiVar = new Var("Budai vár", 4500, Latvanyossagok.ErdekessegiSzint.EgészJó);
            var budaivarCsucs = new Csucs(budaiVar);
            var matyasTemplom = new Templom("Mátyás Templom", 1800, Latvanyossagok.ErdekessegiSzint.NagyonJó);
            var matyasTemplomCsucs = new Csucs(matyasTemplom);
            var halaszBastya = new Kilato("Halászbástya", 4500, Latvanyossagok.ErdekessegiSzint.EgészJó);
            var halaszBastyaCsucs = new Csucs(halaszBastya);
            var citadella = new Kilato("Citadella", 4500, Latvanyossagok.ErdekessegiSzint.EgészJó);
            var citadellaCsucs = new Csucs(citadella);
            var parlament = new Egyeb("Parlament", 4500, Latvanyossagok.ErdekessegiSzint.EgészJó);
            var parlamentCsucs = new Csucs(parlament);
            var gellertFurdo = new Furdo("Gellért fürdő", 4500, Latvanyossagok.ErdekessegiSzint.EgészJó);
            var gellertFurdoCsucs = new Csucs(gellertFurdo);
            var margitSziget = new Egyeb("Margit Sziget", 4500, Latvanyossagok.ErdekessegiSzint.EgészJó);
            var margitSzigetCsucs = new Csucs(margitSziget);
            var budapestEye = new Kilato("Budapest Eye", 4500, Latvanyossagok.ErdekessegiSzint.EgészJó);
            var budapestEyeCsucs = new Csucs(budapestEye);
            var bazilika = new Templom("Szent István Bazilika", 1000, Latvanyossagok.ErdekessegiSzint.NagyonJó);
            var bazilikaCsucs = new Csucs(bazilika);
            var zsinagoga = new Templom("Dohány utcai Zsinagóga", 4500, Latvanyossagok.ErdekessegiSzint.EgészJó);
            var zsinagogaCsucs = new Csucs(zsinagoga);
            var hosokTere = new Egyeb("Hősök tere", 4500, Latvanyossagok.ErdekessegiSzint.EgészJó);
            var hosokTereCsucs = new Csucs(hosokTere);
            var vajdaHunyadVara = new Var("Vajdahunyad vára", 4500, Latvanyossagok.ErdekessegiSzint.EgészJó);
            var vajdaHunyadVaraCsucs = new Csucs(vajdaHunyadVara);
            var szechenyiFurdo = new Furdo("Széchenyi fürdő", 4500, Latvanyossagok.ErdekessegiSzint.EgészJó);
            var szechenyiFurdoCsucs = new Csucs(szechenyiFurdo);

            //Várak
            budaiVar.HasonloLatvanyossagHozzaad(vajdaHunyadVara);
            vajdaHunyadVara.HasonloLatvanyossagHozzaad(budaiVar);
            //Egyéb
            parlament.HasonloLatvanyossagHozzaad(margitSziget);
            parlament.HasonloLatvanyossagHozzaad(hosokTere);
            margitSziget.HasonloLatvanyossagHozzaad(parlament);
            margitSziget.HasonloLatvanyossagHozzaad(hosokTere);
            hosokTere.HasonloLatvanyossagHozzaad(parlament);
            hosokTere.HasonloLatvanyossagHozzaad(margitSziget);
            //Fürdők
            gellertFurdo.HasonloLatvanyossagHozzaad(szechenyiFurdo);
            szechenyiFurdo.HasonloLatvanyossagHozzaad(gellertFurdo);
            //Kilátók
            halaszBastya.HasonloLatvanyossagHozzaad(citadella);
            halaszBastya.HasonloLatvanyossagHozzaad(budapestEye);
            citadella.HasonloLatvanyossagHozzaad(halaszBastya);
            citadella.HasonloLatvanyossagHozzaad(budapestEye);
            budapestEye.HasonloLatvanyossagHozzaad(halaszBastya);
            budapestEye.HasonloLatvanyossagHozzaad(citadella);
            //Templomok
            matyasTemplom.HasonloLatvanyossagHozzaad(bazilika);
            matyasTemplom.HasonloLatvanyossagHozzaad(zsinagoga);
            bazilika.HasonloLatvanyossagHozzaad(matyasTemplom);
            bazilika.HasonloLatvanyossagHozzaad(zsinagoga);
            zsinagoga.HasonloLatvanyossagHozzaad(matyasTemplom);
            zsinagoga.HasonloLatvanyossagHozzaad(bazilika);



            #endregion

            #region gráfok
                #region gráf létrehozása, csúcsok felvétele
            Graf graf = new Graf();
            graf.UjCsucs(budaivarCsucs);
            graf.UjCsucs(matyasTemplomCsucs);
            graf.UjCsucs(halaszBastyaCsucs);
            graf.UjCsucs(citadellaCsucs);
            graf.UjCsucs(parlamentCsucs);
            graf.UjCsucs(gellertFurdoCsucs);
            graf.UjCsucs(margitSzigetCsucs);
            graf.UjCsucs(budapestEyeCsucs);
            graf.UjCsucs(bazilikaCsucs);
            graf.UjCsucs(zsinagogaCsucs);
            graf.UjCsucs(hosokTereCsucs);
            graf.UjCsucs(vajdaHunyadVaraCsucs);
            graf.UjCsucs(szechenyiFurdoCsucs);
            #endregion
                #region Élek hozzáadása
            graf.ElHozzaad(new El(budaivarCsucs, matyasTemplomCsucs, 1));
            graf.ElHozzaad(new El(budaivarCsucs, halaszBastyaCsucs, 1));
            graf.ElHozzaad(new El(matyasTemplomCsucs, parlamentCsucs, 3));
            graf.ElHozzaad(new El(halaszBastyaCsucs, matyasTemplomCsucs, 1));
           // graf.ElHozzaad(new El(citadellaCsucs, budaivarCsucs, 5));
           // graf.ElHozzaad(new El(parlamentCsucs, gellertFurdoCsucs, 3));
            graf.ElHozzaad(new El(parlamentCsucs, margitSzigetCsucs, 5));
            graf.ElHozzaad(new El(parlamentCsucs, budapestEyeCsucs, 2));
            graf.ElHozzaad(new El(parlamentCsucs, bazilikaCsucs, 2));
            graf.ElHozzaad(new El(parlamentCsucs, zsinagogaCsucs, 2));
            graf.ElHozzaad(new El(parlamentCsucs, hosokTereCsucs, 4));
           // graf.ElHozzaad(new El(parlamentCsucs, citadellaCsucs, 5));
            graf.ElHozzaad(new El(gellertFurdoCsucs, parlamentCsucs, 3));
            graf.ElHozzaad(new El(margitSzigetCsucs, budapestEyeCsucs, 3));
            graf.ElHozzaad(new El(budapestEyeCsucs, bazilikaCsucs, 1));
           // graf.ElHozzaad(new El(bazilikaCsucs, parlamentCsucs, 2));
            graf.ElHozzaad(new El(bazilikaCsucs, zsinagogaCsucs, 2));
            graf.ElHozzaad(new El(zsinagogaCsucs, hosokTereCsucs, 4));
            graf.ElHozzaad(new El(hosokTereCsucs, vajdaHunyadVaraCsucs, 1));
            graf.ElHozzaad(new El(vajdaHunyadVaraCsucs, szechenyiFurdoCsucs, 1));
           // graf.ElHozzaad(new El(szechenyiFurdoCsucs, parlamentCsucs, 5));
            #endregion


            #endregion


            Console.WriteLine("------------------ FŐ PROGRAM -------");

            Turista turista;
            string nev;

            Console.WriteLine("Kérlek, add meg a neved!");
            nev = Console.ReadLine();

            turista = new Turista(nev);

            while (true)
            {
                Console.Clear();
                GrafCsucsokFelhasznaloValasztashoz(graf);
                Console.WriteLine("Kedves {0}! Kérlek, válassz kiindulási pontot!\n",turista.Nev);
                int indulas = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(graf.Csucsok[indulas].Latvanyossag.Nev);
                
                Console.WriteLine("Kedves {0}! Kérlek, válassz célpontot!\n", turista.Nev);
                int erkezes = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(graf.Csucsok[erkezes].Latvanyossag.Nev);

                
                Console.WriteLine();

               // Dijkstra.DijkstraAlgo(GrafToMatrix(graf), 0, 8, graf);
                //TombKiir(GrafToMatrix(graf));
                Map terkep = new Map();

                List<Csucs> utvonal = Utkereses.LegrovidebbUt(terkep, graf.Csucsok[indulas], graf.Csucsok[erkezes], graf);
                turista.Utvonal = utvonal;

                turista.Utvonal.Add(budaivarCsucs);
                turista.Utvonal.Add(parlamentCsucs);


                foreach (Csucs latvany in turista.Utvonal)
                {
                    Console.Write(latvany.Latvanyossag.Nev + " => ");
                }

                Console.WriteLine("VEGE");
                Console.ReadLine();
            }
        }



        private static void GrafCsucsokKilistaz(Graf graf)
        {
            for (int i = 0; i < graf.Elek.Count; i++)
            {
                Console.WriteLine("{0} -> {1}: {2} ", graf.Elek[i].Honnan.Latvanyossag.Nev, graf.Elek[i].Hova.Latvanyossag.Nev, graf.Elek[i].Tavolsag);

            }
        }
        private static void GrafCsucsokFelhasznaloValasztashoz(Graf graf)
        {
            for (int i=0; i< graf.Csucsok.Count;i++)
            {
                Console.WriteLine("[{0}]. {1}",i,graf.Csucsok[i].Latvanyossag.Nev);
            }
        }

        private static void TombKiir(int[,] tomb)
        {
            int n = tomb.GetLength(0);

            for (int i=0; i<n;i++)
            {
                for (int j=0; j<n;j++)
                {
                    Console.Write(tomb[i,j]+ " ");
                }
                Console.WriteLine();
            }

        }

        private static int[,] GrafToMatrix(Graf graf)
        {
            int[,] tomb = new int[graf.Csucsok.Count, graf.Csucsok.Count];

            for (int i=0;i<graf.Csucsok.Count;i++)
            {
                for (int j=0;j<graf.Csucsok.Count;j++)
                {
                    if (graf.VezetEL(graf.Csucsok[i],graf.Csucsok[j]))
                    {
                        El el = graf.GetEl(graf.Csucsok[i], graf.Csucsok[j]);
                        
                        tomb[i, j] = (int)el.Tavolsag;
                    }
                    else
                    {
                        tomb[i, j] = 0;
                    }
                }
            }

            return tomb;
        }
    

    }
}
