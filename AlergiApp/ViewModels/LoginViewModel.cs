using AlergiApp.DataBase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AlergiApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _Email;
        private string _Senha;

        public ICommand Entrar_Command;
        AcessDataBase dataBase = new AcessDataBase();

        public LoginViewModel()
        {
            Email = string.Empty;
            Senha = string.Empty;

            Entrar_Command = new Command(() =>
            {
                try
                {
                    if(dataBase.Login(Email, Senha))
                    {
                        App.Current.MainPage = new MainPage();
                    }
                    else
                    {
                        MostrarMensagem.Mostrar("Usuário não cadastrado!");
                    }
                }
                catch (Exception ex)
                {
                    MostrarMensagem.Mostrar(ex.Message);
                }
            });
        }

        public string Email
        {
            get => _Email;
            set => _Email = value;
        }
        public string Senha
        {
            get => _Senha;
            set => _Senha = value;
        }
    }
}
