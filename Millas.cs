

namespace Speed.Class
{
    public class Millas
    {
        public double Distancia { get; set; }

        public Millas(double distancia)
        {
            Distancia = distancia;
        }

        public double A_Kilometros()
        {
            return Distancia * 1.60934;
        }

        public override string ToString()
        {
            return $"{Distancia} mi";
        }
    }
}
