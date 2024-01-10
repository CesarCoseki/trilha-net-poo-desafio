namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
         public Iphone (string numero, string modelo, string _IMEI,int memoria ) : base (numero, modelo, _IMEI, memoria)
        {

        }
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"{nomeApp} esta sendo instalado no Iphone: {Modelo} com {Memoria}GB.");
        }
    }
}