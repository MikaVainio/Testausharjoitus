using System;

namespace sali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testataan asikasluokkaa");
			Console.WriteLine("Anna etunimi");
			string etunimi = Console.ReadLine();
			Console.WriteLine("Anna sukunimi");
			string sukunimi = Console.ReadLine();
			Console.WriteLine("Syötä pituus");
			float pituus = float.Parse(Console.ReadLine());
			Console.WriteLine("Syötä paino");
			float paino = float.Parse(Console.ReadLine());
			
			Asiakas asiakas = new Asiakas(etunimi, sukunimi, pituus, paino);
			asiakas.BMI();
            
        }
    }
}
