using Prism.Commands;
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
        /// <summary>
        /// Gets a collection of root items.
        /// </summary>
        public ObservableCollection<TreeItemViewModel> Items { get; private set; } = new ObservableCollection<TreeItemViewModel>();

        /// <summary>
        /// Gets a command which when executed begins the process of connecting to a server.
        /// </summary>
        public ICommand ConnectCommand => _ConnectCommand ??= new DelegateCommand(async () => await ConnectAsync(), CanConnect);
        private DelegateCommand _ConnectCommand;

        /// <summary>
        /// Gets a command which when executed disconnects from the current server.
        /// </summary>
        public ICommand DisconnectCommand => _DisconnectCommand ??= new DelegateCommand(async () => await DisconnectAsync(), CanDisconnect);
        private DelegateCommand _DisconnectCommand;

        /// <summary>
        /// Gets a command which when executed refreshes the tree.
        /// </summary>
        public ICommand RefreshCommand => _RefreshCommand ??= new DelegateCommand(async () => await RefreshAsync(), CanRefresh);
        private DelegateCommand _RefreshCommand;


        public ExplorerViewModel()
        {

        }

        public bool CanConnect()
        {
            return true;
        }

        public async Task ConnectAsync()
        {
            await Task.CompletedTask;
        }

        public bool CanDisconnect()
        {
            return true;
        }

        public async Task DisconnectAsync()
        {
            await Task.CompletedTask;
        }

        public bool CanRefresh()
        {
            return true;
        }

        public async Task RefreshAsync()
        {
            await Task.CompletedTask;
        }
    }
}
