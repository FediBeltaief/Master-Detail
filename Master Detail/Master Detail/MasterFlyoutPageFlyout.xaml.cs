using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Master_Detail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterFlyoutPageFlyout : ContentPage
    {
        public ListView ListView;

        public MasterFlyoutPageFlyout()
        {
            InitializeComponent();

            BindingContext = new MasterFlyoutPageFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class MasterFlyoutPageFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MasterFlyoutPageFlyoutMenuItem> MenuItems { get; set; }

            public MasterFlyoutPageFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<MasterFlyoutPageFlyoutMenuItem>(new[]
                {
                    new MasterFlyoutPageFlyoutMenuItem { Id = 0, Title = "Page 1", TargetType=typeof(P1) },
                    new MasterFlyoutPageFlyoutMenuItem { Id = 1, Title = "Page 2", TargetType=typeof(P2) },
                    new MasterFlyoutPageFlyoutMenuItem { Id = 2, Title = "Page 3", TargetType=typeof(P3) }
                }) ; ; ;
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}