namespace Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblmodelo = new System.Windows.Forms.Label();
            this.lblano = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btnligar = new System.Windows.Forms.Button();
            this.piccarro = new System.Windows.Forms.PictureBox();
            this.btndesligar = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.piccarro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Location = new System.Drawing.Point(79, 58);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(35, 13);
            this.lblmodelo.TabIndex = 0;
            this.lblmodelo.Text = "model";
            // 
            // lblano
            // 
            this.lblano.AutoSize = true;
            this.lblano.Location = new System.Drawing.Point(79, 126);
            this.lblano.Name = "lblano";
            this.lblano.Size = new System.Drawing.Size(27, 13);
            this.lblano.TabIndex = 1;
            this.lblano.Text = "year";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(79, 198);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(35, 13);
            this.lblstatus.TabIndex = 2;
            this.lblstatus.Text = "status";
            // 
            // btnligar
            // 
            this.btnligar.Location = new System.Drawing.Point(203, 58);
            this.btnligar.Name = "btnligar";
            this.btnligar.Size = new System.Drawing.Size(75, 23);
            this.btnligar.TabIndex = 3;
            this.btnligar.Text = "ON";
            this.btnligar.UseVisualStyleBackColor = true;
            this.btnligar.Click += new System.EventHandler(this.btnligar_Click);
            // 
            // piccarro
            // 
            this.piccarro.Image = ((System.Drawing.Image)(resources.GetObject("piccarro.Image")));
            this.piccarro.Location = new System.Drawing.Point(11, 254);
            this.piccarro.Name = "piccarro";
            this.piccarro.Size = new System.Drawing.Size(135, 87);
            this.piccarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccarro.TabIndex = 4;
            this.piccarro.TabStop = false;
            // 
            // btndesligar
            // 
            this.btndesligar.Location = new System.Drawing.Point(203, 116);
            this.btndesligar.Name = "btndesligar";
            this.btndesligar.Size = new System.Drawing.Size(75, 23);
            this.btndesligar.TabIndex = 5;
            this.btndesligar.Text = "OFF";
            this.btndesligar.UseVisualStyleBackColor = true;
            this.btndesligar.Click += new System.EventHandler(this.btndesligar_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(345, 57);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 6;
            this.btn.Text = "VAI";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 403);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btndesligar);
            this.Controls.Add(this.piccarro);
            this.Controls.Add(this.btnligar);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblano);
            this.Controls.Add(this.lblmodelo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.piccarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.Label lblano;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btnligar;
        private System.Windows.Forms.PictureBox piccarro;
        private System.Windows.Forms.Button btndesligar;
        private System.Windows.Forms.Button btn;
    }
}

