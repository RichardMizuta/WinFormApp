namespace WinFormApp1
{
    partial class F_Main
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
            this.L_Jikan = new System.Windows.Forms.Label();
            this.L_Tokuten = new System.Windows.Forms.Label();
            this.L_Sum = new System.Windows.Forms.Label();
            this.B_Start = new System.Windows.Forms.Button();
            this.PG_Jikan = new System.Windows.Forms.ProgressBar();
            this.P_Enemy = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // L_Jikan
            // 
            this.L_Jikan.AutoSize = true;
            this.L_Jikan.Location = new System.Drawing.Point(190, 18);
            this.L_Jikan.Name = "L_Jikan";
            this.L_Jikan.Size = new System.Drawing.Size(51, 15);
            this.L_Jikan.TabIndex = 0;
            this.L_Jikan.Text = "残り時間";
            // 
            // L_Tokuten
            // 
            this.L_Tokuten.AutoSize = true;
            this.L_Tokuten.Location = new System.Drawing.Point(423, 18);
            this.L_Tokuten.Name = "L_Tokuten";
            this.L_Tokuten.Size = new System.Drawing.Size(31, 15);
            this.L_Tokuten.TabIndex = 1;
            this.L_Tokuten.Text = "得点";
            // 
            // L_Sum
            // 
            this.L_Sum.AutoSize = true;
            this.L_Sum.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L_Sum.Location = new System.Drawing.Point(532, 36);
            this.L_Sum.Name = "L_Sum";
            this.L_Sum.Size = new System.Drawing.Size(22, 25);
            this.L_Sum.TabIndex = 2;
            this.L_Sum.Text = "0";
            // 
            // B_Start
            // 
            this.B_Start.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.B_Start.Location = new System.Drawing.Point(42, 12);
            this.B_Start.Name = "B_Start";
            this.B_Start.Size = new System.Drawing.Size(125, 56);
            this.B_Start.TabIndex = 3;
            this.B_Start.Text = "スタート";
            this.B_Start.UseVisualStyleBackColor = false;
            // 
            // PG_Jikan
            // 
            this.PG_Jikan.Location = new System.Drawing.Point(193, 36);
            this.PG_Jikan.Maximum = 10;
            this.PG_Jikan.Name = "PG_Jikan";
            this.PG_Jikan.Size = new System.Drawing.Size(198, 28);
            this.PG_Jikan.TabIndex = 4;
            this.PG_Jikan.Value = 10;
            // 
            // P_Enemy
            // 
            this.P_Enemy.BackColor = System.Drawing.Color.White;
            this.P_Enemy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.P_Enemy.Location = new System.Drawing.Point(42, 91);
            this.P_Enemy.Name = "P_Enemy";
            this.P_Enemy.Size = new System.Drawing.Size(613, 314);
            this.P_Enemy.TabIndex = 5;
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.P_Enemy);
            this.Controls.Add(this.PG_Jikan);
            this.Controls.Add(this.B_Start);
            this.Controls.Add(this.L_Sum);
            this.Controls.Add(this.L_Tokuten);
            this.Controls.Add(this.L_Jikan);
            this.Name = "F_Main";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label L_Jikan;
        private Label L_Tokuten;
        private Label L_Sum;
        private Button B_Start;
        private ProgressBar PG_Jikan;
        private Panel P_Enemy;
    }
}