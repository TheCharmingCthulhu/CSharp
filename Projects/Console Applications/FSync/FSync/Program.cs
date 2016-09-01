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
        static SyncLog _log = new SyncLog();

        static void Main(string[] args)
        {
            Initialize();

            string[] parameters = null;
            do
            {
                Console.Write("$:");

                parameters = ParseLine(Console.ReadLine().ToLower());

                Parse(parameters);

                if (parameters == null) parameters = new string[] {};
            } while (!parameters.Contains("exit"));

            if (_sync != null) _sync.Disconnect();
            if (_log != null) _log.Dispose();
        }

        private static void Initialize()
        {
            Console.Title = string.Format("FSync - Ultimate SSH Tool : Version \"{0}\"", Assembly.GetExecutingAssembly().GetName().Version.ToString());

            ConsoleUtils.OnExit(() => {
                Console.WriteLine("\nApplication succesfully terminated : Saving...");

                _log.Dispose();
            });
        }
    
        private static void Log(string description, SyncLog.LogType type = SyncLog.LogType.Info)
        {
            Console.WriteLine(string.Format("[{0}]: {1}", DateTime.Now, description));

            _log.Push(type, description);
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

            if (_sync == null)
            {
                Log("No connection! : Use \"connect -n\" for a new connection.", SyncLog.LogType.Warning);

                return;
            }

            Log("Invalid arguments!", SyncLog.LogType.Error);
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

            if (_sync != null && _sync.IsConnected)
            {
                if (args.Contains("disconnect"))
                {
                    Disconnect();

                    Log("Session disconnected!");

                    return true;
                }

                if (args.Contains("execute") | args.Contains("exec") | args.Contains("->"))
                {
                    return ParseArguments(args, (x) =>
                    {
                        var result = _sync.Execute(x);

                        Log(string.Format(result.IsSuccess ? string.Format("({0}>\"{1}\")", _settings.Hostname, (result.Output != null ? result.Output : "")) 
                            : "Execution Failed: \"{0}\"", result.ErrorOutput), result.IsSuccess ? SyncLog.LogType.Info : SyncLog.LogType.Error);
                    });
                }

                if (args.Contains("sync"))
                {
                    return ParseArguments(args, (x) =>
                    {
                        if (x.Length == 3)
                        {
                            WinSCP.SynchronizationResult result = null;

                            if (x.Contains("--local"))
                                result = _sync.Synchronize(WinSCP.SynchronizationMode.Local, x[1], x[2], x.Length == 4 ? x[3] : "");

                            if (x.Contains("--remote"))
                            {

                            }

                            if (x.Contains("--both"))
                            {

                            }


                            PrintResults(result);
                        }
                        else Log("Command: \"sync -l\" has missing parameters!", SyncLog.LogType.Error);
                    });
                }
            }

            return false;
        }

        private static void PrintResults(WinSCP.SynchronizationResult result)
        {
            Log(string.Format("Sync complete : Downloads {0} : Uploads {1} : Removed {2} : Failures {3}", 
                result.Downloads.Count, result.Uploads.Count, result.Removals.Count, result.Failures.Count));
        }

        private static bool ParseArguments(string[] args, Action<string[]> callback)
        {
            string[] parameters = args.Count() > 1 ? args.Skip(1).ToArray() : null;

            if (parameters != null)
            {
                callback?.Invoke(parameters);

                return true;
            }

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
                Log("Connection established!");
        }

        internal static string Seperator()
        {
            return string.Format("<{0}>", new string('-', 30));
        }
    }
}
