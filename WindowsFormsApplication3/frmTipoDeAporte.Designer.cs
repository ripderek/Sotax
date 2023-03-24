namespace WindowsFormsApplication3
{
    partial class frmTipoDeAporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTipodeAporteDiario = new System.Windows.Forms.Button();
            this.btnTipodeAporteBauche = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(116, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO DE APORTE";
            // 
            // btnTipodeAporteDiario
            // 
            this.btnTipodeAporteDiario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(65)))));
            this.btnTipodeAporteDiario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipodeAporteDiario.FlatAppearance.BorderSize = 0;
            this.btnTipodeAporteDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipodeAporteDiario.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipodeAporteDiario.Location = new System.Drawing.Point(45, 114);
            this.btnTipodeAporteDiario.Name = "btnTipodeAporteDiario";
            this.btnTipodeAporteDiario.Size = new System.Drawing.Size(130, 38);
            this.btnTipodeAporteDiario.TabIndex = 1;
            this.btnTipodeAporteDiario.Text = "DIARIO";
            this.btnTipodeAporteDiario.UseVisualStyleBackColor = false;
            this.btnTipodeAporteDiario.Click += new System.EventHandler(this.btnTipodeAporteDiario_Click);
            // 
            // btnTipodeAporteBauche
            // 
            this.btnTipodeAporteBauche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(230)))), ((int)(((byte)(65)))));
            this.btnTipodeAporteBauche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTipodeAporteBauche.FlatAppearance.BorderSize = 0;
            this.btnTipodeAporteBauche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipodeAporteBauche.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipodeAporteBauche.Location = new System.Drawing.Point(211, 114);
            this.btnTipodeAporteBauche.Name = "btnTipodeAporteBauche";
            this.btnTipodeAporteBauche.Size = new System.Drawing.Size(130, 38);
            this.btnTipodeAporteBauche.TabIndex = 1;
            this.btnTipodeAporteBauche.Text = "BAUCHE";
            this.btnTipodeAporteBauche.UseVisualStyleBackColor = false;
            this.btnTipodeAporteBauche.Click += new System.EventHandler(this.btnTipodeAporteBauche_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(361, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication3.Properties.Resources.Warning_37097;
            this.pictureBox1.Location = new System.Drawing.Point(147, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmTipoDeAporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(395, 171);
            this.Controls.Add(this.btnTipodeAporteBauche);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTipodeAporteDiario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTipoDeAporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTipoDeAporte";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTipodeAporteDiario;
        private System.Windows.Forms.Button btnTipodeAporteBauche;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}