using System;
using System.Windows.Input;

namespace MattermostAddinConnect.Settings
{
    public class SaveCommand : ICommand
    {
        private readonly ISettingsSaveService _saveService;
        private readonly IClosableWindow _window;

        public SaveCommand(ISettingsSaveService saveService, IClosableWindow window)
        {
            _saveService = saveService;
            _window = window;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var viewModel = parameter as SettingsViewModel;
            if (viewModel == null)
            {
                throw new ArgumentException(@"Invalid ViewModel ", "parameter");
            }
            _saveService.SaveCredentials(viewModel.MattermostUrl, viewModel.TeamId, viewModel.Username, viewModel.Version);
            _saveService.SaveChannels(string.Empty);
            _window.Close();
        }

#pragma warning disable CS0067 // The event 'SaveCommand.CanExecuteChanged' is never used
        public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067 // The event 'SaveCommand.CanExecuteChanged' is never used
    }
}