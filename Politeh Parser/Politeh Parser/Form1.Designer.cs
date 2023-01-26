namespace Politeh_Parser
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
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.LoadFileText = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(51, 79);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(151, 23);
            this.LoadFileButton.TabIndex = 0;
            this.LoadFileButton.Text = "Загрузить Excel Файл";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // LoadFileText
            // 
            this.LoadFileText.AutoSize = true;
            this.LoadFileText.Location = new System.Drawing.Point(48, 117);
            this.LoadFileText.Name = "LoadFileText";
            this.LoadFileText.Size = new System.Drawing.Size(35, 13);
            this.LoadFileText.TabIndex = 1;
            this.LoadFileText.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoadFileText);
            this.Controls.Add(this.LoadFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadFileButton;
        private System.Windows.Forms.Label LoadFileText;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

