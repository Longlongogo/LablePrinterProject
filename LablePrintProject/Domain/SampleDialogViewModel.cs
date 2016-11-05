using System;
using System.ComponentModel;
using LablePrintProject.Domain;

namespace LablePrintProject.Domain
{
    public class SampleDialogViewModel : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                this.MutateVerbose(ref _name, value, RaisePropertyChanged());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Action<PropertyChangedEventArgs> RaisePropertyChanged()
        {
            return args => PropertyChanged?.Invoke(this, args);
        }
    }
}