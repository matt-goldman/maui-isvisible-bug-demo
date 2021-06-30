using Microsoft.Maui.Controls;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace maui_isvisible_bug_demo
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private bool showLabel;

        public bool ShowLabel
        {
            get => showLabel;
            set
            {
                showLabel = value;
                OnPropertyChanged(nameof(ShowLabel));
            }
        }

        public ICommand ShowHideCommand { get; set; }

        public MainViewModel()
        {
            ShowHideCommand = new Command(() => ShowHideLabel());
        }

        private void ShowHideLabel()
        {
            ShowLabel = !ShowLabel;
            Console.WriteLine($"Label should be visible: {ShowLabel}");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
