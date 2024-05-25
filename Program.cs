﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", "Modelo 1", imei: "1111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "4987", "Modelo 2", imei: "2222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");