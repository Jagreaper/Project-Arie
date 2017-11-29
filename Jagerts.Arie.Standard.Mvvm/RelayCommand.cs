using System;
using System.Windows.Input;

namespace Jagerts.Arie.Standard.Mvvm
{
    /// <summary>
    /// The implementation of a Relayed command from the UI layer
    /// </summary>
    public class RelayCommand : ICommand
    {
        #region Constructor

        /// <summary>
        /// Relay Command constructor with a action
        /// </summary>
        /// <param name="action">Command's Action</param>
        public RelayCommand(Action action)
        {
            this.Action = action;
            this.CanExecuteChanged?.Invoke(this, null);
        }

        /// <summary>
        /// Relay Command constructor with a action and can execute function
        /// </summary>
        /// <param name="action">Command's Action</param>
        /// <param name="canExecute">Function that defines whether or not the action will execute</param>
        public RelayCommand(Action action, Func<bool> canExecute)
            : this(action)
        {
            this.CanExecuteFunc = canExecute;
            this.CanExecuteChanged?.Invoke(this, null);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Action delegate
        /// </summary>
        private Action Action { get; set; }

        /// <summary>
        /// Action executablity delegate
        /// </summary>
        private Func<bool> CanExecuteFunc { get; set; }

        #endregion

        #region Events

        /// <summary>
        /// A event that handles the change in state of the executablity of the action delegate
        /// </summary>
        public event EventHandler CanExecuteChanged;

        #endregion

        #region Methods

        /// <summary>
        /// Checks whether or not the action delegate is executable
        /// </summary>
        /// <param name="parameter">Unused</param>
        /// <returns>A boolean value representing the executablity of the action delegate</returns>
        public bool CanExecute(object parameter) => this.Action != null && (this.CanExecuteFunc == null || this.CanExecuteFunc.Invoke());

        /// <summary>
        /// Executes the action delegate
        /// </summary>
        /// <param name="parameter">Unused</param>
        public void Execute(object parameter)
        {
            if (this.CanExecute(parameter))
                this.Action.Invoke();
        }

        #endregion
    }

    /// <summary>
    /// The implementation of a Relayed command from the UI layer
    /// </summary>
    /// <typeparam name="T">Argument Type for action</typeparam>
    public class RelayCommand<T> : ICommand
    {
        #region Constructor

        /// <summary>
        /// Relay Command constructor with a action
        /// </summary>
        /// <param name="action">Command's Action</param>
        public RelayCommand(Action<T> action)
        {
            this.Action = action;
            this.CanExecuteChanged?.Invoke(this, null);
        }

        /// <summary>
        /// Relay Command constructor with a action and can execute function
        /// </summary>
        /// <param name="action">Command's Action</param>
        /// <param name="canExecute">Function that defines whether or not the action will execute</param>
        public RelayCommand(Action<T> action, Func<T, bool> canExecute)
            : this(action)
        {
            this.CanExecuteFunc = canExecute;
            this.CanExecuteChanged?.Invoke(this, null);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Action delegate
        /// </summary>
        private Action<T> Action { get; set; }

        /// <summary>
        /// Action executablity delegate
        /// </summary>
        private Func<T, bool> CanExecuteFunc { get; set; }

        #endregion

        #region Events

        /// <summary>
        /// A event that handles the change in state of the executablity of the action delegate
        /// </summary>
        public event EventHandler CanExecuteChanged;

        #endregion

        #region Methods
        
        /// <summary>
        /// Checks whether or not the action delegate is executable
        /// </summary>
        /// <param name="parameter">Parameter that is checked to determine the executability of the action delegate</param>
        /// <returns>A boolean value representing the executablity of the action delegate</returns>z
        public bool CanExecute(object parameter)
        {
            return this.Action != null && (this.CanExecuteFunc == null || this.CanExecuteFunc.Invoke((T)parameter));
        }

        /// <summary>
        /// Executes the action delegate
        /// </summary>
        /// <param name="parameter">Parameter to be passed as an argument to the action delegate</param>
        public void Execute(object parameter)
        {
            if (this.CanExecute(parameter))
                this.Action.Invoke((T)parameter);
        }

        #endregion
    }
}
