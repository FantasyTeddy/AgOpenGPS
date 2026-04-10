using AgOpenGPS.Core.DrawLib;
using AgOpenGPS.Properties;

namespace AgOpenGPS.Classes
{
    public class ScreenTextures
    {
        public ScreenTextures()
        {
        }

        public Texture2D Compass
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_Compass);
                return field;
            }
        }

        public Texture2D CrossTrackBackground
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.CrossTrackBackground);
                return field;
            }
        }

        public Texture2D Font
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_Font);
                return field;
            }
        }

        public Texture2D LateralManual
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_LateralManual);
                return field;
            }
        }

        public Texture2D Lift
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_Lift);
                return field;
            }
        }

        public Texture2D MenuShowHide
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.MenuHideShow);
                return field;
            }
        }

        public Texture2D NoGps
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_NoGPS);
                return field;
            }
        }

        public Texture2D Pan
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.Pan);
                return field;
            }
        }

        public Texture2D Speedo
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_Speedo);
                return field;
            }
        }

        public Texture2D SpeedoNeedle
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_SpeedoNeedle);
                return field;
            }
        }

        public Texture2D SteerDot
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_SteerDot);
                return field;
            }
        }

        public Texture2D SteerPointer
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_SteerPointer);
                return field;
            }
        }

        public Texture2D TramDot
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_TramOnOff);
                return field;
            }
        }

        public Texture2D Turn
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_Turn);
                return field;
            }
        }

        public Texture2D TurnCancel
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_TurnCancel);
                return field;
            }
        }

        public Texture2D TurnManual
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_TurnManual);
                return field;
            }
        }

        public Texture2D UTurnU
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.YouTurnU);
                return field;
            }
        }

        public Texture2D UTurnH
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.YouTurnH);
                return field;
            }
        }

        public Texture2D QuestionMark
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_QuestionMark);
                return field;
            }
        }

        public Texture2D ZoomIn
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.ZoomIn48);
                return field;
            }
        }

        public Texture2D ZoomOut
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.ZoomOut48);
                return field;
            }
        }

        public Texture2D HeadlandLight
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_HeadlandLight);
                return field;
            }
        }

        public Texture2D HeadlandDark
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_HeadlandDark);
                return field;
            }
        }

    }

}
