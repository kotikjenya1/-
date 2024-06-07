namespace MusicAppWinForms
{
    partial class AddEditForm
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
            this.Title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtLyrics = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(55, 45);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(116, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(116, 71);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(100, 20);
            this.txtArtist.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(70, 216);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(116, 98);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 6;
            // 
            // txtLyrics
            // 
            this.txtLyrics.Location = new System.Drawing.Point(116, 132);
            this.txtLyrics.Name = "txtLyrics";
            this.txtLyrics.Size = new System.Drawing.Size(100, 20);
            this.txtLyrics.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Lyrics";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(116, 400);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 20);
            this.txtGenre.TabIndex = 13;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLyrics);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Title);
            this.Name = "AddEditForm";
            this.Text = "AddEditForm";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtLyrics;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGenre;
    }
}