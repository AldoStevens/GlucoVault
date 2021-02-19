using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ConsumeJson.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace ConsumeLocalJson
{
    public partial class MainPage : ContentPage
    {

        private ObservableCollection<TestModel> myrootobject;

        public MainPage()
        {
            InitializeComponent();


            BindingContext = this;
            var assembly = typeof(MainPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("ConsumeJson.testmodel.json");


            using (var reader = new System.IO.StreamReader(stream))
            {
                var json = reader.ReadToEnd();

                List<TestModel> mylist = JsonConvert.DeserializeObject<List<TestModel>>(json);
                myrootobject = new ObservableCollection<TestModel>(mylist);
                MyListView.ItemsSource = myrootobject;

            }



        }

     

        async private void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var mydetails = e.Item as TestModel;

            await Navigation.PushModalAsync(new MyListPageDetails(mydetails.name, mydetails.ingredients, mydetails.image));
        }

        

    }
}