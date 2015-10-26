using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace FreshMVVMSample
{
	public class CommandReference : BindableObject, ICommand {

		public static readonly BindableProperty CommandProperty = 
			BindableProperty.Create("Command", typeof(ICommand), typeof(CommandReference),
				defaultValue: null, propertyChanged: CommandReference.OnCommandChanged);

		public ICommand Command {
			get { return (ICommand)GetValue(CommandReference.CommandProperty); }
			set { SetValue(CommandReference.CommandProperty, value); }
		}

		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter) {
			if (Command != null)
				return Command.CanExecute(parameter);
			return false;
		}

		public void Execute(object parameter) {
			if (this.CanExecute(parameter)) {
				Command.Execute(parameter);
			}
		}

		private static void OnCommandChanged(BindableObject bindable, object oldValue, object newValue) {

			CommandReference commandReference = bindable as CommandReference;
			ICommand oldCommand = oldValue as ICommand;
			ICommand newCommand = newValue as ICommand;

			if (oldCommand != null)
				oldCommand.CanExecuteChanged -= commandReference.CanExecuteChanged;

			if (newCommand != null)
				newCommand.CanExecuteChanged += commandReference.CanExecuteChanged;

		}

	}
}

