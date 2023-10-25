namespace DESAFIO_CELULAR.Models;
public class Iphone : Smartphone
{
    public Iphone(string numero,string modelo,string imei,int memoria) : base(numero, modelo, imei, memoria)
    {    //construtor herdado da superclasse(base)
    }

    public override void InstalarAplicativo(string nomeApp){
        Console.WriteLine($" {nomeApp} Instalado com sucesso! no modelo {Modelo}");
    }
}
