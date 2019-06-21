namespace SearchFiles
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
            this.FolderAddress = new System.Windows.Forms.TextBox();
            this.labelDirectory = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelTemplate = new System.Windows.Forms.Label();
            this.TemplateName = new System.Windows.Forms.TextBox();
            this.Content = new System.Windows.Forms.TextBox();
            this.labelContent = new System.Windows.Forms.Label();
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.buttonFind = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FolderAddress
            // 
            this.FolderAddress.Location = new System.Drawing.Point(83, 12);
            this.FolderAddress.Name = "FolderAddress";
            this.FolderAddress.Size = new System.Drawing.Size(100, 22);
            this.FolderAddress.TabIndex = 0;
            // 
            // labelDirectory
            // 
            this.labelDirectory.AutoSize = true;
            this.labelDirectory.Location = new System.Drawing.Point(12, 15);
            this.labelDirectory.Name = "labelDirectory";
            this.labelDirectory.Size = new System.Drawing.Size(65, 17);
            this.labelDirectory.TabIndex = 1;
            this.labelDirectory.Text = "Directory";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(189, 11);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Select folder";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSelect_MouseClick);
            // 
            // labelTemplate
            // 
            this.labelTemplate.AutoSize = true;
            this.labelTemplate.Location = new System.Drawing.Point(12, 48);
            this.labelTemplate.Name = "labelTemplate";
            this.labelTemplate.Size = new System.Drawing.Size(67, 17);
            this.labelTemplate.TabIndex = 3;
            this.labelTemplate.Text = "Template";
            // 
            // TemplateName
            // 
            this.TemplateName.Location = new System.Drawing.Point(83, 48);
            this.TemplateName.Name = "TemplateName";
            this.TemplateName.Size = new System.Drawing.Size(100, 22);
            this.TemplateName.TabIndex = 4;
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(83, 86);
            this.Content.Multiline = true;
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(181, 94);
            this.Content.TabIndex = 5;
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Location = new System.Drawing.Point(12, 89);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(57, 17);
            this.labelContent.TabIndex = 6;
            this.labelContent.Text = "Content";
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.Location = new System.Drawing.Point(362, 11);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.Size = new System.Drawing.Size(466, 704);
            this.treeViewFiles.TabIndex = 7;
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.Location = new System.Drawing.Point(15, 186);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(249, 119);
            this.buttonFind.TabIndex = 8;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 732);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(48, 17);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Status";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(15, 311);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(249, 40);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 765);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.treeViewFiles);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.TemplateName);
            this.Controls.Add(this.labelTemplate);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.labelDirectory);
            this.Controls.Add(this.FolderAddress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FolderAddress;
        private System.Windows.Forms.Label labelDirectory;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelTemplate;
        private System.Windows.Forms.TextBox TemplateName;
        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.TreeView treeViewFiles;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonCancel;
    }
}

