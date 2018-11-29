﻿using System;
using System.Runtime.InteropServices;

namespace Microsoft.Diagnostics.Runtime.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WINDBG_EXTENSION_APIS/*32 or 64; both are defined the same in managed code*/
    {
        public UInt32 nSize;
        public IntPtr lpOutputRoutine;
        public IntPtr lpGetExpressionRoutine;
        public IntPtr lpGetSymbolRoutine;
        public IntPtr lpDisasmRoutine;
        public IntPtr lpCheckControlCRoutine;
        public IntPtr lpReadProcessMemoryRoutine;
        public IntPtr lpWriteProcessMemoryRoutine;
        public IntPtr lpGetThreadContextRoutine;
        public IntPtr lpSetThreadContextRoutine;
        public IntPtr lpIoctlRoutine;
        public IntPtr lpStackTraceRoutine;
    }
}