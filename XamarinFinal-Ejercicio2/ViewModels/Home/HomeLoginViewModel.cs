using System;
using Acr.UserDialogs;
using Plugin.Connectivity.Abstractions;
using Prism.Navigation;
using TemplateSpartaneApp.LocalData;

namespace TemplateSpartaneApp.ViewModels.Home
{
    public class HomeLoginViewModel:ViewModelAbstraction
    {
        public string Username { get; set; }
        public HomeLoginViewModel(INavigationService navigationService, IUserDialogs userDialogsService,
                                  IConnectivity connectivity) : base(navigationService, userDialogsService, connectivity)
        {
            TitleToolbar = "Home";
            Username = Profile.Instance.Email;
        }
    }
}
