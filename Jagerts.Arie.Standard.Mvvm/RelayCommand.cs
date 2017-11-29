using System;
using System.Windows.Input;

namespace Jagerts.Arie.Standard.Mvvm
{
    /// <summary>
    /// The implementation of a Relayed command from the UI layer.
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Constructor
        /// <summary>
        /// Relay Command constructor with an action delegate.
        /// </summary>
        /// <param name="action">Action delegate.</param>
        public RelayCommand(Action action)
        {
            this.Action = action;
            this.CanExecuteChanged?.Invoke(this, null);
        }

        /// <summary>
        /// Relay Command constructor with a action and can execute function.
        /// </summary>
        /// <param name="action">Action delegate.</param>
        /// <param name="canExecute">Functional delegate that defines whether or not the action delegate can execute.</param>
        public RelayCommand(Action action, Func<bool> canExecute)
            : this(action)
        {
            this.CanExecuteFunc = canExecute;
            this.CanExecuteChanged?.Invoke(this, null);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Action delegate.
        /// </summary>
        private Action Action { get; set; }

        /// <summary>
        /// Action executablity delegate.
        /// </summary>
        private Func<bool> CanExecuteFunc { get; set; }

        #endregion

        #region Events

        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        #endregion

        #region Methods

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command. If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>True if this command can be executed; otherwise, false.</returns>
        public bool CanExecute(object parameter) => this.Action != null && (this.CanExecuteFunc == null || this.CanExecuteFunc.Invoke());

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command. If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            if (this.CanExecute(parameter))
                this.Action.Invoke();
        }

        #endregion
    }

    /// <summary>
    /// The implementation of a Relayed command from the UI layer.
    /// </summary>
    /// <typeparam name="T">Argument Type for action</typeparam>
    public class RelayCommand<T> : ICommand
    {
        #region Constructor

        /// <summary>
        /// Relay Command constructor with an action delegate.
        /// </summary>
        /// <param name="action">Action delegate.</param>
        public RelayCommand(Action<T> action)
        {
            this.Action = action;
            this.CanExecuteChanged?.Invoke(this, null);
        }

        /// <summary>
        /// Relay Command constructor with a action and can execute function.
        /// </summary>
        /// <param name="action">Action delegate.</param>
        /// <param name="canExecute">Functional delegate that defines whether or not the action delegate can execute.</param>
        public RelayCommand(Action<T> action, Func<T, bool> canExecute)
            : this(action)
        {
            this.CanExecuteFunc = canExecute;
            this.CanExecuteChanged?.Invoke(this, null);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Action delegate.
        /// </summary>
        private Action<T> Action { get; set; }

        /// <summary>
        /// Action executablity delegate.
        /// </summary>
        private Func<T, bool> CanExecuteFunc { get; set; }

        #endregion

        #region Events

        /// <summary>
        /// Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        #endregion

        #region Methods

        /// <summary>
        /// Defines the method that determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command. If the command does not require data to be passed, this object can be set to null.</param>
        /// <returns>True if this command can be executed; otherwise, false.</returns>
        public bool CanExecute(object parameter)
        {
            return this.Action != null && (this.CanExecuteFunc == null || this.CanExecuteFunc.Invoke((T)parameter));
        }

        /// <summary>
        /// Defines the method to be called when the command is invoked.
        /// </summary>
        /// <param name="parameter">Data used by the command. If the command does not require data to be passed, this object can be set to null.</param>
        public void Execute(object parameter)
        {
            if (this.CanExecute(parameter))
                this.Action.Invoke((T)parameter);
        }

        #endregion
    }
}
