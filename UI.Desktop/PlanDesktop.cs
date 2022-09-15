using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        private Plan PlanActual;

        public PlanDesktop()
        {
            InitializeComponent();
        }
        public PlanDesktop(ModoForm modo) : this()
        {
            this.modo = modo;
            MapearDeDatos();
        }

        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            this.modo = modo;
            PlanLogic pl = new PlanLogic();
            this.PlanActual = pl.GetOne(ID);
            MapearDeDatos();
        }

        public virtual void MapearDeDatos()
        {
            if (modo == ModoForm.Alta)
            {
                this.txtID.Text = "";//Cuando hace el save lo genera automaticamente autoincremental
            }
            else
            {
                this.txtID.Text = this.PlanActual.ID.ToString();
                this.txtDescripcion.Text = this.PlanActual.Descripcion;
                // me falta poner para ID Especialidad

            }

            switch (modo)
            {
                case ModoForm.Alta:
                    this.Text = "Alta";
                    this.btnAceptar.Text = "Guardar";
                    break;

                case ModoForm.Baja:
                    this.Text = "Baja";
                    this.btnAceptar.Text = "Eliminar";
                    break;

                case ModoForm.Modificacion:
                    this.Text = "Modificación";
                    this.btnAceptar.Text = "Guardar";
                    break;

                case ModoForm.Consulta:
                    this.Text = "Consulta";
                    this.btnAceptar.Text = "Aceptar";
                    break;

                default:
                    break;
            }

        }

        public virtual void MapearADatos()
        {
            if (modo == ModoForm.Alta)
            {
                this.PlanActual = new Plan();
            }

            this.PlanActual.Descripcion = this.txtDescripcion.Text.Trim();
            this.PlanActual.State = (BusinessEntity.States)(int)modo;
            //Falta para ID Especialidad

        }

        public virtual void GuardarCambios()
        {
            MapearADatos();
            PlanLogic ml = new PlanLogic();
            ml.Save(PlanActual);
        }


        public virtual bool Validar()
        {
            bool descripcionVal = ValidarCampoVacio(txtDescripcion, errorDescripcion, "La descripcion no puede estar vacia.");
            bool esStringVal = ValidarEsString(txtDescripcion, errorDescripcion, "No se puede ingresar numeros en la descripcion");

            bool isOK = (descripcionVal);

            if (!isOK)
            {
                MessageBox.Show("Hay campos incorrectos, por favor verifique.", "Campos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return isOK;
        }

        private bool ValidarCampoVacio(TextBox txtActual, ErrorProvider erpActual, string mensajeError)
        {
            if (String.IsNullOrEmpty(txtActual.Text.Trim()))
            {
                erpActual.SetError(txtActual, mensajeError);
                return false;
            }
            else
            {
                erpActual.Clear();
                return true;
            }
        }

        private bool ValidarEsString(TextBox txtActual, ErrorProvider erpActual, string mensajeError)
        {
            int n;
            if (Int32.TryParse(txtActual.Text.Trim(), out n))
            {
                erpActual.SetError(txtActual, mensajeError);
                return false;
            }
            else
            {
                erpActual.Clear();
                return true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool ok = Validar();
            if (ok)
            {
                GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
