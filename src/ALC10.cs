using System;
using System.Runtime.InteropServices;
using NativeLibraryLoader;

namespace OpenAL
{
    public static class ALC10
    {
        /* typedef int ALenum; */
        public const int ALC_FALSE = 0x0000;
        public const int ALC_TRUE = 0x0001;
        public const int ALC_FREQUENCY = 0x1007;
        public const int ALC_REFRESH = 0x1008;
        public const int ALC_SYNC = 0x1009;

        public const int ALC_NO_ERROR = 0x0000;
        public const int ALC_INVALID_DEVICE = 0xA001;
        public const int ALC_INVALID_CONTEXT = 0xA002;
        public const int ALC_INVALID_ENUM = 0xA003;
        public const int ALC_INVALID_VALUE = 0xA004;
        public const int ALC_OUT_OF_MEMORY = 0xA005;

        public const int ALC_ATTRIBUTES_SIZE = 0x1002;
        public const int ALC_ALL_ATTRIBUTES = 0x1003;
        public const int ALC_DEFAULT_DEVICE_SPECIFIER = 0x1004;
        public const int ALC_DEVICE_SPECIFIER = 0x1005;
        public const int ALC_EXTENSIONS = 0x1006;

        private delegate IntPtr alcCreateContext_IntPtr_int___t(
                    IntPtr device,
                    int[] attrList
                );

        private static alcCreateContext_IntPtr_int___t s_alcCreateContext_IntPtr_int___t = __LoadFunction<alcCreateContext_IntPtr_int___t>("alcCreateContext");

        public static IntPtr alcCreateContext(
IntPtr device,
int[] attrList
) => s_alcCreateContext_IntPtr_int___t(device, attrList);

        private delegate bool alcMakeContextCurrent_IntPtr_t(IntPtr context);

        private static alcMakeContextCurrent_IntPtr_t s_alcMakeContextCurrent_IntPtr_t = __LoadFunction<alcMakeContextCurrent_IntPtr_t>("alcMakeContextCurrent");

        public static bool alcMakeContextCurrent(IntPtr context) => s_alcMakeContextCurrent_IntPtr_t(context);

        private delegate void alcDestroyContext_IntPtr_t(IntPtr context);

        private static alcDestroyContext_IntPtr_t s_alcDestroyContext_IntPtr_t = __LoadFunction<alcDestroyContext_IntPtr_t>("alcDestroyContext");

        public static void alcDestroyContext(IntPtr context) => s_alcDestroyContext_IntPtr_t(context);

        private delegate IntPtr alcGetCurrentContext__t();

        private static alcGetCurrentContext__t s_alcGetCurrentContext__t = __LoadFunction<alcGetCurrentContext__t>("alcGetCurrentContext");

        public static IntPtr alcGetCurrentContext() => s_alcGetCurrentContext__t();

        private delegate IntPtr alcGetContextsDevice_IntPtr_t(IntPtr context);

        private static alcGetContextsDevice_IntPtr_t s_alcGetContextsDevice_IntPtr_t = __LoadFunction<alcGetContextsDevice_IntPtr_t>("alcGetContextsDevice");

        public static IntPtr alcGetContextsDevice(IntPtr context) => s_alcGetContextsDevice_IntPtr_t(context);

        private delegate IntPtr alcOpenDevice_string_t(
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string devicename
);

        private static alcOpenDevice_string_t s_alcOpenDevice_string_t = __LoadFunction<alcOpenDevice_string_t>("alcOpenDevice");

        public static IntPtr alcOpenDevice(
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string devicename
) => s_alcOpenDevice_string_t(devicename);

        private delegate bool alcCloseDevice_IntPtr_t(IntPtr device);

        private static alcCloseDevice_IntPtr_t s_alcCloseDevice_IntPtr_t = __LoadFunction<alcCloseDevice_IntPtr_t>("alcCloseDevice");

        public static bool alcCloseDevice(IntPtr device) => s_alcCloseDevice_IntPtr_t(device);

        private delegate int alcGetError_IntPtr_t(IntPtr device);

        private static alcGetError_IntPtr_t s_alcGetError_IntPtr_t = __LoadFunction<alcGetError_IntPtr_t>("alcGetError");

        public static int alcGetError(IntPtr device) => s_alcGetError_IntPtr_t(device);

        private delegate IntPtr alcGetProcAddress_IntPtr_string_t(
IntPtr device,
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string funcname
);

        private static alcGetProcAddress_IntPtr_string_t s_alcGetProcAddress_IntPtr_string_t = __LoadFunction<alcGetProcAddress_IntPtr_string_t>("alcGetProcAddress");

        public static IntPtr alcGetProcAddress(
IntPtr device,
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string funcname
) => s_alcGetProcAddress_IntPtr_string_t(device, funcname);

        private delegate int alcGetEnumValue_IntPtr_string_t(
IntPtr device,
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string enumname
);

        private static alcGetEnumValue_IntPtr_string_t s_alcGetEnumValue_IntPtr_string_t = __LoadFunction<alcGetEnumValue_IntPtr_string_t>("alcGetEnumValue");

        public static int alcGetEnumValue(
IntPtr device,
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string enumname
) => s_alcGetEnumValue_IntPtr_string_t(device, enumname);

        private delegate IntPtr alcGetString_IntPtr_int_t(IntPtr device, int param);

        private static alcGetString_IntPtr_int_t s_alcGetString_IntPtr_int_t = __LoadFunction<alcGetString_IntPtr_int_t>("alcGetString");

        public static IntPtr alcGetString(IntPtr device, int param) => s_alcGetString_IntPtr_int_t(device, param);

        private delegate void alcGetIntegerv_IntPtr_int_int_int___t(
IntPtr device,
int param,
int size,
int[] values
);

        private static alcGetIntegerv_IntPtr_int_int_int___t s_alcGetIntegerv_IntPtr_int_int_int___t = __LoadFunction<alcGetIntegerv_IntPtr_int_int_int___t>("alcGetIntegerv");

        public static void alcGetIntegerv(
IntPtr device,
int param,
int size,
int[] values
) => s_alcGetIntegerv_IntPtr_int_int_int___t(device, param, size, values);
        private static T __LoadFunction<T>(string name) => throw new NotImplementedException();	}
}

