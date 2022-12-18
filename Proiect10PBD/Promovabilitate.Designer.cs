
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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMaterie
            // 
            this.textBoxMaterie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaterie.Location = new System.Drawing.Point(684, 265);
            this.textBoxMaterie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMaterie.Name = "textBoxMaterie";
            this.textBoxMaterie.Size = new System.Drawing.Size(227, 38);
            this.textBoxMaterie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 268);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume disciplina:";
            // 
            // buttonPromovabilitate
            // 
            this.buttonPromovabilitate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPromovabilitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromovabilitate.Location = new System.Drawing.Point(545, 398);
            this.buttonPromovabilitate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPromovabilitate.Name = "buttonPromovabilitate";
            this.buttonPromovabilitate.Size = new System.Drawing.Size(361, 101);
            this.buttonPromovabilitate.TabIndex = 2;
            this.buttonPromovabilitate.Text = "Calculeaza";
            this.buttonPromovabilitate.UseVisualStyleBackColor = false;
            this.buttonPromovabilitate.Click += new System.EventHandler(this.buttonPromovabilitate_Click);
            // 
            // labelPromovabilitate
            // 
            this.labelPromovabilitate.AutoSize = true;
            this.labelPromovabilitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPromovabilitate.Location = new System.Drawing.Point(715, 569);
            this.labelPromovabilitate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPromovabilitate.Name = "labelPromovabilitate";
            this.labelPromovabilitate.Size = new System.Drawing.Size(0, 46);
            this.labelPromovabilitate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(886, 69);
            this.label2.TabIndex = 4;
            this.label2.Text = "Promovabilitatea unei discipline ";
            // 
            // Promovabilitate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 723);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPromovabilitate);
            this.Controls.Add(this.buttonPromovabilitate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMaterie);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Promovabilitate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMaterie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPromovabilitate;
        private System.Windows.Forms.Label labelPromovabilitate;
        private System.Windows.Forms.Label label2;
    }
}