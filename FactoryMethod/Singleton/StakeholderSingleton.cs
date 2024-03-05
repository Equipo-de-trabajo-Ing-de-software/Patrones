using System.Text;

namespace Singleton
{
    public class StakeholderSingleton
    {
        private static StakeholderSingleton _instance;

        public Guid Id { get; set; }
        public string Password { get; set; }

        public static string GetRandomPassword(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        private StakeholderSingleton()
        {
            Id = Guid.NewGuid();
            int length = 10;
            Password = GetRandomPassword(length);
          
        }

        public static StakeholderSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new StakeholderSingleton();
            }
            return _instance;
        }
    }
}