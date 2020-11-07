using System.ComponentModel;
using Xamarin.Forms;
using timechecker.ViewModels;

namespace timechecker.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}