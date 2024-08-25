using DesafioPOO.Models;


Iphone iphone = new Iphone(numero: "(13)99199-9929", modelo: "Iphone 14 PRO MAX", imei: "354217065812345", memoria: 500);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("------=----------=------");

Nokia nokia = new Nokia(numero: "(14)99421-3231", modelo: "Nokia X-30", imei: "862123040781234", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

