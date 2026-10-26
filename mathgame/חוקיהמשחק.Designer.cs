namespace mathgame
{
    partial class חוקיהמשחק
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(חוקיהמשחק));
            this.התחלתהמשחק = new System.Windows.Forms.Button();
            this.החזרהלתפריט = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // התחלתהמשחק
            // 
            this.התחלתהמשחק.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.התחלתהמשחק.Location = new System.Drawing.Point(1050, 73);
            this.התחלתהמשחק.Name = "התחלתהמשחק";
            this.התחלתהמשחק.Size = new System.Drawing.Size(215, 121);
            this.התחלתהמשחק.TabIndex = 0;
            this.התחלתהמשחק.Text = "התחלת המשחק";
            this.התחלתהמשחק.UseVisualStyleBackColor = true;
            this.התחלתהמשחק.Click += new System.EventHandler(this.התחלתהמשחק_Click);
            // 
            // החזרהלתפריט
            // 
            this.החזרהלתפריט.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.החזרהלתפריט.Location = new System.Drawing.Point(1050, 200);
            this.החזרהלתפריט.Name = "החזרהלתפריט";
            this.החזרהלתפריט.Size = new System.Drawing.Size(215, 121);
            this.החזרהלתפריט.TabIndex = 1;
            this.החזרהלתפריט.Text = "בחזרה אחורה ";
            this.החזרהלתפריט.UseVisualStyleBackColor = true;
            this.החזרהלתפריט.Click += new System.EventHandler(this.החזרהלתפריט_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(29, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(988, 76);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // חוקיהמשחק
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mathgame.Properties.Resources.WhatsApp_Image_2024_07_01_at_16_06_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 647);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.החזרהלתפריט);
            this.Controls.Add(this.התחלתהמשחק);
            this.Name = "חוקיהמשחק";
            this.Text = "חוקיהמשחק";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button התחלתהמשחק;
        private System.Windows.Forms.Button החזרהלתפריט;
        private System.Windows.Forms.Label label1;
    }
}