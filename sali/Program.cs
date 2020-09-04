// Määritellään ulkoiset nimiavaruudet
using System;

// Määritellään pääohjelman nimiavaruus
namespace sali
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään asiakkaan tiedot konsolilta
			Console.WriteLine("Testataan asikasluokkaa");
			Console.WriteLine("Anna etunimi");
			string etunimi = Console.ReadLine();
			Console.WriteLine("Anna sukunimi");
			string sukunimi = Console.ReadLine();
			Console.WriteLine("Syötä pituus metreinä");
			float pituus = float.Parse(Console.ReadLine());
			Console.WriteLine("Syötä paino kiloina");
			float paino = float.Parse(Console.ReadLine());
			
			// Luodaan Asiakas-olio luokasta, joka on määritelty tiedostossa Asiakas.cs
			Asiakas asiakas = new Asiakas(etunimi, sukunimi, pituus, paino);
			
			// Kutsutaan metodia, joka tulostaa painoindeksin
			asiakas.BMI();
            
        }
    }
}
