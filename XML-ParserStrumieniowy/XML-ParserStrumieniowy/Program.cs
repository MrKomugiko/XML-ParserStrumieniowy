using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_ParserStrumieniowy
{
    class Program
    {
        static void Main(string[] args)
        {
            string plec = "";
            //--------------------------
            int wiekK = 0;
            float sumawiekuK = 0;
            float liczK = 0;
            //-------------------------
            int wiekM = 0;
            float sumawiekuM = 0;
            float liczM = 0;
            
            using (XmlReader reader = XmlReader.Create("..//..//Pliki XML/test.xml"))
            {
                while (reader.Read())//wczytanie kolejnego węzła   
                {
                    // Sprawdzanie czy jest to element startowy     
                    if (reader.IsStartElement())
                    {
                        // Sprawdzenie nazwy aktualnego węzła  
                        if (reader.Name == "plec")
                        {
                            if (reader.Read()){
                                plec = reader.Value.Trim();
                                if (plec == "K")
                                {
                                        liczK++;
                                        Console.WriteLine("  Zawartosc: " + plec + " Kobieta nr.[" + liczK + "]");
                                }
                                else
                                if (plec == "M")
                                {
                                        liczM++;
                                        Console.WriteLine("  Zawartosc: " + plec + " Kobieta nr.[" + liczM + "]");
                                }
                            }
                        }
                        if (reader.Name == "wiek")
                        {
                            if (reader.Read()){
                                if (plec == "K")
                                {
                                        wiekK = Convert.ToInt32(reader.Value.Trim());
                                        Console.WriteLine("  WiekK: " + wiekK);
                                        sumawiekuK += wiekK;
                                }
                                else
                                if (plec == "M")
                                {
                                        wiekM = Convert.ToInt32(reader.Value.Trim());
                                        Console.WriteLine("  WiekM: " + wiekM);
                                        sumawiekuM += wiekM;
                                }
                            }
                        }
                    }
                }
            }
            float sredniaK = sumawiekuK / liczK;
            Console.WriteLine("Kobiet: {0}", liczK);
            Console.WriteLine("Łączny wiek kobiet {0}", sumawiekuK);
            Console.WriteLine("Średnia wieku kobiet {0}", sredniaK); 
           
            float sredniaM = sumawiekuM / liczM;
            Console.WriteLine("Mezczyzn: {0}", liczM);
            Console.WriteLine("Łączny wiek Mezczyzn {0}", sumawiekuM);
            Console.WriteLine("Średnia wieku Mezczyzn {0}", sredniaM);
            Console.Read();
        }
    }
}
