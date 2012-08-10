namespace UDPClient
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
      this.textBoxMessageToSend = new System.Windows.Forms.TextBox();
      this.buttonConnect = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxConsole = new System.Windows.Forms.TextBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.buttonSendMessage = new System.Windows.Forms.Button();
      this.textBoxIpAddress = new System.Windows.Forms.TextBox();
      this.textBoxPort = new System.Windows.Forms.TextBox();
      this.button_LedOn = new System.Windows.Forms.Button();
      this.button_LedOff = new System.Windows.Forms.Button();
      this.panel_Sending = new System.Windows.Forms.Panel();
      this.panel_Sending.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxMessageToSend
      // 
      this.textBoxMessageToSend.Location = new System.Drawing.Point(3, 3);
      this.textBoxMessageToSend.Name = "textBoxMessageToSend";
      this.textBoxMessageToSend.Size = new System.Drawing.Size(551, 20);
      this.textBoxMessageToSend.TabIndex = 3;
      this.textBoxMessageToSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMessageToSend_KeyDown);
      // 
      // buttonConnect
      // 
      this.buttonConnect.Location = new System.Drawing.Point(446, 13);
      this.buttonConnect.Name = "buttonConnect";
      this.buttonConnect.Size = new System.Drawing.Size(75, 23);
      this.buttonConnect.TabIndex = 2;
      this.buttonConnect.Text = "Connect";
      this.buttonConnect.UseVisualStyleBackColor = true;
      this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(17, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "IP";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(211, 18);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(37, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "PORT";
      // 
      // textBoxConsole
      // 
      this.textBoxConsole.Location = new System.Drawing.Point(16, 38);
      this.textBoxConsole.Multiline = true;
      this.textBoxConsole.Name = "textBoxConsole";
      this.textBoxConsole.ReadOnly = true;
      this.textBoxConsole.Size = new System.Drawing.Size(644, 312);
      this.textBoxConsole.TabIndex = 5;
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(-231, 703);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 20);
      this.textBox3.TabIndex = 0;
      // 
      // buttonSendMessage
      // 
      this.buttonSendMessage.Location = new System.Drawing.Point(560, 1);
      this.buttonSendMessage.Name = "buttonSendMessage";
      this.buttonSendMessage.Size = new System.Drawing.Size(75, 23);
      this.buttonSendMessage.TabIndex = 4;
      this.buttonSendMessage.Text = "Send";
      this.buttonSendMessage.UseVisualStyleBackColor = true;
      this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
      // 
      // textBoxIpAddress
      // 
      this.textBoxIpAddress.Location = new System.Drawing.Point(50, 10);
      this.textBoxIpAddress.Name = "textBoxIpAddress";
      this.textBoxIpAddress.Size = new System.Drawing.Size(155, 20);
      this.textBoxIpAddress.TabIndex = 0;
      this.textBoxIpAddress.Text = "192.168.0.177";
      // 
      // textBoxPort
      // 
      this.textBoxPort.Location = new System.Drawing.Point(254, 10);
      this.textBoxPort.Name = "textBoxPort";
      this.textBoxPort.Size = new System.Drawing.Size(155, 20);
      this.textBoxPort.TabIndex = 1;
      this.textBoxPort.Text = "8888";
      // 
      // button_LedOn
      // 
      this.button_LedOn.Location = new System.Drawing.Point(3, 30);
      this.button_LedOn.Name = "button_LedOn";
      this.button_LedOn.Size = new System.Drawing.Size(75, 23);
      this.button_LedOn.TabIndex = 4;
      this.button_LedOn.Text = "Led ON";
      this.button_LedOn.UseVisualStyleBackColor = true;
      this.button_LedOn.Click += new System.EventHandler(this.button_LedOn_Click);
      // 
      // button_LedOff
      // 
      this.button_LedOff.Location = new System.Drawing.Point(94, 30);
      this.button_LedOff.Name = "button_LedOff";
      this.button_LedOff.Size = new System.Drawing.Size(75, 23);
      this.button_LedOff.TabIndex = 4;
      this.button_LedOff.Text = "Led OFF";
      this.button_LedOff.UseVisualStyleBackColor = true;
      this.button_LedOff.Click += new System.EventHandler(this.button_LedOff_Click);
      // 
      // panel_Sending
      // 
      this.panel_Sending.Controls.Add(this.textBoxMessageToSend);
      this.panel_Sending.Controls.Add(this.buttonSendMessage);
      this.panel_Sending.Controls.Add(this.button_LedOn);
      this.panel_Sending.Controls.Add(this.button_LedOff);
      this.panel_Sending.Enabled = false;
      this.panel_Sending.Location = new System.Drawing.Point(16, 356);
      this.panel_Sending.Name = "panel_Sending";
      this.panel_Sending.Size = new System.Drawing.Size(644, 58);
      this.panel_Sending.TabIndex = 6;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(672, 415);
      this.Controls.Add(this.panel_Sending);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonConnect);
      this.Controls.Add(this.textBoxConsole);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.textBoxPort);
      this.Controls.Add(this.textBoxIpAddress);
      this.Name = "Form1";
      this.Text = "Form1";
      this.panel_Sending.ResumeLayout(false);
      this.panel_Sending.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessageToSend;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonSendMessage;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Button button_LedOn;
        private System.Windows.Forms.Button button_LedOff;
        private System.Windows.Forms.Panel panel_Sending;
    }
}

