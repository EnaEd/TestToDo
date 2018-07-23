using System.Collections.ObjectModel;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

namespace TestToDo.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
    
    private MvxCommand _goToItem;
       public System.Windows.Input.ICommand GoToItem
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
    }
        
}