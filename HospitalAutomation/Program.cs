using System.Globalization;
using System.Net.NetworkInformation;
using System.Text.Json;

namespace HospitalAutomation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Global.macAddress = GetMacAddress();
            Global._initialTickCount = Environment.TickCount;
            GetCurrentTimeApi();
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("tr-TR");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
            
        }

        private static void GetCurrentTimeApi()
        {
            using (HttpClient client = new HttpClient())
            {
                string apiKey = "MNPAG3GJD4FY";
                string url = $"http://api.timezonedb.com/v2.1/get-time-zone?key={apiKey}&format=json&by=zone&zone=Europe/Istanbul";

                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;

                var jsonDocument = JsonDocument.Parse(responseBody);
                string currentTimeString = jsonDocument.RootElement.GetProperty("formatted").GetString()!;

                Global._initialTime = DateTime.Parse(currentTimeString);
            }
        }
        static string GetMacAddress()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up &&
                    (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                     nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211))
                {
                    return nic.GetPhysicalAddress().ToString();
                }
            }
            return string.Empty;
        }
        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            ErrorLogger.LogError(e.Exception);
        }

        // Background thread veya yakalanmamýþ hatalarý yakalar
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            ErrorLogger.LogError(e.ExceptionObject as Exception);
        }
    }
}