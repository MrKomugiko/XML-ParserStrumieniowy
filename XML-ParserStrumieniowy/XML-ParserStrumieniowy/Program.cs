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
            int sumawieku = 0;
            int liczbaelementow;
            using (XmlReader reader = XmlReader.Create("test.xml"))
            {
                while (reader.Read())//wczytanie kolejnego węzła   
                {
                    // Sprawdzanie czy jest to element startowy     
                    if (reader.IsStartElement())
                    {
                        // Sprawdzenie nazwy aktualnego węzła  
                        switch (reader.Name)
                        {
                            case "wiek":
                            Console.WriteLine("Start elementu wiek.");
                                // Wczytanie kolejnego elementu – skoro aktualny jest elementem początkowym to następny powinien być treścią elementu.  
                                if (reader.Read())
                                { 
                                    Console.WriteLine("  Zawartosc: " + reader.Value.Trim());
                                }
                                break;
                        }
                    }
                }
            }
        }
    }
}
