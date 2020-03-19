namespace PesoIdeal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPeso = new System.Windows.Forms.TextBox();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioFem = new System.Windows.Forms.RadioButton();
            this.radioMasc = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedIMC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAVISO = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo";
            // 
            // textPeso
            // 
            this.textPeso.Location = new System.Drawing.Point(86, 46);
            this.textPeso.Name = "textPeso";
            this.textPeso.Size = new System.Drawing.Size(111, 20);
            this.textPeso.TabIndex = 3;
            // 
            // textAltura
            // 
            this.textAltura.Location = new System.Drawing.Point(86, 81);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(111, 20);
            this.textAltura.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioFem);
            this.groupBox1.Controls.Add(this.radioMasc);
            this.groupBox1.Location = new System.Drawing.Point(86, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 82);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // radioFem
            // 
            this.radioFem.AutoSize = true;
            this.radioFem.Location = new System.Drawing.Point(7, 43);
            this.radioFem.Name = "radioFem";
            this.radioFem.Size = new System.Drawing.Size(67, 17);
            this.radioFem.TabIndex = 1;
            this.radioFem.Text = "Feminino";
            this.radioFem.UseVisualStyleBackColor = true;
            // 
            // radioMasc
            // 
            this.radioMasc.AutoSize = true;
            this.radioMasc.Location = new System.Drawing.Point(7, 20);
            this.radioMasc.Name = "radioMasc";
            this.radioMasc.Size = new System.Drawing.Size(73, 17);
            this.radioMasc.TabIndex = 0;
            this.radioMasc.Text = "Masculino";
            this.radioMasc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "CALCULAR IMC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedIMC
            // 
            this.maskedIMC.Enabled = false;
            this.maskedIMC.Location = new System.Drawing.Point(86, 228);
            this.maskedIMC.Name = "maskedIMC";
            this.maskedIMC.Size = new System.Drawing.Size(111, 20);
            this.maskedIMC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Calcule seu IMC";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "IMC";
            // 
            // labelAVISO
            // 
            this.labelAVISO.AutoSize = true;
            this.labelAVISO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAVISO.Location = new System.Drawing.Point(204, 165);
            this.labelAVISO.Name = "labelAVISO";
            this.labelAVISO.Size = new System.Drawing.Size(0, 15);
            this.labelAVISO.TabIndex = 8;
            this.labelAVISO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 276);
            this.Controls.Add(this.labelAVISO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maskedIMC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.textPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPeso;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioFem;
        private System.Windows.Forms.RadioButton radioMasc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedIMC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAVISO;
    }
}

