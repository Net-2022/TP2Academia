
namespace UI.Desktop
{
    partial class ModuloUsuarioDesktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloUsuarioDesktop));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdModulo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.erpDescripcion = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.cmbIdModulo = new System.Windows.Forms.ComboBox();
            this.cmbIdUsuario = new System.Windows.Forms.ComboBox();
            this.chkAlta = new System.Windows.Forms.CheckBox();
            this.chkBaja = new System.Windows.Forms.CheckBox();
            this.chkModificacion = new System.Windows.Forms.CheckBox();
            this.chkConsulta = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblIdModulo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblIdUsuario, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbIdModulo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbIdUsuario, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkAlta, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chkBaja, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.chkModificacion, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkConsulta, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.erpDescripcion.SetIconPadding(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 161);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblIdModulo
            // 
            this.lblIdModulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdModulo.AutoSize = true;
            this.lblIdModulo.Location = new System.Drawing.Point(3, 33);
            this.lblIdModulo.Name = "lblIdModulo";
            this.lblIdModulo.Size = new System.Drawing.Size(53, 13);
            this.lblIdModulo.TabIndex = 1;
            this.lblIdModulo.Text = "IDModulo";
            // 
            // txtID
            // 
            this.txtID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.erpDescripcion.SetIconPadding(this.txtID, 3);
            this.txtID.Location = new System.Drawing.Point(63, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.btnCancelar, 2);
            this.btnCancelar.Location = new System.Drawing.Point(300, 134);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(63, 24);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(213, 134);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(81, 24);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblId
            // 
            this.lblId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(21, 6);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // erpDescripcion
            // 
            this.erpDescripcion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpDescripcion.ContainerControl = this;
            this.erpDescripcion.Icon = ((System.Drawing.Icon)(resources.GetObject("erpDescripcion.Icon")));
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(3, 60);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(54, 13);
            this.lblIdUsuario.TabIndex = 10;
            this.lblIdUsuario.Text = "IDUsuario";
            // 
            // cmbIdModulo
            // 
            this.cmbIdModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbIdModulo.FormattingEnabled = true;
            this.cmbIdModulo.Location = new System.Drawing.Point(63, 29);
            this.cmbIdModulo.Name = "cmbIdModulo";
            this.cmbIdModulo.Size = new System.Drawing.Size(121, 21);
            this.cmbIdModulo.TabIndex = 1;
            // 
            // cmbIdUsuario
            // 
            this.cmbIdUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbIdUsuario.FormattingEnabled = true;
            this.cmbIdUsuario.Location = new System.Drawing.Point(63, 56);
            this.cmbIdUsuario.Name = "cmbIdUsuario";
            this.cmbIdUsuario.Size = new System.Drawing.Size(121, 21);
            this.cmbIdUsuario.TabIndex = 2;
            // 
            // chkAlta
            // 
            this.chkAlta.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkAlta, 2);
            this.chkAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAlta.Location = new System.Drawing.Point(190, 3);
            this.chkAlta.Name = "chkAlta";
            this.chkAlta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAlta.Size = new System.Drawing.Size(124, 20);
            this.chkAlta.TabIndex = 3;
            this.chkAlta.Text = "Permite Alta";
            this.chkAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAlta.UseVisualStyleBackColor = true;
            // 
            // chkBaja
            // 
            this.chkBaja.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkBaja, 2);
            this.chkBaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBaja.Location = new System.Drawing.Point(190, 29);
            this.chkBaja.Name = "chkBaja";
            this.chkBaja.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBaja.Size = new System.Drawing.Size(124, 21);
            this.chkBaja.TabIndex = 4;
            this.chkBaja.Text = "Permite Baja";
            this.chkBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBaja.UseVisualStyleBackColor = true;
            // 
            // chkModificacion
            // 
            this.chkModificacion.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkModificacion, 2);
            this.chkModificacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkModificacion.Location = new System.Drawing.Point(190, 56);
            this.chkModificacion.Name = "chkModificacion";
            this.chkModificacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkModificacion.Size = new System.Drawing.Size(124, 21);
            this.chkModificacion.TabIndex = 5;
            this.chkModificacion.Text = "Permite Modificacion";
            this.chkModificacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkModificacion.UseVisualStyleBackColor = true;
            // 
            // chkConsulta
            // 
            this.chkConsulta.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkConsulta, 2);
            this.chkConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkConsulta.Location = new System.Drawing.Point(190, 83);
            this.chkConsulta.Name = "chkConsulta";
            this.chkConsulta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkConsulta.Size = new System.Drawing.Size(124, 17);
            this.chkConsulta.TabIndex = 6;
            this.chkConsulta.Text = "Permite Consulta";
            this.chkConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkConsulta.UseVisualStyleBackColor = true;
            // 
            // ModuloUsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModuloUsuarioDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpDescripcion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdModulo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ErrorProvider erpDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.ComboBox cmbIdModulo;
        private System.Windows.Forms.ComboBox cmbIdUsuario;
        private System.Windows.Forms.CheckBox chkAlta;
        private System.Windows.Forms.CheckBox chkBaja;
        private System.Windows.Forms.CheckBox chkModificacion;
        private System.Windows.Forms.CheckBox chkConsulta;
    }
}