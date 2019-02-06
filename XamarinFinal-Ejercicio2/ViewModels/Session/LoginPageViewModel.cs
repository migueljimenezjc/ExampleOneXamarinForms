using System;
using System.Text.RegularExpressions;
using Acr.UserDialogs;
using Plugin.Connectivity.Abstractions;
using Prism.Commands;
using Prism.Navigation;
using TemplateSpartaneApp.LocalData;
using TemplateSpartaneApp.Models.Catalogs;

namespace TemplateSpartaneApp.ViewModels.Session
{
    public class LoginPageViewModel : ViewModelBase
    {
        private UserSpartaneModel user = new UserSpartaneModel();

        public UserSpartaneModel User{
            get => user;
            set => SetProperty(ref user,value);
        }

        private string messageError;
        public string MessageError{

            get => messageError;
            set => SetProperty(ref messageError, value);
        }

        private bool showMessageError;
        public bool ShowMessageError{
            get => showMessageError;
            set => SetProperty(ref showMessageError,value);
        }

        public DelegateCommand OnLoginCommand { get; set; }

        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            OnLoginCommand = new DelegateCommand(OnLoginCommandExecute);
            Title = "";
            User.Email = "miguel.jimenez.contreras@hotmail.com";
        }

        private void OnLoginCommandExecute()
        {
            if (!Regex.Match(User.Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
            {
                ShowMessageError = true;
                MessageError = "Error Format Email";
                return;
            }
            else if (string.IsNullOrEmpty(User.Email))
            {
                ShowMessageError = true;
                MessageError = "Error Email";
                return;
            }
            else if(string.IsNullOrEmpty(User.Password))
            {
                ShowMessageError = true;
                MessageError = "Error Password";
                return;
            }
            ShowMessageError = false;
            Profile.Instance.Email = User.Email;
            Profile.Instance.UserName = User.Password;
            AppSettings.Instance.Logged = false;
            NavigationService.NavigateAsync(new Uri("http://template.com/Index/Navigation/HomeUser", UriKind.Absolute));


        }
    }
}
