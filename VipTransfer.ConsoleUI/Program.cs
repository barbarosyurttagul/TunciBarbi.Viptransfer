// See https://aka.ms/new-console-template for more information

using System.Collections;
using VipTransfer.DataAccess.Concretes;
using VipTransfer.Entities.Concretes;

ArrivalDal arrivalDal = new ArrivalDal();

//Console.WriteLine(arrivalDal.GetById(2));

Arrival arrival = new Arrival(4, "Kaş");

arrivalDal.Add(arrival);


var arrivalList = arrivalDal.GetAll();
foreach (var item in arrivalList)
{
    //String Interpolation
    Console.WriteLine($"Idsi: {item.Id} Adı: {item.Name}");
}



/*
Console.WriteLine("Silindikten sonraki veritabanı aşağıdaki gibidir");

foreach (var item in arrivalList)
{
    //String Interpolation
    Console.WriteLine($"Idsi: {item.Id} Adı: {item.Name}");
}
*/
arrival.Name = "Kemer";
arrivalDal.Update(arrival);
Console.WriteLine("Güncellemeden sonraki liste");
foreach (var item in arrivalList)
{
    //String Interpolation
    Console.WriteLine($"Idsi: {item.Id} Adı: {item.Name}");
}

var arrivalByName = arrivalDal.GetByName("Kemer");
Console.WriteLine(arrivalByName.Id + " " + arrivalByName.Name);

string isim = "Tunci";



Console.WriteLine(isim[0]);

//for (int i = 0; i < isim.Length; i++)
//{
//    Console.Write(isim[i] + " ");
//}

foreach (var karakter in isim)
{
    Console.Write(karakter + " ");
}

//Collectionlar Array, ArrayList, List, Dictionary, HashSet gibi içerisine bir dizi eleman yükleyebildiğimiz veri yapılarıdır
// Array eleman sayısı fix sayıda oluşturulur. Sonradan ekleme yapılamaz. Ama performans sağlar.
// List'e sonradan eleman ekleyerek genişletilebilir. 

List<int> yeniListe = new();

ArrayList yeniArrayList = new ArrayList();

