﻿using System;

namespace Hazır_Metotlar_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp,Hoşgeldiniz!";
            string degisken2 = "CSharp";
            //Length;
            Console.WriteLine(degisken.Length);
            //ToUpper,ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            //Concat (Birleştirir)
            Console.WriteLine(String.Concat(degisken, "Merhaba!"));

            //Compare,CompareTo 
            //degisken1=degisken2(karakter sayısı)=>0
            //degisken1>degisken2=>1
            //degisken1<degisken2=>-1
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(String.Compare(degisken, degisken2, true));//true ise büyük küçük harf duyarsız.
            Console.WriteLine(String.Compare(degisken, degisken2, false));//false ise büyük küçük harf duyarlı.
                                                                          //Contains
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));
            //IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Zikriye"));
            Console.WriteLine(degisken.LastIndexOf("i"));
            //Insert 
            Console.WriteLine(degisken.Insert(0, "Merhaba!"));
            //PadLeft,PadRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));//Boşluk sayısı+karakter sayısı kadar soldan boşluk bırakır.
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken2);
            //Remove
            Console.WriteLine(degisken.Remove(10)); //10.indexten sonrasını sil
            Console.WriteLine(degisken.Remove(5,3)); //5.karakterden sonraki 3 karakteri sil
            Console.WriteLine(degisken.Remove(0,1)); //0.karakterden itibaren 1 karakter sil. 
            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace("","*"));
            //Split
            Console.WriteLine(degisken.Split(' ')[1]);
            //Substring
            Console.WriteLine(degisken.Substring(4));//4.indexten sonuna kadar getirir.
            Console.WriteLine(degisken.Substring(4,6));//4.indexten itibaren 6 karakter getirir. 


        }
    }
}
