using AgOpenGPS.Core.Interfaces;

namespace AgOpenGPS.Core.Presenters
{
    public class ApplicationPresenter : IApplicationPresenter
    {
        public ApplicationPresenter(
            IPanelPresenter panelPresenter,
            IErrorPresenter errorrPresenter)
        {
            PanelPresenter = panelPresenter;
            ErrorPresenter = errorrPresenter;
        }

        public IPanelPresenter PanelPresenter { get; }

        public IErrorPresenter ErrorPresenter { get; }

    }
}
