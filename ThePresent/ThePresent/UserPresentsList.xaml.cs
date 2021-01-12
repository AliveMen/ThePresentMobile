using System.Collections.ObjectModel;
using ThePresent.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePresent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPresentsList : ContentPage
    {
        private ObservableCollection<PresentViewModel> Presents { get; set; }

        public UserPresentsList()
        {
            Presents = new ObservableCollection<PresentViewModel>()
            {
                new PresentViewModel()
                {
                    Name = "Контактные педали", 
                    Description = "Shimanp SPD 515", 
                    ImageUrl = "https://mountainpeaks.ru/upload/iblock/baa/eb8e53da6e8311e1b58ed027885a8ece_eec33370bad011e1bbced027885a8ece.resize1.jpg"
                },
                new PresentViewModel()
                {
                    Name = "Контактные педали",
                    Description = "Shimanp SPD 515",
                    ImageUrl = "https://mountainpeaks.ru/upload/iblock/baa/eb8e53da6e8311e1b58ed027885a8ece_eec33370bad011e1bbced027885a8ece.resize1.jpg"
                },
                new PresentViewModel()
                {
                    Name = "Контактные педали",
                    Description = "Shimanp SPD 515",
                    ImageUrl = "https://mountainpeaks.ru/upload/iblock/baa/eb8e53da6e8311e1b58ed027885a8ece_eec33370bad011e1bbced027885a8ece.resize1.jpg"
                }
            };
            InitializeComponent();
        }
    }
}