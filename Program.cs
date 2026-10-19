using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "22222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");