using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;

namespace PlatAuction
{
    public partial class Auctions : ContentPage
    {
        public Auctions()
        {
            InitializeComponent();
        }

        public async void Button_Clicked(object sender, EventArgs e){
            MobileServiceClient client = new MobileServiceClient("http://TCarney-640G2.nepbroadcasting.com/PlatAuction/");

            var todoItems = await client.GetTable<ToDoItem>().ReadAsync();
            message.Text = todoItems.First().Text;
        }
    }
}
