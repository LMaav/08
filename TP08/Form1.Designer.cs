namespace TP08
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtg_Cliente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.ckb_Status = new System.Windows.Forms.CheckBox();
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_Cliente
            // 
            this.dtg_Cliente.AllowUserToAddRows = false;
            this.dtg_Cliente.AllowUserToDeleteRows = false;
            this.dtg_Cliente.AllowUserToOrderColumns = true;
            this.dtg_Cliente.AllowUserToResizeColumns = false;
            this.dtg_Cliente.AllowUserToResizeRows = false;
            this.dtg_Cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_Cliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dtg_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_Cliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtg_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtg_Cliente.Location = new System.Drawing.Point(154, 156);
            this.dtg_Cliente.MultiSelect = false;
            this.dtg_Cliente.Name = "dtg_Cliente";
            this.dtg_Cliente.ReadOnly = true;
            this.dtg_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Cliente.Size = new System.Drawing.Size(492, 228);
            this.dtg_Cliente.TabIndex = 1000;
            this.dtg_Cliente.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtg_Cliente_CellMouseClick);
            this.dtg_Cliente.SelectionChanged += new System.EventHandler(this.dtg_Cliente_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(520, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 1005;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 1006;
            this.label1.Text = "Tarefa";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome.Location = new System.Drawing.Point(154, 46);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(235, 26);
            this.txt_Nome.TabIndex = 1001;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar.Location = new System.Drawing.Point(154, 390);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(492, 30);
            this.btn_Deletar.TabIndex = 1009;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = true;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.Location = new System.Drawing.Point(154, 120);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(492, 30);
            this.btn_Atualizar.TabIndex = 1008;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salvar.Location = new System.Drawing.Point(154, 85);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(492, 30);
            this.btn_Salvar.TabIndex = 1007;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // ckb_Status
            // 
            this.ckb_Status.AutoSize = true;
            this.ckb_Status.Enabled = false;
            this.ckb_Status.Location = new System.Drawing.Point(395, 53);
            this.ckb_Status.Name = "ckb_Status";
            this.ckb_Status.Size = new System.Drawing.Size(15, 14);
            this.ckb_Status.TabIndex = 1010;
            this.ckb_Status.UseVisualStyleBackColor = true;
            // 
            // dtp_Data
            // 
            this.dtp_Data.Location = new System.Drawing.Point(416, 52);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(230, 20);
            this.dtp_Data.TabIndex = 1011;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_Data);
            this.Controls.Add(this.ckb_Status);
            this.Controls.Add(this.dtg_Cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Salvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.CheckBox ckb_Status;
        private System.Windows.Forms.DateTimePicker dtp_Data;
    }
}

