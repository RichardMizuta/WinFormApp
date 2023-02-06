namespace WinFormApp1
{
    partial class Owner
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
            this.B_Syokyu = new System.Windows.Forms.Button();
            this.B_Chukyu = new System.Windows.Forms.Button();
            this.B_Jyokyu = new System.Windows.Forms.Button();
            this.B_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Syokyu
            // 
            this.B_Syokyu.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Syokyu.Location = new System.Drawing.Point(158, 12);
            this.B_Syokyu.Name = "B_Syokyu";
            this.B_Syokyu.Size = new System.Drawing.Size(226, 77);
            this.B_Syokyu.TabIndex = 0;
            this.B_Syokyu.Text = "初級";
            this.B_Syokyu.UseVisualStyleBackColor = true;
            this.B_Syokyu.Click += new System.EventHandler(this.B_Syokyu_Click_1);
            // 
            // B_Chukyu
            // 
            this.B_Chukyu.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Chukyu.Location = new System.Drawing.Point(158, 112);
            this.B_Chukyu.Name = "B_Chukyu";
            this.B_Chukyu.Size = new System.Drawing.Size(226, 77);
            this.B_Chukyu.TabIndex = 1;
            this.B_Chukyu.Text = "中級";
            this.B_Chukyu.UseVisualStyleBackColor = true;
            this.B_Chukyu.Click += new System.EventHandler(this.B_Chukyu_Click_1);
            // 
            // B_Jyokyu
            // 
            this.B_Jyokyu.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Jyokyu.Location = new System.Drawing.Point(158, 214);
            this.B_Jyokyu.Name = "B_Jyokyu";
            this.B_Jyokyu.Size = new System.Drawing.Size(226, 72);
            this.B_Jyokyu.TabIndex = 2;
            this.B_Jyokyu.Text = "上級";
            this.B_Jyokyu.UseVisualStyleBackColor = true;
            this.B_Jyokyu.Click += new System.EventHandler(this.B_Jyokyu_Click_1);
            // 
            // B_Close
            // 
            this.B_Close.Font = new System.Drawing.Font("Yu Gothic UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.B_Close.Location = new System.Drawing.Point(158, 334);
            this.B_Close.Name = "B_Close";
            this.B_Close.Size = new System.Drawing.Size(226, 67);
            this.B_Close.TabIndex = 3;
            this.B_Close.Text = "終了";
            this.B_Close.UseVisualStyleBackColor = true;
            this.B_Close.Click += new System.EventHandler(this.B_Close_Click);
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.B_Close);
            this.Controls.Add(this.B_Jyokyu);
            this.Controls.Add(this.B_Chukyu);
            this.Controls.Add(this.B_Syokyu);
            this.Name = "Owner";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Owner_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button B_Syokyu;
        private Button B_Chukyu;
        private Button B_Jyokyu;
        private Button B_Close;
    }
}