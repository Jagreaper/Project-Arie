using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Jagerts.Arie.Standard.Mvvm
{
    /// <summary>
    /// Abstract class that defines useable functions for a Model type in the Mvvm pattern
    /// </summary>
    public abstract class ObservableObject : INotifyPropertyChanged
    {
        #region Events

        /// <summary>
        /// An event that flags a property as dirty for the user interface
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        /// <summary>
        /// A method that checks to see if a given property exists and then raises a property changed event
        /// </summary>
        /// <param name="propertyName">The name of the property that has changed</param>
        public void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (propertyName != null)
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            else
                throw new NullReferenceException();
        }

        /// <summary>
        /// Updates the property to the new values and raises a property changed event
        /// </summary>
        /// <typeparam name="T">Property type</typeparam>
        /// <param name="property">Reference to property</param>
        /// <param name="value">Value to update property to</param>
        /// <param name="propertyName">The name of the property that has changed</param>
        public void Set<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            property = value;
            this.RaisePropertyChanged(propertyName);
        }

        #endregion
    }
}
