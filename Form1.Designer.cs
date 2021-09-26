
namespace DoorPortaria
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
            this.port_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pwd_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ip_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.realplay_pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.streamtype_comboBox = new System.Windows.Forms.ComboBox();
            this.channel_comboBox = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.capture_button = new System.Windows.Forms.Button();
            this.start_realplay_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.realplay_pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // port_textBox
            // 
            this.port_textBox.Location = new System.Drawing.Point(251, 19);
            this.port_textBox.Name = "port_textBox";
            this.port_textBox.Size = new System.Drawing.Size(43, 20);
            this.port_textBox.TabIndex = 21;
            this.port_textBox.Text = "2080";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Port(端口):";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(626, 17);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(115, 23);
            this.login_button.TabIndex = 24;
            this.login_button.Text = "Login(登录)";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(368, 19);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(53, 20);
            this.name_textBox.TabIndex = 22;
            this.name_textBox.Text = "alarmaq";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Name(用户):";
            // 
            // pwd_textBox
            // 
            this.pwd_textBox.Location = new System.Drawing.Point(498, 19);
            this.pwd_textBox.Name = "pwd_textBox";
            this.pwd_textBox.Size = new System.Drawing.Size(103, 20);
            this.pwd_textBox.TabIndex = 23;
            this.pwd_textBox.Text = "213388al";
            this.pwd_textBox.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Pwd(密码):";
            // 
            // ip_textBox
            // 
            this.ip_textBox.Location = new System.Drawing.Point(84, 19);
            this.ip_textBox.Name = "ip_textBox";
            this.ip_textBox.Size = new System.Drawing.Size(92, 20);
            this.ip_textBox.TabIndex = 19;
            this.ip_textBox.Text = "45.224.164.99";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "IP(设备IP):";
            // 
            // realplay_pictureBox
            // 
            this.realplay_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.realplay_pictureBox.Location = new System.Drawing.Point(4, 71);
            this.realplay_pictureBox.Name = "realplay_pictureBox";
            this.realplay_pictureBox.Size = new System.Drawing.Size(562, 445);
            this.realplay_pictureBox.TabIndex = 20;
            this.realplay_pictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.streamtype_comboBox);
            this.groupBox2.Controls.Add(this.channel_comboBox);
            this.groupBox2.Controls.Add(this.save_button);
            this.groupBox2.Controls.Add(this.capture_button);
            this.groupBox2.Controls.Add(this.start_realplay_button);
            this.groupBox2.Location = new System.Drawing.Point(572, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 196);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview(预览)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(22, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "StreamType(码流类型):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Channel(通道):";
            // 
            // streamtype_comboBox
            // 
            this.streamtype_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.streamtype_comboBox.FormattingEnabled = true;
            this.streamtype_comboBox.Location = new System.Drawing.Point(20, 81);
            this.streamtype_comboBox.Name = "streamtype_comboBox";
            this.streamtype_comboBox.Size = new System.Drawing.Size(159, 21);
            this.streamtype_comboBox.TabIndex = 6;
            // 
            // channel_comboBox
            // 
            this.channel_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channel_comboBox.FormattingEnabled = true;
            this.channel_comboBox.Location = new System.Drawing.Point(20, 35);
            this.channel_comboBox.Name = "channel_comboBox";
            this.channel_comboBox.Size = new System.Drawing.Size(159, 21);
            this.channel_comboBox.TabIndex = 5;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(20, 167);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(159, 23);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "StartSave(开始保存录像)";
            this.save_button.UseVisualStyleBackColor = true;
            // 
            // capture_button
            // 
            this.capture_button.Location = new System.Drawing.Point(20, 137);
            this.capture_button.Name = "capture_button";
            this.capture_button.Size = new System.Drawing.Size(159, 23);
            this.capture_button.TabIndex = 8;
            this.capture_button.Text = "Capture(抓图)";
            this.capture_button.UseVisualStyleBackColor = true;
            this.capture_button.Click += new System.EventHandler(this.capture_button_Click);
            // 
            // start_realplay_button
            // 
            this.start_realplay_button.Location = new System.Drawing.Point(20, 108);
            this.start_realplay_button.Name = "start_realplay_button";
            this.start_realplay_button.Size = new System.Drawing.Size(159, 23);
            this.start_realplay_button.TabIndex = 7;
            this.start_realplay_button.Text = "StartReal(开始监视)";
            this.start_realplay_button.UseVisualStyleBackColor = true;
            this.start_realplay_button.Click += new System.EventHandler(this.start_realplay_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 616);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.port_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pwd_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ip_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.realplay_pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.realplay_pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox port_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pwd_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ip_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox realplay_pictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox streamtype_comboBox;
        private System.Windows.Forms.ComboBox channel_comboBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button capture_button;
        private System.Windows.Forms.Button start_realplay_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}