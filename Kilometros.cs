


namespace Speed.Class
{
    public class Kilometros
    {
        public double Distancia { get; set; }

        public Kilometros(double distancia)
        {
            Distancia = distancia;
        }

        public double A_Millas()
        {
            return Distancia / 1.60934;
        }

        public override string ToString()
        {
            return $"{Distancia} km";
        }
    }
}
