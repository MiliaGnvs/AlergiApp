using AlergiApp.Models;
using LiteDB;
using System.Linq;
using Xamarin.Forms;

namespace AlergiApp.DataBase
{
    public class AcessDataBase
    {
        LiteDatabase _dataBase;
        LiteCollection<Usuario> Usuarios;
        public AcessDataBase()
        {
            //Verifica se o banco já existe, caso não ele cria
            _dataBase = new LiteDatabase(DependencyService.Get<IFileHelper>().GetFilePath("Banco.db"));
            //Consulta de usuários
            Usuarios = _dataBase.GetCollection<Usuario>();
        }

        public void InsertUsuario(Usuario usuario)
        {
            usuario.IdUsuario = Usuarios.Count() == 0 ? 1 : (int)(Usuarios.Max(x => x.IdUsuario) + 1);
            Usuarios.Insert(usuario);
        }

        public Usuario GetUsuarioByEmail(string email)
        {
            return Usuarios.FindAll().FirstOrDefault(x => x.Email == email);
        }

        public bool Login(string email, string senha)
        {
            var select = Usuarios.FindAll().Where(x => x.Email.ToUpper() == email.ToUpper() && x.Senha == senha).Count();
            return select == 1;
        }
    }
}
