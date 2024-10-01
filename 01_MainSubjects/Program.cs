using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;  
using System.Threading.Tasks;
using System.Text;

//DERS 1 NOTLARI


// bu using ifadeler kullanicagimiz kodlara ait kutuphaneleri tutuyor. bu sekilde kutuphanlere ayrilmasinin sebebi 
//programlama da her birkod bir kutuphaneye aittir. yazilim dunyasi neye ihtiyacin varsa onu kullanicagin zaman
//onu buraya dahil edicem. hepsini tek baslik altinda toplamak karmasa yaratabilir 

namespace _01_MainSubjects
{
    internal class Program 
    // burasi internal bir erisim belirleyici
    {
        static void Main(string[] args)
        {
            //burasi komutlarimizin yazildigi yerdir main metodunun icine yazilir 
            //amacimiz ekrana yaziyazdirmak bunun icin;
            // Console.WriteLine("Hello World!"); 
            // //bir yapinin metot oldugunu anlamak icin yazarken sol tarafinda cikan mor bir kup vardir
            // //bu onun metot oldugu anlamina gelir
            // Console.Read();// read metodu ekranin beklemesini saglamak icin kullanilir enter tusuna basana kadar ekrani bekleticek
            // //olan koddur 

            #region YAZDIRMAKOMUTLARI
// YAZDIRMA KOMUTLARI 
            // Console.WriteLine(""); // bir deger yazar sonra imleci bir alt satira yazar 
            // Console.Write(""); // write ifadesi bir yaziyi yazdigi zaman o yaziyi en saga atar
//             
//     Console.WriteLine("***** Yemek Kategorileri *****");
//     
//     Console.WriteLine("");
//     Console.WriteLine("1-Corbalar");
//     Console.WriteLine("2- Ana Yemekler");
//     Console.WriteLine("3-Soguk Baslangiclar");
//     Console.WriteLine("4-Salatalar");
//     Console.WriteLine("5-Tatlilar");
//     Console.WriteLine("6-Icecekler");
//     Console.WriteLine("");
// Console.WriteLine("***** Yemek Kategorileri *****");
#endregion
            #region String DEGISKENLER
             //STRING 
             //string alfabetik turde verilerimizi tutabilicegimiz degisken turu
             //Degisken_turu degisken_adi;

            //  string name;
            //  name = "Umre";
            //  Console.Write(name); // name'i ("name") seklinde yazmiyorum cift tirnak icinde yazarsak bize
            //  // ekrana direk name yazar ama bizim istedigimiz name degerinin karisligini yazmasi 
            //
            //  String customerName;
            //  String customerSurname;
            //  String customerEmail;
            //  //degisken adllandirilirken araya bosluk konulmaz.
            //  String customerAddress;
            //  String customerPhone, district, city; // bir satirda ayni turde birden fazla degisken tanimlanabiliyor
            //  
            // customerName = "Umre";
            // customerSurname = "Gunes";
            // customerEmail = "Umre@gmail.com";
            // customerAddress = "123 Main Street";
            // customerPhone = "0123456789";
            // district = "Cankaya";
            // city = "Ankara";
            //
            // Console.WriteLine("**** Rezervasyon Karti ****");
            // Console.WriteLine("------------------------");
            // Console.WriteLine("Musteri: " + customerName + " " + customerSurname);
            // Console.WriteLine("Email: " + customerEmail);
            // Console.WriteLine("iletisim:" + customerPhone);
            // Console.WriteLine("Adres: " + district + "/" + city);
            // Console.WriteLine("-------------------------");
            //
            // customerName = "Emir";
            // Console.WriteLine(customerName);
            // /*bu sekilde once umre nin musteri bilgilerini girer sonra Emirin adini yazdirir cunku
            //  programlamada hiyerarsik bir  atama siralamasi vardir. yukaridan baslar  asagiya dogru
            //  giderek okur.*/
            //
            // customerSurname = "Terzi";
            // customerPhone = "0123456729";
            // customerEmail = "Emir@gmail.com";
            // district = "Ortahisar";
            // city = "Trabzon";
            // Console.WriteLine("------------------------");
            // Console.WriteLine("Musteri: " + customerName + " " + customerSurname);
            // Console.WriteLine("Email: " + customerEmail);
            // Console.WriteLine("iletisim:" + customerPhone);
            // Console.WriteLine("Adres: " + district + "/" + city);
            // Console.WriteLine("-------------------------");
            //
            //
            #endregion
            #region INT DEGISKENLER

             /*tamsayi turundeki degiskenlerdir
              */

             // int number = 24;
             // Console.WriteLine(number);

             int hamburgerPrice = 300;
             int cokePrice = 35;
             int waterPrice = 10;
             int friesPrice = 50;
             int pizzaPrice = 250;
             int lemonedaPrice = 30;
             Console.WriteLine("***** Restoran Menu Fiyati *****");
             Console.WriteLine();
             Console.WriteLine("-----Hambuger:" +hamburgerPrice+ "TL");
             Console.WriteLine("-----:Pizza" +pizzaPrice+ "TL");
             Console.WriteLine("-----Kola:" +cokePrice+ "TL");
             Console.WriteLine("-----Limonata:" +lemonedaPrice+ "TL");
             Console.WriteLine("-----Su:" +waterPrice+ "TL" );
             Console.WriteLine("-----Kizartma:" +friesPrice+ "TL");
             Console.WriteLine("***** Restoran Menu Fiyati *****");
             
             
             Console.WriteLine();

             int hambugerCount;
             int cokeCount;
             int waterCount;
             int friesCount;
             int lemonedaCount;
             int pizzaCount;
             
             int totalHambugerPrice;
             int totalCokePrice;
             int totalWaterPrice;
             int totalFriesPrice;
             int totalLemonedaPrice;
             int totalPizzaPrice;
             

             hambugerCount = 3;
             cokeCount = 3;
             waterCount = 3;
             friesCount = 1;
             pizzaCount = 0;
             lemonedaCount = 0;
             totalHambugerPrice = hambugerCount * hamburgerPrice; //adet carpi fiyat
             totalCokePrice = cokeCount * cokePrice;
             totalWaterPrice = waterCount * waterPrice;
             totalFriesPrice = friesCount * friesPrice;
             totalLemonedaPrice = lemonedaCount * lemonedaPrice;
             totalPizzaPrice = pizzaCount * pizzaPrice;
             
             
             Console.WriteLine("------------------------------------------------");
             
             Console.WriteLine("Hambuger Tutari:" + totalHambugerPrice+ "TL" );
             Console.WriteLine("Kola tutari:" +totalCokePrice+ "TL");
             Console.WriteLine("Su tutari:" +totalWaterPrice+ "TL");
             Console.WriteLine("Kizartma tutari:" +totalFriesPrice+ "TL");
             Console.WriteLine("Limonata tutari:" +totalLemonedaPrice+ "TL");
             Console.WriteLine("Pizza tutari:" + totalPizzaPrice + "TL");
             Console.WriteLine();
                 
             int totalPrice=totalHambugerPrice + totalCokePrice + totalLemonedaPrice + totalPizzaPrice + totalFriesPrice + totalWaterPrice;
             
             Console.WriteLine("Toplam odenecek Tutar: " + totalPrice+ "TL");
             
             

             Console.Read();
             










             #endregion

        }
    }
}

