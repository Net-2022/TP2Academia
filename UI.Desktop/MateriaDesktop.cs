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
    public partial class MateriaDesktop : ApplicationForm
    {
        private Materia MateriaActual;

        public MateriaDesktop()
        {
            InitializeComponent();
        }
        public MateriaDesktop(ModoForm modo) : this()
        {
            this.modo = modo;
            MapearDeDatos();
        }

        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            this.modo = modo;
            MateriaLogic ml = new MateriaLogic();
            this.MateriaActual = ml.GetOne(ID);
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
                this.txtID.Text = this.MateriaActual.ID.ToString();
                this.txtDescripcion.Text = this.MateriaActual.Descripcion;
                this.txtHSSemanales.Text = this.MateriaActual.HSSemanales.ToString();
                this.txtHSTotales.Text = this.MateriaActual.HSTotales.ToString();
                this.txtIDPlan.Text = this.MateriaActual.IDPlan.ToString();
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
                this.MateriaActual = new Materia();
            }
            this.MateriaActual.HSSemanales = Convert.ToInt32(this.txtHSSemanales.Text.Trim());
            this.MateriaActual.HSTotales = Convert.ToInt32(this.txtHSTotales.Text.Trim());
            this.MateriaActual.IDPlan = int.Parse(this.txtIDPlan.Text.Trim());
            this.MateriaActual.Descripcion = this.txtDescripcion.Text.Trim();
            this.MateriaActual.State = (BusinessEntity.States)(int)modo;

        }

        public virtual void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic ml = new MateriaLogic();
            ml.Save(MateriaActual);

        }

        public virtual bool Validar()
        {
            bool descripcionVal = ValidarCampoVacio(txtDescripcion, errorDescripcion, "La descripcion no puede estar vacia.");
            bool idPlanVal = ValidarCampoVacio(txtIDPlan, errorIDPlan, "El Id del Plan no puede estar vacio.");
            bool hsSemanalesVal = ValidarCampoVacio(txtHSSemanales, errorHSSemanales, "las horas semanales no puede estar vacio.");
            bool hsTotalesVal = ValidarCampoVacio(txtHSTotales, errorHSTotales, "las horas totales no puede estar vacio.");

            bool isOK = (descripcionVal && idPlanVal && hsSemanalesVal && hsTotalesVal);

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
