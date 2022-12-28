namespace ITMO.WinForm.Lab1.Exercise
{
    partial class nForm
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
            this.checkBoxClosed = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxClosed
            // 
            this.checkBoxClosed.AutoSize = true;
            this.checkBoxClosed.Location = new System.Drawing.Point(323, 202);
            this.checkBoxClosed.Name = "checkBoxClosed";
            this.checkBoxClosed.Size = new System.Drawing.Size(115, 20);
            this.checkBoxClosed.TabIndex = 0;
            this.checkBoxClosed.Text = "Close Window";
            this.checkBoxClosed.UseVisualStyleBackColor = true;
            this.checkBoxClosed.CheckedChanged += new System.EventHandler(this.checkBoxClosed_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(323, 251);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 61);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // nForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.checkBoxClosed);
            this.Name = "nForm";
            this.Text = "nForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.nForm_FormClosing_1);
            this.Load += new System.EventHandler(this.nForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxClosed;
        private System.Windows.Forms.Button btnClose;
    }
}