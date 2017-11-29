using System;

namespace Jagerts.Arie.Standard.Mvvm
{
    /// <summary>
    /// Abstract class that defines useable functions for a View Model type in the Mvvm pattern
    /// </summary>
    public abstract class ViewModel : ObservableObject
    {
        #region Events

        /// <summary>
        /// Handles the loading of all View Model resources upon creation
        /// </summary>
        public EventHandler<EventArgs> Load;

        /// <summary>
        /// Handles the finalisation of any resources upon the initial closing of the view model
        /// </summary>
        public EventHandler<EventArgs> Close;

        /// <summary>
        /// Handles the finalisation of any resources upon the final stages closing of the view model
        /// </summary>
        public EventHandler<EventArgs> Closing;

        #endregion

        #region Methods

        /// <summary>
        /// Handles the loading of all View Model resources upon creation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual void OnLoad(object sender, EventArgs e) => this.Load?.Invoke(sender, e);

        /// <summary>
        /// Handles the finalisation of any resources upon the initial closing of the view model
        /// </summary>
        /// <param name="sender">Reference to the caller of this function</param>
        /// <param name="e">Event arguments</param>
        public virtual void OnClose(object sender, EventArgs e) => this.Close?.Invoke(sender, e);

        /// <summary>
        /// Handles the finalisation of any resources upon the final stages closing of the view model
        /// </summary>
        /// <param name="sender">Reference to the caller of this function</param>
        /// <param name="e">Event arguments</param>
        public virtual void OnClosing(object sender, EventArgs e) => this.Closing?.Invoke(sender, e);

        #endregion
    }
}
