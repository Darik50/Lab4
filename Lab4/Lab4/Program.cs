using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите ОС(win, mac, ubuntu):");
                string str = Console.ReadLine();
                if (str == "win")
                {
                    Inp(new WinFactory());
                    WinFactory factory = new WinFactory();
                    // передаем в конструктор тип класса
                    XmlSerializer formatter = new XmlSerializer(typeof(WinFactory));
                    File.Delete("Factory.xml");
                    // получаем поток, куда будем записывать сериализованный объект
                    using (FileStream fs = new FileStream("Factory.xml", FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, factory);
                    }

                    // десериализация
                    using (FileStream fs = new FileStream("Factory.xml", FileMode.OpenOrCreate))
                    {
                        WinFactory newFactory = (WinFactory)formatter.Deserialize(fs);
                    }
                }
                else
                {
                    if (str == "mac")
                    {
                        Inp(new MacFactory());
                        MacFactory factory = new MacFactory();
                        // передаем в конструктор тип класса
                        XmlSerializer formatter = new XmlSerializer(typeof(MacFactory));
                        File.Delete("Factory.xml");
                        // получаем поток, куда будем записывать сериализованный объект
                        using (FileStream fs = new FileStream("Factory.xml", FileMode.OpenOrCreate))
                        {
                            formatter.Serialize(fs, factory);
                        }

                        // десериализация
                        using (FileStream fs = new FileStream("Factory.xml", FileMode.OpenOrCreate))
                        {
                            MacFactory newFactory = (MacFactory)formatter.Deserialize(fs);
                        }
                    }
                    else
                    {
                        if (str == "ubuntu")
                        {
                            Inp(new UbFactory());
                            UbFactory factory = new UbFactory();
                            // передаем в конструктор тип класса
                            XmlSerializer formatter = new XmlSerializer(typeof(UbFactory));
                            File.Delete("Factory.xml");
                            // получаем поток, куда будем записывать сериализованный объект
                            using (FileStream fs = new FileStream("Factory.xml", FileMode.OpenOrCreate))
                            {
                                formatter.Serialize(fs, factory);
                            }

                            // десериализация
                            using (FileStream fs = new FileStream("Factory.xml", FileMode.OpenOrCreate))
                            {
                                UbFactory newFactory = (UbFactory)formatter.Deserialize(fs);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Данной ОС не существует");
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Введены неверные данные");
            }            
            Console.ReadKey();
        }

        static void Inp(IAbstractFactory factory)
        {
            var AutoLoad = factory.TuneAutoLoad();
            var Screen = factory.TuneScreen();
            var Aud = factory.TuneAud();
            var Icon = factory.TuneIcon();
            var DataBase = factory.TuneDataBas();
            var Link = factory.TuneLink();
            var BackMod = factory.TuneBackMod();
            var LoadScreen = factory.TuneLoadScreen();
            var Safe = factory.TuneSafety();
            var Inter = factory.TuneInterf();
            Console.WriteLine("Настройки:");
            AutoLoad.CustAutoLoad();
            Screen.Resol();
            Aud.CustAud();
            Icon.ViewIcon();
            DataBase.CustDataBas();
            Link.CustLink();
            BackMod.CustBackMod();
            LoadScreen.CustLoadScreen();
            Safe.CustSafety();
            Inter.CustInterf();  
        }

    }
}
