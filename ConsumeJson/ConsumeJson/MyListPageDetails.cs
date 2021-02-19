using Xamarin.Forms;

namespace ConsumeLocalJson
{
    internal class MyListPageDetails : Page
    {
        private string name;
        private string email;
        private string image;

        public MyListPageDetails(string name, string email, string image)
        {
            this.name = name;
            this.email = email;
            this.image = image;
        }
    }
}