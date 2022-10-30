
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
            this.buttonMaterii.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMaterii.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaterii.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMaterii.Location = new System.Drawing.Point(67, 139);
            this.buttonMaterii.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMaterii.Name = "buttonMaterii";
            this.buttonMaterii.Size = new System.Drawing.Size(290, 104);
            this.buttonMaterii.TabIndex = 0;
            this.buttonMaterii.Text = "Afisare materii";
            this.buttonMaterii.UseVisualStyleBackColor = false;
            this.buttonMaterii.Click += new System.EventHandler(this.butonMaterii_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(481, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(719, 421);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonStudenti
            // 
            this.buttonStudenti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStudenti.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudenti.Location = new System.Drawing.Point(67, 304);
            this.buttonStudenti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStudenti.Name = "buttonStudenti";
            this.buttonStudenti.Size = new System.Drawing.Size(290, 97);
            this.buttonStudenti.TabIndex = 2;
            this.buttonStudenti.Text = "Afisare studenti";
            this.buttonStudenti.UseVisualStyleBackColor = false;
            this.buttonStudenti.Click += new System.EventHandler(this.buttonStudenti_Click);
            // 
            // buttonNote
            // 
            this.buttonNote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNote.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNote.Location = new System.Drawing.Point(67, 454);
            this.buttonNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNote.Name = "buttonNote";
            this.buttonNote.Size = new System.Drawing.Size(290, 103);
            this.buttonNote.TabIndex = 3;
            this.buttonNote.Text = "Afisare note";
            this.buttonNote.UseVisualStyleBackColor = false;
            this.buttonNote.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 705);
            this.Controls.Add(this.buttonNote);
            this.Controls.Add(this.buttonStudenti);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonMaterii);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

