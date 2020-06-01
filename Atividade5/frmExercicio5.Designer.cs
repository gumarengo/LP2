namespace PMenus
{
    partial class frmExercicio5
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblPrim = new System.Windows.Forms.Label();
            this.lblSeg = new System.Windows.Forms.Label();
            this.btnSorteio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(194, 58);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(136, 20);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(194, 110);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(136, 20);
            this.txtNum2.TabIndex = 1;
            // 
            // lblPrim
            // 
            this.lblPrim.AutoSize = true;
            this.lblPrim.Location = new System.Drawing.Point(70, 64);
            this.lblPrim.Name = "lblPrim";
            this.lblPrim.Size = new System.Drawing.Size(84, 13);
            this.lblPrim.TabIndex = 2;
            this.lblPrim.Text = "Primeiro Numero";
            // 
            // lblSeg
            // 
            this.lblSeg.AutoSize = true;
            this.lblSeg.Location = new System.Drawing.Point(70, 113);
            this.lblSeg.Name = "lblSeg";
            this.lblSeg.Size = new System.Drawing.Size(90, 13);
            this.lblSeg.TabIndex = 3;
            this.lblSeg.Text = "Segundo Numero";
            // 
            // btnSorteio
            // 
            this.btnSorteio.Location = new System.Drawing.Point(157, 181);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(75, 44);
            this.btnSorteio.TabIndex = 4;
            this.btnSorteio.Text = "Realizar Sorteio";
            this.btnSorteio.UseVisualStyleBackColor = true;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // frmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 251);
            this.Controls.Add(this.btnSorteio);
            this.Controls.Add(this.lblSeg);
            this.Controls.Add(this.lblPrim);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "frmExercicio5";
            this.Text = "frmExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblPrim;
        private System.Windows.Forms.Label lblSeg;
        private System.Windows.Forms.Button btnSorteio;
    }
}