/****************************************************************************
**				SAKARYA uNİVERSİTESİ
**		BİLGİSAYAR VE BİLİsİM BİLİMLERİ FAKuLTESİ
**		    BİLGİSAYAR MuHENDİSLİgİ BoLuMu
**	         NESNEYE DAYALI PROGRAMLAMA DERSİ
**
**				oDEV NUMARASI....:odev_2.1
**				ogRENCİ ADI......:Suleyman Arif Karakilic
**				ogRENCİ NUMARASI.:b201210029
**				DERS GRUBU.......:B
****************************************************************************/





using System;
using System.Collections;
using System.Collections.Generic;

namespace odev2._1
{
    class Menu
    {
        public void Menu1()//menunun yazdirildigi method
        {
            string[] MenuItem = new string[10];
            MenuItem[0] = "1 Eleman Sayisi\n";
            MenuItem[1] = "2 Birlestir\n";
            MenuItem[2] = "3 Araya Gir\n";
            MenuItem[3] = "4 Deger Al\n";
            MenuItem[4] = "5 Diziye Ayir\n";
            MenuItem[5] = "6 Char Diziye Donustur\n";
            MenuItem[6] = "7 Deger Indis \n";
            MenuItem[7] = "8 Sirala(A-Z) \n";
            MenuItem[8] = "9 Sirala(Z-A) \n";
            MenuItem[9] = "10 Ters Cevir \n";
            for (int menu = 0; menu < MenuItem.Length; menu++)// menunun yazdirma dongusu
            {
                Console.WriteLine(MenuItem[menu]);
            }
            Console.WriteLine("Yapmak istediginiz islemi seciniz : ");
        }
    }

    class Func
    {
        public string girdi;

        public void GetGirdi()
        {
            Console.WriteLine("Islem yapacaginiz stringi giriniz : ");
            girdi = Console.ReadLine();
        }
        public int ElemanSayisi(string str)
        {
            int sayac = 0;
            foreach (char c in str) //eleman sayisini saydiran sayac
            {
                sayac++;
            }
            return sayac;
        }
            
        public void Birlestir()
        {
            string str1;
            string str2;
            string str3;
            Console.WriteLine("Birinci stringi giriniz : ");
            str1=Console.ReadLine();
            Console.WriteLine("İkinci stringi giriniz : ");
            str2 = Console.ReadLine();
            str3 =str1 + str2  ;
            Console.WriteLine("Stringlerin birlestirilmis hali : "+ str3);
        }
        public string  ArayaGir(int index , string ekle)
        {
           
            char[] stringArray = new char[ElemanSayisi(ekle) + ElemanSayisi(girdi)];

            for (int i = 0; i < index; i++)  //araya girmeden onceki kismi alan for
            {
                stringArray[i] = girdi[i];
            }
            for(int i=0; i<ElemanSayisi(ekle); i++)
            {
                stringArray[index + i] = ekle[i]; //eklenecek stringin foru
            }
            for (int i =0, girdiUzunluk=ElemanSayisi(girdi); i <girdiUzunluk- index; i++)
            {
                stringArray[index + ElemanSayisi(ekle) + i] = girdi[index + i];// araya girdikten sonraki kismi yazan for
            }
            return new string(stringArray);
        }
        public string DegerAl(int index, int step) 
        {
            char[] stringArray = new char[step] ;

            for (int i = 0; i < step; i++)//indexten kac ileri gideceğini sayan for
            {
                stringArray[i] = girdi[index + i];
            }

            return new string(stringArray);
        }
        public string[] DiziyeAyir(char c) 
        {
            string str = girdi;
            List<string> ar = new List<string>();
            string temp = "";

            for (int i = 0,n=ElemanSayisi(str); i < n; i++) //eleman sayisi alindi
            {
                if (str[i] != c) //eger girilen sembol girdide var ise
                {
                    temp += str[i]; 
                    if (i == (n - 1)) //sembole kadari tempe atanir 
                        ar.Add(temp);
                    continue;

                }
                ar.Add(temp);   //sembolden sonrasini tempe atar
                temp = "";
            }
            for(int i=0;i<ar.Count;i++) // bosluklari kaldirir
            {
                ar.Remove("");
            }
            return ar.ToArray();

        }
        public char[] CharDonustur()
        {
            char[] stringArray = new char[ElemanSayisi(girdi)];

            for(int i=0; i< ElemanSayisi(girdi);i++)//girdiden alinan elemanlari char dizisine atiyor
            {
                stringArray[i] = girdi[i];
            }
            return stringArray;
        }
        public int DegerIndis(char c)   
        {
            int index = -1;
           for(int i =0;i<ElemanSayisi(girdi);i++) //kac eleman oldugu sorgulaniyor
            {
                if(girdi[i] == c ) //eger c iye esitse atama yapiyor
                {
                    index= i;
                    break;
                }
            }
            return index;
        }
        public char[] SiralaAZ()
        {
            char temp;
            int elemanSayisi = ElemanSayisi(girdi);
            char[] sirali = CharDonustur();
            
            for (int i = 0; i <= elemanSayisi - 1; i++) // eleman sayisi alindi
            {
                for (int j = i + 1; j < elemanSayisi; j++) 
                {
                    if ((int)sirali[i] > (int)sirali[j]) //sort algoritmasi
                    {
                        temp = sirali[i];
                        sirali[i] = sirali[j];
                        sirali[j] = temp;
                    }
                }
            }

            return sirali;
        }
        public char[] SiralaZA() 
        {
            char temp;
            int elemanSayisi = ElemanSayisi(girdi);
            char[] sirali = CharDonustur();

            for (int i = 0; i <= elemanSayisi - 1; i++)
            {
                for (int j = i + 1; j < elemanSayisi; j++)
                {
                    if ((int)sirali[i] < (int)sirali[j])
                    {
                        temp = sirali[i];
                        sirali[i] = sirali[j];
                        sirali[j] = temp;
                    }
                }
            }

            return sirali;
        }
        public string TersCevir() 
        {

               

                char[] stringArray = CharDonustur();

                string reverse = String.Empty;

                for (int i = ElemanSayisi(new string (stringArray)) - 1; i >= 0; i--) //elemanlar tersten yeni stringe yazdirilir
                {
                    reverse += stringArray[i];
                }

            return reverse;
        }

    }


    class BenimString
    {
        static void Main(string[] args)
        {
            int selection;
            int index;
            while (true)
            {
                Func benimString = new Func();
                Menu menu = new Menu();
                menu.Menu1();


                
                selection = int.Parse(Console.ReadLine());
                if (selection != 2)
                {
                    benimString.GetGirdi();
                }
                switch (selection)//menu secim noktasi
                {
                    case 1:
                        Console.WriteLine("\n Stringin eleman sayisi : " + benimString.ElemanSayisi(benimString.girdi));
                        break;
                    case 2:
                        benimString.Birlestir();

                        break;
                    case 3:
                        
                        string ekle;
                        Console.WriteLine("Eklenecek stringi yaziniz : ");
                        ekle = Console.ReadLine();
                        Console.WriteLine("Kacinci indexe ekleyeceginizi yaziniz : ");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Birlesmis string : " + benimString.ArayaGir(index, ekle));

                        break;
                    case 4:
                        Console.WriteLine("Kacinci indexten alacaginizi yaziniz : ");
                        index = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Kac adim ilerleyeceginizi yaziniz : ");
                        int step = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Birlesmis string : " + benimString.DegerAl(index, step));
                        break;
                    case 5:
                        Console.WriteLine("Ayirilacak sembolu seciniz : ");
                        char ch = Convert.ToChar(Console.ReadLine());
                        string[] str = benimString.DiziyeAyir(ch);
                        foreach( string s in str)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    case 6:
                        char[] array = benimString.CharDonustur();
                        foreach (char list in array)
                        {
                            Console.WriteLine("\n Char : "+ list);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Aranacak index degerini yaziniz : ");
                        char c=Convert.ToChar(Console.ReadLine());
                        Console.WriteLine(benimString.DegerIndis(c));

                        break;
                    case 8:
                        char[] sirali1 = benimString.SiralaAZ();
                        foreach(char sira1 in  sirali1)
                        {
                            Console.WriteLine("A-Z Siralanmis string diziniz ; " + sira1);
                        }

                        break;
                    case 9:
                        char[] sirali2 = benimString.SiralaZA();
                        foreach (char sira2 in sirali2)
                        {
                            Console.WriteLine("ZA Siralanmis string diziniz ; " + sira2);
                        }

                        break;
                    case 10:
                        
                        Console.WriteLine("Ters cevirilmis hali : " + benimString.TersCevir());
                        break;
                    default:
                        Console.WriteLine("Hatali Giris!");
                        break;
                }
                Console.WriteLine("Devam etmek icin herhangi bir tusa basiniz.\n");
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
