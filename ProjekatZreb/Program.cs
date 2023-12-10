using System;
using System.Collections.Generic;

namespace ProjekatZreb
{
    class Program
    {
        static void Main(string[] args)
        {
            Pot pot0 = new Pot(
                true, 
                new List<Slip> { 
                    new Slip("Nemacka"),
                    new Slip("Portugal"),
                    new Slip("Francuska"),
                    new Slip("Spanija"),
                    new Slip("Belgija"),
                    new Slip("Engleska")
                });
            Pot pot1 = new Pot(
                false,
                new List<Slip> {
                    new Slip("Madjarska"),
                    new Slip("Turska"),
                    new Slip("Rumunija"),
                    new Slip("Danska"),
                    new Slip("Albanija"),
                    new Slip("Austrija")
                });
            Pot pot2 = new Pot(
                false,
                new List<Slip> {
                    new Slip("Holandija"),
                    new Slip("Skotska"),
                    new Slip("Hrvatska"),
                    new Slip("Slovenija"),
                    new Slip("Slovacka"),
                    new Slip("Ceska")
                });
            Pot pot3 = new Pot(
                false,
                new List<Slip> {
                    new Slip("Italija"),
                    new Slip("Srbija"),
                    new Slip("Svajcarska"),
                    new Slip("Poljska/Estonija/Finska/Vels"),
                    new Slip("BiH/Ukrajina/Izrael/Island"),
                    new Slip("Gruzija/Luksemburg/Grčka/Kazahstan")
                });
            Zreb zreb = new Zreb(new List<Pot> { pot0, pot1, pot2, pot3 });
            Console.WriteLine("Zreb za evropsko prvenstvo u fudbalu 2024. godine:");
            Console.WriteLine("----------------------------------------");
            for(int i = 0; i < zreb.pots.Count; i++)
            {
                Console.Write($"{i + 1}. Sesir: ");
                for(int j = 0; j < zreb.pots[i].slips.Count; j++)
                {
                    Console.Write($"{zreb.pots[i].slips[j].label}");
                    if(j != zreb.pots[i].slips.Count - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pritisnite 'enter' za pocetak izvlacenja.");
            Console.ReadLine();
            Console.Clear();
            Tournament tournament = zreb.Draw();
            zreb.DisplayTournament(tournament);
        }
    }
}