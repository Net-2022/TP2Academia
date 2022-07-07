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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            this.dgvMaterias.ReadOnly = true; //que sea de solo lectura 
            this.dgvMaterias.AutoGenerateColumns = false; //No agregue columnas automáticamente
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvMaterias.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            AddTextColumn("id", "ID", "ID");
            AddTextColumn("descripcion", "Descripcion", "Descripcion");
            AddTextColumn("horas semanales", "HSSemanales", "HSSemanales");
            AddTextColumn("horas totales", "HSTotales", "HSTotales");
            AddTextColumn("Id Plan", "IDPlan", "IDPlan");

        }

        private void AddTextColumn(string name, string headerText, string dataPropertyName)
        {
            DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
            newColumn.Name = name;
            newColumn.HeaderText = headerText;
            newColumn.DataPropertyName = dataPropertyName;

            this.dgvMaterias.Columns.Add(newColumn);
        }

        public void Listar()
        {
            MateriaLogic ml = new MateriaLogic();
            this.dgvMaterias.DataSource = ml.GetAll(); //se define el origen de datos con el DataSource
        }

        private void Materias_Load(object sender, EventArgs e)
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
            MateriaDesktop materiaDesk = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            materiaDesk.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;

            MateriaDesktop materiaDesk = new MateriaDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            materiaDesk.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Materia)this.dgvMaterias.SelectedRows[0].DataBoundItem).ID;

            MateriaDesktop materiaDesk = new MateriaDesktop(ID, ApplicationForm.ModoForm.Baja);
            materiaDesk.ShowDialog();
            this.Listar();
        }
    }
}
