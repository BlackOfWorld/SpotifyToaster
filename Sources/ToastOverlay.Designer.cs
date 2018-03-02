namespace spotifytoaster
{
    partial class ToastOverlay
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
            this.trackBox = new CustomLabel();
            this.artistBox = new CustomLabel();
            this.albumBox = new CustomLabel();
            this.SuspendLayout();
            // 
            // trackBox
            // 
            this.trackBox.AutoSize = true;
            this.trackBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trackBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackBox.ForeColor = System.Drawing.Color.YellowGreen;
            this.trackBox.Location = new System.Drawing.Point(120, 88);
            this.trackBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.trackBox.Name = "trackBox";
            this.trackBox.Size = new System.Drawing.Size(129, 25);
            this.trackBox.TabIndex = 8;
            this.trackBox.Text = "Track Name";
            // 
            // artistBox
            // 
            this.artistBox.AutoSize = true;
            this.artistBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.artistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistBox.ForeColor = System.Drawing.Color.YellowGreen;
            this.artistBox.Location = new System.Drawing.Point(120, 52);
            this.artistBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.artistBox.Name = "artistBox";
            this.artistBox.Size = new System.Drawing.Size(62, 25);
            this.artistBox.TabIndex = 7;
            this.artistBox.Text = "Artist";
            // 
            // albumBox
            // 
            this.albumBox.AutoSize = true;
            this.albumBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.albumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumBox.ForeColor = System.Drawing.Color.YellowGreen;
            this.albumBox.Location = new System.Drawing.Point(120, 15);
            this.albumBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(73, 25);
            this.albumBox.TabIndex = 12;
            this.albumBox.Text = "Album";
            // 
            // ToastOverlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(544, 129);
            this.ControlBox = false;
            this.Controls.Add(this.albumBox);
            this.Controls.Add(this.trackBox);
            this.Controls.Add(this.artistBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ToastOverlay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ToastOverlay";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label trackBox;
        internal System.Windows.Forms.Label artistBox;
        internal System.Windows.Forms.Label albumBox;


    }
}