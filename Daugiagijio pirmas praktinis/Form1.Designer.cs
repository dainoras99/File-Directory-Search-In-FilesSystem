
namespace Daugiagijio_pirmas_praktinis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fileTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CateogoryButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(167, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "FAILO/DIREKCIJOS PAIEŠKA FAILŲ SISTEMOJE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ieškomas failas/direkcija:";
            // 
            // fileTextBox
            // 
            this.fileTextBox.Location = new System.Drawing.Point(260, 116);
            this.fileTextBox.Name = "fileTextBox";
            this.fileTextBox.Size = new System.Drawing.Size(246, 20);
            this.fileTextBox.TabIndex = 3;
            this.fileTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(424, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Katalogo pavadinimas, kuriame pradedama paieška:";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(474, 152);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(489, 20);
            this.locationTextBox.TabIndex = 5;
            this.locationTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(973, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(505, 207);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(66, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "IEŠKOTI";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(48, 302);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.Size = new System.Drawing.Size(970, 387);
            this.resultsTextBox.TabIndex = 8;
            this.resultsTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(973, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // CateogoryButton
            // 
            this.CateogoryButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.CateogoryButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.CateogoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CateogoryButton.Location = new System.Drawing.Point(959, 149);
            this.CateogoryButton.Name = "CateogoryButton";
            this.CateogoryButton.Size = new System.Drawing.Size(27, 23);
            this.CateogoryButton.TabIndex = 10;
            this.CateogoryButton.Text = "...";
            this.CateogoryButton.UseVisualStyleBackColor = true;
            this.CateogoryButton.Click += new System.EventHandler(this.CateogoryButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(48, 259);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(970, 23);
            this.progressBar.TabIndex = 11;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(920, 706);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 24);
            this.timerLabel.TabIndex = 12;
            this.timerLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1057, 760);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.CateogoryButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fileTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox fileTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox locationTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RichTextBox resultsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CateogoryButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label timerLabel;
    }
}

