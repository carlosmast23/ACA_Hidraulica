
namespace ACA_Hidraulica
{
    partial class SegundoFormulario
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtPerdidasLocales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPotenciaNeta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPotenciaInstalada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(49, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Perdidas Locales:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPerdidasLocales
            // 
            this.txtPerdidasLocales.Location = new System.Drawing.Point(49, 69);
            this.txtPerdidasLocales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPerdidasLocales.Name = "txtPerdidasLocales";
            this.txtPerdidasLocales.Size = new System.Drawing.Size(273, 31);
            this.txtPerdidasLocales.TabIndex = 12;
            this.txtPerdidasLocales.TextChanged += new System.EventHandler(this.textDiametro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Potencia Neta:";
            // 
            // txtPotenciaNeta
            // 
            this.txtPotenciaNeta.Location = new System.Drawing.Point(49, 163);
            this.txtPotenciaNeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPotenciaNeta.Name = "txtPotenciaNeta";
            this.txtPotenciaNeta.Size = new System.Drawing.Size(273, 31);
            this.txtPotenciaNeta.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(452, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Potencia Instalada:";
            // 
            // txtPotenciaInstalada
            // 
            this.txtPotenciaInstalada.Location = new System.Drawing.Point(452, 163);
            this.txtPotenciaInstalada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPotenciaInstalada.Name = "txtPotenciaInstalada";
            this.txtPotenciaInstalada.Size = new System.Drawing.Size(257, 31);
            this.txtPotenciaInstalada.TabIndex = 16;
            // 
            // SegundoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(722, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPotenciaInstalada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPotenciaNeta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPerdidasLocales);
            this.Name = "SegundoFormulario";
            this.Text = "SegundoFormulario";
            this.Load += new System.EventHandler(this.SegundoFormulario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPerdidasLocales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPotenciaNeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPotenciaInstalada;
    }
}