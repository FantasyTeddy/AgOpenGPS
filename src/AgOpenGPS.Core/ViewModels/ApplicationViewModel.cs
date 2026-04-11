using AgOpenGPS.Core.Interfaces;
using AgOpenGPS.Core.Presenters;
using AgOpenGPS.Core.Streamers;
using System.Windows.Input;

namespace AgOpenGPS.Core.ViewModels
{
    public class ApplicationViewModel : DayNightAndUnitsViewModel
    {
        private readonly ApplicationModel _applicationModel;
        private readonly FieldDescriptionStreamer _fieldDescriptionStreamer;
        private readonly FieldStreamer _fieldStreamer;
        private ApplicationPresenter _applicationPresenter;

        public ApplicationViewModel(
            ApplicationModel applicationModel,
            FieldDescriptionStreamer fieldDescriptionStreamer,
            FieldStreamer fieldStreamer)
        {
            _applicationModel = applicationModel;
            _fieldDescriptionStreamer = fieldDescriptionStreamer;
            _fieldStreamer = fieldStreamer;
            ShowConfigMenuCommand = new RelayCommand(ShowConfigMenu);
            ShowSelectFieldMenuCommand = new RelayCommand(ShowSelectFieldMenu);
        }

        public IPanelPresenter PanelPresenter => _applicationPresenter.PanelPresenter;

        public void SetPresenter(ApplicationPresenter appPresenter)
        {
            _applicationPresenter = appPresenter;
        }

        public ICommand ShowConfigMenuCommand { get; }
        public ICommand ShowSelectFieldMenuCommand { get; }

        public ConfigMenuViewModel ConfigMenuViewModel
        {
            get
            {
                if (field == null)
                {
                    field =
                        new ConfigMenuViewModel(
                            _applicationPresenter.PanelPresenter.ConfigMenuPanelPresenter);
                    AddChild(field);
                }
                return field;
            }
        }

        public SelectFieldMenuViewModel SelectFieldMenuViewModel
        {
            get
            {
                if (field == null)
                {
                    field =
                        new SelectFieldMenuViewModel(
                            _applicationModel,
                            _fieldDescriptionStreamer,
                            _fieldStreamer,
                            _applicationPresenter.PanelPresenter.SelectFieldPanelPresenter);
                    AddChild(field);
                }
                return field;
            }
        }

        private void ShowConfigMenu()
        {
            PanelPresenter.ConfigMenuPanelPresenter.ShowConfigMenuDialog(ConfigMenuViewModel);
        }

        private void ShowSelectFieldMenu()
        {
            PanelPresenter.SelectFieldPanelPresenter.ShowSelectFieldMenuDialog(SelectFieldMenuViewModel);
        }

    }
}
