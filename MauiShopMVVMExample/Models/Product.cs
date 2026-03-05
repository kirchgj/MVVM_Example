using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiShopMVVMExample.Models
{
    public class Product
    {
        private int id;
        private string productName;
        private string description;
        private double price;
        private string imageUrl;
        private DateTime offerEndDate;

        public int Id
        {
            get => id;
            set
            {
                id = value;

            }
        }

        public string ProductName
        {
            get => productName;
            set
            {
                productName = value;

            }
        }

        public string Description
        {
            get => description;
            set
            {
                description = value;

            }
        }

        public double Price
        {
            get => price;
            set
            {
                price = value;

            }
        }

        public string ImageUrl
        {
            get => imageUrl;
            set
            {
                imageUrl = value;

            }
        }

        public DateTime OfferEndDate
        {
            get => offerEndDate;
            set
            {
                offerEndDate = value;

            }
        }


    }
}
