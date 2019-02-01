using System;
using Prism.Navigation;
using Prism.Commands;
using Prism.Mvvm;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2.ViewModels
{
    public class UserModel
    {
        protected INavigationService NavigationService { get; private set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        private string email;
      

    }
}
