namespace BranchingPractice
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnDisplayGreeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(55, 28);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 23);
            this.TxtName.TabIndex = 0;
            // 
            // BtnDisplayGreeting
            // 
            this.BtnDisplayGreeting.Location = new System.Drawing.Point(51, 66);
            this.BtnDisplayGreeting.Name = "BtnDisplayGreeting";
            this.BtnDisplayGreeting.Size = new System.Drawing.Size(104, 23);
            this.BtnDisplayGreeting.TabIndex = 1;
            this.BtnDisplayGreeting.Text = "Display Greeting";
            this.BtnDisplayGreeting.UseVisualStyleBackColor = true;
            this.BtnDisplayGreeting.Click += new System.EventHandler(this.BtnDisplayGreeting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 112);
            this.Controls.Add(this.BtnDisplayGreeting);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "Branching Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtName;
        private Button BtnDisplayGreeting;
    }
}