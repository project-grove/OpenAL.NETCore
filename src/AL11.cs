using System;
using System.Runtime.InteropServices;
using NativeLibraryLoader;
using OpenAL.Internal;

namespace OpenAL
{
    public static class AL11
    {
        /* typedef int ALenum; */
        public const int AL_SEC_OFFSET = 0x1024;
        public const int AL_SAMPLE_OFFSET = 0x1025;
        public const int AL_BYTE_OFFSET = 0x1026;

        public const int AL_SPEED_OF_SOUND = 0xC003;

        public const int AL_LINEAR_DISTANCE = 0xD003;
        public const int AL_LINEAR_DISTANCE_CLAMPED = 0xD004;
        public const int AL_EXPONENT_DISTANCE = 0xD005;
        public const int AL_EXPONENT_DISTANCE_CLAMED = 0xD006;

        private delegate void alSpeedOfSound_float_t(float value);

        private static alSpeedOfSound_float_t s_alSpeedOfSound_float_t = __LoadFunction<alSpeedOfSound_float_t>("alSpeedOfSound");

        public static void alSpeedOfSound(float value) => s_alSpeedOfSound_float_t(value);
        private static T __LoadFunction<T>(string name) => Loader.OpenAL.LoadFunction<T>(name);
    }
}

