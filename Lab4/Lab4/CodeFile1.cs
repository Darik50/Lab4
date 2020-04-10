using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AbstractFactory
{
    /// <summary>
    /// Интерфейс абстрактной фабрики.
    /// </summary>
    public interface IAbstractFactory
    {
        Screen TuneScreen();
        Icon TuneIcon();
        Interf TuneInterf();
        Aud TuneAud();
        DataBas TuneDataBas();
        Link TuneLink();
        AutoLoad TuneAutoLoad();
        BackMod TuneBackMod();
        LoadScreen TuneLoadScreen();
        Safety TuneSafety();

    }
    /// <summary>
    /// Класс для семейства Win.
    /// </summary>
    [Serializable]
    public class WinFactory : IAbstractFactory
    {
        public Screen TuneScreen()
        {
            return new WinScreen();
        }
        public Icon TuneIcon()
        {
            return new WinIcon();
        }
        public Interf TuneInterf()
        {
            return new WinInterf();
        }
        public Aud TuneAud()
        {
            return new WinAud();
        }
        public DataBas TuneDataBas()
        {
            return new WinDataBas();
        }
        public Link TuneLink()
        {
            return new WinLink();
        }
        public AutoLoad TuneAutoLoad()
        {
            return new WinAutoLoad();
        }
        public BackMod TuneBackMod()
        {
            return new WinBackMod();
        }
        public LoadScreen TuneLoadScreen()
        {
            return new WinLoadScreen();
        }
        public Safety TuneSafety()
        {
            return new WinSafety();
        } 
    }
    /// <summary>
    /// Класс для семейства Mac.
    /// </summary>
    [Serializable]
    public class MacFactory : IAbstractFactory
    {
        public Screen TuneScreen()
        {
            return new MacScreen();
        }
        public Icon TuneIcon()
        {
            return new MacIcon();
        }
        public Interf TuneInterf()
        {
            return new MacInterf();
        }
        public Aud TuneAud()
        {
            return new MacAud();
        }
        public DataBas TuneDataBas()
        {
            return new MacDataBas();
        }
        public Link TuneLink()
        {
            return new MacLink();
        }
        public AutoLoad TuneAutoLoad()
        {
            return new MacAutoLoad();
        }
        public BackMod TuneBackMod()
        {
            return new MacBackMod();
        }
        public LoadScreen TuneLoadScreen()
        {
            return new MacLoadScreen();
        }
        public Safety TuneSafety()
        {
            return new MacSafety();
        }

    }
    /// <summary>
    /// Класс для семейства Ubuntu.
    /// </summary>
    [Serializable]
    public class UbFactory : IAbstractFactory
    {
        public Screen TuneScreen()
        {
            return new UbScreen();
        }
        public Icon TuneIcon()
        {
            return new UbIcon();
        }
        public Interf TuneInterf()
        {
            return new UbInterf();
        }
        public Aud TuneAud()
        {
            return new UbAud();
        }
        public DataBas TuneDataBas()
        {
            return new UbDataBas();
        }
        public Link TuneLink()
        {
            return new UbLink();
        }
        public AutoLoad TuneAutoLoad()
        {
            return new UbAutoLoad();
        }
        public BackMod TuneBackMod()
        {
            return new UbBackMod();
        }
        public LoadScreen TuneLoadScreen()
        {
            return new UbLoadScreen();
        }
        public Safety TuneSafety()
        {
            return new UbSafety();
        }

    }
    /// <summary>
    /// Интерфейс настройки разрешения экрана.
    /// </summary>
    public interface Screen
    {
        void Resol();
    }
    /// <summary>
    /// Класс настройки разрешения экрана win.
    /// </summary>
    [Serializable]
    public class WinScreen : Screen
    { 
        public void Resol()
        {
            Console.WriteLine("Разрешение экрана для Win");
        }
    }

    /// <summary>
    /// Класс настройки разрешения экрана mac.
    /// </summary>
    public class MacScreen : Screen
    {
        public void Resol()
        {
            Console.WriteLine("Разрешение экрана для Mac");
        }
    }

    /// <summary>
    /// Класс настройки разрешения экрана ub.
    /// </summary>
    public class UbScreen : Screen
    {
        public void Resol()
        {
            Console.WriteLine("Разрешение экрана для Ubuntu");
        }
    }
    /// <summary>
    /// Интерфейс настройки иконки ОС.
    /// </summary>
    public interface Icon
    {
        void ViewIcon();
    }
    /// <summary>
    /// Класс настройки иконки win.
    /// </summary>
    public class WinIcon : Icon
    {
        public void ViewIcon()
        {
            Console.WriteLine("Иконка для Win");
        }
    }

    /// <summary>
    /// Класс настройки иконки win.
    /// </summary>
    public class MacIcon : Icon
    {
        public void ViewIcon()
        {
            Console.WriteLine("Иконка для Mac");
        }
    }
    /// <summary>
    /// Класс настройки иконки win.
    /// </summary>
    public class UbIcon : Icon
    {
        public void ViewIcon()
        {
            Console.WriteLine("Иконка для Ubuntu");
        }
    }
    /// <summary>
    /// Интерфейс настройки интерфейса ОС.
    /// </summary>
    public interface Interf
    {
        void CustInterf();
    }
    /// <summary>
    /// Класс настройки интерфейса win.
    /// </summary>
    public class WinInterf : Interf
    {
        public void CustInterf()
        {
            Console.WriteLine("Интерфейс для Win");
        }
    }
    /// <summary>
    /// Класс настройки интерфейса Mac.
    /// </summary>
    public class MacInterf : Interf
    {
        public void CustInterf()
        {
            Console.WriteLine("Интерфейс для Mac");
        }
    }
    /// <summary>
    /// Класс настройки интерфейса Ubuntu.
    /// </summary>
    public class UbInterf : Interf
    {
        public void CustInterf()
        {
            Console.WriteLine("Интерфейс для Ubuntu");
        }
    }
    /// <summary>
    /// Интерфейс настройки музыкального фона ОС.
    /// </summary>
    public interface Aud
    {
        void CustAud();
    }
    /// <summary>
    /// Класс настройки музыкального фона win.
    /// </summary>
    public class WinAud : Aud
    {
        public void CustAud()
        {
            Console.WriteLine("Музыка для Win");
        }
    }
    /// <summary>
    /// Класс настройки музыкального фона Mac.
    /// </summary>
    public class MacAud : Aud
    {
        public void CustAud()
        {
            Console.WriteLine("Музыка для Mac");
        }
    }
    /// <summary>
    /// Класс настройки музыкального фона Ubuntu.
    /// </summary>
    public class UbAud : Aud
    {
        public void CustAud()
        {
            Console.WriteLine("Музыка для Ubuntu");
        }
    }
    /// <summary>
    /// Интерфейс настройки БД ОС.
    /// </summary>
    public interface DataBas
    {
        void CustDataBas();
    }
    /// <summary>
    /// Класс настройки БД win.
    /// </summary>
    public class WinDataBas : DataBas
    {
        public void CustDataBas()
        {
            Console.WriteLine("База данных для Win");
        }
    }
    /// <summary>
    /// Класс настройки БД Mac.
    /// </summary>
    public class MacDataBas : DataBas
    {
        public void CustDataBas()
        {
            Console.WriteLine("База данных для Mac");
        }
    }
    /// <summary>
    /// Класс настройки БД Ubuntu.
    /// </summary>
    public class UbDataBas : DataBas
    {
        public void CustDataBas()
        {
            Console.WriteLine("База данных для Ubuntu");
        }
    }
    /// <summary>
    /// Интерфейс настройки ссылок ОС.
    /// </summary>
    public interface Link
    {
        void CustLink();
    }
    /// <summary>
    /// Класс настройки ссылок win.
    /// </summary>
    public class WinLink : Link
    {
        public void CustLink()
        {
            Console.WriteLine("Ссылки для Win");
        }
    }
    /// <summary>
    /// Класс настройки ссылок Mac.
    /// </summary>
    public class MacLink : Link
    {
        public void CustLink()
        {
            Console.WriteLine("Ссылки для Mac");
        }
    }
    /// <summary>
    /// Класс настройки ссылок Ubuntu.
    /// </summary>
    public class UbLink : Link
    {
        public void CustLink()
        {
            Console.WriteLine("Ссылки для Ubuntu");
        }
    }
    /// <summary>
    /// Интерфейс настройки автозагрузки ОС.
    /// </summary>
    public interface AutoLoad
    {
        void CustAutoLoad();
    }   
    /// <summary>
    /// Класс настройки автозагрузки win.
    /// </summary>
    public class WinAutoLoad : AutoLoad
    {
        public void CustAutoLoad()
        {
            Console.WriteLine("Автозагрузки для Win");
        }
    }
    /// <summary>
    /// Класс настройки автозагрузки Mac.
    /// </summary>
    public class MacAutoLoad : AutoLoad
    {
        public void CustAutoLoad()
        {
            Console.WriteLine("Автозагрузки для Mac");
        }
    }
    /// <summary>
    /// Класс настройки автозагрузки Ubuntu.
    /// </summary>
    public class UbAutoLoad : AutoLoad
    {
        public void CustAutoLoad()
        {
            Console.WriteLine("Автозагрузки для Ubuntu");
        }
    }
    /// <summary>
    /// Интерфейс настройки фоновой работы ОС.
    /// </summary>
    public interface BackMod
    {
        void CustBackMod();
    }
    /// <summary>
    /// Класс настройки фоновый режим win.
    /// </summary>
    public class WinBackMod : BackMod
    {
        public void CustBackMod()
        {
            Console.WriteLine("Фоновый режим для Win");
        }
    }
    /// <summary>
    /// Класс настройки фоновый режим Mac.
    /// </summary>
    public class MacBackMod : BackMod
    {
        public void CustBackMod()
        {
            Console.WriteLine("Фоновый режим для Mac");
        }
    }
    /// <summary>
    /// Класс настройки фоновый режим Ubuntu.
    /// </summary>
    public class UbBackMod : BackMod
    {
        public void CustBackMod()
        {
            Console.WriteLine("Фоновый режим для Ubuntu");
        }
    }
    /// <summary>
    /// Интерфейс настройки экрана загрузки ОС.
    /// </summary>
    public interface LoadScreen
    {
        void CustLoadScreen();
    }
    /// <summary>
    /// Класс настройки экрана загрузки win.
    /// </summary>
    public class WinLoadScreen : LoadScreen
    {
        public void CustLoadScreen()
        {
            Console.WriteLine("Экрана загрузки для Win");
        }
    }
    /// <summary>
    /// Класс настройки экрана загрузки Mac.
    /// </summary>
    public class MacLoadScreen : LoadScreen
    {
        public void CustLoadScreen()
        {
            Console.WriteLine("Экрана загрузки для Mac");
        }
    }
    /// <summary>
    /// Класс настройки экрана загрузки Ubuntu.
    /// </summary>
    public class UbLoadScreen : LoadScreen
    {
        public void CustLoadScreen()
        {
            Console.WriteLine("Экрана загрузки для Ubuntu");
        }
    }
    /// <summary>
    /// Интерфейс настройки безопасности ОС.
    /// </summary>
    public interface Safety
    {
        void CustSafety();
    }
    /// <summary>
    /// Класс настройки безопасности win.
    /// </summary>
    public class WinSafety : Safety
    {
        public void CustSafety()
        {
            Console.WriteLine("Настройки безопасности для Win");
        }
    }
    /// <summary>
    /// Класс настройки безопасности Mac.
    /// </summary>
    public class MacSafety : Safety
    {
        public void CustSafety()
        {
            Console.WriteLine("Настройки безопасности для Mac");
        }
    }
    /// <summary>
    /// Класс настройки безопасности Ubuntu.
    /// </summary>
    public class UbSafety : Safety
    {
        public void CustSafety()
        {
            Console.WriteLine("Настройки безопасности для Ubuntu");
        }
    }

}