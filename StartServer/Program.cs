using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StartServer
{
    internal class Program
    {
        private static string programPath = @"C:\Flyff\Program\";
        private static bool StateAccount = false;
        private static bool StateCertifier = false;
        private static bool StateDatabase = false;
        private static bool StateCore = false;
        private static bool StateLogin = false;
        private static bool StateCache = false;
        private static bool StateWorld = false;

        static void Main(string[] args)
        {
            Console.Title = "FlyFF - Serverstarter";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("[" + DateTime.Now + "][TOOL] - [s] START SERVER , [c] - STOP SERVER, [r] - RESTART SERVER, [q] - CLOSE PROGAM");
            _serverList(true);
            int key;
            while ((key = Console.Read()) != 'q')
            {
                if (key == 's')
                {
                    _initServerStartAll();
                } else if (key == 'c')
                {
                    _initCloseServer();
                } else if (key == 'r')
                {
                    _initRestartServer();
                }
            }
        }

        private static void _serverList(bool Output)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[" + DateTime.Now + "][TOOL] - CHECK SERVER STATUS - START");
            for (int i = 0; i < 8; i++)
            {
                if (i == 1)
                {
                    if (_checkServerState("AccountServer", Output))
                    {
                        StateAccount = true;
                    }
                    else
                    {
                        StateAccount = false;
                    }
                }
                else if (i == 2)
                {
                    if (_checkServerState("Certifier", Output))
                    {
                        StateCertifier = true;
                    }
                    else
                    {
                        StateCertifier = false;
                    }
                }
                else if (i == 3)
                {
                    if (_checkServerState("DatabaseServer", Output))
                    {
                        StateDatabase = true;
                    }
                    else
                    {
                        StateDatabase = false;
                    }
                }
                else if (i == 4)
                {
                    if (_checkServerState("CoreServer", Output))
                    {
                        StateCore = true;
                    }
                    else
                    {
                        StateCore = false;
                    }
                }
                else if (i == 5)
                {
                    if (_checkServerState("LoginServer", Output))
                    {
                        StateLogin = true;
                    }
                    else
                    {
                        StateLogin = false;
                    }
                }
                else if (i == 6)
                {
                    if (_checkServerState("CacheServer", Output))
                    {
                        StateCache = true;
                    }
                    else
                    {
                        StateCache = false;
                    }
                }
                else if (i == 7)
                {
                    if (_checkServerState("WorldServer", Output))
                    {
                        StateWorld = true;
                    }
                    else
                    {
                        StateWorld = false;
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("[" + DateTime.Now + "][TOOL] - CHECK SERVER STATUS - END");
        }

        private static bool _checkServerState(String srvr, bool Output)
        {
         
            Process[] Server = Process.GetProcessesByName(srvr);
            if (Server.Length == 0)
            {
                if (Output)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[" + DateTime.Now.ToString() + "][TOOL] - " + srvr + " OFFLINE");
                }
                return false;
            }
            else
            {
                if (Output)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("[" + DateTime.Now.ToString() + "][TOOL] - " + srvr + " ONLINE");
                }
                return true;
            }
        }

        private static void _initServerStartAll()
        {
            /* ---------------- ACCOUNT SERVER ---------------- */
            if (!StateAccount)
            {
                Process AccountServer = new Process();
                AccountServer.StartInfo.FileName = programPath + "AccountServer.exe";
                AccountServer.StartInfo.WorkingDirectory = programPath;
                AccountServer.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                AccountServer.Start();
                AccountServer.WaitForInputIdle();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[" + DateTime.Now.ToString() + "][TOOL] - ACCOUNT SERVER STARTED");
                StateAccount = true;
            }

            /* ---------------- CERTIFIER SERVER ---------------- */
            if (!StateCertifier)
            {
                Process Certifier = new Process();
                Certifier.StartInfo.FileName = programPath + "Certifier.exe";
                Certifier.StartInfo.WorkingDirectory = programPath;
                Certifier.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                Certifier.Start();
                Certifier.WaitForInputIdle();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[" + DateTime.Now.ToString() + "][TOOL] - CERTIFIER SERVER STARTED");
                StateCertifier = true;
            }

            /* ---------------- DATABASE SERVER ---------------- */
            if (!StateDatabase)
            {
                Process DatabaseServer = new Process();
                DatabaseServer.StartInfo.FileName = programPath + "DatabaseServer.exe";
                DatabaseServer.StartInfo.WorkingDirectory = programPath;
                DatabaseServer.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                DatabaseServer.Start();
                DatabaseServer.WaitForInputIdle();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[" + DateTime.Now.ToString() + "][TOOL] - DATABASE SERVER STARTED");
                StateDatabase = true;
            }

            /* ---------------- CORE SERVER ---------------- */
            if (!StateCore)
            {
                Process CoreServer = new Process();
                CoreServer.StartInfo.FileName = programPath + "CoreServer.exe";
                CoreServer.StartInfo.WorkingDirectory = programPath;
                CoreServer.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                CoreServer.Start();
                CoreServer.WaitForInputIdle();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[" + DateTime.Now.ToString() + "][TOOL] - CORE SERVER STARTED");
                StateCore = true;
            }

            /* ---------------- LOGIN SERVER ---------------- */
            if (!StateLogin)
            {
                Process LoginServer = new Process();
                LoginServer.StartInfo.FileName = programPath + "LoginServer.exe";
                LoginServer.StartInfo.WorkingDirectory = programPath;
                LoginServer.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                LoginServer.Start();
                LoginServer.WaitForInputIdle();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[" + DateTime.Now.ToString() + "][TOOL] - LOGIN SERVER STARTED");
                StateLogin = true;
            }


            /* ---------------- CACHE SERVER ---------------- */
            if (!StateCache)
            {
                Process CacheServer = new Process();
                CacheServer.StartInfo.FileName = programPath + "CacheServer.exe";
                CacheServer.StartInfo.WorkingDirectory = programPath;
                CacheServer.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                CacheServer.Start();
                CacheServer.WaitForInputIdle();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[" + DateTime.Now.ToString() + "][TOOL] - CACHE SERVER STARTED");
                StateCache = true;
            }

            /* ---------------- WORLD SERVER ---------------- */
            if (!StateWorld)
            {
                Process WorldServer = new Process();
                WorldServer.StartInfo.FileName = programPath + "WorldServer.exe";
                WorldServer.StartInfo.WorkingDirectory = programPath;
                WorldServer.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                WorldServer.Start();
                WorldServer.WaitForInputIdle();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("[" + DateTime.Now.ToString() + "][TOOL] - WORLD SERVER STARTED");
                StateWorld = true;
            }
        }

        private static bool _initServerStart(String Srvr)
        {
            Process Server = new Process();
            Server.StartInfo.FileName = @"C:\Flyff\Program\" + Srvr + ".exe";
            Server.StartInfo.WorkingDirectory = programPath;
            Server.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Server.Start();
            Server.WaitForInputIdle();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("[" + DateTime.Now.ToString() + "][TOOL] - " + Srvr + " started");
            return true;
        }

        private static void _initServerStop(String srvr)
        {
            Process[] localByName = Process.GetProcessesByName(srvr);
            foreach (Process p in localByName)
            {
                p.Kill();
                p.WaitForExit();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[" + DateTime.Now.ToString() + "][TOOL] - " + srvr + " STOPPED");
        }


        private static void _initCloseServer()
        {
            if (StateWorld)
            {
                _initServerStop("WorldServer");
                StateWorld = false;
            }
            if (StateCache)
            {
                _initServerStop("CacheServer");
                StateCache = false;
            }
            if (StateLogin)
            {
                _initServerStop("LoginServer");
                StateLogin = false;
            }
            if (StateCore)
            {
                _initServerStop("CoreServer");
                StateCore = false;
            }
            if (StateDatabase)
            {
                _initServerStop("DatabaseServer");
                StateDatabase = false;
            }
            if (StateCertifier)
            {
                _initServerStop("Certifier");
                StateCertifier = false;
            }
            if (StateAccount)
            {
                _initServerStop("AccountServer");
                StateAccount = false;
            }
        }

      

        private static void _initRestartServer()
        {
            _initCloseServer();
            Thread.Sleep(100);
            _initServerStartAll();
        }
    }
}
