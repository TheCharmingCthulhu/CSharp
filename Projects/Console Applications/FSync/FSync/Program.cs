using System;
using System.Linq;
using System.Reflection;
using FSync.Sources;
using FSync.Sources.Win32;

namespace FSync
{
    class Program
    {
        static Sync _sync;
        static SyncSettings _settings;

        static void Main(string[] args)
        {
            Console.WriteLine(string.Format("FSync - Ultimate SSH Tool : Version \"{0}\"", Assembly.GetExecutingAssembly().GetName().Version.ToString()));

            string[] parameters = null;
            do
            {
                Console.Write("$:");

                parameters = ParseLine(Console.ReadLine().ToLower());

                Parse(parameters);

                if (parameters == null) parameters = new string[] {};
            } while (!parameters.Contains("exit"));

            if (_sync != null) _sync.Disconnect();
        }
        
        #region <- Parser ->
        private static string[] ParseLine(string line)
        {
            string args = "";
            bool zip = false;

            for (int i = 0; i < line.Length; i++)
            {
                var index = Convert.ToInt32(line[i]);

                if (index == 32 && !zip)
                    args += '#';
                else if (index == 34)
                {
                    zip = !zip;

                    args += '"';
                }
                else
                    args += line[i];
            }

            return args.Trim('#').Split('#');
        }

        private static void Parse(string[] args)
        {
            if (args == null) return;

            if (ParseUtils(args)) return;
            if (ParseSync(args)) return;

            Console.WriteLine("Invalid arguments!");
        }

        private static bool ParseSync(string[] args)
        {
            if (args.Contains("connect"))
            {
                _settings = new SyncSettings();

                if (!args.Contains("-n"))
                    SyncStorage.LoadSettings(_settings);

                Connect();

                return true;
            }

            if (args.Contains("disconnect"))
            {
                Disconnect();

                return true;
            }

            // Parsing on valid connection!
            if (_sync != null && _sync.IsConnected)
            {
                if (args.Contains("exec"))
                {
                    string[] parameters = args.Count() > 1 ? args.Skip(1).ToArray() : null;

                    if (parameters != null)
                    {
                        var result = _sync.Execute(parameters);

                        Console.WriteLine(result.IsSuccess ? (result.Output != null ? result.Output : "") : "Execution Failed: \"{0}\"", result.ErrorOutput);
                    }

                    return true;
                }
            }
            else Console.WriteLine("No connection has been established!");

            return false;
        }

        private static bool ParseUtils(string[] args)
        {
            if (args.Contains("tray"))
            {
                ConsoleUtils.ShowConsoleWindow(false);

                string message = args.Count() > 1 ? args[1] : "";

                Tray.Run(message);

                ConsoleUtils.ShowConsoleWindow(true);

                return true;
            }

            if (args.Contains("clear") | args.Contains("cls") | args.Contains("clr"))
            {
                Console.Clear();

                return true;
            }

            return false;
        }
        #endregion

        private static void Disconnect()
        {
            _sync.Disconnect();
        }

        private static void Connect()
        {
            if (_settings.Hostname == null)
            {
                Console.Write("Enter Hostname: ");
                _settings.Hostname = Console.ReadLine();
            }

            if (_settings.Username == null)
            {
                Console.Write("Enter Username: ");
                _settings.Username = Console.ReadLine();
            }

            if (_settings.Password == null)
            {
                Console.Write("Enter Password: ");
                _settings.Password = Console.ReadLine();
            }

            SyncStorage.SaveSettings(_settings);

            _sync = new Sync(_settings.Hostname, _settings.Username, _settings.Password);

            if (_sync.Connect(WinSCP.Protocol.Sftp))
                Console.WriteLine("Connection established!");
        }

        internal static string Seperator()
        {
            return string.Format("<{0}>", new String('-', 30));
        }
    }
}
