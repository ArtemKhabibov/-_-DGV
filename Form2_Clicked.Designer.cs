
namespace Авито_Создание_переключаемых_DGV
{
    partial class Form2_Clicked
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
            this.OK_B = new System.Windows.Forms.Button();
            this.Cancel_B = new System.Windows.Forms.Button();
            this.A_TB = new System.Windows.Forms.TextBox();
            this.A_L = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OK_B
            // 
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.Location = new System.Drawing.Point(211, 286);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(75, 23);
            this.OK_B.TabIndex = 0;
            this.OK_B.Text = "OK";
            this.OK_B.UseVisualStyleBackColor = true;
            // 
            // Cancel_B
            // 
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Location = new System.Drawing.Point(304, 286);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(75, 23);
            this.Cancel_B.TabIndex = 1;
            this.Cancel_B.Text = "Cancel";
            this.Cancel_B.UseVisualStyleBackColor = true;
            // 
            // A_TB
            // 
            this.A_TB.Location = new System.Drawing.Point(211, 75);
            this.A_TB.Name = "A_TB";
            this.A_TB.Size = new System.Drawing.Size(141, 22);
            this.A_TB.TabIndex = 2;
            // 
            // A_L
            // 
            this.A_L.AutoSize = true;
            this.A_L.Location = new System.Drawing.Point(211, 52);
            this.A_L.Name = "A_L";
            this.A_L.Size = new System.Drawing.Size(141, 17);
            this.A_L.TabIndex = 3;
            this.A_L.Text = "Введите перменную";
            // 
            // Form2_Clicked
            // 
            this.AcceptButton = this.OK_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.A_L);
            this.Controls.Add(this.A_TB);
            this.Controls.Add(this.Cancel_B);
            this.Controls.Add(this.OK_B);
            this.Name = "Form2_Clicked";
            this.Text = "Form2_Clicked";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_Clicked_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_B;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.TextBox A_TB;
        private System.Windows.Forms.Label A_L;
    }
}