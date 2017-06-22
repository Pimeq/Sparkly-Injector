using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Injector
{
    public class CheatInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class ProcessInfo
    {
        public Process process;
        private string limit(string input, int limit)
        {
            if (input.Length > limit)
                    return input.Substring(0, limit) + "...";
                return input;
        }
        public string info
        {
            get
            {
                if (process == null)
                    return null;

                string name;
                if (process.MainWindowTitle == "")
                    name = $"{limit(process.ProcessName, 30)}.exe ";
                else
                    name = $"{limit(process.MainWindowTitle, 20)} ({limit(process.ProcessName, 10)}.exe)";

                try
                {
                    name = name.PadRight(40) + $"\t[{process.Id}]";
                }
                catch { }
                return name;
            }
        }

        public override string ToString()
        {
            return info;
        }
    }

    public class Wav
    {
        [Flags]
        public enum SoundFlags
        {
            /// <summary>play synchronously (default)</summary>
            SND_SYNC = 0x0000,
            /// <summary>play asynchronously</summary>
            SND_ASYNC = 0x0001,
            /// <summary>silence (!default) if sound not found</summary>
            SND_NODEFAULT = 0x0002,
            /// <summary>pszSound points to a memory file</summary>
            SND_MEMORY = 0x0004,
            /// <summary>loop the sound until next sndPlaySound</summary>
            SND_LOOP = 0x0008,
            /// <summary>don't stop any currently playing sound</summary>
            SND_NOSTOP = 0x0010,
            /// <summary>Stop Playing Wave</summary>
            SND_PURGE = 0x40,
            /// <summary>don't wait if the driver is busy</summary>
            SND_NOWAIT = 0x00002000,
            /// <summary>name is a registry alias</summary>
            SND_ALIAS = 0x00010000,
            /// <summary>alias is a predefined id</summary>
            SND_ALIAS_ID = 0x00110000,
            /// <summary>name is file name</summary>
            SND_FILENAME = 0x00020000,
            /// <summary>name is resource name or atom</summary>
            SND_RESOURCE = 0x00040004
        }

        [DllImport("winmm.dll", SetLastError = true)]
        static extern bool PlaySound(string pszSound, UIntPtr hmod, uint fdwSound);

        public static bool Play(string wavFileName)
        {
            try
            {
                return PlaySound(wavFileName, UIntPtr.Zero, (uint) SoundFlags.SND_ASYNC);
            }
            catch
            {
                return false;
            }
        }
    }
}
