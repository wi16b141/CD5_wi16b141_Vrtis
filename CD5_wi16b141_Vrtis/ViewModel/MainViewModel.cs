using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System;
using System.Windows.Media.Imaging;
using GalaSoft.MvvmLight.CommandWpf;

namespace CD5_wi16b141_Vrtis.ViewModel
{    
    public class MainViewModel : ViewModelBase
    {   
        private ToyVm currentToy;
        private RelayCommand<ItemVm> btnBuyClicked;

        //properties
        public ToyVm CurrentToy
        {
            get { return currentToy; }
            set { currentToy = value; RaisePropertyChanged(); }
        }
        public ObservableCollection<ToyVm> Toys { get; set; }
        public ObservableCollection<ItemVm> ShoppingCart { get; set; }        
        public RelayCommand<ItemVm> BtnBuyClicked
        {
            get
            {
                return btnBuyClicked;
            }

            set
            {
                btnBuyClicked = value; RaisePropertyChanged();
            }
        }

        public MainViewModel()
        {
            Toys = new ObservableCollection<ToyVm>();
            ShoppingCart = new ObservableCollection<ItemVm>();
            BtnBuyClicked = new RelayCommand<ItemVm>((p)=> { ShoppingCart.Add(p); }, (p) => { return true; });
            GenerateDemoData();
        }
        private void GenerateDemoData()
        {
            ObservableCollection<ItemVm> lego = new ObservableCollection<ItemVm>();
            lego.Add(new ItemVm("Lego 2", new BitmapImage(new Uri("Images/lego2.jpg", UriKind.Relative)), "5+"));
            lego.Add(new ItemVm("Lego 3", new BitmapImage(new Uri("Images/lego3.jpg", UriKind.Relative)), "8-10"));
            lego.Add(new ItemVm("Lego 4", new BitmapImage(new Uri("Images/lego4.jpg", UriKind.Relative)), "8+"));

            ObservableCollection<ItemVm> playmobil = new ObservableCollection<ItemVm>();
            playmobil.Add(new ItemVm("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            playmobil.Add(new ItemVm("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            playmobil.Add(new ItemVm("Playmobil 2", new BitmapImage(new Uri("Images/playmobil2.jpg", UriKind.Relative)), "5+"));
            playmobil.Add(new ItemVm("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            playmobil.Add(new ItemVm("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));
            playmobil.Add(new ItemVm("Playmobil 3", new BitmapImage(new Uri("Images/playmobil3.jpg", UriKind.Relative)), "10+"));

            Toys.Add(new ToyVm("MY Lego", new BitmapImage((new Uri("Images/lego1.jpg", UriKind.Relative))), lego));
            Toys.Add(new ToyVm("MY Playmobil", new BitmapImage((new Uri("Images/playmobil1.jpg", UriKind.Relative))), playmobil));
        }
    }
}