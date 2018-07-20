using System;
using System.Runtime.InteropServices;
using NativeLibraryLoader;

namespace OpenAL
{
    public static class EFX
    {
        /* typedef int ALenum; */
        public const int AL_METERS_PER_UNIT = 0x20004;

        public const int AL_DIRECT_FILTER = 0x20005;
        public const int AL_AUXILIARY_SEND_FILTER = 0x20006;
        public const int AL_AIR_ABSORPTION_FACTOR = 0x20007;
        public const int AL_ROOM_ROLLOFF_FACTOR = 0x20008;
        public const int AL_CONE_OUTER_GAINHF = 0x20009;
        public const int AL_DIRECT_FILTER_GAINHF_AUTO = 0x2000A;
        public const int AL_AUXILIARY_SEND_FILTER_GAIN_AUTO = 0x2000B;
        public const int AL_AUXILIARY_SEND_FILTER_GAINHF_AUTO = 0x2000C;

        public const int AL_REVERB_DENSITY = 0x0001;
        public const int AL_REVERB_DIFFUSION = 0x0002;
        public const int AL_REVERB_GAIN = 0x0003;
        public const int AL_REVERB_GAINHF = 0x0004;
        public const int AL_REVERB_DECAY_TIME = 0x0005;
        public const int AL_REVERB_DECAY_HFRATIO = 0x0006;
        public const int AL_REVERB_REFLECTIONS_GAIN = 0x0007;
        public const int AL_REVERB_REFLECTIONS_DELAY = 0x0008;
        public const int AL_REVERB_LATE_REVERB_GAIN = 0x0009;
        public const int AL_REVERB_LATE_REVERB_DELAY = 0x000A;
        public const int AL_REVERB_AIR_ABSORPTION_FACTOR = 0x000B;
        public const int AL_REVERB_ROOM_ROLLOFF_FACTOR = 0x000C;
        public const int AL_REVERB_DECAY_HFLIMIT = 0x000D;

        public const int AL_EAXREVERB_DENSITY = 0x0001;
        public const int AL_EAXREVERB_DIFFUSION = 0x0002;
        public const int AL_EAXREVERB_GAIN = 0x0003;
        public const int AL_EAXREVERB_GAINHF = 0x0004;
        public const int AL_EAXREVERB_GAINLF = 0x0005;
        public const int AL_EAXREVERB_DECAY_TIME = 0x0006;
        public const int AL_EAXREVERB_DECAY_HFRATIO = 0x0007;
        public const int AL_EAXREVERB_DECAY_LFRATIO = 0x0008;
        public const int AL_EAXREVERB_REFLECTIONS_GAIN = 0x0009;
        public const int AL_EAXREVERB_REFLECTIONS_DELAY = 0x000A;
        public const int AL_EAXREVERB_REFLECTIONS_PAN = 0x000B;
        public const int AL_EAXREVERB_LATE_REVERB_GAIN = 0x000C;
        public const int AL_EAXREVERB_LATE_REVERB_DELAY = 0x000D;
        public const int AL_EAXREVERB_LATE_REVERT_PAN = 0x000E;
        public const int AL_EAXREVERB_ECHO_TIME = 0x000F;
        public const int AL_EAXREVERB_ECHO_DEPTH = 0x0010;
        public const int AL_EAXREVERB_MODULATION_TIME = 0x0011;
        public const int AL_EAXREVERB_MODULATION_DEPTH = 0x0012;
        public const int AL_EAXREVERB_AIR_ABSORPTION_GAINHF = 0x0013;
        public const int AL_EAXREVERB_HFREFERENCE = 0x0014;
        public const int AL_EAXREVERB_LFREFERENCE = 0x0015;
        public const int AL_EAXREVERB_ROOM_ROLLOFF_FACTOR = 0x0016;
        public const int AL_EAXREVERB_DECAY_HFLIMIT = 0x0017;

        public const int AL_CHORUS_WAVEFORM = 0x0001;
        public const int AL_CHORUS_PHASE = 0x0002;
        public const int AL_CHORUS_RATE = 0x0003;
        public const int AL_CHORUS_DEPTH = 0x0004;
        public const int AL_CHORUS_FEEDBACK = 0x0005;
        public const int AL_CHORUS_DELAY = 0x0006;

        public const int AL_DISTORTION_EDGE = 0x0001;
        public const int AL_DISTORTION_GAIN = 0x0002;
        public const int AL_DISTORTION_LOWPASS_CUTOFF = 0x0003;
        public const int AL_DISTORTION_EQCENTER = 0x0004;
        public const int AL_DISTORTION_EQBANDWIDTH = 0x0005;

        public const int AL_ECHO_DELAY = 0x0001;
        public const int AL_ECHO_LRDELAY = 0x0002;
        public const int AL_ECHO_DAMPING = 0x0003;
        public const int AL_ECHO_FEEDBACK = 0x0004;
        public const int AL_ECHO_SPREAD = 0x0005;

        public const int AL_FLANGER_WAVEFORM = 0x0001;
        public const int AL_FLANGER_PHASE = 0x0002;
        public const int AL_FLANGER_RATE = 0x0003;
        public const int AL_FLANGER_DEPTH = 0x0004;
        public const int AL_FLANGER_FEEDBACK = 0x0005;
        public const int AL_FLANGER_DELAY = 0x0006;

        public const int AL_FREQUENCY_SHIFTER_FREQUENCY = 0x0001;
        public const int AL_FREQUENCY_SHIFTER_LEFT_DIRECTION = 0x0002;
        public const int AL_FREQUENCY_SHIFTER_RIGHT_DIRECTION = 0x0003;

        public const int AL_VOCAL_MORPHER_PHONEMEA = 0x0001;
        public const int AL_VOCAL_MORPHER_PHONEMEA_COARSE_TUNING = 0x0002;
        public const int AL_VOCAL_MORPHER_PHONEMEB = 0x0003;
        public const int AL_VOCAL_MORPHER_PHONEMEB_COARSE_TUNING = 0x0004;
        public const int AL_VOCAL_MORPHER_WAVEFORM = 0x0005;
        public const int AL_VOCAL_MORPHER_RATE = 0x0006;

        public const int AL_PITCH_SHIFTER_COARSE_TUNE = 0x0001;
        public const int AL_PITCH_SHIFTER_FINE_TUNE = 0x0002;

        public const int AL_RING_MODULATOR_FREQUENCY = 0x0001;
        public const int AL_RING_MODULATOR_HIGHPASS_CUTOFF = 0x0002;
        public const int AL_RING_MODULATOR_WAVEFORM = 0x0003;

        public const int AL_AUTOWAH_ATTACK_TIME = 0x0001;
        public const int AL_AUTOWAH_RELEASE_TIME = 0x0002;
        public const int AL_AUTOWAH_RESONANCE = 0x0003;
        public const int AL_AUTOWAH_PEAK_GAIN = 0x0004;

        public const int AL_COMPRESSOR_ONOFF = 0x0001;

        public const int AL_EQUALIZER_LOW_GAIN = 0x0001;
        public const int AL_EQUALIZER_LOW_CUTOFF = 0x0002;
        public const int AL_EQUALIZER_MID1_GAIN = 0x0003;
        public const int AL_EQUALIZER_MID1_CENTER = 0x0004;
        public const int AL_EQUALIZER_MID1_WIDTH = 0x0005;
        public const int AL_EQUALIZER_MID2_GAIN = 0x0006;
        public const int AL_EQUALIZER_MID2_CENTER = 0x0007;
        public const int AL_EQUALIZER_MID2_WIDTH = 0x0008;
        public const int AL_EQUALIZER_HIGH_GAIN = 0x0009;
        public const int AL_EQUALIZER_HIGH_CUTOFF = 0x000A;

        public const int AL_EFFECT_FIRST_PARAMETER = 0x0000;
        public const int AL_EFFECT_LAST_PARAMETER = 0x8000;
        public const int AL_EFFECT_TYPE = 0x8001;

        public const int AL_EFFECT_NULL = 0x0000;
        public const int AL_EFFECT_REVERB = 0x0001;
        public const int AL_EFFECT_CHORUS = 0x0002;
        public const int AL_EFFECT_DISTORTION = 0x0003;
        public const int AL_EFFECT_ECHO = 0x0004;
        public const int AL_EFFECT_FLANGER = 0x0005;
        public const int AL_EFFECT_FREQUENCY_SHIFTER = 0x0006;
        public const int AL_EFFECT_VOCAL_MORPHER = 0x0007;
        public const int AL_EFFECT_PITCH_SHIFTER = 0x0008;
        public const int AL_EFFECT_RING_MODULATOR = 0x0009;
        public const int AL_EFFECT_AUTOWAH = 0x000A;
        public const int AL_EFFECT_COMPRESSOR = 0x000B;
        public const int AL_EFFECT_EQUALIZER = 0x000C;
        public const int AL_EFFECT_EAXREVERB = 0x8000;

        public const int AL_EFFECTSLOT_EFFECT = 0x0001;
        public const int AL_EFFECTSLOT_GAIN = 0x0002;
        public const int AL_EFFECTSLOT_AUXILIARY_SEND_AUTO = 0x0003;

        public const int AL_EFFECTSLOT_NULL = 0x0000;

        public const int AL_LOWPASS_GAIN = 0x0001;
        public const int AL_LOWPASS_GAINHF = 0x0002;

        public const int AL_HIGHPASS_GAIN = 0x0001;
        public const int AL_HIGHPASS_GAINLF = 0x0002;

        public const int AL_BANDPASS_GAIN = 0x0001;
        public const int AL_BANDPASS_GAINLF = 0x0002;
        public const int AL_BANDPASS_GAINHF = 0x0003;

        public const int AL_FILTER_FIRST_PARAMETER = 0x0000;
        public const int AL_FILTER_LAST_PARAMETER = 0x8000;
        public const int AL_FILTER_TYPE = 0x8001;

        public const int AL_FILTER_NULL = 0x0000;
        public const int AL_FILTER_LOWPASS = 0x0001;
        public const int AL_FILTER_HIGHPASS = 0x0002;
        public const int AL_FILTER_BANDPASS = 0x0003;

        private delegate void alGenEffects_int_uint___t(int n, uint[] effects);

        private static alGenEffects_int_uint___t s_alGenEffects_int_uint___t = __LoadFunction<alGenEffects_int_uint___t>("alGenEffects");

        public static void alGenEffects(int n, uint[] effects) => s_alGenEffects_int_uint___t(n, effects);

        private delegate void alGenEffects_int_uint_t(int n, out uint effects);

        private static alGenEffects_int_uint_t s_alGenEffects_int_uint_t = __LoadFunction<alGenEffects_int_uint_t>("alGenEffects");

        public static void alGenEffects(int n, out uint effects) => s_alGenEffects_int_uint_t(n, out effects);

        private delegate void alDeleteEffects_int_uint___t(int n, uint[] effects);

        private static alDeleteEffects_int_uint___t s_alDeleteEffects_int_uint___t = __LoadFunction<alDeleteEffects_int_uint___t>("alDeleteEffects");

        public static void alDeleteEffects(int n, uint[] effects) => s_alDeleteEffects_int_uint___t(n, effects);

        private delegate void alDeleteEffects_int_uint_t(int n, ref uint effects);

        private static alDeleteEffects_int_uint_t s_alDeleteEffects_int_uint_t = __LoadFunction<alDeleteEffects_int_uint_t>("alDeleteEffects");

        public static void alDeleteEffects(int n, ref uint effects) => s_alDeleteEffects_int_uint_t(n, ref effects);

        private delegate bool alIsEffect_uint_t(uint effect);

        private static alIsEffect_uint_t s_alIsEffect_uint_t = __LoadFunction<alIsEffect_uint_t>("alIsEffect");

        public static bool alIsEffect(uint effect) => s_alIsEffect_uint_t(effect);

        private delegate void alEffecti_uint_int_int_t(
uint effect,
int param,
int iValue
);

        private static alEffecti_uint_int_int_t s_alEffecti_uint_int_int_t = __LoadFunction<alEffecti_uint_int_int_t>("alEffecti");

        public static void alEffecti(
uint effect,
int param,
int iValue
) => s_alEffecti_uint_int_int_t(effect, param, iValue);

        private delegate void alEffectiv_uint_int_int___t(
uint effect,
int param,
int[] iValues
);

        private static alEffectiv_uint_int_int___t s_alEffectiv_uint_int_int___t = __LoadFunction<alEffectiv_uint_int_int___t>("alEffectiv");

        public static void alEffectiv(
uint effect,
int param,
int[] iValues
) => s_alEffectiv_uint_int_int___t(effect, param, iValues);

        private delegate void alEffectf_uint_int_float_t(
uint effect,
int param,
float flValue
);

        private static alEffectf_uint_int_float_t s_alEffectf_uint_int_float_t = __LoadFunction<alEffectf_uint_int_float_t>("alEffectf");

        public static void alEffectf(
uint effect,
int param,
float flValue
) => s_alEffectf_uint_int_float_t(effect, param, flValue);

        private delegate void alEffectfv_uint_int_float___t(
uint effect,
int param,
float[] flValues
);

        private static alEffectfv_uint_int_float___t s_alEffectfv_uint_int_float___t = __LoadFunction<alEffectfv_uint_int_float___t>("alEffectfv");

        public static void alEffectfv(
uint effect,
int param,
float[] flValues
) => s_alEffectfv_uint_int_float___t(effect, param, flValues);

        private delegate void alGetEffecti_uint_int_int_t(
uint effect,
int param,
out int piValue
);

        private static alGetEffecti_uint_int_int_t s_alGetEffecti_uint_int_int_t = __LoadFunction<alGetEffecti_uint_int_int_t>("alGetEffecti");

        public static void alGetEffecti(
uint effect,
int param,
out int piValue
) => s_alGetEffecti_uint_int_int_t(effect, param, out piValue);

        private delegate void alGetEffectiv_uint_int_int___t(
uint effect,
int param,
int[] piValues
);

        private static alGetEffectiv_uint_int_int___t s_alGetEffectiv_uint_int_int___t = __LoadFunction<alGetEffectiv_uint_int_int___t>("alGetEffectiv");

        public static void alGetEffectiv(
uint effect,
int param,
int[] piValues
) => s_alGetEffectiv_uint_int_int___t(effect, param, piValues);

        private delegate void alGetEffectf_uint_int_float_t(
uint effect,
int param,
out float pflValue
);

        private static alGetEffectf_uint_int_float_t s_alGetEffectf_uint_int_float_t = __LoadFunction<alGetEffectf_uint_int_float_t>("alGetEffectf");

        public static void alGetEffectf(
uint effect,
int param,
out float pflValue
) => s_alGetEffectf_uint_int_float_t(effect, param, out pflValue);

        private delegate void alGetEffectfv_uint_int_float___t(
uint effect,
int param,
float[] pflValues
);

        private static alGetEffectfv_uint_int_float___t s_alGetEffectfv_uint_int_float___t = __LoadFunction<alGetEffectfv_uint_int_float___t>("alGetEffectfv");

        public static void alGetEffectfv(
uint effect,
int param,
float[] pflValues
) => s_alGetEffectfv_uint_int_float___t(effect, param, pflValues);

        private delegate void alGenFilters_int_uint___t(int n, uint[] filters);

        private static alGenFilters_int_uint___t s_alGenFilters_int_uint___t = __LoadFunction<alGenFilters_int_uint___t>("alGenFilters");

        public static void alGenFilters(int n, uint[] filters) => s_alGenFilters_int_uint___t(n, filters);

        private delegate void alGenFilters_int_uint_t(int n, out uint filters);

        private static alGenFilters_int_uint_t s_alGenFilters_int_uint_t = __LoadFunction<alGenFilters_int_uint_t>("alGenFilters");

        public static void alGenFilters(int n, out uint filters) => s_alGenFilters_int_uint_t(n, out filters);

        private delegate void alDeleteFilters_int_uint___t(int n, uint[] filters);

        private static alDeleteFilters_int_uint___t s_alDeleteFilters_int_uint___t = __LoadFunction<alDeleteFilters_int_uint___t>("alDeleteFilters");

        public static void alDeleteFilters(int n, uint[] filters) => s_alDeleteFilters_int_uint___t(n, filters);

        private delegate void alDeleteFilters_int_uint_t(int n, ref uint filters);

        private static alDeleteFilters_int_uint_t s_alDeleteFilters_int_uint_t = __LoadFunction<alDeleteFilters_int_uint_t>("alDeleteFilters");

        public static void alDeleteFilters(int n, ref uint filters) => s_alDeleteFilters_int_uint_t(n, ref filters);

        private delegate bool alIsFilter_uint_t(uint filter);

        private static alIsFilter_uint_t s_alIsFilter_uint_t = __LoadFunction<alIsFilter_uint_t>("alIsFilter");

        public static bool alIsFilter(uint filter) => s_alIsFilter_uint_t(filter);

        private delegate void alFilteri_uint_int_int_t(
uint filter,
int param,
int iValue
);

        private static alFilteri_uint_int_int_t s_alFilteri_uint_int_int_t = __LoadFunction<alFilteri_uint_int_int_t>("alFilteri");

        public static void alFilteri(
uint filter,
int param,
int iValue
) => s_alFilteri_uint_int_int_t(filter, param, iValue);

        private delegate void alFilteriv_uint_int_int___t(
uint filter,
int param,
int[] iValues
);

        private static alFilteriv_uint_int_int___t s_alFilteriv_uint_int_int___t = __LoadFunction<alFilteriv_uint_int_int___t>("alFilteriv");

        public static void alFilteriv(
uint filter,
int param,
int[] iValues
) => s_alFilteriv_uint_int_int___t(filter, param, iValues);

        private delegate void alFilterf_uint_int_float_t(
uint filter,
int param,
float flValue
);

        private static alFilterf_uint_int_float_t s_alFilterf_uint_int_float_t = __LoadFunction<alFilterf_uint_int_float_t>("alFilterf");

        public static void alFilterf(
uint filter,
int param,
float flValue
) => s_alFilterf_uint_int_float_t(filter, param, flValue);

        private delegate void alFilterfv_uint_int_float___t(
uint filter,
int param,
float[] flValues
);

        private static alFilterfv_uint_int_float___t s_alFilterfv_uint_int_float___t = __LoadFunction<alFilterfv_uint_int_float___t>("alFilterfv");

        public static void alFilterfv(
uint filter,
int param,
float[] flValues
) => s_alFilterfv_uint_int_float___t(filter, param, flValues);

        private delegate void alGetFilteri_uint_int_int_t(
uint filter,
int param,
out int piValue
);

        private static alGetFilteri_uint_int_int_t s_alGetFilteri_uint_int_int_t = __LoadFunction<alGetFilteri_uint_int_int_t>("alGetFilteri");

        public static void alGetFilteri(
uint filter,
int param,
out int piValue
) => s_alGetFilteri_uint_int_int_t(filter, param, out piValue);

        private delegate void alGetFilteriv_uint_int_int___t(
uint filter,
int param,
int[] piValues
);

        private static alGetFilteriv_uint_int_int___t s_alGetFilteriv_uint_int_int___t = __LoadFunction<alGetFilteriv_uint_int_int___t>("alGetFilteriv");

        public static void alGetFilteriv(
uint filter,
int param,
int[] piValues
) => s_alGetFilteriv_uint_int_int___t(filter, param, piValues);

        private delegate void alGetFilterf_uint_int_float_t(
uint filter,
int param,
out float pflValue
);

        private static alGetFilterf_uint_int_float_t s_alGetFilterf_uint_int_float_t = __LoadFunction<alGetFilterf_uint_int_float_t>("alGetFilterf");

        public static void alGetFilterf(
uint filter,
int param,
out float pflValue
) => s_alGetFilterf_uint_int_float_t(filter, param, out pflValue);

        private delegate void alGetFilterfv_uint_int_float___t(
uint filter,
int param,
float[] pflValues
);

        private static alGetFilterfv_uint_int_float___t s_alGetFilterfv_uint_int_float___t = __LoadFunction<alGetFilterfv_uint_int_float___t>("alGetFilterfv");

        public static void alGetFilterfv(
uint filter,
int param,
float[] pflValues
) => s_alGetFilterfv_uint_int_float___t(filter, param, pflValues);

        private delegate void alGenAuxiliaryEffectSlots_int_uint___t(
int n,
uint[] effectslots
);

        private static alGenAuxiliaryEffectSlots_int_uint___t s_alGenAuxiliaryEffectSlots_int_uint___t = __LoadFunction<alGenAuxiliaryEffectSlots_int_uint___t>("alGenAuxiliaryEffectSlots");

        public static void alGenAuxiliaryEffectSlots(
int n,
uint[] effectslots
) => s_alGenAuxiliaryEffectSlots_int_uint___t(n, effectslots);

        private delegate void alGenAuxiliaryEffectSlots_int_uint_t(
int n,
out uint effectslots
);

        private static alGenAuxiliaryEffectSlots_int_uint_t s_alGenAuxiliaryEffectSlots_int_uint_t = __LoadFunction<alGenAuxiliaryEffectSlots_int_uint_t>("alGenAuxiliaryEffectSlots");

        public static void alGenAuxiliaryEffectSlots(
int n,
out uint effectslots
) => s_alGenAuxiliaryEffectSlots_int_uint_t(n, out effectslots);

        private delegate void alDeleteAuxiliaryEffectSlots_int_uint___t(
int n,
uint[] effectslots
);

        private static alDeleteAuxiliaryEffectSlots_int_uint___t s_alDeleteAuxiliaryEffectSlots_int_uint___t = __LoadFunction<alDeleteAuxiliaryEffectSlots_int_uint___t>("alDeleteAuxiliaryEffectSlots");

        public static void alDeleteAuxiliaryEffectSlots(
int n,
uint[] effectslots
) => s_alDeleteAuxiliaryEffectSlots_int_uint___t(n, effectslots);

        private delegate void alDeleteAuxiliaryEffectSlots_int_uint_t(
int n,
ref uint effectslots
);

        private static alDeleteAuxiliaryEffectSlots_int_uint_t s_alDeleteAuxiliaryEffectSlots_int_uint_t = __LoadFunction<alDeleteAuxiliaryEffectSlots_int_uint_t>("alDeleteAuxiliaryEffectSlots");

        public static void alDeleteAuxiliaryEffectSlots(
int n,
ref uint effectslots
) => s_alDeleteAuxiliaryEffectSlots_int_uint_t(n, ref effectslots);

        private delegate bool alIsAuxiliaryEffectSlot_uint_t(uint effectslot);

        private static alIsAuxiliaryEffectSlot_uint_t s_alIsAuxiliaryEffectSlot_uint_t = __LoadFunction<alIsAuxiliaryEffectSlot_uint_t>("alIsAuxiliaryEffectSlot");

        public static bool alIsAuxiliaryEffectSlot(uint effectslot) => s_alIsAuxiliaryEffectSlot_uint_t(effectslot);

        private delegate void alAuxiliaryEffectSloti_uint_int_int_t(
uint effectslot,
int param,
int iValue
);

        private static alAuxiliaryEffectSloti_uint_int_int_t s_alAuxiliaryEffectSloti_uint_int_int_t = __LoadFunction<alAuxiliaryEffectSloti_uint_int_int_t>("alAuxiliaryEffectSloti");

        public static void alAuxiliaryEffectSloti(
uint effectslot,
int param,
int iValue
) => s_alAuxiliaryEffectSloti_uint_int_int_t(effectslot, param, iValue);

        private delegate void alAuxiliaryEffectSlotiv_uint_int_int___t(
uint effectslot,
int param,
int[] iValues
);

        private static alAuxiliaryEffectSlotiv_uint_int_int___t s_alAuxiliaryEffectSlotiv_uint_int_int___t = __LoadFunction<alAuxiliaryEffectSlotiv_uint_int_int___t>("alAuxiliaryEffectSlotiv");

        public static void alAuxiliaryEffectSlotiv(
uint effectslot,
int param,
int[] iValues
) => s_alAuxiliaryEffectSlotiv_uint_int_int___t(effectslot, param, iValues);

        private delegate void alAuxiliaryEffectSlotf_uint_int_float_t(
uint effectslot,
int param,
float flValue
);

        private static alAuxiliaryEffectSlotf_uint_int_float_t s_alAuxiliaryEffectSlotf_uint_int_float_t = __LoadFunction<alAuxiliaryEffectSlotf_uint_int_float_t>("alAuxiliaryEffectSlotf");

        public static void alAuxiliaryEffectSlotf(
uint effectslot,
int param,
float flValue
) => s_alAuxiliaryEffectSlotf_uint_int_float_t(effectslot, param, flValue);

        private delegate void alAuxiliaryEffectSlotfv_uint_int_float___t(
uint effectslot,
int param,
float[] flValues
);

        private static alAuxiliaryEffectSlotfv_uint_int_float___t s_alAuxiliaryEffectSlotfv_uint_int_float___t = __LoadFunction<alAuxiliaryEffectSlotfv_uint_int_float___t>("alAuxiliaryEffectSlotfv");

        public static void alAuxiliaryEffectSlotfv(
uint effectslot,
int param,
float[] flValues
) => s_alAuxiliaryEffectSlotfv_uint_int_float___t(effectslot, param, flValues);

        private delegate void alGetAuxiliaryEffectSloti_uint_int_int_t(
uint effectslot,
int param,
out int piValue
);

        private static alGetAuxiliaryEffectSloti_uint_int_int_t s_alGetAuxiliaryEffectSloti_uint_int_int_t = __LoadFunction<alGetAuxiliaryEffectSloti_uint_int_int_t>("alGetAuxiliaryEffectSloti");

        public static void alGetAuxiliaryEffectSloti(
uint effectslot,
int param,
out int piValue
) => s_alGetAuxiliaryEffectSloti_uint_int_int_t(effectslot, param, out piValue);

        private delegate void alGetAuxiliaryEffectSlotiv_uint_int_int___t(
uint effectslot,
int param,
int[] piValues
);

        private static alGetAuxiliaryEffectSlotiv_uint_int_int___t s_alGetAuxiliaryEffectSlotiv_uint_int_int___t = __LoadFunction<alGetAuxiliaryEffectSlotiv_uint_int_int___t>("alGetAuxiliaryEffectSlotiv");

        public static void alGetAuxiliaryEffectSlotiv(
uint effectslot,
int param,
int[] piValues
) => s_alGetAuxiliaryEffectSlotiv_uint_int_int___t(effectslot, param, piValues);

        private delegate void alGetAuxiliaryEffectSlotf_uint_int_float_t(
uint effectslot,
int param,
out float pflValue
);

        private static alGetAuxiliaryEffectSlotf_uint_int_float_t s_alGetAuxiliaryEffectSlotf_uint_int_float_t = __LoadFunction<alGetAuxiliaryEffectSlotf_uint_int_float_t>("alGetAuxiliaryEffectSlotf");

        public static void alGetAuxiliaryEffectSlotf(
uint effectslot,
int param,
out float pflValue
) => s_alGetAuxiliaryEffectSlotf_uint_int_float_t(effectslot, param, out pflValue);

        private delegate void alGetAuxiliaryEffectSlotfv_uint_int_float___t(
uint effectslot,
int param,
float[] pflValues
);

        private static alGetAuxiliaryEffectSlotfv_uint_int_float___t s_alGetAuxiliaryEffectSlotfv_uint_int_float___t = __LoadFunction<alGetAuxiliaryEffectSlotfv_uint_int_float___t>("alGetAuxiliaryEffectSlotfv");

        public static void alGetAuxiliaryEffectSlotfv(
uint effectslot,
int param,
float[] pflValues
) => s_alGetAuxiliaryEffectSlotfv_uint_int_float___t(effectslot, param, pflValues);
        private static T __LoadFunction<T>(string name) => throw new NotImplementedException();	}
}

