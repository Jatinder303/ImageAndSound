namespace ImageAndSound
{
    partial class Form1
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
            this.PicBox_Main = new System.Windows.Forms.PictureBox();
            this.Btn_First = new System.Windows.Forms.Button();
            this.Btn_Second = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox_Main
            // 
            this.PicBox_Main.Location = new System.Drawing.Point(179, 12);
            this.PicBox_Main.Name = "PicBox_Main";
            this.PicBox_Main.Size = new System.Drawing.Size(374, 217);
            this.PicBox_Main.TabIndex = 0;
            this.PicBox_Main.TabStop = false;
            // 
            // Btn_First
            // 
            this.Btn_First.Location = new System.Drawing.Point(179, 304);
            this.Btn_First.Name = "Btn_First";
            this.Btn_First.Size = new System.Drawing.Size(75, 23);
            this.Btn_First.TabIndex = 1;
            this.Btn_First.Text = "Cricket";
            this.Btn_First.UseVisualStyleBackColor = true;
            this.Btn_First.Click += new System.EventHandler(this.Btn_First_Click);
            // 
            // Btn_Second
            // 
            this.Btn_Second.Location = new System.Drawing.Point(478, 304);
            this.Btn_Second.Name = "Btn_Second";
            this.Btn_Second.Size = new System.Drawing.Size(75, 23);
            this.Btn_Second.TabIndex = 2;
            this.Btn_Second.Text = "Football";
            this.Btn_Second.UseVisualStyleBackColor = true;
            this.Btn_Second.Click += new System.EventHandler(this.Btn_Second_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Second);
            this.Controls.Add(this.Btn_First);
            this.Controls.Add(this.PicBox_Main);
            this.Name = "Form1";
            this.Text = "Sound and Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox_Main;
        private System.Windows.Forms.Button Btn_First;
        private System.Windows.Forms.Button Btn_Second;
    }
}

