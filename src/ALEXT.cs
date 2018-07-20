using System;
using System.Runtime.InteropServices;
using NativeLibraryLoader;
using OpenAL.Internal;

namespace OpenAL
{
    public static class ALEXT
    {
        /* TODO: All OpenAL Soft extensions! Complete as needed. */

        /* typedef int ALenum */
        public const int AL_FORMAT_MONO_FLOAT32 = 0x10010;
        public const int AL_FORMAT_STEREO_FLOAT32 = 0x10011;

        public const int AL_LOOP_POINTS_SOFT = 0x2015;

        public const int AL_UNPACK_BLOCK_ALIGNMENT_SOFT = 0x200C;
        public const int AL_PACK_BLOCK_ALIGNMENT_SOFT = 0x200D;

        public const int AL_FORMAT_MONO_MSADPCM_SOFT = 0x1302;
        public const int AL_FORMAT_STEREO_MSADPCM_SOFT = 0x1303;

        public const int AL_BYTE_SOFT = 0x1400;
        public const int AL_SHORT_SOFT = 0x1402;
        public const int AL_FLOAT_SOFT = 0x1406;

        public const int AL_MONO_SOFT = 0x1500;
        public const int AL_STEREO_SOFT = 0x1501;

        public const int AL_GAIN_LIMIT_SOFT = 0x200E;

        private delegate void alGetBufferSamplesSOFT_uint_int_int_int_int_IntPtr_t(
                    uint buffer,
                    int offset,
                    int samples,
                    int channels,
                    int type,
                    IntPtr data
                );

        private static alGetBufferSamplesSOFT_uint_int_int_int_int_IntPtr_t s_alGetBufferSamplesSOFT_uint_int_int_int_int_IntPtr_t = __LoadFunction<alGetBufferSamplesSOFT_uint_int_int_int_int_IntPtr_t>("alGetBufferSamplesSOFT");

        public static void alGetBufferSamplesSOFT(
uint buffer,
int offset,
int samples,
int channels,
int type,
IntPtr data
) => s_alGetBufferSamplesSOFT_uint_int_int_int_int_IntPtr_t(buffer, offset, samples, channels, type, data);
        private static T __LoadFunction<T>(string name) => Loader.OpenAL.LoadFunction<T>(name);
    }
}

