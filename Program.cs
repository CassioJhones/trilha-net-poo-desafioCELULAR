using DESAFIO_CELULAR.Models;

Console.WriteLine("\nSmartphone Iphone:");
Iphone clt = new Iphone("(19)3546", "M-15", "9999", 120);
clt.Ligar();
clt.InstalarAplicativo("HOTMART");
clt.ReceberLigacao();

Console.WriteLine("\nSmartphone Nokia:");
Nokia estagiario = new Nokia("(15)3661","c3p0","0000",2);
estagiario.Ligar();
estagiario.InstalarAplicativo("TIKTOK");
estagiario.ReceberLigacao();
