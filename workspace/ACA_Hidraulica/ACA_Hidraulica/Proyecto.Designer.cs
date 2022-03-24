
namespace ACA_Hidraulica
{
    partial class Proyecto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proyecto));
            this.checkBoxCalculo1 = new System.Windows.Forms.CheckBox();
            this.checkBoxCalculo2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxCalculo1
            // 
            this.checkBoxCalculo1.AutoSize = true;
            this.checkBoxCalculo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkBoxCalculo1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxCalculo1.ForeColor = System.Drawing.Color.White;
            this.checkBoxCalculo1.Location = new System.Drawing.Point(921, 315);
            this.checkBoxCalculo1.Name = "checkBoxCalculo1";
            this.checkBoxCalculo1.Size = new System.Drawing.Size(298, 25);
            this.checkBoxCalculo1.TabIndex = 0;
            this.checkBoxCalculo1.Text = "Cálculo de la potencia de una bomba";
            this.checkBoxCalculo1.UseVisualStyleBackColor = false;
            this.checkBoxCalculo1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxCalculo2
            // 
            this.checkBoxCalculo2.AutoSize = true;
            this.checkBoxCalculo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.checkBoxCalculo2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxCalculo2.ForeColor = System.Drawing.Color.White;
            this.checkBoxCalculo2.Location = new System.Drawing.Point(921, 367);
            this.checkBoxCalculo2.Name = "checkBoxCalculo2";
            this.checkBoxCalculo2.Size = new System.Drawing.Size(282, 25);
            this.checkBoxCalculo2.TabIndex = 1;
            this.checkBoxCalculo2.Text = "Cálculo de potencia de una turbina";
            this.checkBoxCalculo2.UseVisualStyleBackColor = false;
            this.checkBoxCalculo2.CheckedChanged += new System.EventHandler(this.checkBoxCalculo2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1033, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Acceder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1268, 518);
            this.Controls.Add(this.checkBoxCalculo2);
            this.Controls.Add(this.checkBoxCalculo1);
            this.Controls.Add(this.button1);
            this.Name = "Proyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxCalculo1;
        private System.Windows.Forms.CheckBox checkBoxCalculo2;
        private System.Windows.Forms.Button button1;
    }
}