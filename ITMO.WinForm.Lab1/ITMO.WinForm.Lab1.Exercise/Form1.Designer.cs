namespace ITMO.WinForm.Lab1.Exercise
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
            this.btn_border = new System.Windows.Forms.Button();
            this.btn_size = new System.Windows.Forms.Button();
            this.btn_opacity = new System.Windows.Forms.Button();
            this.btn_nForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_border
            // 
            this.btn_border.Location = new System.Drawing.Point(78, 102);
            this.btn_border.Name = "btn_border";
            this.btn_border.Size = new System.Drawing.Size(96, 54);
            this.btn_border.TabIndex = 0;
            this.btn_border.Text = "Border Style";
            this.btn_border.UseVisualStyleBackColor = true;
            this.btn_border.Click += new System.EventHandler(this.btn_border_Click);
            // 
            // btn_size
            // 
            this.btn_size.Location = new System.Drawing.Point(180, 102);
            this.btn_size.Name = "btn_size";
            this.btn_size.Size = new System.Drawing.Size(96, 54);
            this.btn_size.TabIndex = 1;
            this.btn_size.Text = "Resize";
            this.btn_size.UseVisualStyleBackColor = true;
            this.btn_size.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_opacity
            // 
            this.btn_opacity.Location = new System.Drawing.Point(282, 102);
            this.btn_opacity.Name = "btn_opacity";
            this.btn_opacity.Size = new System.Drawing.Size(96, 54);
            this.btn_opacity.TabIndex = 2;
            this.btn_opacity.Text = "Opacity";
            this.btn_opacity.UseVisualStyleBackColor = true;
            this.btn_opacity.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_nForm
            // 
            this.btn_nForm.Location = new System.Drawing.Point(78, 198);
            this.btn_nForm.Name = "btn_nForm";
            this.btn_nForm.Size = new System.Drawing.Size(300, 84);
            this.btn_nForm.TabIndex = 3;
            this.btn_nForm.Text = "nForm";
            this.btn_nForm.UseVisualStyleBackColor = true;
            this.btn_nForm.Click += new System.EventHandler(this.btn_nForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_nForm);
            this.Controls.Add(this.btn_opacity);
            this.Controls.Add(this.btn_size);
            this.Controls.Add(this.btn_border);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_border;
        private System.Windows.Forms.Button btn_size;
        private System.Windows.Forms.Button btn_opacity;
        private System.Windows.Forms.Button btn_nForm;
    }
}

