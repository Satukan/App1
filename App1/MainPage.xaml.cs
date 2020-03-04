using System;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public ICommand TestCommand => new RelayCommand<object>(p => Test());
        private void Test()
        {

        }

        public class RelayCommand<T> : ICommand where T : class
        {
            private readonly Action<object> commandTask;

            public RelayCommand(Action<object> workToDo)
            {
                commandTask = workToDo;
            }

            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                commandTask(parameter);
            }
        }
    }
}
