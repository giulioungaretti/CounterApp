
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Models;

using System.Windows.Input;

namespace BlankApp.ViewModels
{
    public class CounterViewModel : ObservableObject
    {
        private readonly Counter _counter;
        public ICommand IncrementCmd { get; }
        public ICommand DecrementCmd { get; }
        public int CounterValue
        {
            get => _counter.Value;
            set => SetProperty(_counter.Value, value, _counter, (model, name) => model.Value = name);
        }
        private void Increment() => CounterValue++;
        private void Decrement() => CounterValue--;

        public CounterViewModel(Counter counter)
        {
            _counter = counter;
            IncrementCmd = new RelayCommand(Increment);
            DecrementCmd = new RelayCommand(Decrement);
        }

        public CounterViewModel() : this(new() { Value = 0 }) { }
    }
}
