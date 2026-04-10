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
                field ??= new Texture2D(Resources.z_Compass);
                return field;
            }
        }

        public Texture2D CrossTrackBackground
        {
            get
            {
                field ??= new Texture2D(Resources.CrossTrackBackground);
                return field;
            }
        }

        public Texture2D Font
        {
            get
            {
                field ??= new Texture2D(Resources.z_Font);
                return field;
            }
        }

        public Texture2D LateralManual
        {
            get
            {
                field ??= new Texture2D(Resources.z_LateralManual);
                return field;
            }
        }

        public Texture2D Lift
        {
            get
            {
                field ??= new Texture2D(Resources.z_Lift);
                return field;
            }
        }

        public Texture2D MenuShowHide
        {
            get
            {
                field ??= new Texture2D(Resources.MenuHideShow);
                return field;
            }
        }

        public Texture2D NoGps
        {
            get
            {
                field ??= new Texture2D(Resources.z_NoGPS);
                return field;
            }
        }

        public Texture2D Pan
        {
            get
            {
                field ??= new Texture2D(Resources.Pan);
                return field;
            }
        }

        public Texture2D Speedo
        {
            get
            {
                field ??= new Texture2D(Resources.z_Speedo);
                return field;
            }
        }

        public Texture2D SpeedoNeedle
        {
            get
            {
                field ??= new Texture2D(Resources.z_SpeedoNeedle);
                return field;
            }
        }

        public Texture2D SteerDot
        {
            get
            {
                field ??= new Texture2D(Resources.z_SteerDot);
                return field;
            }
        }

        public Texture2D SteerPointer
        {
            get
            {
                field ??= new Texture2D(Resources.z_SteerPointer);
                return field;
            }
        }

        public Texture2D TramDot
        {
            get
            {
                field ??= new Texture2D(Resources.z_TramOnOff);
                return field;
            }
        }

        public Texture2D Turn
        {
            get
            {
                field ??= new Texture2D(Resources.z_Turn);
                return field;
            }
        }

        public Texture2D TurnCancel
        {
            get
            {
                field ??= new Texture2D(Resources.z_TurnCancel);
                return field;
            }
        }

        public Texture2D TurnManual
        {
            get
            {
                field ??= new Texture2D(Resources.z_TurnManual);
                return field;
            }
        }

        public Texture2D UTurnU
        {
            get
            {
                field ??= new Texture2D(Resources.YouTurnU);
                return field;
            }
        }

        public Texture2D UTurnH
        {
            get
            {
                field ??= new Texture2D(Resources.YouTurnH);
                return field;
            }
        }

        public Texture2D QuestionMark
        {
            get
            {
                field ??= new Texture2D(Resources.z_QuestionMark);
                return field;
            }
        }

        public Texture2D ZoomIn
        {
            get
            {
                field ??= new Texture2D(Resources.ZoomIn48);
                return field;
            }
        }

        public Texture2D ZoomOut
        {
            get
            {
                field ??= new Texture2D(Resources.ZoomOut48);
                return field;
            }
        }

        public Texture2D HeadlandLight
        {
            get
            {
                field ??= new Texture2D(Resources.z_HeadlandLight);
                return field;
            }
        }

        public Texture2D HeadlandDark
        {
            get
            {
                field ??= new Texture2D(Resources.z_HeadlandDark);
                return field;
            }
        }

    }

}
