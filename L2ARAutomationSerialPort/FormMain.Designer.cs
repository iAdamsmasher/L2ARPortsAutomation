
namespace L2ARAutomationSerialPort
{
    partial class FormSerialPortAutomation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerialPortAutomation));
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.labelParty = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBoundRate = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParty = new System.Windows.Forms.ComboBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonOpenDrawer = new System.Windows.Forms.Button();
            this.buttonCloseDrawer = new System.Windows.Forms.Button();
            this.buttonUpClip = new System.Windows.Forms.Button();
            this.buttonDownClip = new System.Windows.Forms.Button();
            this.buttonUSBIn = new System.Windows.Forms.Button();
            this.buttonUSBOut = new System.Windows.Forms.Button();
            this.buttonP3In = new System.Windows.Forms.Button();
            this.buttonP3Out = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(73, 40);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(59, 20);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Portas:";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(38, 92);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(94, 20);
            this.labelBaudRate.TabIndex = 1;
            this.labelBaudRate.Text = "Baud Rate: ";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(49, 149);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(79, 20);
            this.labelDataBits.TabIndex = 2;
            this.labelDataBits.Text = "Data Bits:";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Location = new System.Drawing.Point(49, 205);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(82, 20);
            this.labelStopBits.TabIndex = 3;
            this.labelStopBits.Text = "Stop Bits: ";
            // 
            // labelParty
            // 
            this.labelParty.AutoSize = true;
            this.labelParty.Location = new System.Drawing.Point(77, 262);
            this.labelParty.Name = "labelParty";
            this.labelParty.Size = new System.Drawing.Size(49, 20);
            this.labelParty.TabIndex = 4;
            this.labelParty.Text = "Party:";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.comboBoxPorts.Location = new System.Drawing.Point(168, 40);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPorts.TabIndex = 6;
            // 
            // comboBoxBoundRate
            // 
            this.comboBoxBoundRate.FormattingEnabled = true;
            this.comboBoxBoundRate.Location = new System.Drawing.Point(168, 89);
            this.comboBoxBoundRate.Name = "comboBoxBoundRate";
            this.comboBoxBoundRate.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBoundRate.TabIndex = 7;
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(168, 149);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(121, 28);
            this.comboBoxDataBits.TabIndex = 8;
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(168, 205);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(121, 28);
            this.comboBoxStopBits.TabIndex = 9;
            // 
            // comboBoxParty
            // 
            this.comboBoxParty.FormattingEnabled = true;
            this.comboBoxParty.Location = new System.Drawing.Point(168, 257);
            this.comboBoxParty.Name = "comboBoxParty";
            this.comboBoxParty.Size = new System.Drawing.Size(121, 28);
            this.comboBoxParty.TabIndex = 10;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(313, 43);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 29);
            this.buttonOpen.TabIndex = 11;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonOpenDrawer
            // 
            this.buttonOpenDrawer.Location = new System.Drawing.Point(479, 67);
            this.buttonOpenDrawer.Name = "buttonOpenDrawer";
            this.buttonOpenDrawer.Size = new System.Drawing.Size(97, 31);
            this.buttonOpenDrawer.TabIndex = 12;
            this.buttonOpenDrawer.Text = "Open";
            this.buttonOpenDrawer.UseVisualStyleBackColor = true;
            this.buttonOpenDrawer.Click += new System.EventHandler(this.buttonOpenDrawer_Click);
            // 
            // buttonCloseDrawer
            // 
            this.buttonCloseDrawer.Location = new System.Drawing.Point(638, 67);
            this.buttonCloseDrawer.Name = "buttonCloseDrawer";
            this.buttonCloseDrawer.Size = new System.Drawing.Size(95, 31);
            this.buttonCloseDrawer.TabIndex = 13;
            this.buttonCloseDrawer.Text = "Close";
            this.buttonCloseDrawer.UseVisualStyleBackColor = true;
            // 
            // buttonUpClip
            // 
            this.buttonUpClip.Location = new System.Drawing.Point(479, 124);
            this.buttonUpClip.Name = "buttonUpClip";
            this.buttonUpClip.Size = new System.Drawing.Size(97, 30);
            this.buttonUpClip.TabIndex = 14;
            this.buttonUpClip.Text = "Up Clip";
            this.buttonUpClip.UseVisualStyleBackColor = true;
            // 
            // buttonDownClip
            // 
            this.buttonDownClip.Location = new System.Drawing.Point(638, 124);
            this.buttonDownClip.Name = "buttonDownClip";
            this.buttonDownClip.Size = new System.Drawing.Size(95, 30);
            this.buttonDownClip.TabIndex = 15;
            this.buttonDownClip.Text = "Down Clip";
            this.buttonDownClip.UseVisualStyleBackColor = true;
            // 
            // buttonUSBIn
            // 
            this.buttonUSBIn.Location = new System.Drawing.Point(479, 182);
            this.buttonUSBIn.Name = "buttonUSBIn";
            this.buttonUSBIn.Size = new System.Drawing.Size(97, 27);
            this.buttonUSBIn.TabIndex = 16;
            this.buttonUSBIn.Text = "USB IN";
            this.buttonUSBIn.UseVisualStyleBackColor = true;
            // 
            // buttonUSBOut
            // 
            this.buttonUSBOut.Location = new System.Drawing.Point(638, 182);
            this.buttonUSBOut.Name = "buttonUSBOut";
            this.buttonUSBOut.Size = new System.Drawing.Size(95, 32);
            this.buttonUSBOut.TabIndex = 17;
            this.buttonUSBOut.Text = "USB OUT";
            this.buttonUSBOut.UseVisualStyleBackColor = true;
            // 
            // buttonP3In
            // 
            this.buttonP3In.Location = new System.Drawing.Point(479, 241);
            this.buttonP3In.Name = "buttonP3In";
            this.buttonP3In.Size = new System.Drawing.Size(97, 32);
            this.buttonP3In.TabIndex = 18;
            this.buttonP3In.Text = "P3 IN";
            this.buttonP3In.UseVisualStyleBackColor = true;
            // 
            // buttonP3Out
            // 
            this.buttonP3Out.Location = new System.Drawing.Point(638, 241);
            this.buttonP3Out.Name = "buttonP3Out";
            this.buttonP3Out.Size = new System.Drawing.Size(95, 32);
            this.buttonP3Out.TabIndex = 19;
            this.buttonP3Out.Text = "P3 OUT";
            this.buttonP3Out.UseVisualStyleBackColor = true;
            // 
            // listBoxResult
            // 
            this.listBoxResult.BackColor = System.Drawing.Color.LightBlue;
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Location = new System.Drawing.Point(479, 327);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(362, 184);
            this.listBoxResult.TabIndex = 20;
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(781, 67);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(95, 32);
            this.buttonStatus.TabIndex = 21;
            this.buttonStatus.Text = "STATUS";
            this.buttonStatus.UseVisualStyleBackColor = true;
            // 
            // FormSerialPortAutomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 629);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonP3Out);
            this.Controls.Add(this.buttonP3In);
            this.Controls.Add(this.buttonUSBOut);
            this.Controls.Add(this.buttonUSBIn);
            this.Controls.Add(this.buttonDownClip);
            this.Controls.Add(this.buttonUpClip);
            this.Controls.Add(this.buttonCloseDrawer);
            this.Controls.Add(this.buttonOpenDrawer);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.comboBoxParty);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.comboBoxBoundRate);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.labelParty);
            this.Controls.Add(this.labelStopBits);
            this.Controls.Add(this.labelDataBits);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.labelPort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSerialPortAutomation";
            this.Text = "L2AR Port Automation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelParty;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.ComboBox comboBoxBoundRate;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxParty;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonOpenDrawer;
        private System.Windows.Forms.Button buttonCloseDrawer;
        private System.Windows.Forms.Button buttonUpClip;
        private System.Windows.Forms.Button buttonDownClip;
        private System.Windows.Forms.Button buttonUSBIn;
        private System.Windows.Forms.Button buttonUSBOut;
        private System.Windows.Forms.Button buttonP3In;
        private System.Windows.Forms.Button buttonP3Out;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonStatus;
    }
}

