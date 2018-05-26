namespace Klient_UDP
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
            this.button1 = new System.Windows.Forms.Button();
            this.chat = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.NumericUpDown();
            this.info_feed = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chat
            // 
            this.chat.Location = new System.Drawing.Point(40, 165);
            this.chat.Multiline = true;
            this.chat.Name = "chat";
            this.chat.Size = new System.Drawing.Size(840, 134);
            this.chat.TabIndex = 2;
            this.chat.TextChanged += new System.EventHandler(this.chat_TextChanged);
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(40, 33);
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(375, 22);
            this.adress.TabIndex = 3;
            this.adress.TextChanged += new System.EventHandler(this.adress_TextChanged);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(532, 33);
            this.port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(254, 22);
            this.port.TabIndex = 5;
            this.port.ValueChanged += new System.EventHandler(this.port_ValueChanged);
            // 
            // info_feed
            // 
            this.info_feed.FormattingEnabled = true;
            this.info_feed.ItemHeight = 16;
            this.info_feed.Location = new System.Drawing.Point(40, 305);
            this.info_feed.Name = "info_feed";
            this.info_feed.Size = new System.Drawing.Size(840, 116);
            this.info_feed.TabIndex = 6;
            this.info_feed.SelectedIndexChanged += new System.EventHandler(this.info_feed_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 521);
            this.Controls.Add(this.info_feed);
            this.Controls.Add(this.port);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.chat);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox chat;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.NumericUpDown port;
        private System.Windows.Forms.ListBox info_feed;
    }
}

