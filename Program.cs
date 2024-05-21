using DesafioPOO.Models;

Console.WriteLine("Teste Nokia");
Smartphone nokia = new Nokia(numero: "21998107410", modelo: "Moto G Force", imei: "093451233", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Teste Iphone");
Smartphone iphone = new Iphone(numero: "21970758285", modelo: "13 ProMAx", imei: "321542871", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
