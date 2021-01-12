using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Diagnostics;
using ThePresent.FriendDetail;
using ThePresent.Friends;
using ThePresent.ViewModels;
using FriendViewModel = ThePresent.ViewModels.FriendViewModel;

namespace WorkingWithListview
{
    public partial class CustomCellXaml : ContentPage
    {
        
        public CustomCellXaml()
        {
            InitializeComponent();

            BindingContext = new ThePresent.Friends.FriendViewModel();

        }

        public void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is FriendViewModel selectedFriend)
            {
                Navigation.PushAsync(new FriendDetailPage(selectedFriend));
            }

            friendsView.SelectedItem = null;


        }

        async void OnCellClicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var t = b.CommandParameter;

            await ((ContentPage)((ListView)((ViewCell)((StackLayout)b.Parent).Parent).Parent).Parent).DisplayAlert("Clicked", t + " button was clicked", "OK");
            Debug.WriteLine("clicked" + t);
        }
    }
}

