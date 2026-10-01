namespace gatoTemporario
{
    partial class Registros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btncadastro = new RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnDash = new RoundedButton();
            this.LinkSair = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnNovoCadastro = new RoundedButton();
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(20)))), ((int)(((byte)(131)))));
            this.groupBox1.Controls.Add(this.Btncadastro);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.BtnDash);
            this.groupBox1.Controls.Add(this.LinkSair);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 590);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Btncadastro
            // 
            this.Btncadastro.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btncadastro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btncadastro.Location = new System.Drawing.Point(31, 197);
            this.Btncadastro.Name = "Btncadastro";
            this.Btncadastro.Size = new System.Drawing.Size(170, 40);
            this.Btncadastro.TabIndex = 19;
            this.Btncadastro.Text = "Cadastro de pares";
            this.Btncadastro.UseVisualStyleBackColor = true;
            this.Btncadastro.Click += new System.EventHandler(this.Btncadastro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::gatoTemporario.Properties.Resources.CellularToast_scale_100_contrast_black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::gatoTemporario.Properties.Resources.CellularToast_scale_100_contrast_black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(20)))), ((int)(((byte)(131)))));
            this.pictureBox4.BackgroundImage = global::gatoTemporario.Properties.Resources.CellularToast_scale_100_contrast_black;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::gatoTemporario.Properties.Resources.icone;
            this.pictureBox4.Location = new System.Drawing.Point(6, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(195, 106);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // BtnDash
            // 
            this.BtnDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(118)))), ((int)(((byte)(166)))));
            this.BtnDash.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDash.ForeColor = System.Drawing.Color.White;
            this.BtnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDash.ImageKey = "(nenhum/a)";
            this.BtnDash.Location = new System.Drawing.Point(0, 151);
            this.BtnDash.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDash.Name = "BtnDash";
            this.BtnDash.Size = new System.Drawing.Size(199, 40);
            this.BtnDash.TabIndex = 7;
            this.BtnDash.Text = "Dashboard";
            this.BtnDash.UseVisualStyleBackColor = false;
            // 
            // LinkSair
            // 
            this.LinkSair.AutoSize = true;
            this.LinkSair.LinkColor = System.Drawing.Color.White;
            this.LinkSair.Location = new System.Drawing.Point(6, 561);
            this.LinkSair.Name = "LinkSair";
            this.LinkSair.Size = new System.Drawing.Size(25, 13);
            this.LinkSair.TabIndex = 4;
            this.LinkSair.TabStop = true;
            this.LinkSair.Text = "Sair";
            this.LinkSair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkSair_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.BtnNovoCadastro);
            this.groupBox2.Controls.Add(this.cmbFiltros);
            this.groupBox2.Controls.Add(this.txtBuscar);
            this.groupBox2.Controls.Add(this.dgvRegistros);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(228, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 590);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // BtnNovoCadastro
            // 
            this.BtnNovoCadastro.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BtnNovoCadastro.FlatAppearance.BorderSize = 15;
            this.BtnNovoCadastro.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovoCadastro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnNovoCadastro.Location = new System.Drawing.Point(544, 89);
            this.BtnNovoCadastro.Name = "BtnNovoCadastro";
            this.BtnNovoCadastro.Size = new System.Drawing.Size(99, 32);
            this.BtnNovoCadastro.TabIndex = 16;
            this.BtnNovoCadastro.Text = "Novo Cadastro";
            this.BtnNovoCadastro.UseVisualStyleBackColor = true;
            this.BtnNovoCadastro.Click += new System.EventHandler(this.BtnNovoCadastro_Click);
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Location = new System.Drawing.Point(390, 95);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltros.TabIndex = 11;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(59, 95);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(325, 37);
            this.txtBuscar.TabIndex = 10;
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(6, 151);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(690, 433);
            this.dgvRegistros.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Visão geral dos calçados cadastrados sem par";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Registros";
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 614);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registros";
            this.Text = "Registros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private RoundedButton BtnDash;
        private System.Windows.Forms.LinkLabel LinkSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.TextBox txtBuscar;
        private RoundedButton BtnNovoCadastro;
        private RoundedButton Btncadastro;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}