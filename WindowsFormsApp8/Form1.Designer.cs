namespace WindowsFormsApp8
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
            this.pictureBox_Nevado = new System.Windows.Forms.PictureBox();
            this.panel_Terem = new System.Windows.Forms.Panel();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.button_Statisztika = new System.Windows.Forms.Button();
            this.button_Balra = new System.Windows.Forms.Button();
            this.button_Jobbra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Nevado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Nevado
            // 
            this.pictureBox_Nevado.Location = new System.Drawing.Point(37, 72);
            this.pictureBox_Nevado.Name = "pictureBox_Nevado";
            this.pictureBox_Nevado.Size = new System.Drawing.Size(108, 154);
            this.pictureBox_Nevado.TabIndex = 0;
            this.pictureBox_Nevado.TabStop = false;
            // 
            // panel_Terem
            // 
            this.panel_Terem.Location = new System.Drawing.Point(211, 29);
            this.panel_Terem.Name = "panel_Terem";
            this.panel_Terem.Size = new System.Drawing.Size(358, 280);
            this.panel_Terem.TabIndex = 1;
            // 
            // button_Mentes
            // 
            this.button_Mentes.Location = new System.Drawing.Point(177, 347);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(75, 23);
            this.button_Mentes.TabIndex = 2;
            this.button_Mentes.Text = "Mentés";
            this.button_Mentes.UseVisualStyleBackColor = true;
            // 
            // button_Statisztika
            // 
            this.button_Statisztika.Location = new System.Drawing.Point(337, 347);
            this.button_Statisztika.Name = "button_Statisztika";
            this.button_Statisztika.Size = new System.Drawing.Size(75, 23);
            this.button_Statisztika.TabIndex = 3;
            this.button_Statisztika.Text = "Statisztika";
            this.button_Statisztika.UseVisualStyleBackColor = true;
            // 
            // button_Balra
            // 
            this.button_Balra.BackgroundImage = global::WindowsFormsApp8.Properties.Resources.balra;
            this.button_Balra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Balra.Location = new System.Drawing.Point(116, 399);
            this.button_Balra.Name = "button_Balra";
            this.button_Balra.Size = new System.Drawing.Size(106, 62);
            this.button_Balra.TabIndex = 4;
            this.button_Balra.UseVisualStyleBackColor = true;
            // 
            // button_Jobbra
            // 
            this.button_Jobbra.BackgroundImage = global::WindowsFormsApp8.Properties.Resources.jobbra;
            this.button_Jobbra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Jobbra.Location = new System.Drawing.Point(395, 399);
            this.button_Jobbra.Name = "button_Jobbra";
            this.button_Jobbra.Size = new System.Drawing.Size(104, 62);
            this.button_Jobbra.TabIndex = 5;
            this.button_Jobbra.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 497);
            this.Controls.Add(this.button_Jobbra);
            this.Controls.Add(this.button_Balra);
            this.Controls.Add(this.button_Statisztika);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.panel_Terem);
            this.Controls.Add(this.pictureBox_Nevado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Nevado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Nevado;
        private System.Windows.Forms.Panel panel_Terem;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.Button button_Statisztika;
        private System.Windows.Forms.Button button_Balra;
        private System.Windows.Forms.Button button_Jobbra;
    }
}

