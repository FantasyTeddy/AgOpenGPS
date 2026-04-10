using System.Collections.ObjectModel;

namespace AgOpenGPS.Core.ViewModels
{
    // The class DayNightAndUnitsViewModel implements the properties IsDay and IsMetric.
    // Moreover, an instance of this class propagates changes to these properites to its childs.
    public class DayNightAndUnitsViewModel : ViewModel
    {
        private readonly Collection<DayNightAndUnitsViewModel> _children;

        public DayNightAndUnitsViewModel()
        {
            _children = new Collection<DayNightAndUnitsViewModel>();
        }

        public bool IsMetric
        {
            get;
            set
            {
                if (value != field)
                {
                    field = value;
                    foreach (DayNightAndUnitsViewModel child in _children) child.IsMetric = value;
                    NotifyAllPropertiesChanged();
                }
            }
        }

        public bool IsDay
        {
            get;
            set
            {
                if (value != field)
                {
                    field = value;
                    foreach (DayNightAndUnitsViewModel child in _children) child.IsDay = value;
                    NotifyAllPropertiesChanged();
                }
            }
        }

        protected void AddChild(DayNightAndUnitsViewModel child)
        {
            _children.Add(child);
            child.IsDay = IsDay;
            child.IsMetric = IsMetric;
        }
    }

}
