
namespace Авито_Создание_переключаемых_DGV
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
            this.Tab_TC = new System.Windows.Forms.TabControl();
            this.Pages_L = new System.Windows.Forms.Label();
            this.Pages_TB = new System.Windows.Forms.TextBox();
            this.Pages_B = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Row_NUD = new System.Windows.Forms.NumericUpDown();
            this.Col_NUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Row_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab_TC
            // 
            this.Tab_TC.Location = new System.Drawing.Point(12, 12);
            this.Tab_TC.Name = "Tab_TC";
            this.Tab_TC.SelectedIndex = 0;
            this.Tab_TC.Size = new System.Drawing.Size(610, 302);
            this.Tab_TC.TabIndex = 0;
            // 
            // Pages_L
            // 
            this.Pages_L.AutoSize = true;
            this.Pages_L.Location = new System.Drawing.Point(628, 37);
            this.Pages_L.Name = "Pages_L";
            this.Pages_L.Size = new System.Drawing.Size(144, 17);
            this.Pages_L.TabIndex = 1;
            this.Pages_L.Text = "Количество страниц";
            // 
            // Pages_TB
            // 
            this.Pages_TB.Location = new System.Drawing.Point(631, 58);
            this.Pages_TB.Name = "Pages_TB";
            this.Pages_TB.Size = new System.Drawing.Size(100, 22);
            this.Pages_TB.TabIndex = 2;
            // 
            // Pages_B
            // 
            this.Pages_B.Location = new System.Drawing.Point(631, 87);
            this.Pages_B.Name = "Pages_B";
            this.Pages_B.Size = new System.Drawing.Size(100, 23);
            this.Pages_B.TabIndex = 3;
            this.Pages_B.Text = "Применить";
            this.Pages_B.UseVisualStyleBackColor = true;
            this.Pages_B.Click += new System.EventHandler(this.Pages_B_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.ColumnHeadersHeight = 30;
            this.DGV.ColumnHeadersVisible = false;
            this.DGV.Location = new System.Drawing.Point(12, 321);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 100;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(610, 150);
            this.DGV.TabIndex = 4;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // Row_NUD
            // 
            this.Row_NUD.Location = new System.Drawing.Point(628, 449);
            this.Row_NUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Row_NUD.Name = "Row_NUD";
            this.Row_NUD.Size = new System.Drawing.Size(120, 22);
            this.Row_NUD.TabIndex = 5;
            this.Row_NUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Row_NUD.ValueChanged += new System.EventHandler(this.Row_NUD_ValueChanged);
            // 
            // Col_NUD
            // 
            this.Col_NUD.Location = new System.Drawing.Point(502, 477);
            this.Col_NUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Col_NUD.Name = "Col_NUD";
            this.Col_NUD.Size = new System.Drawing.Size(120, 22);
            this.Col_NUD.TabIndex = 6;
            this.Col_NUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.Col_NUD.ValueChanged += new System.EventHandler(this.Col_NUD_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 698);
            this.Controls.Add(this.Col_NUD);
            this.Controls.Add(this.Row_NUD);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.Pages_B);
            this.Controls.Add(this.Pages_TB);
            this.Controls.Add(this.Pages_L);
            this.Controls.Add(this.Tab_TC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Row_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Col_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_TC;
        private System.Windows.Forms.Label Pages_L;
        private System.Windows.Forms.TextBox Pages_TB;
        private System.Windows.Forms.Button Pages_B;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.NumericUpDown Row_NUD;
        private System.Windows.Forms.NumericUpDown Col_NUD;
    }
}

