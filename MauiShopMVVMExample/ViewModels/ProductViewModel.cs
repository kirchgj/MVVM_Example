
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

using MauiShopMVVMExample.Models;

namespace MauiShopMVVMExample.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public ProductViewModel()
        {

            Product = new Product
            {
                Id = 1,
                Description = "Apple, Malus domestica, is one of the most widely cultivated tree fruits with a fleshy and edible surrounding tissue.",
                ImageUrl = "https://mauiman.dev/mauishopimages/red-apple-isolated.jpg",
                OfferEndDate = new DateTime(2022, 2, 10),
                ProductName = "Apple",
                Price = 2.80
            };
        }
        public Product Product { get; set; }
        public string UserName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
