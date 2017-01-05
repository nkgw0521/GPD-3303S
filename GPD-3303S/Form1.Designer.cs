namespace GPD_3303S
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelComPort = new System.Windows.Forms.Label();
            this.cmbComPort = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.radioButtonOutputOff = new System.Windows.Forms.RadioButton();
            this.radioButtonOutputOn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonBeepOn = new System.Windows.Forms.RadioButton();
            this.radioButtonBeepOff = new System.Windows.Forms.RadioButton();
            this.tabControlCh = new System.Windows.Forms.TabControl();
            this.tabPageCh1 = new System.Windows.Forms.TabPage();
            this.textBoxOutputCurrent1 = new System.Windows.Forms.TextBox();
            this.labelOutputCurrentCh1 = new System.Windows.Forms.Label();
            this.tabPageCh2 = new System.Windows.Forms.TabPage();
            this.textBoxOutputCurrentCh2 = new System.Windows.Forms.TextBox();
            this.labelOutputCurrentCh2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControlCh.SuspendLayout();
            this.tabPageCh1.SuspendLayout();
            this.tabPageCh2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(18, 18);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(53, 12);
            this.labelComPort.TabIndex = 0;
            this.labelComPort.Text = "Com Port";
            // 
            // cmbComPort
            // 
            this.cmbComPort.FormattingEnabled = true;
            this.cmbComPort.Location = new System.Drawing.Point(77, 15);
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(309, 20);
            this.cmbComPort.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(392, 12);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonOutputOff
            // 
            this.radioButtonOutputOff.AutoSize = true;
            this.radioButtonOutputOff.Location = new System.Drawing.Point(45, 18);
            this.radioButtonOutputOff.Name = "radioButtonOutputOff";
            this.radioButtonOutputOff.Size = new System.Drawing.Size(39, 16);
            this.radioButtonOutputOff.TabIndex = 4;
            this.radioButtonOutputOff.TabStop = true;
            this.radioButtonOutputOff.Text = "Off";
            this.radioButtonOutputOff.UseVisualStyleBackColor = true;
            this.radioButtonOutputOff.CheckedChanged += new System.EventHandler(this.radioButtonOutput_CheckedChanged);
            // 
            // radioButtonOutputOn
            // 
            this.radioButtonOutputOn.AutoSize = true;
            this.radioButtonOutputOn.Location = new System.Drawing.Point(45, 40);
            this.radioButtonOutputOn.Name = "radioButtonOutputOn";
            this.radioButtonOutputOn.Size = new System.Drawing.Size(37, 16);
            this.radioButtonOutputOn.TabIndex = 5;
            this.radioButtonOutputOn.TabStop = true;
            this.radioButtonOutputOn.Text = "On";
            this.radioButtonOutputOn.UseVisualStyleBackColor = true;
            this.radioButtonOutputOn.CheckedChanged += new System.EventHandler(this.radioButtonOutput_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonOutputOn);
            this.groupBox1.Controls.Add(this.radioButtonOutputOff);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonBeepOn);
            this.groupBox2.Controls.Add(this.radioButtonBeepOff);
            this.groupBox2.Location = new System.Drawing.Point(148, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 68);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Beep";
            // 
            // radioButtonBeepOn
            // 
            this.radioButtonBeepOn.AutoSize = true;
            this.radioButtonBeepOn.Location = new System.Drawing.Point(39, 38);
            this.radioButtonBeepOn.Name = "radioButtonBeepOn";
            this.radioButtonBeepOn.Size = new System.Drawing.Size(37, 16);
            this.radioButtonBeepOn.TabIndex = 1;
            this.radioButtonBeepOn.TabStop = true;
            this.radioButtonBeepOn.Text = "On";
            this.radioButtonBeepOn.UseVisualStyleBackColor = true;
            // 
            // radioButtonBeepOff
            // 
            this.radioButtonBeepOff.AutoSize = true;
            this.radioButtonBeepOff.Location = new System.Drawing.Point(39, 16);
            this.radioButtonBeepOff.Name = "radioButtonBeepOff";
            this.radioButtonBeepOff.Size = new System.Drawing.Size(39, 16);
            this.radioButtonBeepOff.TabIndex = 0;
            this.radioButtonBeepOff.TabStop = true;
            this.radioButtonBeepOff.Text = "Off";
            this.radioButtonBeepOff.UseVisualStyleBackColor = true;
            // 
            // tabControlCh
            // 
            this.tabControlCh.Controls.Add(this.tabPageCh1);
            this.tabControlCh.Controls.Add(this.tabPageCh2);
            this.tabControlCh.Location = new System.Drawing.Point(24, 117);
            this.tabControlCh.Multiline = true;
            this.tabControlCh.Name = "tabControlCh";
            this.tabControlCh.SelectedIndex = 0;
            this.tabControlCh.Size = new System.Drawing.Size(447, 192);
            this.tabControlCh.TabIndex = 8;
            // 
            // tabPageCh1
            // 
            this.tabPageCh1.Controls.Add(this.textBoxOutputCurrent1);
            this.tabPageCh1.Controls.Add(this.labelOutputCurrentCh1);
            this.tabPageCh1.Location = new System.Drawing.Point(4, 22);
            this.tabPageCh1.Name = "tabPageCh1";
            this.tabPageCh1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCh1.Size = new System.Drawing.Size(439, 166);
            this.tabPageCh1.TabIndex = 0;
            this.tabPageCh1.Text = "CH1";
            this.tabPageCh1.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputCurrent1
            // 
            this.textBoxOutputCurrent1.Location = new System.Drawing.Point(124, 18);
            this.textBoxOutputCurrent1.Name = "textBoxOutputCurrent1";
            this.textBoxOutputCurrent1.Size = new System.Drawing.Size(100, 19);
            this.textBoxOutputCurrent1.TabIndex = 1;
            // 
            // labelOutputCurrentCh1
            // 
            this.labelOutputCurrentCh1.AutoSize = true;
            this.labelOutputCurrentCh1.Location = new System.Drawing.Point(6, 21);
            this.labelOutputCurrentCh1.Name = "labelOutputCurrentCh1";
            this.labelOutputCurrentCh1.Size = new System.Drawing.Size(101, 12);
            this.labelOutputCurrentCh1.TabIndex = 0;
            this.labelOutputCurrentCh1.Text = "Output Current [A]";
            // 
            // tabPageCh2
            // 
            this.tabPageCh2.Controls.Add(this.textBoxOutputCurrentCh2);
            this.tabPageCh2.Controls.Add(this.labelOutputCurrentCh2);
            this.tabPageCh2.Location = new System.Drawing.Point(4, 22);
            this.tabPageCh2.Name = "tabPageCh2";
            this.tabPageCh2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCh2.Size = new System.Drawing.Size(439, 166);
            this.tabPageCh2.TabIndex = 1;
            this.tabPageCh2.Text = "CH2";
            this.tabPageCh2.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputCurrentCh2
            // 
            this.textBoxOutputCurrentCh2.Location = new System.Drawing.Point(124, 18);
            this.textBoxOutputCurrentCh2.Name = "textBoxOutputCurrentCh2";
            this.textBoxOutputCurrentCh2.Size = new System.Drawing.Size(100, 19);
            this.textBoxOutputCurrentCh2.TabIndex = 3;
            // 
            // labelOutputCurrentCh2
            // 
            this.labelOutputCurrentCh2.AutoSize = true;
            this.labelOutputCurrentCh2.Location = new System.Drawing.Point(6, 21);
            this.labelOutputCurrentCh2.Name = "labelOutputCurrentCh2";
            this.labelOutputCurrentCh2.Size = new System.Drawing.Size(101, 12);
            this.labelOutputCurrentCh2.TabIndex = 2;
            this.labelOutputCurrentCh2.Text = "Output Current [A]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 321);
            this.Controls.Add(this.tabControlCh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.cmbComPort);
            this.Controls.Add(this.labelComPort);
            this.Name = "Form1";
            this.Text = "GPD-3303S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControlCh.ResumeLayout(false);
            this.tabPageCh1.ResumeLayout(false);
            this.tabPageCh1.PerformLayout();
            this.tabPageCh2.ResumeLayout(false);
            this.tabPageCh2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.ComboBox cmbComPort;
        private System.Windows.Forms.Button buttonConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton radioButtonOutputOff;
        private System.Windows.Forms.RadioButton radioButtonOutputOn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonBeepOn;
        private System.Windows.Forms.RadioButton radioButtonBeepOff;
        private System.Windows.Forms.TabControl tabControlCh;
        private System.Windows.Forms.TabPage tabPageCh1;
        private System.Windows.Forms.TabPage tabPageCh2;
        private System.Windows.Forms.TextBox textBoxOutputCurrent1;
        private System.Windows.Forms.Label labelOutputCurrentCh1;
        private System.Windows.Forms.TextBox textBoxOutputCurrentCh2;
        private System.Windows.Forms.Label labelOutputCurrentCh2;
    }
}

