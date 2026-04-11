using AgOpenGPS.Core.Interfaces;
using AgOpenGPS.Core.Streamers;
using System.Windows.Input;

namespace AgOpenGPS.Core.ViewModels
{
    public class SelectFieldMenuViewModel : DayNightAndUnitsViewModel
    {
        private readonly ApplicationModel _appModel;
        private readonly FieldDescriptionStreamer _fieldDescriptionStreamer;
        private readonly FieldStreamer _fieldStreamer;
        private readonly ISelectFieldPanelPresenter _selectFieldPanelPresenter;

        public SelectFieldMenuViewModel(
            ApplicationModel appModel,
            FieldDescriptionStreamer fieldDescriptionStreamer,
            FieldStreamer fieldStreamer,
            ISelectFieldPanelPresenter selectFieldPanelPresenter)
        {
            _appModel = appModel;
            _fieldDescriptionStreamer = fieldDescriptionStreamer;
            _fieldStreamer = fieldStreamer;
            _selectFieldPanelPresenter = selectFieldPanelPresenter;
            StartSelectNearFieldCommand = new RelayCommand(StartSelectNearField);
            StartCreateFieldFromExistingCommand = new RelayCommand(StartCreateFieldFromExisting);
            StartSelectFieldCommand = new RelayCommand(StartSelectField);
            CancelCommand = new RelayCommand(Cancel);
        }

        public SelectNearFieldViewModel SelectNearFieldViewModel
        {
            get
            {
                if (field == null)
                {
                    field =
                        new SelectNearFieldViewModel(
                            _appModel,
                            _fieldDescriptionStreamer,
                            _fieldStreamer,
                            _selectFieldPanelPresenter);
                    AddChild(field);
                }
                return field;
            }
        }

        public CreateFromExistingFieldViewModel CreateFromExistingFieldViewModel
        {
            get
            {
                if (field == null)
                {
                    field =
                        new CreateFromExistingFieldViewModel(
                            _appModel,
                            _fieldDescriptionStreamer,
                            _fieldStreamer,
                            _selectFieldPanelPresenter);
                    AddChild(field);
                }
                return field;
            }
        }

        public SelectFieldViewModel SelectFieldViewModel
        {
            get
            {
                if (field == null)
                {
                    field =
                        new SelectFieldViewModel(
                            _appModel,
                            _fieldDescriptionStreamer,
                            _fieldStreamer,
                            _selectFieldPanelPresenter);
                    AddChild(field);
                }
                return field;
            }
        }

        public ICommand StartSelectNearFieldCommand { get; }
        public ICommand StartCreateFieldFromExistingCommand { get; }
        public ICommand StartSelectFieldCommand { get; }
        public ICommand CancelCommand { get; }

        public string CurrentFieldName => _appModel.Fields.CurrentFieldName;

        private void StartSelectNearField()
        {
            // TODO implement different behaviour if number of fields is 0 or 1
            _selectFieldPanelPresenter.CloseSelectFieldMenuDialog();
            SelectNearFieldViewModel.UpdateFields();
            _selectFieldPanelPresenter.ShowSelectNearFieldDialog(SelectNearFieldViewModel);
        }

        private void StartCreateFieldFromExisting()
        {
            // TODO implement different behaviour if number of fields is 0 or 1
            _selectFieldPanelPresenter.CloseSelectFieldMenuDialog();
            CreateFromExistingFieldViewModel.UpdateFields();
            _selectFieldPanelPresenter.ShowCreateFromExistingFieldDialog(CreateFromExistingFieldViewModel);
        }

        private void StartSelectField()
        {
            // TODO implement different behaviour if number of fields is 0 or 1
            _selectFieldPanelPresenter.CloseSelectFieldMenuDialog();
            SelectFieldViewModel.UpdateFields();
            _selectFieldPanelPresenter.ShowSelectFieldDialog(SelectFieldViewModel);
        }

        private void Cancel()
        {
            _selectFieldPanelPresenter.CloseSelectFieldMenuDialog();
        }

    }
}
