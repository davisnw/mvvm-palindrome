using DomainModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmPalindrome.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IPalindromeEvaluationService _palindromeEvaluationService;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IPalindromeEvaluationService palindromeEvaluationService)
        {
            _palindromeEvaluationService = palindromeEvaluationService;

            if (IsInDesignMode)
            {
                // Code runs in Blend --> create design time data.
                Output = "Hello Design World!";
            }
            else
            {
                // Code runs "for real"
                Output = "Hello Real World!";
            }

            var t = Task.Run(async delegate
            {
                await Task.Delay(3000);

                //Must modify view model on the UI thread, or we risk crashing the app.
                Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
                () =>
                {
                    Output = "Hello Delayed World!";
                });

                return 42;
            });

            //InitializeCommands
            CheckIfInputIsAPalindromeCommand = new RelayCommand(CheckIfInputIsAPalindromeCommandImplementation);
        }

        private string _output = null;

        public string Output
        {
            get { return _output; }
            set { Set(ref _output, value); }
        }

        private string _input = null;

        public string Input
        {
            get { return _input; }
            set { Set(ref _input, value);}
        }

        #region Commands

        /// <summary>
        /// Note that I don't bother having the command property raise the PropertyChangedEvent, because
        /// the command will only be set once - when the view model is instantiated.
        /// </summary>
        public ICommand CheckIfInputIsAPalindromeCommand { get; private set; }

        private void CheckIfInputIsAPalindromeCommandImplementation()
        {
            if (_palindromeEvaluationService.IsAPalindrome(Input))
                Output = string.Format("Yay! \"{0}\" is a palindrome!!!", Input);
            else
                Output = string.Format(string.Format("Boo! \"{0}\" is a not palindrome. :-(", Input));
        }

        #endregion
    }
}