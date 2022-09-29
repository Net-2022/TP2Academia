using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web
{
    public partial class Home : System.Web.UI.Page
    {
        private UsuarioLogic _usuarioLogic = new UsuarioLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try
            {
                Usuario user = _usuarioLogic.GetAll().Single((u) => u.NombreUsuario == this.Login1.UserName && u.Clave == this.Login1.Password);
                this.ViewState["LoggedUserID"] = user.ID;
                e.Authenticated = true;
            }
            catch (Exception)
            {
                this.Login1.InstructionText = "No coinciden los datos con un usuario registrado.";
                e.Authenticated = false;
            }
        }


    }
}