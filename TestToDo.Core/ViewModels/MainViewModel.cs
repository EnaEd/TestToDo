using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;
using TestToDo.Core.Models;

namespace TestToDo.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
    
    private MvxCommand _goToItem;
       public ICommand GoToItem
        {
            get
            {
                _goToItem = _goToItem ?? new MvxCommand(GoInItem);
                return _goToItem;
            }
        }
        private void GoInItem()
        {
           ShowViewModel<ItemViewModel>();
        }
        private MvxCommand<Item> _openItem;
        public ICommand OpenItem
        {
            get
            {
                _openItem = _openItem ?? new MvxCommand<Item>(DoOpenItem);
                return _openItem;
            }
        }
        public void DoOpenItem(Item item)
        {
            ShowViewModel<ItemViewModel>(item);
        }
    }
        
}