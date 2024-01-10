namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama - OK        
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }
        public Smartphone(string numero, string modelo, string _IMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = _IMEI;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades - OK
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"O {Numero} está recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}