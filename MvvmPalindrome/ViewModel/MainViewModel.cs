using GalaSoft.MvvmLight;
using System.Threading.Tasks;

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
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
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
        }

        private string _output = null;

        public string Output
        {
            get { return _output; }
            set { Set(ref _output, value); }
        }
    }
}