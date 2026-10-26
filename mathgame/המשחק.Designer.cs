namespace mathgame
{
    partial class המשחק
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
            this.חזרהלתפריט = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // חזרהלתפריט
            // 
            this.חזרהלתפריט.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.חזרהלתפריט.Location = new System.Drawing.Point(1073, 490);
            this.חזרהלתפריט.Name = "חזרהלתפריט";
            this.חזרהלתפריט.Size = new System.Drawing.Size(172, 112);
            this.חזרהלתפריט.TabIndex = 0;
            this.חזרהלתפריט.Text = "חזרה לתפריט ";
            this.חזרהלתפריט.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.חזרהלתפריט.UseVisualStyleBackColor = true;
            this.חזרהלתפריט.Click += new System.EventHandler(this.חזרהלתפריט_Click);
            // 
            // המשחק
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mathgame.Properties.Resources.WhatsApp_Image_2024_07_01_at_16_06_10;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1286, 647);
            this.Controls.Add(this.חזרהלתפריט);
            this.Name = "המשחק";
            this.Text = "המשחק";
            this.Load += new System.EventHandler(this.המשחק_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button חזרהלתפריט;
    }
}