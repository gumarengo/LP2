namespace PAtividade6
{
    partial class frmEx4
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNumInscr = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblGratif = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtNumInscr = new System.Windows.Forms.TextBox();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtGratif = new System.Windows.Forms.TextBox();
            this.btnSalBruto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(155, 34);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(37, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(37, 70);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo";
            // 
            // lblNumInscr
            // 
            this.lblNumInscr.AutoSize = true;
            this.lblNumInscr.Location = new System.Drawing.Point(37, 101);
            this.lblNumInscr.Name = "lblNumInscr";
            this.lblNumInscr.Size = new System.Drawing.Size(105, 13);
            this.lblNumInscr.TabIndex = 3;
            this.lblNumInscr.Text = "Número de Inscrição";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Location = new System.Drawing.Point(37, 133);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(53, 13);
            this.lblProd.TabIndex = 4;
            this.lblProd.Text = "Produção";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(37, 165);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 5;
            this.lblSalario.Text = "Salário";
            // 
            // lblGratif
            // 
            this.lblGratif.AutoSize = true;
            this.lblGratif.Location = new System.Drawing.Point(37, 203);
            this.lblGratif.Name = "lblGratif";
            this.lblGratif.Size = new System.Drawing.Size(64, 13);
            this.lblGratif.TabIndex = 6;
            this.lblGratif.Text = "Gratificação";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(155, 67);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 7;
            // 
            // txtNumInscr
            // 
            this.txtNumInscr.Location = new System.Drawing.Point(155, 101);
            this.txtNumInscr.Name = "txtNumInscr";
            this.txtNumInscr.Size = new System.Drawing.Size(100, 20);
            this.txtNumInscr.TabIndex = 8;
            // 
            // txtProd
            // 
            this.txtProd.Location = new System.Drawing.Point(155, 133);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(100, 20);
            this.txtProd.TabIndex = 9;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(155, 165);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 10;
            // 
            // txtGratif
            // 
            this.txtGratif.Location = new System.Drawing.Point(155, 200);
            this.txtGratif.Name = "txtGratif";
            this.txtGratif.Size = new System.Drawing.Size(100, 20);
            this.txtGratif.TabIndex = 11;
            // 
            // btnSalBruto
            // 
            this.btnSalBruto.Location = new System.Drawing.Point(117, 267);
            this.btnSalBruto.Name = "btnSalBruto";
            this.btnSalBruto.Size = new System.Drawing.Size(75, 44);
            this.btnSalBruto.TabIndex = 12;
            this.btnSalBruto.Text = "Salário Bruto";
            this.btnSalBruto.UseVisualStyleBackColor = true;
            this.btnSalBruto.Click += new System.EventHandler(this.btnSalBruto_Click);
            // 
            // frmEx4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.btnSalBruto);
            this.Controls.Add(this.txtGratif);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.txtNumInscr);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblGratif);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblNumInscr);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "frmEx4";
            this.Text = "Exercício 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNumInscr;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblGratif;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtNumInscr;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtGratif;
        private System.Windows.Forms.Button btnSalBruto;
    }
}