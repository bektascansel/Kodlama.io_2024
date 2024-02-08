//Degiskenler();


/*
Vatandas vatandas = new Vatandas();
SelamVer("Engin");
int sonuc = Topla();
Console.WriteLine(sonuc);
SelamVer();*/

using Business.Adaptor;
using Business.Concrete;
using Entities.Concrete;

string ogrenci1 = "Engin";
string ogrenci2 = "Kerem";
string ogrenci3 = "Berkay";

string[] ogrenciler = new string[3];
ogrenciler[0] = ogrenci1;
ogrenciler[1] = ogrenci2;
ogrenciler[2] = ogrenci3;

ogrenciler=new string[4];
ogrenciler[3] = "İlker";

foreach (string o in ogrenciler)
    Console.WriteLine(o);

string[] sehirler1 = new[]{ "ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };


sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);


Person person1 = new Person();
person1.FirstName = "Engin";
person1.LastName = "Demirog";
person1.NationalIdenity = 123;
person1.DateOdBirthYear = 1985;

Person person2 = new Person(); 
person2.FirstName = "Murat";

foreach(string o in sehirler1)
{
    Console.WriteLine(o);
}


List<string> yeniSehirler=new List<string> { "Ankara","İzmir","İstanbul"};

yeniSehirler.Add("Aydın");

foreach (var item in yeniSehirler)
{
    Console.WriteLine(item);
}

PttManager pttManager = new PttManager(new PersonManager(),new MernisServiceAdaptor());
pttManager.GiveMask(person1);



static void Degiskenler()
{
    Console.WriteLine("Hello, World!");

    string mesaj = "Hello ";
    double tutar = 100000;
    int sayi = 100;
    bool girisYapmisMi = false;


    string ad = "Engin";
    string soyad = "Demirog";
    int dogumYili = 1985;
    long tc = 12345678912;


    Console.WriteLine(mesaj);
    Console.WriteLine(tutar * 1.69);
}


//default parameter
static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba "+isim);
}

static int Topla(int sayi1=5,int sayi2=10)
{
    Console.WriteLine("Toplam " + (sayi1 + sayi2));
    return sayi1+sayi2;
}


class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

}