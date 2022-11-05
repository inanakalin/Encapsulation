internal class Program
{
    private static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci ();
            ogrenci.Ad1 = "ali";
            ogrenci.Soyad1 = "atabak";
            ogrenci.No1=140;
            ogrenci.Sınıf1= 7;

        Ogrenci ogrenci1 = new Ogrenci ();
            ogrenci1.Ad1 = "Erinç";
            ogrenci1.Soyad1 = "Bilican";
            ogrenci1.No1 = 151; //ogrenci.N yazdığında karşına çıkan anahtar şeklindeki şey bunun bir properties
            ogrenci1.Sınıf1 = 10; //olduğunu gösterir yani enkapsüle edildiğini ve getter ve setter olduğunu anlayabiliyoruz
            ogrenci1.SinifAtlat();//mesela sınıfın enkapsülesine gidip ordaki getter'ı silersek artık burada
           // ogrenci1.OgrenciBilgileriGetir(); //üzerinde değişiklik yapamayız

        Ogrenci ogrenci2 = new Ogrenci ();
           {
            System.Console.WriteLine("Öğrenci Bilgilerini Sırası ile giriniz");
            System.Console.Write("Öğrenci Adı       :");
                string veriAd =  Console.ReadLine ();
                ogrenci2.Ad1 = veriAd;
            System.Console.Write("Öğrenci Soyadı    :");
                 string veriSoyad =  Console.ReadLine ();
                 ogrenci2.Soyad1 = veriSoyad;
            System.Console.Write("Öğrenci Numarası  :");
                int VeriNo = Convert.ToInt32 (Console.ReadLine ());
              // ogrenci2.NoKontrol ();
                ogrenci2.No1 = VeriNo;
            System.Console.Write("Öğrenci Sınıfı    :");
                int VeriSınıfı = Convert.ToInt32 (Console.ReadLine ());
                ogrenci2.Sınıf1 = VeriSınıfı;
           }            
           // ogrenci2.OgrenciBilgileriGetir();
         Ogrenci ogrenci3 = new Ogrenci (7,"akalın",234,"resit","reso");
            ogrenci3.OgrenciBilgileriGetir();
    }
                            
                           
}

public class Ogrenci
{
    private string Basad;

    private string Ad;  //field (alan oluşturduk.) //add parameter to constructor dediğimizde 
    private string Soyad;//
    private int No;
    private int Sınıf ;
    



    //get değer çekme demektir set : değer atama
    public string Ad1 { get => Ad; set => Ad = value; } //bu bir property metotudur
    public string Soyad1 { get => Soyad; set => Soyad = value; }
    public int Sınıf1
    {
     
         get => Sınıf;
      
        set
        {
          if (value < 1)
            {
             System.Console.WriteLine("Sınıf en az 1 olabilir");
             Sınıf =1;
            }
        else { Sınıf = value; }
        }
    }   

           
      //setter atamazsak yukarıda değişiklik yapamazdık

    public int No1 { get => No; set => No = value; }
    //nesnesi oluşturulduğunda - instance- ona get ederken metota eklediğin her properties
    //geriye dönüyor olmalı. Boş dnmemesi için 0 veya null atayabilirsin
    public Ogrenci(int sınıf, string soyad , int no, string ad, string basad)   //bunun adı kurucu metot
    { //parametreli olursa burdan çalışacak ***     *** kurucu metotların ismi sınıfı ile aynı olmalı
      // geri dönüş tipleri olmaz/olmamalı *** *** Class içinde tanımlanan propertiesi atanarak 
      //refactor ederiz. (iyileştiririz)
        Sınıf = sınıf;
        Soyad = soyad;
        No = no;
        Ad = ad;
        Basad = basad;
        
    }
    public Ogrenci (){}  //overload edilebilir*** bu şekilde set edilirse nesne kullanılacağı zaman istenen
                    //class içinde Ogrenci

    public void OgrenciBilgileriGetir ()

    {
        System.Console.WriteLine("*******Öğrenci bilgileri******");
        System.Console.WriteLine("Öğrenci Başadı    : {0}", this.Basad);
        System.Console.WriteLine("Öğrenci Adı       : {0}", this.Ad);         
        System.Console.WriteLine("Öğrenci Soyadı    : {0}", this.Soyad);        
        System.Console.WriteLine("Öğrenci Numarası  : {0}", this.No);        
        System.Console.WriteLine("Öğrenci Sınıfı    : {0}", this.Sınıf); 
    }

    public void SinifAtlat () {this.Sınıf = this.Sınıf +1;}
    public void SinifDusur () {this.Sınıf = this.Sınıf -1;}

    // public void NoKontrol ()
    // {
    //     this.No = this.No;
    //     if (this.No <= 50)
    //     {
    //         System.Console.Write("Lütfen numarayı tekrar giriniz:    ");
    //         int yeniNo = int.Parse(Console.ReadLine());
    //         if (yeniNo <=50)
    //         {
    //         System.Console.Write("Lütfen numarayı düzgün gir bok yiyenin oğlu:  ");
    //             int bok = int.Parse (Console.ReadLine());
    //             this.No = bok;

    //         }

    //     } 
    //     else
    //     {
    //         this.No = this.No + 10;
    //     }
    // }
}