namespace AgOpenGPS
{
    public class CFeatureSettings
    {
        public CFeatureSettings()
        { }

        //public bool ;
        public bool IsHeadlandOn { get; set; } = true;
        public bool IsTramOn { get; set; } = false;
        public bool IsBoundaryOn { get; set; } = true;
        public bool IsBndContourOn { get; set; } = false;
        public bool IsRecPathOn { get; set; } = false;
        public bool IsABSmoothOn { get; set; } = false;
        public bool IsHideContourOn { get; set; } = false;
        public bool IsOffsetFixOn { get; set; } = false;
        public bool IsAgIOOn { get; set; } = true;
        public bool IsContourOn { get; set; } = true;
        public bool IsYouTurnOn { get; set; } = true;
        public bool IsSteerModeOn { get; set; } = true;
        public bool IsManualSectionOn { get; set; } = true;
        public bool IsAutoSectionOn { get; set; } = true;
        public bool IsCycleLinesOn { get; set; } = true;
        public bool IsABLineOn { get; set; } = true;
        public bool IsCurveOn { get; set; } = true;
        public bool IsAutoSteerOn { get; set; } = true;
        public bool IsUTurnOn { get; set; } = true;
        public bool IsLateralOn { get; set; } = true;

        public CFeatureSettings(CFeatureSettings _feature)
        {
            IsHeadlandOn = _feature.IsHeadlandOn;
            IsTramOn = _feature.IsTramOn;
            IsBoundaryOn = _feature.IsBoundaryOn;
            IsBndContourOn = _feature.IsBndContourOn;
            IsRecPathOn = _feature.IsRecPathOn;

            IsABSmoothOn = _feature.IsABSmoothOn;
            IsHideContourOn = _feature.IsHideContourOn;
            IsOffsetFixOn = _feature.IsOffsetFixOn;
            IsAgIOOn = _feature.IsAgIOOn;

            IsContourOn = _feature.IsContourOn;
            IsYouTurnOn = _feature.IsYouTurnOn;
            IsSteerModeOn = _feature.IsSteerModeOn;

            IsManualSectionOn = _feature.IsManualSectionOn;
            IsAutoSectionOn = _feature.IsAutoSectionOn;
            IsCycleLinesOn = _feature.IsCycleLinesOn;
            IsABLineOn = _feature.IsABLineOn;
            IsCurveOn = _feature.IsCurveOn;

            IsAutoSteerOn = _feature.IsAutoSteerOn;
            IsLateralOn = _feature.IsLateralOn;
            IsUTurnOn = _feature.IsUTurnOn;
        }
    }
}