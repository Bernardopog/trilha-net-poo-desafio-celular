namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string model, string imei, int memoria) : base(numero, model, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome}...");
        }
    }
}