
namespace Proiect10PBD
{
    partial class Promovabilitate
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
            this.textBoxMaterie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPromovabilitate = new System.Windows.Forms.Button();
            this.labelPromovabilitate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMaterie
            // 
            this.textBoxMaterie.Location = new System.Drawing.Point(169, 79);
            this.textBoxMaterie.Name = "textBoxMaterie";
            this.textBoxMaterie.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaterie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume materie:";
            // 
            // buttonPromovabilitate
            // 
            this.buttonPromovabilitate.Location = new System.Drawing.Point(88, 121);
            this.buttonPromovabilitate.Name = "buttonPromovabilitate";
            this.buttonPromovabilitate.Size = new System.Drawing.Size(75, 23);
            this.buttonPromovabilitate.TabIndex = 2;
            this.buttonPromovabilitate.Text = "Calculeaza";
            this.buttonPromovabilitate.UseVisualStyleBackColor = true;
            this.buttonPromovabilitate.Click += new System.EventHandler(this.buttonPromovabilitate_Click);
            // 
            // labelPromovabilitate
            // 
            this.labelPromovabilitate.AutoSize = true;
            this.labelPromovabilitate.Location = new System.Drawing.Point(182, 126);
            this.labelPromovabilitate.Name = "labelPromovabilitate";
            this.labelPromovabilitate.Size = new System.Drawing.Size(0, 13);
            this.labelPromovabilitate.TabIndex = 3;
            // 
            // Promovabilitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 228);
            this.Controls.Add(this.labelPromovabilitate);
            this.Controls.Add(this.buttonPromovabilitate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaterie);
            this.Name = "Promovabilitate";
            this.Text = "Promovabilitate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMaterie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPromovabilitate;
        private System.Windows.Forms.Label labelPromovabilitate;
    }
}