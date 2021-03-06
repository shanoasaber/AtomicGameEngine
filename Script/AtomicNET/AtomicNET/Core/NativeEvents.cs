using System;
using System.Runtime.InteropServices;

namespace AtomicEngine
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void EventDispatchDelegate(IntPtr sender, uint eventType, IntPtr eventData);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void UpdateDispatchDelegate(float timeStep);

    public delegate void EventDelegate(uint eventType, ScriptVariantMap eventData);

    public delegate void SenderEventDelegate(AObject sender, uint eventType, ScriptVariantMap eventData);

    public delegate void HandleUpdateDelegate(float timeStep);

    [StructLayout(LayoutKind.Sequential)]
    public struct CoreDelegates
    {
        [MarshalAs(UnmanagedType.FunctionPtr)]
        public EventDispatchDelegate eventDispatch;

        [MarshalAs(UnmanagedType.FunctionPtr)]
        public UpdateDispatchDelegate updateDispatch;
    }

    public partial class ScriptVariantMap
    {
        public void CopyVariantMap(IntPtr vm)
        {
            csi_Atomic_AtomicNET_ScriptVariantMapCopyVariantMap(nativeInstance, vm);
        }

        [DllImport(Constants.LIBNAME, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern IntPtr csi_Atomic_AtomicNET_ScriptVariantMapCopyVariantMap(IntPtr svm, IntPtr vm);

    }

}