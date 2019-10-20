using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace AlergiApp.ViewModels
{
    public class CadastroViewModel : BaseViewModel
    {
        private string _Nome;
        private string _Sobrenome;
        private string _Email;
        private string _Senha;
        private DateTime _DataNasc;

        public ICommand CriarConta_Command;

        public CadastroViewModel()
        {
            Nome = string.Empty;
            Sobrenome = string.Empty;
            Email = string.Empty;
            Senha = string.Empty;
            DataNasc = DateTime.Now;

            CriarConta_Command = new Command(() =>
            {

            });
        }
        
        public string Nome
        {
            get => _Nome;
            set => _Nome = value;
        }
        public string Sobrenome
        {
            get => _Sobrenome;
            set => _Sobrenome = value;
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
        public DateTime DataNasc
        {
            get => _DataNasc;
            set => _DataNasc = value;
        }


    }
}
