using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Viewer.ViewModels
{
    public class ExplorerViewModel : BindableBase
    {
        public ObservableCollection<TreeItemViewModel> TreeRoot { get; set; }

        public ICommand ConnectCommand { get; set; }

        public ICommand DisconnectCommand  { get; set; }

        public ICommand RefreshCommand { get; set; }

        public ExplorerViewModel()
        {

        }
    }
}
