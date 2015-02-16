using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Provider
{
    public static class Setting
    {
        //1. Отримати шлях до файлу
        //2. Знайти значення параметра ProviderName
        //3. Отримати стрічку підключення

        internal static string ConnectionString
        {
            get
            {
                if (_connection == null)
                    throw new NullReferenceException("не вдалося знайти стрічку підключення");
                return _connection;
            }
        }
        private static string _exePath = GetExePath();
        private static readonly string _connection = GetConnectionStringByProvider(GetConnStrName(), GetProviderName());


        // повертає повний шлях з назвою файлу
        public static string GetExePath()
        {
#if DEBUG
            string applicationName =
                Environment.GetCommandLineArgs()[0];
#else
            string applicationName =
                Environment.GetCommandLineArgs()[0] + ".exe";
#endif

            string exePath = System.IO.Path.Combine(
                Environment.CurrentDirectory, applicationName);



            return exePath.Replace(".exe.exe", ".exe");
        }


        /// <summary>Пошук назви провайдера в файлі конфігурації</summary>
        /// <returns>Текстове представлення властивості ProviderName в appSettings</returns>
        internal static string GetProviderName()
        {
            return GetSettings("ProviderName");
        }
        internal static string GetConnStrName()
        {
            return GetSettings("ConnectionStringName");
        }

        private static string GetSettings(string keyName)
        {
            string value = null;

            try
            {
                Configuration config =
                    ConfigurationManager.OpenExeConfiguration(_exePath);

                AppSettingsSection sections =
                    config.GetSection("appSettings") as AppSettingsSection;

                if (sections != null)
                    foreach (var key in sections.Settings.AllKeys)
                    {
                        if (sections.Settings[key].Key == keyName)
                        {
                            value = sections.Settings[key].Value;
                            break;
                        }
                    }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception ex)
            {
                //_service.ShowError(ex.Message + "\n" + ex.StackTrace);
            }

            return value;
        }
               

        /// <summary>Повертає стрічку підключення в залежності від типу провайдера</summary>
        /// <param name="providerName">Текстове представлення провайдера</param>
        /// <returns>Стрічка підключення</returns>
        private static string GetConnectionStringByProvider(string conStrName, string provName)
        {
            string returnValue = null;

            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                for (int i = 1, len = settings.Count; i < len; i++)
                {
                    if (settings[i].Name == conStrName && settings[i].ProviderName == provName)
                    {
                        returnValue = settings[i].ConnectionString;
                        break;
                    }
                }
            }

            return returnValue;
        }
    }
}
