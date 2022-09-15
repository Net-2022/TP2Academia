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
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            this.dgvPlanes.ReadOnly = true; //que sea de solo lectura 
            this.dgvPlanes.AutoGenerateColumns = false; //No agregue columnas automáticamente
            this.dgvPlanes.AllowUserToAddRows = false;
            this.dgvPlanes.AllowUserToDeleteRows = false;
            this.dgvPlanes.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvPlanes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            AddTextColumn("id", "ID", "ID");
            AddTextColumn("descripcion", "Descripcion", "Descripcion");
            // AddTextColumn("id especialidad", "IDEspecialidad", "IDEspecialidad");

        }

        private void AddTextColumn(string name, string headerText, string dataPropertyName)
        {
            DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
            newColumn.Name = name;
            newColumn.HeaderText = headerText;
            newColumn.DataPropertyName = dataPropertyName;

            this.dgvPlanes.Columns.Add(newColumn);
        }
        public void Listar()
        {
                PlanLogic ml = new PlanLogic();
                this.dgvPlanes.DataSource = ml.GetAll(); //se define el origen de datos con el DataSource
        }

        private void Planes_Load(object sender, EventArgs e)
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
            PlanDesktop planDesk = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            planDesk.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;

            PlanDesktop planDesk = new PlanDesktop(ApplicationForm.ModoForm.Modificacion);
            planDesk.ShowDialog();
            this.Listar();

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;

            PlanDesktop planDesk = new PlanDesktop(ApplicationForm.ModoForm.Baja);
            planDesk.ShowDialog();
            this.Listar();

        }
    }
}
