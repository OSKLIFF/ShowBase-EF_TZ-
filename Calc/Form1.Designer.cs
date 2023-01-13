namespace Calc
{
    partial class Form1
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
            this.Content_Viewer = new System.Windows.Forms.TextBox();
            this.File_BT = new System.Windows.Forms.Button();
            this.Save_BT = new System.Windows.Forms.Button();
            this.Size_Font = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Size_Font)).BeginInit();
            this.SuspendLayout();
            // 
            // Content_Viewer
            // 
            this.Content_Viewer.Location = new System.Drawing.Point(12, 12);
            this.Content_Viewer.Multiline = true;
            this.Content_Viewer.Name = "Content_Viewer";
            this.Content_Viewer.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Content_Viewer.Size = new System.Drawing.Size(492, 426);
            this.Content_Viewer.TabIndex = 0;
            // 
            // File_BT
            // 
            this.File_BT.Location = new System.Drawing.Point(510, 56);
            this.File_BT.Name = "File_BT";
            this.File_BT.Size = new System.Drawing.Size(138, 23);
            this.File_BT.TabIndex = 1;
            this.File_BT.Text = "Выбрать файл";
            this.File_BT.UseVisualStyleBackColor = true;
            // 
            // Save_BT
            // 
            this.Save_BT.Location = new System.Drawing.Point(510, 103);
            this.Save_BT.Name = "Save_BT";
            this.Save_BT.Size = new System.Drawing.Size(138, 23);
            this.Save_BT.TabIndex = 2;
            this.Save_BT.Text = "Сохранить изменения";
            this.Save_BT.UseVisualStyleBackColor = true;
            // 
            // Size_Font
            // 
            this.Size_Font.Location = new System.Drawing.Point(511, 12);
            this.Size_Font.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.Size_Font.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.Size_Font.Name = "Size_Font";
            this.Size_Font.Size = new System.Drawing.Size(120, 20);
            this.Size_Font.TabIndex = 3;
            this.Size_Font.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 463);
            this.Controls.Add(this.Size_Font);
            this.Controls.Add(this.Save_BT);
            this.Controls.Add(this.File_BT);
            this.Controls.Add(this.Content_Viewer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Size_Font)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Content_Viewer;
        private System.Windows.Forms.Button File_BT;
        private System.Windows.Forms.Button Save_BT;
        private System.Windows.Forms.NumericUpDown Size_Font;
    }
}

