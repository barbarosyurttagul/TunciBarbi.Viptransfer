// See https://aka.ms/new-console-template for more information
using VipTransfer.DataAccess.Concretes;
using VipTransfer.Entities.Concretes;

ArrivalDal arrivalDal = new ArrivalDal();

//Console.WriteLine(arrivalDal.GetById(2));

Arrival arrival = new Arrival(4, "Kaş");

arrivalDal.Ekle(arrival);


var arrivalList = arrivalDal.GetAll();
foreach (var item in arrivalList)
{
    //String Interpolation
    Console.WriteLine($"Idsi: {item.Id} Adı: {item.Name}");
}

//arrivalDal.Sil(arrival);

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
