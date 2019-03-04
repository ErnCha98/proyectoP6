using CapaLogica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EcoMonedasWeb
{
    public partial class MantenimientoAdministradores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable ListaRoles()
        {
            return rolLN.ListaRoles();
        }

        private int esHabilitado()
        {
            if (chkHabilitar.Checked)
                return 1;
            else
                return 0;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            // Agregar Elemento a la BD
            administradoresLN Elementos = new administradoresLN();
            bool addSuccess = Elementos.
                AgregarAdmistrador(txtNombre.Text, ddlTipoRoles.SelectedValue, esHabilitado()
                ,txtContraDos.Text,
                 hiddenID.Value);
            if (addSuccess)
            {
                // Recargar la pagina
                string pageUrl = Request.Url.AbsoluteUri.Substring(0, Request.Url.AbsoluteUri.Count() - Request.Url.Query.Count());
                Response.Redirect(pageUrl + "?action=save");
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.Text = "No se puede agregar el administrador al sistema";
            }


        }

        protected void grvListado_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}