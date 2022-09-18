namespace Ejercicio_I03_AContarPalabras
{
    partial class ContadorPalabras
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxb1 = new System.Windows.Forms.RichTextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxb1
            // 
            this.rtxb1.Location = new System.Drawing.Point(3, 2);
            this.rtxb1.Name = "rtxb1";
            this.rtxb1.Size = new System.Drawing.Size(739, 590);
            this.rtxb1.TabIndex = 0;
            this.rtxb1.Text = "";
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_calcular.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btn_calcular.Location = new System.Drawing.Point(655, 549);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 32);
            this.btn_calcular.TabIndex = 1;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // ContadorPalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 595);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.rtxb1);
            this.Name = "ContadorPalabras";
            this.Text = "Contador de Palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtxb1;
        private Button btn_calcular;
    }
}