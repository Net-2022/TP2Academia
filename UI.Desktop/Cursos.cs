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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
            this.dvgCursos.ReadOnly = true; //que sea de solo lectura 
            this.dvgCursos.AutoGenerateColumns = false; //No agregue columnas automáticamente
        }

        public void Listar()
        {
            CursoLogic cl = new CursoLogic();
            this.dvgCursos.DataSource = cl.GetAll(); //se define el origen de datos con el DataSource
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop cursoDesk = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            cursoDesk.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Curso)this.dvgCursos.SelectedRows[0].DataBoundItem).ID;

            CursoDesktop cursoDesk = new CursoDesktop(ApplicationForm.ModoForm.Modificacion);
            cursoDesk.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Curso)this.dvgCursos.SelectedRows[0].DataBoundItem).ID;

            CursoDesktop cursoDesk = new CursoDesktop(ApplicationForm.ModoForm.Baja);
            cursoDesk.ShowDialog();
            this.Listar();
        }
    }
}
