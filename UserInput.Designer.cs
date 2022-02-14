namespace LuckyNumbers
{
    partial class UserInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.city_cB = new System.Windows.Forms.ComboBox();
            this.Team_cB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(510, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // city_cB
            // 
            this.city_cB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_cB.FormattingEnabled = true;
            this.city_cB.Location = new System.Drawing.Point(114, 133);
            this.city_cB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.city_cB.Name = "city_cB";
            this.city_cB.Size = new System.Drawing.Size(238, 40);
            this.city_cB.TabIndex = 1;
            this.city_cB.Text = "Select City";
            this.city_cB.SelectedIndexChanged += new System.EventHandler(this.city_cB_SelectedIndexChanged);
            // 
            // Team_cB
            // 
            this.Team_cB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Team_cB.FormattingEnabled = true;
            this.Team_cB.Items.AddRange(new object[] {
            "Baseball",
            "Soccer",
            "Football",
            "Wrestling ",
            "Swimming"});
            this.Team_cB.Location = new System.Drawing.Point(114, 206);
            this.Team_cB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Team_cB.Name = "Team_cB";
            this.Team_cB.Size = new System.Drawing.Size(238, 40);
            this.Team_cB.TabIndex = 1;
            this.Team_cB.Text = "Select Sport";
            this.Team_cB.SelectedIndexChanged += new System.EventHandler(this.Team_cB_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(154, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(539, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Team_cB);
            this.Controls.Add(this.city_cB);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Numbers";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.UserInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox city_cB;
        private System.Windows.Forms.ComboBox Team_cB;
        private System.Windows.Forms.Button button1;
    }
}

