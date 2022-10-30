
namespace Proiect10PBD
{
    partial class Form1
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
            this.buttonMaterii = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonStudenti = new System.Windows.Forms.Button();
            this.buttonNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMaterii
            // 
            this.buttonMaterii.Location = new System.Drawing.Point(152, 59);
            this.buttonMaterii.Name = "buttonMaterii";
            this.buttonMaterii.Size = new System.Drawing.Size(114, 40);
            this.buttonMaterii.TabIndex = 0;
            this.buttonMaterii.Text = "Afisare materii";
            this.buttonMaterii.UseVisualStyleBackColor = true;
            this.buttonMaterii.Click += new System.EventHandler(this.butonMaterii_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(348, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 239);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonStudenti
            // 
            this.buttonStudenti.Location = new System.Drawing.Point(152, 163);
            this.buttonStudenti.Name = "buttonStudenti";
            this.buttonStudenti.Size = new System.Drawing.Size(114, 40);
            this.buttonStudenti.TabIndex = 2;
            this.buttonStudenti.Text = "Afisare studenti";
            this.buttonStudenti.UseVisualStyleBackColor = true;
            this.buttonStudenti.Click += new System.EventHandler(this.buttonStudenti_Click);
            // 
            // buttonNote
            // 
            this.buttonNote.Location = new System.Drawing.Point(152, 258);
            this.buttonNote.Name = "buttonNote";
            this.buttonNote.Size = new System.Drawing.Size(114, 40);
            this.buttonNote.TabIndex = 3;
            this.buttonNote.Text = "Afisare note";
            this.buttonNote.UseVisualStyleBackColor = true;
            this.buttonNote.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNote);
            this.Controls.Add(this.buttonStudenti);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMaterii);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMaterii;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonStudenti;
        private System.Windows.Forms.Button buttonNote;
    }
}

