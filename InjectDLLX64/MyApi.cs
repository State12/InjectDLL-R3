using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace InjectDLLX64
{
    class MyApi
    {
        [DllImport("WayX64.dll", EntryPoint = "ThreadInject", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]

        public static extern int ThreadInject(uint ProcessId,string DLLPath,int dwSize);

        [DllImport("WayX64.dll", EntryPoint = "MemoryInject", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]

        public static extern int MemoryInject(uint ProcessId, string DLLPath, int dwSize);
    }
}
