using System.Media;

namespace AgOpenGPS
{
    public class CSound
    {
        //sound objects - wave files in resources
        public readonly SoundPlayer sndBoundaryAlarm = new(Properties.Resources.Alarm10);
        public readonly SoundPlayer sndUTurnTooClose = new(Properties.Resources.TF012);

        public readonly SoundPlayer sndAutoSteerOn = new(Properties.Resources.SteerOn);
        public readonly SoundPlayer sndAutoSteerOff = new(Properties.Resources.SteerOff);
        public readonly SoundPlayer sndHydLiftUp = new(Properties.Resources.HydUp);
        public readonly SoundPlayer sndHydLiftDn = new(Properties.Resources.HydDown);
        public readonly SoundPlayer sndRTKAlarm = new(Properties.Resources.rtk_lost);
        public readonly SoundPlayer sndSectionOn = new(Properties.Resources.SectionOn);
        public readonly SoundPlayer sndSectionOff = new(Properties.Resources.SectionOff);
        public readonly SoundPlayer sndHeadland = new(Properties.Resources.Headland);
        public readonly SoundPlayer sndRTKRecoverd = new(Properties.Resources.rtk_back);


        public bool isBoundAlarming, isRTKAlarming;
        public bool RTKWasAlarming = false;


        public bool isSteerSoundOn, isTurnSoundOn, isHydLiftSoundOn, isSectionsSoundOn;

        public bool isHydLiftChange;

        public CSound()
        {
            isSteerSoundOn = Properties.Settings.Default.setSound_isAutoSteerOn;
            isHydLiftSoundOn = Properties.Settings.Default.setSound_isHydLiftOn;
            isTurnSoundOn = Properties.Settings.Default.setSound_isUturnOn;
            isSectionsSoundOn = Properties.Settings.Default.setSound_isSectionsOn;
        }
    }
}