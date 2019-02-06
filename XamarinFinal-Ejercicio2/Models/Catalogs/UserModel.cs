using System;
using Prism.Navigation;
using TemplateSpartaneApp.ViewModels;

namespace TemplateSpartaneApp.Models.Catalogs
{
    public class UserModel
    {
        public string Username{get;set;}
        public string Password { get; set; }
        public string Email{ get; set; }
        public DateTime DataAccess { get; set; }
        public bool LogIn { get; set; }
    }
}
