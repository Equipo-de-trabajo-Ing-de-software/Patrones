using System.Text;

namespace Singleton
{
    public class GeneradorInformesSingleton
    {
        private static GeneradorInformesSingleton _instance;
        public string Data { get; set; }

        private GeneradorInformesSingleton()
        {
            Data = ("Plantilla Unica Para Generar Informes");
        }

        public static GeneradorInformesSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GeneradorInformesSingleton();
            }
            return _instance;
        }
    }
}