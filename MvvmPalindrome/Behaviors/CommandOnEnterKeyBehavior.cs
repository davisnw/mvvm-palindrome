using Microsoft.Xaml.Interactivity;
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace MvvmPalindrome.Behaviors
{
    [TypeConstraint(typeof(TextBox))]
    public class CommandOnEnterKeyBehavior : DependencyObject, IBehavior
    {
        public DependencyObject AssociatedObject { get; private set; }

        public void Attach(DependencyObject associatedObject)
        {
            AssociatedObject = associatedObject;

            var associatedTextBox = (TextBox)AssociatedObject;
            associatedTextBox.KeyDown += associatedTextBox_KeyDown;
        }

        void associatedTextBox_KeyDown(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter && Command.CanExecute(null))
            {
                var textBox = (TextBox)AssociatedObject;

                //Ensure that the TextBox property value is bound back to the view model.
                BindingExpression binding = textBox.GetBindingExpression(TextBox.TextProperty);
                binding.UpdateSource();

                //Execute the associated command.
                Command.Execute(null);
            }
        }

        //Register the dependency property.  See: http://msdn.microsoft.com/en-us/library/windows/apps/hh920267.aspx and http://msdn.microsoft.com/en-us/library/windows/apps/hh700353.aspx
        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register(
                "Command", typeof(ICommand),
                typeof(CommandOnEnterKeyBehavior), null
        );

        //Create the dependency property wrapper that allows usage in XAML.
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public void Detach()
        {
            var associatedTextBox = (TextBox)AssociatedObject;
            associatedTextBox.KeyDown -= associatedTextBox_KeyDown;
        }
    }
}
