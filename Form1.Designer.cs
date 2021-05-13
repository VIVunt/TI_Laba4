namespace Laba4
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.EncipherFileButton = new System.Windows.Forms.Button();
            this.DecipherFileButton = new System.Windows.Forms.Button();
            this.SecretKey = new System.Windows.Forms.TextBox();
            this.SecretKeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Файлы txt|*.txt|Файлы cs|*.cs\"";
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Location = new System.Drawing.Point(36, 93);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(120, 30);
            this.ChooseFileButton.TabIndex = 0;
            this.ChooseFileButton.Text = "Выбрать файл";
            this.ChooseFileButton.UseVisualStyleBackColor = true;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // EncipherFileButton
            // 
            this.EncipherFileButton.Location = new System.Drawing.Point(36, 239);
            this.EncipherFileButton.Name = "EncipherFileButton";
            this.EncipherFileButton.Size = new System.Drawing.Size(120, 32);
            this.EncipherFileButton.TabIndex = 1;
            this.EncipherFileButton.Text = "Зашифровать файл";
            this.EncipherFileButton.UseVisualStyleBackColor = true;
            this.EncipherFileButton.Click += new System.EventHandler(this.EncipherFileButton_Click);
            // 
            // DecipherFileButton
            // 
            this.DecipherFileButton.Location = new System.Drawing.Point(313, 239);
            this.DecipherFileButton.Name = "DecipherFileButton";
            this.DecipherFileButton.Size = new System.Drawing.Size(120, 32);
            this.DecipherFileButton.TabIndex = 2;
            this.DecipherFileButton.Text = "Расшифровать файл";
            this.DecipherFileButton.UseVisualStyleBackColor = true;
            this.DecipherFileButton.Click += new System.EventHandler(this.DecipherFileButton_Click);
            // 
            // SecretKey
            // 
            this.SecretKey.Location = new System.Drawing.Point(209, 37);
            this.SecretKey.Name = "SecretKey";
            this.SecretKey.Size = new System.Drawing.Size(177, 20);
            this.SecretKey.TabIndex = 3;
            // 
            // SecretKeyLabel
            // 
            this.SecretKeyLabel.AutoSize = true;
            this.SecretKeyLabel.Location = new System.Drawing.Point(34, 40);
            this.SecretKeyLabel.Name = "SecretKeyLabel";
            this.SecretKeyLabel.Size = new System.Drawing.Size(138, 13);
            this.SecretKeyLabel.TabIndex = 4;
            this.SecretKeyLabel.Text = "Введите секретный ключ:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 326);
            this.Controls.Add(this.SecretKeyLabel);
            this.Controls.Add(this.SecretKey);
            this.Controls.Add(this.DecipherFileButton);
            this.Controls.Add(this.EncipherFileButton);
            this.Controls.Add(this.ChooseFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.Button EncipherFileButton;
        private System.Windows.Forms.Button DecipherFileButton;
        private System.Windows.Forms.TextBox SecretKey;
        private System.Windows.Forms.Label SecretKeyLabel;

    }
}

