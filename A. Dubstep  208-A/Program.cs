using System;

namespace A.Dubstep__208_A
{
    class Program
    {
        static void Main(string[] args)
        {

            string song = Console.ReadLine();
            Console.WriteLine(ReturnToOriginals(song));
        }

        public static string ReturnToOriginals(string song)
        {
            song += "WUB";
            string songLyrics = "";
            string tempWord = "";
            for (int i = 0; i < song.Length - 2; i++)
            {
                if (song[i] == 'W' && song[i + 1] == 'U' && song[i + 2] == 'B')
                {

                    i = i + 2;//Jump a word(WUP)
                    if (tempWord != "")
                    {
                        songLyrics += (tempWord + " ");
                        tempWord = "";
                    }
                }
                else if (i == song.Length - 2)
                {

                }
                else
                {
                    tempWord += song[i];

                }
            }
            return songLyrics.Trim();
        }
    }
}
