using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Viewer.ViewModels
{
    public class MainViewModel : BindableBase
    {
        [Dependency]
        public ExplorerViewModel Explorer { get; set; }

        [Dependency]
        public SavedItemsViewModel SavedItems { get; set; }

        public MainViewModel()
        {

        }
    }
}
