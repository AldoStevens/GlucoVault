using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsumeJson.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyListPageDetail : ContentPage
    {
        public MyListPageDetail(string name, string ingredients, string source)
        {
            InitializeComponent();

            MyItemNameShow.Text = name;
            MyIngredientsItemShow.Text = ingredients;
            MyImageCall.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };
        }
    }
}