namespace ListaGenerica
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cmbExcluir = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "idade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "nome";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(94, 119);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(260, 119);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(196, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(496, 119);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(45, 20);
            this.txtIdade.TabIndex = 5;
            // 
            // gridClientes
            // 
            this.gridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClientes.Location = new System.Drawing.Point(94, 249);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(388, 177);
            this.gridClientes.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(591, 162);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(121, 49);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(506, 249);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(282, 177);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cmbExcluir
            // 
            this.cmbExcluir.FormattingEnabled = true;
            this.cmbExcluir.Location = new System.Drawing.Point(591, 320);
            this.cmbExcluir.Name = "cmbExcluir";
            this.cmbExcluir.Size = new System.Drawing.Size(121, 21);
            this.cmbExcluir.TabIndex = 11;
            this.cmbExcluir.Text = "[Selecione]";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(524, 380);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(95, 23);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(593, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Excluir cadastro";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(679, 380);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 23);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(547, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "anos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cmbExcluir);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.DataGridView gridClientes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cmbExcluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label5;
    }
}

