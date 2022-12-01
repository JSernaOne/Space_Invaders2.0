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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::Space_Invaders2._0.Properties.Resources.Gift_go;
            this.PictureBox1.Location = new System.Drawing.Point(373, 145);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(128, 118);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // Volver_intentarlo
            // 
            this.Volver_intentarlo.BackColor = System.Drawing.Color.Transparent;
            this.Volver_intentarlo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Volver_intentarlo.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Volver_intentarlo.ForeColor = System.Drawing.Color.Cyan;
            this.Volver_intentarlo.Location = new System.Drawing.Point(248, 287);
            this.Volver_intentarlo.Name = "Volver_intentarlo";
            this.Volver_intentarlo.Size = new System.Drawing.Size(126, 58);
            this.Volver_intentarlo.TabIndex = 1;
            this.Volver_intentarlo.Text = "Intentarlo de nuevo";
            this.Volver_intentarlo.UseVisualStyleBackColor = false;
            this.Volver_intentarlo.Click += new System.EventHandler(this.Volver_intentarlo_Click_1);
            // 
            // Volver
            // 
            this.Volver.BackColor = System.Drawing.Color.Transparent;
            this.Volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Volver.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Volver.ForeColor = System.Drawing.Color.Cyan;
            this.Volver.Location = new System.Drawing.Point(499, 287);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(127, 58);
            this.Volver.TabIndex = 2;
            this.Volver.Text = "Volver al Menú";
            this.Volver.UseVisualStyleBackColor = false;
            this.Volver.Click += new System.EventHandler(this.Volver_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(107, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(661, 79);
            this.label1.TabIndex = 3;
            this.label1.Text = "Te han Derrotado";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(859, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Volver_intentarlo);
            this.Controls.Add(this.PictureBox1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(875, 490);
            this.MinimumSize = new System.Drawing.Size(875, 490);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Invaders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Regresar);
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PictureBox1;
        private Button Volver_intentarlo;
        private Button Volver;
        private Label label1;
    }
}