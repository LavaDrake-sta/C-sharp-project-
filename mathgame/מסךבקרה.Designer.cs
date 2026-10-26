namespace mathgame
{
    partial class מסךבקרה
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
            this.התחלתמשחק = new System.Windows.Forms.Button();
            this.חוקיהמשחק = new System.Windows.Forms.Button();
            this.חזרהלמסךראשי = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // התחלתמשחק
            // 
            this.התחלתמשחק.BackColor = System.Drawing.Color.ForestGreen;
            this.התחלתמשחק.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.התחלתמשחק.Location = new System.Drawing.Point(894, 155);
            this.התחלתמשחק.Name = "התחלתמשחק";
            this.התחלתמשחק.Size = new System.Drawing.Size(205, 111);
            this.התחלתמשחק.TabIndex = 0;
            this.התחלתמשחק.Text = "התחלת משחק";
            this.התחלתמשחק.UseVisualStyleBackColor = false;
            this.התחלתמשחק.Click += new System.EventHandler(this.התחלתמשחק_Click);
            // 
            // חוקיהמשחק
            // 
            this.חוקיהמשחק.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.חוקיהמשחק.Location = new System.Drawing.Point(894, 272);
            this.חוקיהמשחק.Name = "חוקיהמשחק";
            this.חוקיהמשחק.Size = new System.Drawing.Size(205, 110);
            this.חוקיהמשחק.TabIndex = 1;
            this.חוקיהמשחק.Text = "חוקי המשחק";
            this.חוקיהמשחק.UseVisualStyleBackColor = true;
            this.חוקיהמשחק.Click += new System.EventHandler(this.חוקיהמשחק_Click);
            // 
            // חזרהלמסךראשי
            // 
            this.חזרהלמסךראשי.BackColor = System.Drawing.Color.Red;
            this.חזרהלמסךראשי.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.חזרהלמסךראשי.Location = new System.Drawing.Point(894, 388);
            this.חזרהלמסךראשי.Name = "חזרהלמסךראשי";
            this.חזרהלמסךראשי.Size = new System.Drawing.Size(205, 110);
            this.חזרהלמסךראשי.TabIndex = 2;
            this.חזרהלמסךראשי.Text = "חזרה למסך ראשי";
            this.חזרהלמסךראשי.UseVisualStyleBackColor = false;
            this.חזרהלמסךראשי.Click += new System.EventHandler(this.חזרהלמסךראשי_Click);
            // 
            // מסךבקרה
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mathgame.Properties.Resources.WhatsApp_Image_2024_07_01_at_16_06_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1291, 646);
            this.Controls.Add(this.חזרהלמסךראשי);
            this.Controls.Add(this.חוקיהמשחק);
            this.Controls.Add(this.התחלתמשחק);
            this.Name = "מסךבקרה";
            this.Text = "מסךבקרה";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button התחלתמשחק;
        private System.Windows.Forms.Button חוקיהמשחק;
        private System.Windows.Forms.Button חזרהלמסךראשי;
    }
}