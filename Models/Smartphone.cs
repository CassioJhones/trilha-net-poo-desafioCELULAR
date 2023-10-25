namespace DESAFIO_CELULAR.Models;
public abstract class Smartphone{
    public Smartphone(string numero, string modelo, string imei, int memoria){
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;  }
   
    public string Numero { get; set; }
    protected string Modelo { get; set; }
    protected string IMEI { get; set; }
    protected int Memoria { get; set; }

    public void Ligar(){
        Console.WriteLine("Ligando...");
        Console.WriteLine($"Celular modelo {Modelo} com {Memoria}GB de memoria...");
    }

    public void ReceberLigacao(){ 
        Console.WriteLine($"[ATENÇÃO]: O {Numero} está Recebendo uma ligação...");}
   
    public abstract void InstalarAplicativo(string nomeApp); //obrigatorio nas classes filhas
}
