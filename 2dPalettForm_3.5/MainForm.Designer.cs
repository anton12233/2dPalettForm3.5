namespace _2dPalettForm_3._5
{
    partial class MainForm
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
            this.PalettPanel = new System.Windows.Forms.Panel();
            this.DeleteFirst = new System.Windows.Forms.Button();
            this.DeleteLast = new System.Windows.Forms.Button();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.TotalPoint = new System.Windows.Forms.Label();
            this.Square = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PalettPanel
            // 
            this.PalettPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.PalettPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.PalettPanel.Location = new System.Drawing.Point(10, 10);
            this.PalettPanel.Name = "PalettPanel";
            this.PalettPanel.Size = new System.Drawing.Size(670, 430);
            this.PalettPanel.TabIndex = 0;
            this.PalettPanel.BackColor = System.Drawing.Color.Gray;
            this.PalettPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PalettPanel_MouseClick);
            // 
            // DeleteFirst
            // 
            this.DeleteFirst.Location = new System.Drawing.Point(685, 15);
            this.DeleteFirst.Name = "DeleteFirst";
            this.DeleteFirst.Size = new System.Drawing.Size(110, 35);
            this.DeleteFirst.TabIndex = 1;
            this.DeleteFirst.Text = "Delete first point (FP)";
            this.DeleteFirst.UseVisualStyleBackColor = true;
            this.DeleteFirst.Click += new System.EventHandler(this.DeleteFirst_Click);
            // 
            // DeleteLast
            // 
            this.DeleteLast.Location = new System.Drawing.Point(685, 55);
            this.DeleteLast.Name = "DeleteLast";
            this.DeleteLast.Size = new System.Drawing.Size(110, 35);
            this.DeleteLast.TabIndex = 2;
            this.DeleteLast.Text = "Delete last point (LP)";
            this.DeleteLast.UseVisualStyleBackColor = true;
            this.DeleteLast.Click += new System.EventHandler(this.DeleteLast_Click);
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(685, 100);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(110, 25);
            this.DeleteAll.TabIndex = 3;
            this.DeleteAll.Text = "Delete all point";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // TotalPoint
            // 
            this.TotalPoint.AutoSize = true;
            this.TotalPoint.Location = new System.Drawing.Point(685, 216);
            this.TotalPoint.Name = "TotalPoint";
            this.TotalPoint.Size = new System.Drawing.Size(70, 15);
            this.TotalPoint.TabIndex = 4;
            this.TotalPoint.Text = "Total points: 0";
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Location = new System.Drawing.Point(687, 239);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(26, 13);
            this.Square.TabIndex = 5;
            this.Square.Text = "S: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.TotalPoint);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.DeleteLast);
            this.Controls.Add(this.DeleteFirst);
            this.Controls.Add(this.PalettPanel);
            this.Name = "MainForm";
            this.Text = "Palette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PalettPanel;
        private System.Windows.Forms.Button DeleteFirst;
        private System.Windows.Forms.Button DeleteLast;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.Label TotalPoint;
        private System.Windows.Forms.Label Square;
    }
}