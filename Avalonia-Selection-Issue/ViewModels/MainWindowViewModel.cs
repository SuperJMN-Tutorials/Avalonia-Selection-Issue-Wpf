using System.Collections.ObjectModel;
using System.Reactive;
using Avalonia_Selection_Issue.ViewModels;
using ReactiveUI;

namespace AvaloniaApplication8.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>(new[]
            {
                new Item { Name = "Item One" }, 
                new Item { Name = "Item TWO" }
            });

            MoveToTop = ReactiveCommand.Create(() => Items.Move(1, 0));
        }

        public ReactiveCommand<Unit, Unit> MoveToTop { get; }

        public ObservableCollection<Item> Items { get; }
    }
}