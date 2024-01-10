namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone 

    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia (string numero, string modelo, string _IMEI,int memoria ) : base (numero, modelo, _IMEI, memoria)
        {
                
        }
        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"{nomeApp} esta atualmete em download no Nokia: {Modelo}. A memoria do dispositivo esta em {Memoria}GB no momento.");
        }
    }
}