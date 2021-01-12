using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FriendViewModel = ThePresent.ViewModels.FriendViewModel;

namespace ThePresent.FriendDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendDetailPage : ContentPage
    {
        public FriendDetailPage(FriendViewModel friend)
        {
            BindingContext = friend ?? throw new ArgumentNullException();
                
            InitializeComponent();

        }
    }
}