using AgOpenGPS.Core.DrawLib;
using AgOpenGPS.Properties;

namespace AgOpenGPS.Classes
{
    public class VehicleTextures
    {
        public VehicleTextures()
        {
        }

        public Texture2D Tractor
        {
            get
            {
                if (field == null) field = new Texture2D(null);
                return field;
            }
        }

        public Texture2D Harvester
        {
            get
            {
                if (field == null) field = new Texture2D(null);
                return field;
            }
        }

        public Texture2D ArticulatedFront
        {
            get
            {
                if (field == null) field = new Texture2D(null);
                return field;
            }
        }

        public Texture2D ArticulatedRear
        {
            get
            {
                if (field == null) field = new Texture2D(null);
                return field;
            }
        }

        public Texture2D FrontWheel
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_FrontWheels);
                return field;
            }
        }

        public Texture2D Tire
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_Tire);
                return field;
            }
        }

        public Texture2D ToolAxle
        {
            get
            {
                if (field == null) field = new Texture2D(Resources.z_Tool);
                return field;
            }
        }

    }
}
