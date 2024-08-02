using Pratik_Encapsulation;
//doğru kapı sayısı atanıyor
Car araba = new Car("Honda","Civic","Beyaz",4);
Console.WriteLine($"{araba.Marka},{araba.Model},{araba.Renk},{araba.KapiSayisi}");


//yanlış kapı sayısı atanıyor
Car araba2 = new Car("Toyota", "Corolla", "Siyah", 3);
Console.WriteLine($"{araba2.Marka}, {araba2.Model}, {araba2.Renk}, {araba2.KapiSayisi}");