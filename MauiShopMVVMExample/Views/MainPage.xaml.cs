using MauiShopMVVMExample.ViewModels;

namespace MauiShopMVVMExample.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage(ProductViewModel viewModel)
        {
            InitializeComponent();

            this.BindingContext = viewModel;

        }

        private void SaveProductButton_OnClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Save Command");
        }
    }

}