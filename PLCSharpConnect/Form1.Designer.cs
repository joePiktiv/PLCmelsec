namespace PLCSharpConnect
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
            this.components = new System.ComponentModel.Container();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPLCIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.text_read_data = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.winsock1 = new MelsecPLC.Winsock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.text_remote_port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_tag = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text_local_port = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(271, 125);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(126, 40);
            this.btnWrite.TabIndex = 19;
            this.btnWrite.Text = "Write Data to PLC";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(48, 125);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(124, 40);
            this.btnRead.TabIndex = 18;
            this.btnRead.Text = "Read Data from PLC";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(404, 70);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 36);
            this.btnDisconnect.TabIndex = 17;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "PLC Write Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "PLC IP Address";
            // 
            // txtPLCIPAddress
            // 
            this.txtPLCIPAddress.Location = new System.Drawing.Point(98, 11);
            this.txtPLCIPAddress.Name = "txtPLCIPAddress";
            this.txtPLCIPAddress.Size = new System.Drawing.Size(100, 20);
            this.txtPLCIPAddress.TabIndex = 14;
            this.txtPLCIPAddress.Text = "10.126.224.221";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "PLC Read Data";
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(98, 79);
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(100, 20);
            this.txtWrite.TabIndex = 12;
            this.txtWrite.Text = "0002";
            // 
            // text_read_data
            // 
            this.text_read_data.Location = new System.Drawing.Point(98, 44);
            this.text_read_data.Name = "text_read_data";
            this.text_read_data.Size = new System.Drawing.Size(100, 20);
            this.text_read_data.TabIndex = 11;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(404, 11);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 50);
            this.BtnConnect.TabIndex = 10;
            this.BtnConnect.Text = "PLC Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // winsock1
            // 
            this.winsock1.LocalPort = 80;
            this.winsock1.RemoteIP = "127.0.0.1";
            this.winsock1.RemotePort = 80;
            this.winsock1.DataArrival += new MelsecPLC.Winsock.DataArrivalEventHandler(this.winsock1_DataArrival);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Remote Port";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // text_remote_port
            // 
            this.text_remote_port.Location = new System.Drawing.Point(288, 11);
            this.text_remote_port.Name = "text_remote_port";
            this.text_remote_port.Size = new System.Drawing.Size(100, 20);
            this.text_remote_port.TabIndex = 20;
            this.text_remote_port.Text = "2000";
            this.text_remote_port.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tag";
            // 
            // text_tag
            // 
            this.text_tag.Location = new System.Drawing.Point(288, 79);
            this.text_tag.Name = "text_tag";
            this.text_tag.Size = new System.Drawing.Size(100, 20);
            this.text_tag.TabIndex = 22;
            this.text_tag.Text = "D100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Local Port";
            // 
            // text_local_port
            // 
            this.text_local_port.Location = new System.Drawing.Point(288, 45);
            this.text_local_port.Name = "text_local_port";
            this.text_local_port.Size = new System.Drawing.Size(100, 20);
            this.text_local_port.TabIndex = 24;
            this.text_local_port.Text = "500";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 185);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text_local_port);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text_tag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_remote_port);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPLCIPAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.text_read_data);
            this.Controls.Add(this.BtnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_tag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_local_port;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_remote_port;

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPLCIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWrite;
        private System.Windows.Forms.TextBox text_read_data;
        private System.Windows.Forms.Button BtnConnect;
        private MelsecPLC.Winsock winsock1;
        private System.Windows.Forms.Timer timer1;
    }
}

