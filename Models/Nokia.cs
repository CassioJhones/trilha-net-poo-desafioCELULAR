namespace DESAFIO_CELULAR.Models;
public class Nokia:Smartphone{
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {//construtor herdado da superclasse(base)
    }

    public override void InstalarAplicativo(string nomeApp){
        Console.WriteLine($"Instalado {nomeApp} com sucesso! no modelo {Modelo}");
    }
}
