namespace Space_Invaders2._0
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Volver_intentarlo = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Space_Invaders2._0.Properties.Resources.Gift_go;
            this.PictureBox1.Location = new System.Drawing.Point(253, 71);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(94, 76);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // Volver_intentarlo
            // 
            this.Volver_intentarlo.BackColor = System.Drawing.Color.Black;
            this.Volver_intentarlo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Volver_intentarlo.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Volver_intentarlo.ForeColor = System.Drawing.Color.White;
            this.Volver_intentarlo.Location = new System.Drawing.Point(120, 233);
            this.Volver_intentarlo.Name = "Volver_intentarlo";
            this.Volver_intentarlo.Size = new System.Drawing.Size(162, 58);
            this.Volver_intentarlo.TabIndex = 1;
            this.Volver_intentarlo.Text = "Intentarlo de nuevo";
            this.Volver_intentarlo.UseVisualStyleBackColor = false;
            this.Volver_intentarlo.Click += new System.EventHandler(this.Volver_intentarlo_Click_1);
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.Color.Black;
            this.Volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Volver.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Volver.ForeColor = System.Drawing.Color.White;
            this.Volver.Location = new System.Drawing.Point(330, 233);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(162, 34);
            this.Volver.TabIndex = 2;
            this.Volver.Text = "Volver al Menu";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Volver_intentarlo);
            this.Controls.Add(this.PictureBox1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Space Invaders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Regresar);
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox PictureBox1;
        private Button Volver_intentarlo;
        private Button Volver;
    }
}