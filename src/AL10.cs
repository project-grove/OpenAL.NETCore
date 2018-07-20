using System;
using System.Runtime.InteropServices;
using NativeLibraryLoader;
using OpenAL.Internal;

namespace OpenAL
{
    public static class AL10
    {
        /* typedef int ALenum; */
        public const int AL_NONE = 0x0000;
        public const int AL_FALSE = 0x0000;
        public const int AL_TRUE = 0x0001;

        public const int AL_SOURCE_RELATIVE = 0x0202;

        public const int AL_CONE_INNER_ANGLE = 0x1001;
        public const int AL_CONE_OUTER_ANGLE = 0x1002;

        public const int AL_PITCH = 0x1003;
        public const int AL_POSITION = 0x1004;
        public const int AL_DIRECTION = 0x1005;
        public const int AL_VELOCITY = 0x1006;
        public const int AL_LOOPING = 0x1007;
        public const int AL_BUFFER = 0x1009;
        public const int AL_GAIN = 0x100A;
        public const int AL_MIN_GAIN = 0x100D;
        public const int AL_MAX_GAIN = 0x100E;
        public const int AL_ORIENTATION = 0x100F;

        public const int AL_SOURCE_STATE = 0x1010;
        public const int AL_INITIAL = 0x1011;
        public const int AL_PLAYING = 0x1012;
        public const int AL_PAUSED = 0x1013;
        public const int AL_STOPPED = 0x1014;

        public const int AL_BUFFERS_QUEUED = 0x1015;
        public const int AL_BUFFERS_PROCESSED = 0x1016;

        public const int AL_REFERENCE_DISTANCE = 0x1020;
        public const int AL_ROLLOFF_FACTOR = 0x1021;
        public const int AL_CONE_OUTER_GAIN = 0x1022;

        public const int AL_MAX_DISTANCE = 0x1023;

        public const int AL_SOURCE_TYPE = 0x1027;
        public const int AL_STATIC = 0x1028;
        public const int AL_STREAMING = 0x1029;
        public const int AL_UNDETERMINED = 0x1030;

        public const int AL_FORMAT_MONO8 = 0x1100;
        public const int AL_FORMAT_MONO16 = 0x1101;
        public const int AL_FORMAT_STEREO8 = 0x1102;
        public const int AL_FORMAT_STEREO16 = 0x1103;

        public const int AL_FREQUENCY = 0x2001;
        public const int AL_BITS = 0x2002;
        public const int AL_CHANNELS = 0x2003;
        public const int AL_SIZE = 0x2004;

        public const int AL_NO_ERROR = 0x0000;
        public const int AL_INVALID_NAME = 0xA001;
        public const int AL_INVALID_ENUM = 0xA002;
        public const int AL_INVALID_VALUE = 0xA003;
        public const int AL_INVALID_OPERATION = 0xA004;
        public const int AL_OUT_OF_MEMORY = 0xA005;

        public const int AL_VENDOR = 0xB001;
        public const int AL_VERSION = 0xB002;
        public const int AL_RENDERER = 0xB003;
        public const int AL_EXTENSIONS = 0xB004;

        public const int AL_DOPPLER_FACTOR = 0xC000;
        /* Deprecated! */
        public const int AL_DOPPLER_VELOCITY = 0xC001;

        public const int AL_DISTANCE_MODEL = 0xD000;
        public const int AL_INVERSE_DISTANCE = 0xD001;
        public const int AL_INVERSE_DISTANCE_CLAMPED = 0xD002;
        public static string alGetString(int param)
        {
            return Marshal.PtrToStringAnsi(INTERNAL_alGetString(param));
        }

        private delegate void alDopplerFactor_float_t(float value);

        private static alDopplerFactor_float_t s_alDopplerFactor_float_t = __LoadFunction<alDopplerFactor_float_t>("alDopplerFactor");

        public static void alDopplerFactor(float value) => s_alDopplerFactor_float_t(value);

        private delegate void alDistanceModel_int_t(int distanceModel);

        private static alDistanceModel_int_t s_alDistanceModel_int_t = __LoadFunction<alDistanceModel_int_t>("alDistanceModel");

        public static void alDistanceModel(int distanceModel) => s_alDistanceModel_int_t(distanceModel);

        private delegate void alEnable_int_t(int capability);

        private static alEnable_int_t s_alEnable_int_t = __LoadFunction<alEnable_int_t>("alEnable");

        public static void alEnable(int capability) => s_alEnable_int_t(capability);

        private delegate void alDisable_int_t(int capability);

        private static alDisable_int_t s_alDisable_int_t = __LoadFunction<alDisable_int_t>("alDisable");

        public static void alDisable(int capability) => s_alDisable_int_t(capability);

        private delegate bool alIsEnabled_int_t(int capability);

        private static alIsEnabled_int_t s_alIsEnabled_int_t = __LoadFunction<alIsEnabled_int_t>("alIsEnabled");

        public static bool alIsEnabled(int capability) => s_alIsEnabled_int_t(capability);

        private delegate IntPtr INTERNAL_alGetString_int_t(int param);

        private static INTERNAL_alGetString_int_t s_INTERNAL_alGetString_int_t = __LoadFunction<INTERNAL_alGetString_int_t>("INTERNAL_alGetString");

        public static IntPtr INTERNAL_alGetString(int param) => s_INTERNAL_alGetString_int_t(param);

        private delegate void alGetBooleanv_int_bool___t(int param, bool[] values);

        private static alGetBooleanv_int_bool___t s_alGetBooleanv_int_bool___t = __LoadFunction<alGetBooleanv_int_bool___t>("alGetBooleanv");

        public static void alGetBooleanv(int param, bool[] values) => s_alGetBooleanv_int_bool___t(param, values);

        private delegate void alGetIntegerv_int_int___t(int param, int[] values);

        private static alGetIntegerv_int_int___t s_alGetIntegerv_int_int___t = __LoadFunction<alGetIntegerv_int_int___t>("alGetIntegerv");

        public static void alGetIntegerv(int param, int[] values) => s_alGetIntegerv_int_int___t(param, values);

        private delegate void alGetFloatv_int_float___t(int param, float[] values);

        private static alGetFloatv_int_float___t s_alGetFloatv_int_float___t = __LoadFunction<alGetFloatv_int_float___t>("alGetFloatv");

        public static void alGetFloatv(int param, float[] values) => s_alGetFloatv_int_float___t(param, values);

        private delegate void alGetDoublev_int_double___t(int param, double[] values);

        private static alGetDoublev_int_double___t s_alGetDoublev_int_double___t = __LoadFunction<alGetDoublev_int_double___t>("alGetDoublev");

        public static void alGetDoublev(int param, double[] values) => s_alGetDoublev_int_double___t(param, values);

        private delegate bool alGetBoolean_int_t(int param);

        private static alGetBoolean_int_t s_alGetBoolean_int_t = __LoadFunction<alGetBoolean_int_t>("alGetBoolean");

        public static bool alGetBoolean(int param) => s_alGetBoolean_int_t(param);

        private delegate int alGetInteger_int_t(int param);

        private static alGetInteger_int_t s_alGetInteger_int_t = __LoadFunction<alGetInteger_int_t>("alGetInteger");

        public static int alGetInteger(int param) => s_alGetInteger_int_t(param);

        private delegate float alGetFloat_int_t(int param);

        private static alGetFloat_int_t s_alGetFloat_int_t = __LoadFunction<alGetFloat_int_t>("alGetFloat");

        public static float alGetFloat(int param) => s_alGetFloat_int_t(param);

        private delegate double alGetDouble_int_t(int param);

        private static alGetDouble_int_t s_alGetDouble_int_t = __LoadFunction<alGetDouble_int_t>("alGetDouble");

        public static double alGetDouble(int param) => s_alGetDouble_int_t(param);

        private delegate int alGetError__t();

        private static alGetError__t s_alGetError__t = __LoadFunction<alGetError__t>("alGetError");

        public static int alGetError() => s_alGetError__t();

        private delegate bool alIsExtensionPresent_string_t(
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string extname
);

        private static alIsExtensionPresent_string_t s_alIsExtensionPresent_string_t = __LoadFunction<alIsExtensionPresent_string_t>("alIsExtensionPresent");

        public static bool alIsExtensionPresent(
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string extname
) => s_alIsExtensionPresent_string_t(extname);

        private delegate IntPtr alGetProcAddress_string_t(
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string fname
);

        private static alGetProcAddress_string_t s_alGetProcAddress_string_t = __LoadFunction<alGetProcAddress_string_t>("alGetProcAddress");

        public static IntPtr alGetProcAddress(
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string fname
) => s_alGetProcAddress_string_t(fname);

        private delegate int alGetEnumValue_string_t(
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string ename
);

        private static alGetEnumValue_string_t s_alGetEnumValue_string_t = __LoadFunction<alGetEnumValue_string_t>("alGetEnumValue");

        public static int alGetEnumValue(
[In()] [MarshalAs(UnmanagedType.LPStr)]
                string ename
) => s_alGetEnumValue_string_t(ename);

        private delegate void alListenerf_int_float_t(
int param,
float value
);

        private static alListenerf_int_float_t s_alListenerf_int_float_t = __LoadFunction<alListenerf_int_float_t>("alListenerf");

        public static void alListenerf(
int param,
float value
) => s_alListenerf_int_float_t(param, value);

        private delegate void alListener3f_int_float_float_float_t(
int param,
float value1,
float value2,
float value3
);

        private static alListener3f_int_float_float_float_t s_alListener3f_int_float_float_float_t = __LoadFunction<alListener3f_int_float_float_float_t>("alListener3f");

        public static void alListener3f(
int param,
float value1,
float value2,
float value3
) => s_alListener3f_int_float_float_float_t(param, value1, value2, value3);

        private delegate void alListenerfv_int_float___t(
int param,
float[] values
);

        private static alListenerfv_int_float___t s_alListenerfv_int_float___t = __LoadFunction<alListenerfv_int_float___t>("alListenerfv");

        public static void alListenerfv(
int param,
float[] values
) => s_alListenerfv_int_float___t(param, values);

        private delegate void alListeneri_int_int_t(
int param,
int value
);

        private static alListeneri_int_int_t s_alListeneri_int_int_t = __LoadFunction<alListeneri_int_int_t>("alListeneri");

        public static void alListeneri(
int param,
int value
) => s_alListeneri_int_int_t(param, value);

        private delegate void alListener3i_int_int_int_int_t(
int param,
int value1,
int value2,
int value3
);

        private static alListener3i_int_int_int_int_t s_alListener3i_int_int_int_int_t = __LoadFunction<alListener3i_int_int_int_int_t>("alListener3i");

        public static void alListener3i(
int param,
int value1,
int value2,
int value3
) => s_alListener3i_int_int_int_int_t(param, value1, value2, value3);

        private delegate void alListeneriv_int_int___t(
int param,
int[] values
);

        private static alListeneriv_int_int___t s_alListeneriv_int_int___t = __LoadFunction<alListeneriv_int_int___t>("alListeneriv");

        public static void alListeneriv(
int param,
int[] values
) => s_alListeneriv_int_int___t(param, values);

        private delegate void alGetListenerf_int_float_t(
int param,
out float value
);

        private static alGetListenerf_int_float_t s_alGetListenerf_int_float_t = __LoadFunction<alGetListenerf_int_float_t>("alGetListenerf");

        public static void alGetListenerf(
int param,
out float value
) => s_alGetListenerf_int_float_t(param, out value);

        private delegate void alGetListener3f_int_float_float_float_t(
int param,
out float value1,
out float value2,
out float value3
);

        private static alGetListener3f_int_float_float_float_t s_alGetListener3f_int_float_float_float_t = __LoadFunction<alGetListener3f_int_float_float_float_t>("alGetListener3f");

        public static void alGetListener3f(
int param,
out float value1,
out float value2,
out float value3
) => s_alGetListener3f_int_float_float_float_t(param, out value1, out value2, out value3);

        private delegate void alGetListenerfv_int_float___t(
int param,
float[] values
);

        private static alGetListenerfv_int_float___t s_alGetListenerfv_int_float___t = __LoadFunction<alGetListenerfv_int_float___t>("alGetListenerfv");

        public static void alGetListenerfv(
int param,
float[] values
) => s_alGetListenerfv_int_float___t(param, values);

        private delegate void alGetListeneri_int_int_t(
int param,
out int value
);

        private static alGetListeneri_int_int_t s_alGetListeneri_int_int_t = __LoadFunction<alGetListeneri_int_int_t>("alGetListeneri");

        public static void alGetListeneri(
int param,
out int value
) => s_alGetListeneri_int_int_t(param, out value);

        private delegate void alGetListener3i_int_int_int_int_t(
int param,
out int value1,
out int value2,
out int value3
);

        private static alGetListener3i_int_int_int_int_t s_alGetListener3i_int_int_int_int_t = __LoadFunction<alGetListener3i_int_int_int_int_t>("alGetListener3i");

        public static void alGetListener3i(
int param,
out int value1,
out int value2,
out int value3
) => s_alGetListener3i_int_int_int_int_t(param, out value1, out value2, out value3);

        private delegate void alGetListeneriv_int_int___t(
int param,
int[] values
);

        private static alGetListeneriv_int_int___t s_alGetListeneriv_int_int___t = __LoadFunction<alGetListeneriv_int_int___t>("alGetListeneriv");

        public static void alGetListeneriv(
int param,
int[] values
) => s_alGetListeneriv_int_int___t(param, values);

        private delegate void alGenSources_int_uint___t(int n, uint[] sources);

        private static alGenSources_int_uint___t s_alGenSources_int_uint___t = __LoadFunction<alGenSources_int_uint___t>("alGenSources");

        public static void alGenSources(int n, uint[] sources) => s_alGenSources_int_uint___t(n, sources);

        private delegate void alGenSources_int_uint_t(int n, out uint sources);

        private static alGenSources_int_uint_t s_alGenSources_int_uint_t = __LoadFunction<alGenSources_int_uint_t>("alGenSources");

        public static void alGenSources(int n, out uint sources) => s_alGenSources_int_uint_t(n, out sources);

        private delegate void alDeleteSources_int_uint___t(int n, uint[] sources);

        private static alDeleteSources_int_uint___t s_alDeleteSources_int_uint___t = __LoadFunction<alDeleteSources_int_uint___t>("alDeleteSources");

        public static void alDeleteSources(int n, uint[] sources) => s_alDeleteSources_int_uint___t(n, sources);

        private delegate void alDeleteSources_int_uint_t(int n, ref uint sources);

        private static alDeleteSources_int_uint_t s_alDeleteSources_int_uint_t = __LoadFunction<alDeleteSources_int_uint_t>("alDeleteSources");

        public static void alDeleteSources(int n, ref uint sources) => s_alDeleteSources_int_uint_t(n, ref sources);

        private delegate bool alIsSource_uint_t(uint source);

        private static alIsSource_uint_t s_alIsSource_uint_t = __LoadFunction<alIsSource_uint_t>("alIsSource");

        public static bool alIsSource(uint source) => s_alIsSource_uint_t(source);

        private delegate void alSourcef_uint_int_float_t(
uint source,
int param,
float value
);

        private static alSourcef_uint_int_float_t s_alSourcef_uint_int_float_t = __LoadFunction<alSourcef_uint_int_float_t>("alSourcef");

        public static void alSourcef(
uint source,
int param,
float value
) => s_alSourcef_uint_int_float_t(source, param, value);

        private delegate void alSource3f_uint_int_float_float_float_t(
uint source,
int param,
float value1,
float value2,
float value3
);

        private static alSource3f_uint_int_float_float_float_t s_alSource3f_uint_int_float_float_float_t = __LoadFunction<alSource3f_uint_int_float_float_float_t>("alSource3f");

        public static void alSource3f(
uint source,
int param,
float value1,
float value2,
float value3
) => s_alSource3f_uint_int_float_float_float_t(source, param, value1, value2, value3);

        private delegate void alSourcefv_uint_int_float___t(
uint source,
int param,
float[] values
);

        private static alSourcefv_uint_int_float___t s_alSourcefv_uint_int_float___t = __LoadFunction<alSourcefv_uint_int_float___t>("alSourcefv");

        public static void alSourcefv(
uint source,
int param,
float[] values
) => s_alSourcefv_uint_int_float___t(source, param, values);

        private delegate void alSourcei_uint_int_int_t(
uint source,
int param,
int value
);

        private static alSourcei_uint_int_int_t s_alSourcei_uint_int_int_t = __LoadFunction<alSourcei_uint_int_int_t>("alSourcei");

        public static void alSourcei(
uint source,
int param,
int value
) => s_alSourcei_uint_int_int_t(source, param, value);

        private delegate void alSource3i_uint_int_int_int_int_t(
uint source,
int param,
int value1,
int value2,
int value3
);

        private static alSource3i_uint_int_int_int_int_t s_alSource3i_uint_int_int_int_int_t = __LoadFunction<alSource3i_uint_int_int_int_int_t>("alSource3i");

        public static void alSource3i(
uint source,
int param,
int value1,
int value2,
int value3
) => s_alSource3i_uint_int_int_int_int_t(source, param, value1, value2, value3);

        private delegate void alSourceiv_uint_int_int___t(
uint source,
int param,
int[] values
);

        private static alSourceiv_uint_int_int___t s_alSourceiv_uint_int_int___t = __LoadFunction<alSourceiv_uint_int_int___t>("alSourceiv");

        public static void alSourceiv(
uint source,
int param,
int[] values
) => s_alSourceiv_uint_int_int___t(source, param, values);

        private delegate void alGetSourcef_uint_int_float_t(
uint source,
int param,
out float value
);

        private static alGetSourcef_uint_int_float_t s_alGetSourcef_uint_int_float_t = __LoadFunction<alGetSourcef_uint_int_float_t>("alGetSourcef");

        public static void alGetSourcef(
uint source,
int param,
out float value
) => s_alGetSourcef_uint_int_float_t(source, param, out value);

        private delegate void alGetSource3f_uint_int_float_float_float_t(
uint source,
int param,
out float value1,
out float value2,
out float value3
);

        private static alGetSource3f_uint_int_float_float_float_t s_alGetSource3f_uint_int_float_float_float_t = __LoadFunction<alGetSource3f_uint_int_float_float_float_t>("alGetSource3f");

        public static void alGetSource3f(
uint source,
int param,
out float value1,
out float value2,
out float value3
) => s_alGetSource3f_uint_int_float_float_float_t(source, param, out value1, out value2, out value3);

        private delegate void alGetSourcefv_uint_int_float___t(
uint source,
int param,
float[] values
);

        private static alGetSourcefv_uint_int_float___t s_alGetSourcefv_uint_int_float___t = __LoadFunction<alGetSourcefv_uint_int_float___t>("alGetSourcefv");

        public static void alGetSourcefv(
uint source,
int param,
float[] values
) => s_alGetSourcefv_uint_int_float___t(source, param, values);

        private delegate void alGetSourcei_uint_int_int_t(
uint source,
int param,
out int value
);

        private static alGetSourcei_uint_int_int_t s_alGetSourcei_uint_int_int_t = __LoadFunction<alGetSourcei_uint_int_int_t>("alGetSourcei");

        public static void alGetSourcei(
uint source,
int param,
out int value
) => s_alGetSourcei_uint_int_int_t(source, param, out value);

        private delegate void alGetSource3i_uint_int_int_int_int_t(
uint source,
int param,
out int value1,
out int value2,
out int value3
);

        private static alGetSource3i_uint_int_int_int_int_t s_alGetSource3i_uint_int_int_int_int_t = __LoadFunction<alGetSource3i_uint_int_int_int_int_t>("alGetSource3i");

        public static void alGetSource3i(
uint source,
int param,
out int value1,
out int value2,
out int value3
) => s_alGetSource3i_uint_int_int_int_int_t(source, param, out value1, out value2, out value3);

        private delegate void alGetSourceiv_uint_int_int___t(
uint source,
int param,
int[] values
);

        private static alGetSourceiv_uint_int_int___t s_alGetSourceiv_uint_int_int___t = __LoadFunction<alGetSourceiv_uint_int_int___t>("alGetSourceiv");

        public static void alGetSourceiv(
uint source,
int param,
int[] values
) => s_alGetSourceiv_uint_int_int___t(source, param, values);

        private delegate void alSourcePlayv_int_uint___t(
int n,
uint[] sources
);

        private static alSourcePlayv_int_uint___t s_alSourcePlayv_int_uint___t = __LoadFunction<alSourcePlayv_int_uint___t>("alSourcePlayv");

        public static void alSourcePlayv(
int n,
uint[] sources
) => s_alSourcePlayv_int_uint___t(n, sources);

        private delegate void alSourceStopv_int_uint___t(
int n,
uint[] sources
);

        private static alSourceStopv_int_uint___t s_alSourceStopv_int_uint___t = __LoadFunction<alSourceStopv_int_uint___t>("alSourceStopv");

        public static void alSourceStopv(
int n,
uint[] sources
) => s_alSourceStopv_int_uint___t(n, sources);

        private delegate void alSourceRewindv_int_uint___t(
int n,
uint[] sources
);

        private static alSourceRewindv_int_uint___t s_alSourceRewindv_int_uint___t = __LoadFunction<alSourceRewindv_int_uint___t>("alSourceRewindv");

        public static void alSourceRewindv(
int n,
uint[] sources
) => s_alSourceRewindv_int_uint___t(n, sources);

        private delegate void alSourcePausev_int_uint___t(
int n,
uint[] sources
);

        private static alSourcePausev_int_uint___t s_alSourcePausev_int_uint___t = __LoadFunction<alSourcePausev_int_uint___t>("alSourcePausev");

        public static void alSourcePausev(
int n,
uint[] sources
) => s_alSourcePausev_int_uint___t(n, sources);

        private delegate void alSourcePlay_uint_t(uint source);

        private static alSourcePlay_uint_t s_alSourcePlay_uint_t = __LoadFunction<alSourcePlay_uint_t>("alSourcePlay");

        public static void alSourcePlay(uint source) => s_alSourcePlay_uint_t(source);

        private delegate void alSourceStop_uint_t(uint source);

        private static alSourceStop_uint_t s_alSourceStop_uint_t = __LoadFunction<alSourceStop_uint_t>("alSourceStop");

        public static void alSourceStop(uint source) => s_alSourceStop_uint_t(source);

        private delegate void alSourceRewind_uint_t(uint source);

        private static alSourceRewind_uint_t s_alSourceRewind_uint_t = __LoadFunction<alSourceRewind_uint_t>("alSourceRewind");

        public static void alSourceRewind(uint source) => s_alSourceRewind_uint_t(source);

        private delegate void alSourcePause_uint_t(uint source);

        private static alSourcePause_uint_t s_alSourcePause_uint_t = __LoadFunction<alSourcePause_uint_t>("alSourcePause");

        public static void alSourcePause(uint source) => s_alSourcePause_uint_t(source);

        private delegate void alSourceQueueBuffers_uint_int_uint___t(
uint source,
int nb,
uint[] buffers
);

        private static alSourceQueueBuffers_uint_int_uint___t s_alSourceQueueBuffers_uint_int_uint___t = __LoadFunction<alSourceQueueBuffers_uint_int_uint___t>("alSourceQueueBuffers");

        public static void alSourceQueueBuffers(
uint source,
int nb,
uint[] buffers
) => s_alSourceQueueBuffers_uint_int_uint___t(source, nb, buffers);

        private delegate void alSourceQueueBuffers_uint_int_uint_t(
uint source,
int nb,
ref uint buffers
);

        private static alSourceQueueBuffers_uint_int_uint_t s_alSourceQueueBuffers_uint_int_uint_t = __LoadFunction<alSourceQueueBuffers_uint_int_uint_t>("alSourceQueueBuffers");

        public static void alSourceQueueBuffers(
uint source,
int nb,
ref uint buffers
) => s_alSourceQueueBuffers_uint_int_uint_t(source, nb, ref buffers);

        private delegate void alSourceUnqueueBuffers_uint_int_uint___t(
uint source,
int nb,
uint[] buffers
);

        private static alSourceUnqueueBuffers_uint_int_uint___t s_alSourceUnqueueBuffers_uint_int_uint___t = __LoadFunction<alSourceUnqueueBuffers_uint_int_uint___t>("alSourceUnqueueBuffers");

        public static void alSourceUnqueueBuffers(
uint source,
int nb,
uint[] buffers
) => s_alSourceUnqueueBuffers_uint_int_uint___t(source, nb, buffers);

        private delegate void alSourceUnqueueBuffers_uint_int_uint_t(
uint source,
int nb,
ref uint buffers
);

        private static alSourceUnqueueBuffers_uint_int_uint_t s_alSourceUnqueueBuffers_uint_int_uint_t = __LoadFunction<alSourceUnqueueBuffers_uint_int_uint_t>("alSourceUnqueueBuffers");

        public static void alSourceUnqueueBuffers(
uint source,
int nb,
ref uint buffers
) => s_alSourceUnqueueBuffers_uint_int_uint_t(source, nb, ref buffers);

        private delegate void alGenBuffers_int_uint___t(int n, uint[] buffers);

        private static alGenBuffers_int_uint___t s_alGenBuffers_int_uint___t = __LoadFunction<alGenBuffers_int_uint___t>("alGenBuffers");

        public static void alGenBuffers(int n, uint[] buffers) => s_alGenBuffers_int_uint___t(n, buffers);

        private delegate void alGenBuffers_int_uint_t(int n, out uint buffers);

        private static alGenBuffers_int_uint_t s_alGenBuffers_int_uint_t = __LoadFunction<alGenBuffers_int_uint_t>("alGenBuffers");

        public static void alGenBuffers(int n, out uint buffers) => s_alGenBuffers_int_uint_t(n, out buffers);

        private delegate void alDeleteBuffers_int_uint___t(int n, uint[] buffers);

        private static alDeleteBuffers_int_uint___t s_alDeleteBuffers_int_uint___t = __LoadFunction<alDeleteBuffers_int_uint___t>("alDeleteBuffers");

        public static void alDeleteBuffers(int n, uint[] buffers) => s_alDeleteBuffers_int_uint___t(n, buffers);

        private delegate void alDeleteBuffers_int_uint_t(int n, ref uint buffers);

        private static alDeleteBuffers_int_uint_t s_alDeleteBuffers_int_uint_t = __LoadFunction<alDeleteBuffers_int_uint_t>("alDeleteBuffers");

        public static void alDeleteBuffers(int n, ref uint buffers) => s_alDeleteBuffers_int_uint_t(n, ref buffers);

        private delegate bool alIsBuffer_uint_t(uint buffer);

        private static alIsBuffer_uint_t s_alIsBuffer_uint_t = __LoadFunction<alIsBuffer_uint_t>("alIsBuffer");

        public static bool alIsBuffer(uint buffer) => s_alIsBuffer_uint_t(buffer);

        private delegate void alBufferData_uint_int_IntPtr_int_int_t(
uint buffer,
int format,
IntPtr data,
int size,
int freq
);

        private static alBufferData_uint_int_IntPtr_int_int_t s_alBufferData_uint_int_IntPtr_int_int_t = __LoadFunction<alBufferData_uint_int_IntPtr_int_int_t>("alBufferData");

        public static void alBufferData(
uint buffer,
int format,
IntPtr data,
int size,
int freq
) => s_alBufferData_uint_int_IntPtr_int_int_t(buffer, format, data, size, freq);

        private delegate void alBufferData_uint_int_byte___int_int_t(
uint buffer,
int format,
byte[] data,
int size,
int freq
);

        private static alBufferData_uint_int_byte___int_int_t s_alBufferData_uint_int_byte___int_int_t = __LoadFunction<alBufferData_uint_int_byte___int_int_t>("alBufferData");

        public static void alBufferData(
uint buffer,
int format,
byte[] data,
int size,
int freq
) => s_alBufferData_uint_int_byte___int_int_t(buffer, format, data, size, freq);

        private delegate void alBufferData_uint_int_short___int_int_t(
uint buffer,
int format,
short[] data,
int size,
int freq
);

        private static alBufferData_uint_int_short___int_int_t s_alBufferData_uint_int_short___int_int_t = __LoadFunction<alBufferData_uint_int_short___int_int_t>("alBufferData");

        public static void alBufferData(
uint buffer,
int format,
short[] data,
int size,
int freq
) => s_alBufferData_uint_int_short___int_int_t(buffer, format, data, size, freq);

        private delegate void alBufferData_uint_int_float___int_int_t(
uint buffer,
int format,
float[] data,
int size,
int freq
);

        private static alBufferData_uint_int_float___int_int_t s_alBufferData_uint_int_float___int_int_t = __LoadFunction<alBufferData_uint_int_float___int_int_t>("alBufferData");

        public static void alBufferData(
uint buffer,
int format,
float[] data,
int size,
int freq
) => s_alBufferData_uint_int_float___int_int_t(buffer, format, data, size, freq);

        private delegate void alBufferf_uint_int_float_t(
uint buffer,
int param,
float value
);

        private static alBufferf_uint_int_float_t s_alBufferf_uint_int_float_t = __LoadFunction<alBufferf_uint_int_float_t>("alBufferf");

        public static void alBufferf(
uint buffer,
int param,
float value
) => s_alBufferf_uint_int_float_t(buffer, param, value);

        private delegate void alBuffer3f_uint_int_float_float_float_t(
uint buffer,
int param,
float value1,
float value2,
float value3
);

        private static alBuffer3f_uint_int_float_float_float_t s_alBuffer3f_uint_int_float_float_float_t = __LoadFunction<alBuffer3f_uint_int_float_float_float_t>("alBuffer3f");

        public static void alBuffer3f(
uint buffer,
int param,
float value1,
float value2,
float value3
) => s_alBuffer3f_uint_int_float_float_float_t(buffer, param, value1, value2, value3);

        private delegate void alBufferfv_uint_int_float___t(
uint buffer,
int param,
float[] values
);

        private static alBufferfv_uint_int_float___t s_alBufferfv_uint_int_float___t = __LoadFunction<alBufferfv_uint_int_float___t>("alBufferfv");

        public static void alBufferfv(
uint buffer,
int param,
float[] values
) => s_alBufferfv_uint_int_float___t(buffer, param, values);

        private delegate void alBufferi_uint_int_int_t(
uint buffer,
int param,
int value
);

        private static alBufferi_uint_int_int_t s_alBufferi_uint_int_int_t = __LoadFunction<alBufferi_uint_int_int_t>("alBufferi");

        public static void alBufferi(
uint buffer,
int param,
int value
) => s_alBufferi_uint_int_int_t(buffer, param, value);

        private delegate void alBuffer3i_uint_int_int_int_int_t(
uint buffer,
int param,
int value1,
int value2,
int value3
);

        private static alBuffer3i_uint_int_int_int_int_t s_alBuffer3i_uint_int_int_int_int_t = __LoadFunction<alBuffer3i_uint_int_int_int_int_t>("alBuffer3i");

        public static void alBuffer3i(
uint buffer,
int param,
int value1,
int value2,
int value3
) => s_alBuffer3i_uint_int_int_int_int_t(buffer, param, value1, value2, value3);

        private delegate void alBufferiv_uint_int_int___t(
uint buffer,
int param,
int[] values
);

        private static alBufferiv_uint_int_int___t s_alBufferiv_uint_int_int___t = __LoadFunction<alBufferiv_uint_int_int___t>("alBufferiv");

        public static void alBufferiv(
uint buffer,
int param,
int[] values
) => s_alBufferiv_uint_int_int___t(buffer, param, values);

        private delegate void alGetBufferf_uint_int_float_t(
uint buffer,
int param,
out float value
);

        private static alGetBufferf_uint_int_float_t s_alGetBufferf_uint_int_float_t = __LoadFunction<alGetBufferf_uint_int_float_t>("alGetBufferf");

        public static void alGetBufferf(
uint buffer,
int param,
out float value
) => s_alGetBufferf_uint_int_float_t(buffer, param, out value);

        private delegate void alGetBuffer3f_uint_int_float_float_float_t(
uint buffer,
int param,
out float value1,
out float value2,
out float value3
);

        private static alGetBuffer3f_uint_int_float_float_float_t s_alGetBuffer3f_uint_int_float_float_float_t = __LoadFunction<alGetBuffer3f_uint_int_float_float_float_t>("alGetBuffer3f");

        public static void alGetBuffer3f(
uint buffer,
int param,
out float value1,
out float value2,
out float value3
) => s_alGetBuffer3f_uint_int_float_float_float_t(buffer, param, out value1, out value2, out value3);

        private delegate void alGetBufferfv_uint_int_float___t(
uint buffer,
int param,
float[] values
);

        private static alGetBufferfv_uint_int_float___t s_alGetBufferfv_uint_int_float___t = __LoadFunction<alGetBufferfv_uint_int_float___t>("alGetBufferfv");

        public static void alGetBufferfv(
uint buffer,
int param,
float[] values
) => s_alGetBufferfv_uint_int_float___t(buffer, param, values);

        private delegate void alGetBufferi_uint_int_int_t(
uint buffer,
int param,
out int value
);

        private static alGetBufferi_uint_int_int_t s_alGetBufferi_uint_int_int_t = __LoadFunction<alGetBufferi_uint_int_int_t>("alGetBufferi");

        public static void alGetBufferi(
uint buffer,
int param,
out int value
) => s_alGetBufferi_uint_int_int_t(buffer, param, out value);

        private delegate void alGetBuffer3i_uint_int_int_int_int_t(
uint buffer,
int param,
out int value1,
out int value2,
out int value3
);

        private static alGetBuffer3i_uint_int_int_int_int_t s_alGetBuffer3i_uint_int_int_int_int_t = __LoadFunction<alGetBuffer3i_uint_int_int_int_int_t>("alGetBuffer3i");

        public static void alGetBuffer3i(
uint buffer,
int param,
out int value1,
out int value2,
out int value3
) => s_alGetBuffer3i_uint_int_int_int_int_t(buffer, param, out value1, out value2, out value3);

        private delegate void alGetBufferiv_uint_int_int___t(
uint buffer,
int param,
int[] values
);

        private static alGetBufferiv_uint_int_int___t s_alGetBufferiv_uint_int_int___t = __LoadFunction<alGetBufferiv_uint_int_int___t>("alGetBufferiv");

        public static void alGetBufferiv(
uint buffer,
int param,
int[] values
) => s_alGetBufferiv_uint_int_int___t(buffer, param, values);
        private static T __LoadFunction<T>(string name) => Loader.OpenAL.LoadFunction<T>(name);
    }
}

