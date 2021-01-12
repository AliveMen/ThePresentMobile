using System;
using System.Collections.ObjectModel;

namespace ThePresent.ViewModels
{
    public class FriendViewModel
    {
        public string Name { get; set; }
        public DateTime PresentDate { get; set; }
        public string SelectedPresent { get; set; }

        public string SelectedPresentId { get; set; }
        public string FirstLetter => Name?.Substring(0, 1) ?? string.Empty;

        public ObservableCollection<PresentViewModel> Presents { get; set; }

        public bool IsRecurrent;
        public string DaysLeft
        {
            get
            {
                var daysLeft = PresentDate.Subtract(DateTime.Now).Days;
                if (daysLeft < 0 && IsRecurrent)
                {
                    daysLeft = PresentDate.AddYears(1).Subtract(DateTime.Now).Days;
                }

                return daysLeft >= 0 ? $"{daysLeft} left": string.Empty;
            }
        }
    }
}