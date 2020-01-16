using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using PrismBindable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismBindable.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public User User { get; }
        private IPageDialogService _pageDialogService;


        private DelegateCommand<Follower> _followersTapCommand;
        public DelegateCommand<Follower> FollowersTapCommand =>
            _followersTapCommand ?? (_followersTapCommand = new DelegateCommand<Follower>(ExecuteFollowersTapCommand));

        async void ExecuteFollowersTapCommand(Follower follower)
        {
            await _pageDialogService.DisplayAlertAsync("Bindable Command", "You Tapped on: " + follower.Name, "Ok");
        }

        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
            : base(navigationService)
        {
            Title = "Main Page";

            _pageDialogService = pageDialogService;

            User = new User
            {
                Username = "davidortinau",
                Email = "daortin@microsoft.com",
                TopFollowers = new List<Follower>
              {
                    new Follower{ Name = "Miguel", Url =
                    "https://avatars0.githubusercontent.com/u/36863?s=400&v=4" },
                     new Follower{ Name = "Follower 2", Url =
                    "https://avatars2.githubusercontent.com/u/7827070?s=460&v=4" }
                    
/*                    "https://avatars0.githubusercontent.com/u/313003?s=400&v=4",
                    "https://avatars0.githubusercontent.com/u/538025?s=400&v=4",
                    "https://avatars2.githubusercontent.com/u/5375137?s=400&v=4",
                    "https://avatars3.githubusercontent.com/u/1235097?s=400&v=4",*/
              },
                FavoriteTech = new string[]
              {
                    ".NET", "C#", "Xamarin.Forms", "XAML", "SkiaSharp", "Azure"
              },
                Achievements = new string[]
              {
                    "\uf2d2", "\uf2ba", "\uf30c"
              }
            };
        }


    
    }
}
