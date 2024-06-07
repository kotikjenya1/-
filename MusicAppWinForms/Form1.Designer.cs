namespace MusicAppWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMusicItems = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTotalDuration = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMusicItems
            // 
            this.lstMusicItems.FormattingEnabled = true;
            this.lstMusicItems.Location = new System.Drawing.Point(132, 160);
            this.lstMusicItems.Name = "lstMusicItems";
            this.lstMusicItems.Size = new System.Drawing.Size(120, 95);
            this.lstMusicItems.TabIndex = 0;
            this.lstMusicItems.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(384, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(384, 244);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblTotalDuration
            // 
            this.lblTotalDuration.AutoSize = true;
            this.lblTotalDuration.Location = new System.Drawing.Point(70, 49);
            this.lblTotalDuration.Name = "lblTotalDuration";
            this.lblTotalDuration.Size = new System.Drawing.Size(35, 13);
            this.lblTotalDuration.TabIndex = 3;
            this.lblTotalDuration.Text = "label1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(384, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTotalDuration);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstMusicItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMusicItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblTotalDuration;
        private System.Windows.Forms.Button btnDelete;
    }
}

