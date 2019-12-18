using BoxManager.BS.Models;
using BoxManager.DAL;

namespace BoxManager.BS
{
    public class LoginService
    {
        public int Login(LoginModel loginModel) 
        {
            var tenantId = -1;

            var usuario = new AdministradorDAL().GetAdministrador(loginModel.Usuario);
            if (usuario != null && usuario.contrasenia == loginModel.Password) 
            {
                tenantId = usuario.idTenant;
            }

            return tenantId;
        }
    }
}
