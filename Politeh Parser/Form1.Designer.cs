namespace Politesh_parsing_net_core
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Load_EXCEL = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.File_Name_in_Form = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Load_EXCEL
            // 
            this.Load_EXCEL.Location = new System.Drawing.Point(33, 55);
            this.Load_EXCEL.Name = "Load_EXCEL";
            this.Load_EXCEL.Size = new System.Drawing.Size(192, 40);
            this.Load_EXCEL.TabIndex = 0;
            this.Load_EXCEL.Text = "Excel file";
            this.Load_EXCEL.UseVisualStyleBackColor = true;
            this.Load_EXCEL.Click += new System.EventHandler(this.Load_EXCEL_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // File_Name_in_Form
            // 
            this.File_Name_in_Form.AutoSize = true;
            this.File_Name_in_Form.Location = new System.Drawing.Point(33, 27);
            this.File_Name_in_Form.Name = "File_Name_in_Form";
            this.File_Name_in_Form.Size = new System.Drawing.Size(38, 15);
            this.File_Name_in_Form.TabIndex = 1;
            this.File_Name_in_Form.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 422);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.File_Name_in_Form);
            this.Controls.Add(this.Load_EXCEL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Load_EXCEL;
        private OpenFileDialog openFileDialog1;
        private Label File_Name_in_Form;
        private TextBox textBox1;
    }
}