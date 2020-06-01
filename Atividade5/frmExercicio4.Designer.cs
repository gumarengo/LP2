namespace PMenus
{
    partial class frmExercicio4
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
            this.rchtxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnCaractNum = new System.Windows.Forms.Button();
            this.btnPrimBranco = new System.Windows.Forms.Button();
            this.btnCaractAlfab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtTexto
            // 
            this.rchtxtTexto.Location = new System.Drawing.Point(76, 66);
            this.rchtxtTexto.Name = "rchtxtTexto";
            this.rchtxtTexto.Size = new System.Drawing.Size(390, 131);
            this.rchtxtTexto.TabIndex = 0;
            this.rchtxtTexto.Text = "";
            // 
            // btnCaractNum
            // 
            this.btnCaractNum.Location = new System.Drawing.Point(76, 246);
            this.btnCaractNum.Name = "btnCaractNum";
            this.btnCaractNum.Size = new System.Drawing.Size(75, 49);
            this.btnCaractNum.TabIndex = 1;
            this.btnCaractNum.Text = "Caracteres Numericos";
            this.btnCaractNum.UseVisualStyleBackColor = true;
            this.btnCaractNum.Click += new System.EventHandler(this.btnCaractNum_Click);
            // 
            // btnPrimBranco
            // 
            this.btnPrimBranco.Location = new System.Drawing.Point(219, 246);
            this.btnPrimBranco.Name = "btnPrimBranco";
            this.btnPrimBranco.Size = new System.Drawing.Size(75, 49);
            this.btnPrimBranco.TabIndex = 2;
            this.btnPrimBranco.Text = "Primeiro Branco";
            this.btnPrimBranco.UseVisualStyleBackColor = true;
            this.btnPrimBranco.Click += new System.EventHandler(this.btnPrimBranco_Click);
            // 
            // btnCaractAlfab
            // 
            this.btnCaractAlfab.Location = new System.Drawing.Point(357, 246);
            this.btnCaractAlfab.Name = "btnCaractAlfab";
            this.btnCaractAlfab.Size = new System.Drawing.Size(75, 49);
            this.btnCaractAlfab.TabIndex = 3;
            this.btnCaractAlfab.Text = "Caracteres Alfabeticos";
            this.btnCaractAlfab.UseVisualStyleBackColor = true;
            this.btnCaractAlfab.Click += new System.EventHandler(this.btnCaractAlfab_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 377);
            this.Controls.Add(this.btnCaractAlfab);
            this.Controls.Add(this.btnPrimBranco);
            this.Controls.Add(this.btnCaractNum);
            this.Controls.Add(this.rchtxtTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtTexto;
        private System.Windows.Forms.Button btnCaractNum;
        private System.Windows.Forms.Button btnPrimBranco;
        private System.Windows.Forms.Button btnCaractAlfab;
    }
}