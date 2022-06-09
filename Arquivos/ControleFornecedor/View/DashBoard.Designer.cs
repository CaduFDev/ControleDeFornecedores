namespace View
{
    partial class DashBoard
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
            this.dgvContatosPj = new System.Windows.Forms.DataGridView();
            this.txtFiltroPJ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPJ = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvContatosPf = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCliPJ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCliPF = new System.Windows.Forms.TextBox();
            this.txtFiltroPF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddTelPJ = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddTelPF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatosPj)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatosPf)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContatosPj
            // 
            this.dgvContatosPj.BackgroundColor = System.Drawing.Color.White;
            this.dgvContatosPj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatosPj.Location = new System.Drawing.Point(12, 135);
            this.dgvContatosPj.MultiSelect = false;
            this.dgvContatosPj.Name = "dgvContatosPj";
            this.dgvContatosPj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatosPj.Size = new System.Drawing.Size(566, 351);
            this.dgvContatosPj.TabIndex = 0;
            this.dgvContatosPj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContatosPj_CellContentClick);
            // 
            // txtFiltroPJ
            // 
            this.txtFiltroPJ.Location = new System.Drawing.Point(132, 105);
            this.txtFiltroPJ.Name = "txtFiltroPJ";
            this.txtFiltroPJ.Size = new System.Drawing.Size(204, 21);
            this.txtFiltroPJ.TabIndex = 1;
            this.txtFiltroPJ.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            this.txtFiltroPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroPJ_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPJ);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Novo Contato";
            // 
            // btnPJ
            // 
            this.btnPJ.FlatAppearance.BorderSize = 0;
            this.btnPJ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPJ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPJ.Location = new System.Drawing.Point(6, 20);
            this.btnPJ.Name = "btnPJ";
            this.btnPJ.Size = new System.Drawing.Size(99, 23);
            this.btnPJ.TabIndex = 1;
            this.btnPJ.Text = "PJ";
            this.btnPJ.UseVisualStyleBackColor = true;
            this.btnPJ.Click += new System.EventHandler(this.btnPJ_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 470);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CamelDev © 2022";
            // 
            // dgvContatosPf
            // 
            this.dgvContatosPf.BackgroundColor = System.Drawing.Color.White;
            this.dgvContatosPf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContatosPf.Location = new System.Drawing.Point(696, 135);
            this.dgvContatosPf.MultiSelect = false;
            this.dgvContatosPf.Name = "dgvContatosPf";
            this.dgvContatosPf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContatosPf.Size = new System.Drawing.Size(573, 351);
            this.dgvContatosPf.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(696, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 54);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Novo Contato";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(6, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "PF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCliPJ
            // 
            this.txtCliPJ.Location = new System.Drawing.Point(342, 105);
            this.txtCliPJ.Name = "txtCliPJ";
            this.txtCliPJ.Size = new System.Drawing.Size(65, 21);
            this.txtCliPJ.TabIndex = 7;
            this.txtCliPJ.TextChanged += new System.EventHandler(this.txtCliPJ_TextChanged);
            this.txtCliPJ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliPJ_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Buscar clientes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(809, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Buscar clientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1019, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cliente";
            // 
            // txtCliPF
            // 
            this.txtCliPF.Location = new System.Drawing.Point(1022, 105);
            this.txtCliPF.Name = "txtCliPF";
            this.txtCliPF.Size = new System.Drawing.Size(65, 21);
            this.txtCliPF.TabIndex = 13;
            this.txtCliPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliPF_KeyPress);
            // 
            // txtFiltroPF
            // 
            this.txtFiltroPF.Location = new System.Drawing.Point(812, 105);
            this.txtFiltroPF.Name = "txtFiltroPF";
            this.txtFiltroPF.Size = new System.Drawing.Size(204, 21);
            this.txtFiltroPF.TabIndex = 12;
            this.txtFiltroPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltroPF_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(515, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Controle de fornecedores";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddTelPJ);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(467, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 54);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Novo Telefone";
            // 
            // btnAddTelPJ
            // 
            this.btnAddTelPJ.FlatAppearance.BorderSize = 0;
            this.btnAddTelPJ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddTelPJ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddTelPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTelPJ.Location = new System.Drawing.Point(6, 20);
            this.btnAddTelPJ.Name = "btnAddTelPJ";
            this.btnAddTelPJ.Size = new System.Drawing.Size(99, 23);
            this.btnAddTelPJ.TabIndex = 1;
            this.btnAddTelPJ.Text = "Adicionar";
            this.btnAddTelPJ.UseVisualStyleBackColor = true;
            this.btnAddTelPJ.Click += new System.EventHandler(this.btnAddTelPJ_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddTelPF);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(1158, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(111, 54);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Novo Telefone";
            // 
            // btnAddTelPF
            // 
            this.btnAddTelPF.FlatAppearance.BorderSize = 0;
            this.btnAddTelPF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddTelPF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddTelPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTelPF.Location = new System.Drawing.Point(6, 20);
            this.btnAddTelPF.Name = "btnAddTelPF";
            this.btnAddTelPF.Size = new System.Drawing.Size(99, 23);
            this.btnAddTelPF.TabIndex = 1;
            this.btnAddTelPF.Text = "Adicionar";
            this.btnAddTelPF.UseVisualStyleBackColor = true;
            this.btnAddTelPF.Click += new System.EventHandler(this.btnAddTelPF_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1281, 498);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCliPF);
            this.Controls.Add(this.txtFiltroPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCliPJ);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvContatosPf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFiltroPJ);
            this.Controls.Add(this.dgvContatosPj);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatosPj)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContatosPf)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContatosPj;
        private System.Windows.Forms.TextBox txtFiltroPJ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvContatosPf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCliPJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCliPF;
        private System.Windows.Forms.TextBox txtFiltroPF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddTelPJ;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddTelPF;
    }
}