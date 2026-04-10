using System.Windows.Forms;
using AgOpenGPS.Core.Models;
using AgOpenGPS.Core.Translations;
using AgOpenGPS.Properties;

namespace AgOpenGPS.Forms.Config
{
    public partial class ConfigSummaryControl : UserControl
    {
        public ConfigSummaryControl()
        {
            InitializeComponent();

            labelProfileMenuHint.Text = gStr.gsProfileMenuHint;
            labelUnits.Text = gStr.gsUnits + ":";
            labelWidth.Text = gStr.gsWidth + ":";
            labelSections.Text = gStr.gsSections + ":";
            labelOffset.Text = gStr.gsOffset + ":";
            labelOverlap.Text = gStr.gsOverlap + ":";
            labelLookAhead.Text = gStr.gsLookAhead + ":";
            labelNudge.Text = gStr.gsNudge + ":";
            labelTramW.Text = gStr.gsTramWidth + ":";
            labelWheelBase.Text = gStr.gsWheelbase + ":";
            labelVehicleType.Text = gStr.gsVehiclegroupbox + ":";
            labelAntPivot.Text = gStr.gsPivot + ":";
            labelAntOffset.Text = gStr.gsAntennaOffset + ":";
            labelHitch.Text = gStr.gsHitchLength + ":";
        }

        public void UpdateSummary(FormGPS mf)
        {
            VehicleSettings vs = Properties.VehicleSettings.Default;
            ToolSettings ts = Properties.ToolSettings.Default;

            // Vehicle panel
            lblSummaryVehicleName.Text = RegistrySettings.vehicleProfileName;
            lblSumVehicleType.Text = vs.setVehicle_vehicleType == 0 ? "Tractor"
                : vs.setVehicle_vehicleType == 1 ? "Harvester" : "Articulated";
            lblSumWheelbase.Text = Distance.SmallDistanceString(mf.IsMetric, vs.setVehicle_wheelbase);
            lblAntPivot.Text = Distance.SmallDistanceString(mf.IsMetric, vs.setVehicle_antennaPivot);
            lblAntOffset.Text = Distance.SmallDistanceString(mf.IsMetric, vs.setVehicle_antennaOffset);
            lblHitch.Text = Distance.SmallDistanceString(mf.IsMetric, ts.setVehicle_hitchLength);

            // Tool panel
            lblSummaryToolName.Text = RegistrySettings.toolProfileName;
            lblSumNumSections.Text = mf.tool.numOfSections.ToString();
            lblToolOffset.Text = Distance.SmallDistanceString(mf.IsMetric, ts.setVehicle_toolOffset);
            lblOverlap.Text = Distance.SmallDistanceString(mf.IsMetric, ts.setVehicle_toolOverlap);
            lblLookahead.Text = ts.setVehicle_toolLookAheadOn.ToString() + " sec";
            lblNudgeDistance.Text = Distance.VerySmallDistanceString(mf.IsMetric, 0.01 * Properties.Settings.Default.setAS_snapDistance);
            lblTramWidth.Text = Distance.MediumDistanceString(mf.IsMetric, Properties.Settings.Default.setTram_tramWidth);

            // Buiten panels
            lblUnits.Text = mf.IsMetric ? "Metric" : "Imperial";
        }

        public void SetSummaryWidth(string widthText)
        {
            lblSummaryWidth.Text = widthText;
        }

    }
}
