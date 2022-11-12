
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
            this.buttonNepromovati = new System.Windows.Forms.Button();
            this.buttonRaport5 = new System.Windows.Forms.Button();
            this.buttonRaport6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMaterii
            // 
            this.buttonMaterii.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMaterii.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMaterii.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMaterii.Location = new System.Drawing.Point(50, 113);
            this.buttonMaterii.Name = "buttonMaterii";
            this.buttonMaterii.Size = new System.Drawing.Size(218, 84);
            this.buttonMaterii.TabIndex = 0;
            this.buttonMaterii.Text = "Afisare materii";
            this.buttonMaterii.UseVisualStyleBackColor = false;
            this.buttonMaterii.Click += new System.EventHandler(this.butonMaterii_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(361, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(539, 345);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonStudenti
            // 
            this.buttonStudenti.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonStudenti.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudenti.Location = new System.Drawing.Point(50, 203);
            this.buttonStudenti.Name = "buttonStudenti";
            this.buttonStudenti.Size = new System.Drawing.Size(218, 79);
            this.buttonStudenti.TabIndex = 2;
            this.buttonStudenti.Text = "Afisare studenti";
            this.buttonStudenti.UseVisualStyleBackColor = false;
            this.buttonStudenti.Click += new System.EventHandler(this.buttonStudenti_Click);
            // 
            // buttonNote
            // 
            this.buttonNote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNote.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNote.Location = new System.Drawing.Point(50, 288);
            this.buttonNote.Name = "buttonNote";
            this.buttonNote.Size = new System.Drawing.Size(218, 84);
            this.buttonNote.TabIndex = 3;
            this.buttonNote.Text = "Afisare note";
            this.buttonNote.UseVisualStyleBackColor = false;
            this.buttonNote.Click += new System.EventHandler(this.buttonNote_Click);
            // 
            // buttonNepromovati
            // 
            this.buttonNepromovati.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNepromovati.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNepromovati.Location = new System.Drawing.Point(50, 378);
            this.buttonNepromovati.Name = "buttonNepromovati";
            this.buttonNepromovati.Size = new System.Drawing.Size(218, 84);
            this.buttonNepromovati.TabIndex = 4;
            this.buttonNepromovati.Text = "Afisare studenti picati";
            this.buttonNepromovati.UseVisualStyleBackColor = false;
            this.buttonNepromovati.Click += new System.EventHandler(this.buttonNepromovati_Click);
            // 
            // buttonRaport5
            // 
            this.buttonRaport5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRaport5.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaport5.Location = new System.Drawing.Point(50, 468);
            this.buttonRaport5.Name = "buttonRaport5";
            this.buttonRaport5.Size = new System.Drawing.Size(218, 84);
            this.buttonRaport5.TabIndex = 5;
            this.buttonRaport5.Text = "Afisare raport studenti";
            this.buttonRaport5.UseVisualStyleBackColor = false;
            this.buttonRaport5.Click += new System.EventHandler(this.buttonRaport5_Click);
            // 
            // buttonRaport6
            // 
            this.buttonRaport6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonRaport6.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRaport6.Location = new System.Drawing.Point(50, 567);
            this.buttonRaport6.Name = "buttonRaport6";
            this.buttonRaport6.Size = new System.Drawing.Size(218, 84);
            this.buttonRaport6.TabIndex = 6;
            this.buttonRaport6.Text = "Afisare raport detaliat";
            this.buttonRaport6.UseVisualStyleBackColor = false;
            this.buttonRaport6.Click += new System.EventHandler(this.buttonRaport6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 749);
            this.Controls.Add(this.buttonRaport6);
            this.Controls.Add(this.buttonRaport5);
            this.Controls.Add(this.buttonNepromovati);
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
        private System.Windows.Forms.Button buttonNepromovati;
        private System.Windows.Forms.Button buttonRaport5;
        private System.Windows.Forms.Button buttonRaport6;
    }
}

