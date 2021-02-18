using System;
using System.Windows.Input;

namespace MattermostAddinConnect.Settings
{
    public class CloseCommand : ICommand
    {
        private readonly IClosableWindow _window;

        public CloseCommand(IClosableWindow window)
        {
            _window = window;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _window.Close();
        }

#pragma warning disable CS0067 // The event 'CloseCommand.CanExecuteChanged' is never used
        public event EventHandler CanExecuteChanged;
#pragma warning restore CS0067 // The event 'CloseCommand.CanExecuteChanged' is never used
    }
}