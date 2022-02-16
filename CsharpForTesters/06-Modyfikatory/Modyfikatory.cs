using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpForTesters._06_Modyfikatory
{
    public class Modyfikatory
    {
        private String film;
        protected String rezyser;
        private String scenarzysta;
        public double budzet;

        public Modyfikatory(string film, string rezyser, string scenarzysta, double budzet)
        {
            this.film = film;
            this.rezyser = rezyser;
            this.scenarzysta = scenarzysta;
            this.budzet = budzet;
        }
    }
}
