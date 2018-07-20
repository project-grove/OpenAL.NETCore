using System;
using System.Runtime.InteropServices;
using NativeLibraryLoader;

namespace OpenAL
{
    public static class ALC11
    {
        /* typedef int ALenum */
        public const int ALC_MONO_SOURCES = 0x1010;
        public const int ALC_STEREO_SOURCES = 0x1011;

        public const int ALC_CAPTURE_DEVICE_SPECIFIER = 0x0310;
        public const int ALC_CAPTURE_DEFAULT_DEVICE_SPECIFIER = 0x0311;
        public const int ALC_CAPTURE_SAMPLES = 0x0312;
        public const int ALC_DEFAULT_ALL_DEVICES_SPECIFIER = 0x1012;
        public const int ALC_ALL_DEVICES_SPECIFIER = 0x1013;

        private delegate void alcProcessContext_IntPtr_t(IntPtr context);

        private static alcProcessContext_IntPtr_t s_alcProcessContext_IntPtr_t = __LoadFunction<alcProcessContext_IntPtr_t>("alcProcessContext");

        public static void alcProcessContext(IntPtr context) => s_alcProcessContext_IntPtr_t(context);

        private delegate void alcSuspendContext_IntPtr_t(IntPtr context);

        private static alcSuspendContext_IntPtr_t s_alcSuspendContext_IntPtr_t = __LoadFunction<alcSuspendContext_IntPtr_t>("alcSuspendContext");

        public static void alcSuspendContext(IntPtr context) => s_alcSuspendContext_IntPtr_t(context);

        private delegate bool alcIsExtensionPresent_IntPtr_string_t(
IntPtr device,
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string extname
);

        private static alcIsExtensionPresent_IntPtr_string_t s_alcIsExtensionPresent_IntPtr_string_t = __LoadFunction<alcIsExtensionPresent_IntPtr_string_t>("alcIsExtensionPresent");

        public static bool alcIsExtensionPresent(
IntPtr device,
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string extname
) => s_alcIsExtensionPresent_IntPtr_string_t(device, extname);

        private delegate IntPtr alcCaptureOpenDevice_string_uint_int_int_t(
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string devicename,
uint frequency,
int format,
int buffersize
);

        private static alcCaptureOpenDevice_string_uint_int_int_t s_alcCaptureOpenDevice_string_uint_int_int_t = __LoadFunction<alcCaptureOpenDevice_string_uint_int_int_t>("alcCaptureOpenDevice");

        public static IntPtr alcCaptureOpenDevice(
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string devicename,
uint frequency,
int format,
int buffersize
) => s_alcCaptureOpenDevice_string_uint_int_int_t(devicename, frequency, format, buffersize);

        private delegate bool alcCaptureCloseDevice_IntPtr_t(IntPtr device);

        private static alcCaptureCloseDevice_IntPtr_t s_alcCaptureCloseDevice_IntPtr_t = __LoadFunction<alcCaptureCloseDevice_IntPtr_t>("alcCaptureCloseDevice");

        public static bool alcCaptureCloseDevice(IntPtr device) => s_alcCaptureCloseDevice_IntPtr_t(device);

        private delegate void alcCaptureStart_IntPtr_t(IntPtr device);

        private static alcCaptureStart_IntPtr_t s_alcCaptureStart_IntPtr_t = __LoadFunction<alcCaptureStart_IntPtr_t>("alcCaptureStart");

        public static void alcCaptureStart(IntPtr device) => s_alcCaptureStart_IntPtr_t(device);

        private delegate void alcCaptureStop_IntPtr_t(IntPtr device);

        private static alcCaptureStop_IntPtr_t s_alcCaptureStop_IntPtr_t = __LoadFunction<alcCaptureStop_IntPtr_t>("alcCaptureStop");

        public static void alcCaptureStop(IntPtr device) => s_alcCaptureStop_IntPtr_t(device);

        private delegate void alcCaptureSamples_IntPtr_IntPtr_int_t(
IntPtr device,
IntPtr buffer,
int samples
);

        private static alcCaptureSamples_IntPtr_IntPtr_int_t s_alcCaptureSamples_IntPtr_IntPtr_int_t = __LoadFunction<alcCaptureSamples_IntPtr_IntPtr_int_t>("alcCaptureSamples");

        public static void alcCaptureSamples(
IntPtr device,
IntPtr buffer,
int samples
) => s_alcCaptureSamples_IntPtr_IntPtr_int_t(device, buffer, samples);
        private static T __LoadFunction<T>(string name) => throw new NotImplementedException();	}
}

