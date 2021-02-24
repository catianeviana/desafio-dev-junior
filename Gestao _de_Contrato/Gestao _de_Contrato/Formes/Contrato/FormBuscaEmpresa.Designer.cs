
namespace Gestao__de_Contrato.Formes.Contrato
{
    partial class FormBuscaEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscaEmpresa));
            this.drigEmpresas = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grouplista = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtRazao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drigEmpresas)).BeginInit();
            this.grouplista.SuspendLayout();
            this.SuspendLayout();
            // 
            // drigEmpresas
            // 
            this.drigEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drigEmpresas.Location = new System.Drawing.Point(107, 74);
            this.drigEmpresas.Name = "drigEmpresas";
            this.drigEmpresas.Size = new System.Drawing.Size(692, 378);
            this.drigEmpresas.TabIndex = 0;
            this.drigEmpresas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.drigEmpresas_CellContentClick);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.Navy;
            this.btnAdicionar.Location = new System.Drawing.Point(6, 77);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(95, 40);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // grouplista
            // 
            this.grouplista.Controls.Add(this.label2);
            this.grouplista.Controls.Add(this.label1);
            this.grouplista.Controls.Add(this.button2);
            this.grouplista.Controls.Add(this.txtRazao);
            this.grouplista.Controls.Add(this.btnCancelar);
            this.grouplista.Controls.Add(this.drigEmpresas);
            this.grouplista.Controls.Add(this.btnAdicionar);
            this.grouplista.Location = new System.Drawing.Point(12, 12);
            this.grouplista.Name = "grouplista";
            this.grouplista.Size = new System.Drawing.Size(805, 458);
            this.grouplista.TabIndex = 2;
            this.grouplista.TabStop = false;
            this.grouplista.Text = "Lista Empresas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(152, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filtro por CNPJ/RAZÂO ou se estiver  vazio lista todos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Filtrar";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(713, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 38);
            this.button2.TabIndex = 15;
            this.button2.Tag = "";
            this.button2.Text = "Buscar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRazao
            // 
            this.txtRazao.Location = new System.Drawing.Point(151, 32);
            this.txtRazao.Name = "txtRazao";
            this.txtRazao.Size = new System.Drawing.Size(548, 20);
            this.txtRazao.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(6, 132);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(95, 37);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBuscaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 482);
            this.Controls.Add(this.grouplista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuscaEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuscaEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.drigEmpresas)).EndInit();
            this.grouplista.ResumeLayout(false);
            this.grouplista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView drigEmpresas;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox grouplista;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtRazao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}