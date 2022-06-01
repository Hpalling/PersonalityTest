using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //prog küsib kasutajalt siseestada tema lemmikvärv;
            //kui kasutajalt sisetab 'punane', konsool kuvad 'oled romantiline'
            //kui kasutaja sisestab 'sinine', konsool kuvad 'oled töökas'
            //kui kasutaja sisestab 'rohelin', konsool kuva 'oled looduseinimne'
            //kui kasutaja sisestab midagi muud, konsool kuvad 'oled {userColor} ükssarvik';

            Console.WriteLine("Sisestada oma lemmikvärv");
            string userColor = Console.ReadLine();

            if(userColor == "punane")
            {
                Console.WriteLine("Oled Romantiline.") ;
            }
            else if (userColor == "sinine")
            {
                Console.WriteLine("Oled Töökas");
            }
            else if (userColor == "roheline")
            {
                Console.WriteLine("oled looduse sõber");
            }
            else
            {
                Console.WriteLine($"oled{userColor} Ükssarvik");
            }
        }
    }
}