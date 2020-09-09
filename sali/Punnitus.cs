using System;
using System.Collections.Generic;
using System.Text;

// Määritellään luokille oma nimiavaruus Jokumuu, pääohjelman nimiavaruus on Sali
namespace Jokumuu
{
    class Punnitus
    {
        // Määritellään paino-kenttä kaikkialla käytettäväksi
        public float paino;

        // Muodostin kaikilla parametreilla
        public Punnitus(float paino)
        {
            this.paino = paino;
        }
    
    }
}
