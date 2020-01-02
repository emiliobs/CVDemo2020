using CVDemo2020.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CVDemo2020.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductView : ContentPage
    {
        public ProductView()
        {
            InitializeComponent();

            this.CVProducts.SelectionChanged += CVProducts_SelectionChanged1;
        }

        private void CVProducts_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            var products = e.CurrentSelection;
            string msg = "Selected products \n";
            for (int i = 0; i < products.Count; i++)
            {
                var product = products[i] as Product;
                msg += $"{product.ProductName} ({product.Price})\n";
            }

            DisplayAlert("Demo", msg, "OK");
        }

     
    }
}