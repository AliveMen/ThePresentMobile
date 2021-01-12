using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ThePresent.Annotations;
using ThePresent.ViewModels;

namespace ThePresent.Friends
{
    public class FriendViewModel : INotifyPropertyChanged
    {
        public FriendViewModel()
        {
            Friends = new ObservableCollection<ViewModels.FriendViewModel>()
            {
                new ViewModels.FriendViewModel()
                {
                    Name = "Вика", PresentDate = new DateTime(2021, 01, 5), SelectedPresent = "DJI mini 2" ,
                    Presents = new ObservableCollection<PresentViewModel>()
                    {
                        new PresentViewModel()  {  Name = "Подарок номер 2" },
                        new PresentViewModel()  {  Name = "Подарок номер 3" }
                    }

                },
                new ViewModels.FriendViewModel() { Name = "Мира", PresentDate = new DateTime(2015, 12, 16), SelectedPresent = "Ipod Headphones", IsRecurrent = true},
                new ViewModels.FriendViewModel() { Name = "Саша", PresentDate = new DateTime(2021, 10, 5), SelectedPresent = "Silver ring", IsRecurrent = true},
                new ViewModels.FriendViewModel() { Name = "Алёна", PresentDate = new DateTime(2020, 10, 5), SelectedPresent = "Lego", IsRecurrent = true},
                new ViewModels.FriendViewModel() { Name = "Игорь", PresentDate = new DateTime(1989, 10, 5), SelectedPresent = "Теплая простыня" },
                new ViewModels.FriendViewModel() { Name = "Igor", PresentDate = new DateTime(1989, 10, 5), SelectedPresent = "Silver ring" },
                new ViewModels.FriendViewModel() { Name = "Igor", PresentDate = new DateTime(1989, 10, 5), SelectedPresent = "Silver ring" },
                new ViewModels.FriendViewModel() { Name = "Igor", PresentDate = new DateTime(1989, 10, 5), SelectedPresent = "Silver ring" },
                new ViewModels.FriendViewModel() { Name = "Igor", PresentDate = new DateTime(1989, 10, 5), SelectedPresent = "Silver ring" },
                new ViewModels.FriendViewModel() { Name = "Igor", PresentDate = new DateTime(1989, 10, 5), SelectedPresent = "Silver ring" },
                new ViewModels.FriendViewModel() { Name = "Igor", PresentDate = new DateTime(1989, 10, 5), SelectedPresent = "Silver ring" },
                new ViewModels.FriendViewModel() { Name = "Igor", PresentDate = new DateTime(1989, 10, 5), SelectedPresent = "Silver ring" },
                new ViewModels.FriendViewModel() { Name = "Igor", PresentDate = new DateTime(1989, 10, 5), SelectedPresent = "Silver ring" }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<ViewModels.FriendViewModel> Friends { get; set; }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}