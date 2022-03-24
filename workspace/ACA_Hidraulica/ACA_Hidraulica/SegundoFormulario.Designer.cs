
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtPotenciaLongitudinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(34, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Perdidas Locales:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtPerdidasLocales
            // 
            this.txtPerdidasLocales.Location = new System.Drawing.Point(34, 41);
            this.txtPerdidasLocales.Name = "txtPerdidasLocales";
            this.txtPerdidasLocales.Size = new System.Drawing.Size(192, 23);
            this.txtPerdidasLocales.TabIndex = 12;
            this.txtPerdidasLocales.TextChanged += new System.EventHandler(this.textDiametro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Potencia Neta:";
            // 
            // txtPotenciaNeta
            // 
            this.txtPotenciaNeta.Location = new System.Drawing.Point(34, 98);
            this.txtPotenciaNeta.Name = "txtPotenciaNeta";
            this.txtPotenciaNeta.Size = new System.Drawing.Size(192, 23);
            this.txtPotenciaNeta.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(316, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Potencia Instalada:";
            // 
            // txtPotenciaInstalada
            // 
            this.txtPotenciaInstalada.Location = new System.Drawing.Point(316, 98);
            this.txtPotenciaInstalada.Name = "txtPotenciaInstalada";
            this.txtPotenciaInstalada.Size = new System.Drawing.Size(181, 23);
            this.txtPotenciaInstalada.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(537, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Perdidas Longitudinal:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtPotenciaLongitudinal
            // 
            this.txtPotenciaLongitudinal.Location = new System.Drawing.Point(537, 98);
            this.txtPotenciaLongitudinal.Name = "txtPotenciaLongitudinal";
            this.txtPotenciaLongitudinal.Size = new System.Drawing.Size(181, 23);
            this.txtPotenciaLongitudinal.TabIndex = 18;
            // 
            // SegundoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 217);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPotenciaLongitudinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPotenciaInstalada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPotenciaNeta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPerdidasLocales);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SegundoFormulario";
            this.Text = "Ejercicio I.I";
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPotenciaLongitudinal;
    }
}