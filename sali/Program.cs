using System;

namespace sali
{
    public class Asiakas
{
	// Kentät perustietoja varten
	protected string etunimi;
	protected string sukunimi;
	protected float pituus;
	protected float paino;

	// Muodostin kaikilla argumenteilla
	public Asiakas(string etunimi, string sukunimi, float pituus, float paino)
	{
		this.etunimi = etunimi;
		this.sukunimi = sukunimi;
		this.pituus = pituus;
		this.paino = paino;
	}

	// Metodit

	// Painoindeksin laskenta
	public void BMI()
    {
		float bmi = this.paino / (this.pituus * this.pituus);
		Console.WriteLine(bmi);
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string kenganNumero = "42";
            Console.WriteLine(kenganNumero);
        }
    }
}
