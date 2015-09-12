namespace Teamproject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TxtLyric = new System.Windows.Forms.TextBox();
            this.ckViewTime1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // TxtLyric
            // 
            this.TxtLyric.BackColor = System.Drawing.Color.SkyBlue;
            this.TxtLyric.Location = new System.Drawing.Point(17, 18);
            this.TxtLyric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtLyric.Multiline = true;
            this.TxtLyric.Name = "TxtLyric";
            this.TxtLyric.ReadOnly = true;
            this.TxtLyric.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtLyric.Size = new System.Drawing.Size(370, 338);
            this.TxtLyric.TabIndex = 1;
            this.TxtLyric.TextChanged += new System.EventHandler(this.TxtLyric_TextChanged);
            // 
            // ckViewTime1
            // 
            this.ckViewTime1.AutoSize = true;
            this.ckViewTime1.Location = new System.Drawing.Point(17, 48);
            this.ckViewTime1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ckViewTime1.Name = "ckViewTime1";
            this.ckViewTime1.Size = new System.Drawing.Size(110, 22);
            this.ckViewTime1.TabIndex = 2;
            this.ckViewTime1.Text = "ViewTime";
            this.ckViewTime1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(391, 354);
            this.Controls.Add(this.ckViewTime1);
            this.Controls.Add(this.TxtLyric);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(417, 414);
            this.MinimumSize = new System.Drawing.Size(417, 414);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Lyrics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtLyric;
        public System.Windows.Forms.CheckBox ckViewTime1;


    }
}