// Määritellään ulkoiset nimiavaruudet
using System;
using System.Collections.Generic;
using System.Text;

// Määritellään luokan nimiavaruus, sama kuin pääohjelmalla
namespace sali
{
    // Määritellään sovelluksen sisäinen luokka Asiakas
    internal class Asiakas
    {
        private string etunimi;
        private string sukunimi;
        private float pituus;
        private float paino;

        // Muodostin kaikilla parametreilla
        public Asiakas(string etunimi, string sukunimi, float pituus, float paino)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.pituus = pituus;
            this.paino = paino;
        }

        // Metodi, joka tulostaa ruudulle painoindeksin
        public void BMI()
        {
            Console.WriteLine("Painoindeksisi on " + this.paino / (this.pituus * this.pituus));
        }
    }
}