
namespace Gestao__de_Contrato.Formes.Contrato
{
    partial class ListarContratosForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListarContratosForms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grouplista = new System.Windows.Forms.GroupBox();
            this.btn_Detalhar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioContrato = new System.Windows.Forms.RadioButton();
            this.radioTodos = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.maskdataInicio = new System.Windows.Forms.MaskedTextBox();
            this.TipoStatus = new System.Windows.Forms.ComboBox();
            this.comboContrato = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.drigContratos = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grouplista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drigContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grouplista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 458);
            this.panel1.TabIndex = 0;
            // 
            // grouplista
            // 
            this.grouplista.Controls.Add(this.btn_Detalhar);
            this.grouplista.Controls.Add(this.btn_Excluir);
            this.grouplista.Controls.Add(this.btn_Editar);
            this.grouplista.Controls.Add(this.radioButton3);
            this.grouplista.Controls.Add(this.radioContrato);
            this.grouplista.Controls.Add(this.radioTodos);
            this.grouplista.Controls.Add(this.label4);
            this.grouplista.Controls.Add(this.maskdataInicio);
            this.grouplista.Controls.Add(this.TipoStatus);
            this.grouplista.Controls.Add(this.comboContrato);
            this.grouplista.Controls.Add(this.label2);
            this.grouplista.Controls.Add(this.label1);
            this.grouplista.Controls.Add(this.button2);
            this.grouplista.Controls.Add(this.drigContratos);
            this.grouplista.Controls.Add(this.btnAdicionar);
            this.grouplista.Location = new System.Drawing.Point(12, 12);
            this.grouplista.Name = "grouplista";
            this.grouplista.Size = new System.Drawing.Size(872, 430);
            this.grouplista.TabIndex = 4;
            this.grouplista.TabStop = false;
            this.grouplista.Text = "Lista Contratros";
            // 
            // btn_Detalhar
            // 
            this.btn_Detalhar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_Detalhar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Detalhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detalhar.ForeColor = System.Drawing.Color.Navy;
            this.btn_Detalhar.Location = new System.Drawing.Point(128, 15);
            this.btn_Detalhar.Name = "btn_Detalhar";
            this.btn_Detalhar.Size = new System.Drawing.Size(97, 24);
            this.btn_Detalhar.TabIndex = 35;
            this.btn_Detalhar.Text = "Detalhar";
            this.btn_Detalhar.UseVisualStyleBackColor = true;
            this.btn_Detalhar.Click += new System.EventHandler(this.btn_Detalhar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Excluir.Location = new System.Drawing.Point(128, 43);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(97, 24);
            this.btn_Excluir.TabIndex = 33;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btn_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.ForeColor = System.Drawing.Color.Navy;
            this.btn_Editar.Location = new System.Drawing.Point(6, 43);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(97, 24);
            this.btn_Editar.TabIndex = 32;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(482, 47);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(66, 17);
            this.radioButton3.TabIndex = 31;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Vigência";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioContrato
            // 
            this.radioContrato.AutoSize = true;
            this.radioContrato.Location = new System.Drawing.Point(560, 47);
            this.radioContrato.Name = "radioContrato";
            this.radioContrato.Size = new System.Drawing.Size(65, 17);
            this.radioContrato.TabIndex = 30;
            this.radioContrato.TabStop = true;
            this.radioContrato.Text = "Contrato";
            this.radioContrato.UseVisualStyleBackColor = true;
            this.radioContrato.CheckedChanged += new System.EventHandler(this.radioContrato_CheckedChanged);
            // 
            // radioTodos
            // 
            this.radioTodos.AutoSize = true;
            this.radioTodos.Location = new System.Drawing.Point(421, 47);
            this.radioTodos.Name = "radioTodos";
            this.radioTodos.Size = new System.Drawing.Size(55, 17);
            this.radioTodos.TabIndex = 29;
            this.radioTodos.TabStop = true;
            this.radioTodos.Text = "Todas";
            this.radioTodos.UseVisualStyleBackColor = true;
            this.radioTodos.CheckedChanged += new System.EventHandler(this.radioTodos_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(580, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Status";
            // 
            // maskdataInicio
            // 
            this.maskdataInicio.Location = new System.Drawing.Point(631, 44);
            this.maskdataInicio.Mask = "00/00/0000";
            this.maskdataInicio.Name = "maskdataInicio";
            this.maskdataInicio.Size = new System.Drawing.Size(128, 20);
            this.maskdataInicio.TabIndex = 23;
            this.maskdataInicio.ValidatingType = typeof(System.DateTime);
            // 
            // TipoStatus
            // 
            this.TipoStatus.FormattingEnabled = true;
            this.TipoStatus.Location = new System.Drawing.Point(631, 15);
            this.TipoStatus.Name = "TipoStatus";
            this.TipoStatus.Size = new System.Drawing.Size(128, 21);
            this.TipoStatus.TabIndex = 19;
            // 
            // comboContrato
            // 
            this.comboContrato.FormattingEnabled = true;
            this.comboContrato.Location = new System.Drawing.Point(442, 15);
            this.comboContrato.Name = "comboContrato";
            this.comboContrato.Size = new System.Drawing.Size(132, 21);
            this.comboContrato.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(378, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Contrato";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(780, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 30);
            this.button2.TabIndex = 15;
            this.button2.Tag = "";
            this.button2.Text = "Buscar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // drigContratos
            // 
            this.drigContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drigContratos.Location = new System.Drawing.Point(6, 69);
            this.drigContratos.Name = "drigContratos";
            this.drigContratos.Size = new System.Drawing.Size(860, 357);
            this.drigContratos.TabIndex = 0;
            this.drigContratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drigContratos_CellContentClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.Navy;
            this.btnAdicionar.Location = new System.Drawing.Point(6, 15);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(97, 24);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Novo";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // ListarContratosForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 458);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListarContratosForms";
            this.Text = "ListarContratosForms";
            this.panel1.ResumeLayout(false);
            this.grouplista.ResumeLayout(false);
            this.grouplista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drigContratos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grouplista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView drigContratos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox TipoStatus;
        private System.Windows.Forms.ComboBox comboContrato;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioContrato;
        private System.Windows.Forms.RadioButton radioTodos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskdataInicio;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Detalhar;
    }
}