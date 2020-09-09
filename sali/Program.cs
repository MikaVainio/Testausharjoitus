// Määritellään ulkoiset nimiavaruudet
using System;

// Otetaan ulkoinen Jokumuu-nimiavaruus  käyttöön, sen komponentit löytyvät ilman polkua
using Jokumuu;

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

			// Luodaan Punnitus-olio luokasta, joka on määritelty ulkoisessa Jokumuu-nimiavaruudessa

			Jokumuu.Punnitus punnitus1 = new Jokumuu.Punnitus(71.2f);

			Console.WriteLine("Ensimmäinen punnitus " + punnitus1.paino);

			// Jos Jokumuu-nimiavaruus on otettu käyttöön Using-lauseessa olion voi luoda:
			Punnitus punnitus2 = new Punnitus(70.5f);

			Console.WriteLine("Toinen punnitus " + punnitus2.paino);



		}
    }
}
