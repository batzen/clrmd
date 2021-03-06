// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Runtime.InteropServices;

namespace Microsoft.Diagnostics.Runtime.ICorDebug
{
    [ComImport]
    [InterfaceType(1)]
    [Guid("CC7BCAF9-8A68-11D2-983C-0000F808342D")]
    public interface ICorDebugReferenceValue : ICorDebugValue
    {
        new void GetType([Out] out CorElementType pType);

        new void GetSize([Out] out uint pSize);

        new void GetAddress([Out] out ulong pAddress);

        new void CreateBreakpoint(
            [Out][MarshalAs(UnmanagedType.Interface)]
            out ICorDebugValueBreakpoint ppBreakpoint);

        void IsNull([Out] out int pbNull);

        void GetValue([Out] out ulong pValue);

        void SetValue([In] ulong value);

        void Dereference(
            [Out][MarshalAs(UnmanagedType.Interface)]
            out ICorDebugValue ppValue);

        void DereferenceStrong(
            [Out][MarshalAs(UnmanagedType.Interface)]
            out ICorDebugValue ppValue);
    }
}