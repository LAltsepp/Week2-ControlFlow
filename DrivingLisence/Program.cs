using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat, kas ta on piisavalt vana,
            //et juhiluba saada(tingimuseks 18 aastad vana)

            Console.WriteLine("Mis aastal sa sündisid?");

            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - YearOfBirth;
            if (Age > 18)
            {
                Console.WriteLine("Sa võid teha juhilube.");
            }

            else if (Age < 18)
            {
                Console.WriteLine("Sa ei saa teha juhilube.");
            }




            
        } 
       

    }
}
