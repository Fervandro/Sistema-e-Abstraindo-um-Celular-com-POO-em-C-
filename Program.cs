using DesafioPOO.Models;

Console.WriteLine("Smartphone iphone:");
Iphone iphone = new Iphone(numero: "1234", modelo: "Modelo 1", imei: "11111",memoria: 9);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("whatsapp");

Console.WriteLine("----------------------------------------------------------");

Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "5678", modelo: "Modelo 2", imei: "22222",memoria: 15);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("----------------------------------------------------------");