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
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.groupBoxBeep = new System.Windows.Forms.GroupBox();
            this.radioButtonBeepOn = new System.Windows.Forms.RadioButton();
            this.radioButtonBeepOff = new System.Windows.Forms.RadioButton();
            this.tabControlCh = new System.Windows.Forms.TabControl();
            this.tabPageCh1 = new System.Windows.Forms.TabPage();
            this.buttonRefreshCurrentCh1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownVch1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownIch1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxOutputCurrentCh1 = new System.Windows.Forms.TextBox();
            this.labelOutputCurrentCh1 = new System.Windows.Forms.Label();
            this.tabPageCh2 = new System.Windows.Forms.TabPage();
            this.buttonRefreshCurrentCh2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownVch2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownIch2 = new System.Windows.Forms.NumericUpDown();
            this.textBoxOutputCurrentCh2 = new System.Windows.Forms.TextBox();
            this.labelOutputCurrentCh2 = new System.Windows.Forms.Label();
            this.buttonLocal = new System.Windows.Forms.Button();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxBeep.SuspendLayout();
            this.tabControlCh.SuspendLayout();
            this.tabPageCh1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIch1)).BeginInit();
            this.tabPageCh2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIch2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(14, 18);
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
            this.cmbComPort.Size = new System.Drawing.Size(282, 20);
            this.cmbComPort.TabIndex = 1;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(284, 51);
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
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.radioButtonOutputOn);
            this.groupBoxOutput.Controls.Add(this.radioButtonOutputOff);
            this.groupBoxOutput.Location = new System.Drawing.Point(12, 41);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(130, 69);
            this.groupBoxOutput.TabIndex = 6;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // groupBoxBeep
            // 
            this.groupBoxBeep.Controls.Add(this.radioButtonBeepOn);
            this.groupBoxBeep.Controls.Add(this.radioButtonBeepOff);
            this.groupBoxBeep.Location = new System.Drawing.Point(148, 42);
            this.groupBoxBeep.Name = "groupBoxBeep";
            this.groupBoxBeep.Size = new System.Drawing.Size(116, 68);
            this.groupBoxBeep.TabIndex = 7;
            this.groupBoxBeep.TabStop = false;
            this.groupBoxBeep.Text = "Beep";
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
            this.radioButtonBeepOff.CheckedChanged += new System.EventHandler(this.radioButtonBeep_CheckedChanged);
            // 
            // tabControlCh
            // 
            this.tabControlCh.Controls.Add(this.tabPageCh1);
            this.tabControlCh.Controls.Add(this.tabPageCh2);
            this.tabControlCh.Location = new System.Drawing.Point(12, 116);
            this.tabControlCh.Multiline = true;
            this.tabControlCh.Name = "tabControlCh";
            this.tabControlCh.SelectedIndex = 0;
            this.tabControlCh.Size = new System.Drawing.Size(347, 133);
            this.tabControlCh.TabIndex = 8;
            // 
            // tabPageCh1
            // 
            this.tabPageCh1.Controls.Add(this.buttonRefreshCurrentCh1);
            this.tabPageCh1.Controls.Add(this.label3);
            this.tabPageCh1.Controls.Add(this.numericUpDownVch1);
            this.tabPageCh1.Controls.Add(this.label1);
            this.tabPageCh1.Controls.Add(this.numericUpDownIch1);
            this.tabPageCh1.Controls.Add(this.textBoxOutputCurrentCh1);
            this.tabPageCh1.Controls.Add(this.labelOutputCurrentCh1);
            this.tabPageCh1.Location = new System.Drawing.Point(4, 22);
            this.tabPageCh1.Name = "tabPageCh1";
            this.tabPageCh1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCh1.Size = new System.Drawing.Size(339, 107);
            this.tabPageCh1.TabIndex = 0;
            this.tabPageCh1.Text = "CH1";
            this.tabPageCh1.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshCurrentCh1
            // 
            this.buttonRefreshCurrentCh1.Location = new System.Drawing.Point(230, 18);
            this.buttonRefreshCurrentCh1.Name = "buttonRefreshCurrentCh1";
            this.buttonRefreshCurrentCh1.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshCurrentCh1.TabIndex = 6;
            this.buttonRefreshCurrentCh1.Text = "Refresh";
            this.buttonRefreshCurrentCh1.UseVisualStyleBackColor = true;
            this.buttonRefreshCurrentCh1.Click += new System.EventHandler(this.buttonRefreshCurrent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Voltage [V]";
            // 
            // numericUpDownVch1
            // 
            this.numericUpDownVch1.DecimalPlaces = 3;
            this.numericUpDownVch1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownVch1.Location = new System.Drawing.Point(124, 68);
            this.numericUpDownVch1.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            196608});
            this.numericUpDownVch1.Name = "numericUpDownVch1";
            this.numericUpDownVch1.Size = new System.Drawing.Size(100, 19);
            this.numericUpDownVch1.TabIndex = 4;
            this.numericUpDownVch1.ValueChanged += new System.EventHandler(this.numericUpDownVch1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current [A]";
            // 
            // numericUpDownIch1
            // 
            this.numericUpDownIch1.DecimalPlaces = 3;
            this.numericUpDownIch1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownIch1.Location = new System.Drawing.Point(124, 43);
            this.numericUpDownIch1.Maximum = new decimal(new int[] {
            3200,
            0,
            0,
            196608});
            this.numericUpDownIch1.Name = "numericUpDownIch1";
            this.numericUpDownIch1.Size = new System.Drawing.Size(100, 19);
            this.numericUpDownIch1.TabIndex = 2;
            this.numericUpDownIch1.ValueChanged += new System.EventHandler(this.numericUpDownIch1_ValueChanged);
            // 
            // textBoxOutputCurrentCh1
            // 
            this.textBoxOutputCurrentCh1.Location = new System.Drawing.Point(124, 18);
            this.textBoxOutputCurrentCh1.Name = "textBoxOutputCurrentCh1";
            this.textBoxOutputCurrentCh1.ReadOnly = true;
            this.textBoxOutputCurrentCh1.Size = new System.Drawing.Size(100, 19);
            this.textBoxOutputCurrentCh1.TabIndex = 1;
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
            this.tabPageCh2.Controls.Add(this.buttonRefreshCurrentCh2);
            this.tabPageCh2.Controls.Add(this.label4);
            this.tabPageCh2.Controls.Add(this.numericUpDownVch2);
            this.tabPageCh2.Controls.Add(this.label2);
            this.tabPageCh2.Controls.Add(this.numericUpDownIch2);
            this.tabPageCh2.Controls.Add(this.textBoxOutputCurrentCh2);
            this.tabPageCh2.Controls.Add(this.labelOutputCurrentCh2);
            this.tabPageCh2.Location = new System.Drawing.Point(4, 22);
            this.tabPageCh2.Name = "tabPageCh2";
            this.tabPageCh2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCh2.Size = new System.Drawing.Size(339, 107);
            this.tabPageCh2.TabIndex = 1;
            this.tabPageCh2.Text = "CH2";
            this.tabPageCh2.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshCurrentCh2
            // 
            this.buttonRefreshCurrentCh2.Location = new System.Drawing.Point(230, 18);
            this.buttonRefreshCurrentCh2.Name = "buttonRefreshCurrentCh2";
            this.buttonRefreshCurrentCh2.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshCurrentCh2.TabIndex = 8;
            this.buttonRefreshCurrentCh2.Text = "Refresh";
            this.buttonRefreshCurrentCh2.UseVisualStyleBackColor = true;
            this.buttonRefreshCurrentCh2.Click += new System.EventHandler(this.buttonRefreshCurrent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Voltage [V]";
            // 
            // numericUpDownVch2
            // 
            this.numericUpDownVch2.DecimalPlaces = 3;
            this.numericUpDownVch2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownVch2.Location = new System.Drawing.Point(124, 68);
            this.numericUpDownVch2.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            196608});
            this.numericUpDownVch2.Name = "numericUpDownVch2";
            this.numericUpDownVch2.Size = new System.Drawing.Size(100, 19);
            this.numericUpDownVch2.TabIndex = 6;
            this.numericUpDownVch2.ValueChanged += new System.EventHandler(this.numericUpDownVch2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Current [A]";
            // 
            // numericUpDownIch2
            // 
            this.numericUpDownIch2.DecimalPlaces = 3;
            this.numericUpDownIch2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownIch2.Location = new System.Drawing.Point(124, 43);
            this.numericUpDownIch2.Maximum = new decimal(new int[] {
            3200,
            0,
            0,
            196608});
            this.numericUpDownIch2.Name = "numericUpDownIch2";
            this.numericUpDownIch2.Size = new System.Drawing.Size(100, 19);
            this.numericUpDownIch2.TabIndex = 4;
            this.numericUpDownIch2.ValueChanged += new System.EventHandler(this.numericUpDownIch2_ValueChanged);
            // 
            // textBoxOutputCurrentCh2
            // 
            this.textBoxOutputCurrentCh2.Location = new System.Drawing.Point(124, 18);
            this.textBoxOutputCurrentCh2.Name = "textBoxOutputCurrentCh2";
            this.textBoxOutputCurrentCh2.ReadOnly = true;
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
            // buttonLocal
            // 
            this.buttonLocal.Location = new System.Drawing.Point(284, 87);
            this.buttonLocal.Name = "buttonLocal";
            this.buttonLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonLocal.TabIndex = 9;
            this.buttonLocal.Text = "Remote Off";
            this.buttonLocal.UseVisualStyleBackColor = true;
            this.buttonLocal.Click += new System.EventHandler(this.buttonLocal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 263);
            this.Controls.Add(this.buttonLocal);
            this.Controls.Add(this.tabControlCh);
            this.Controls.Add(this.groupBoxBeep);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.cmbComPort);
            this.Controls.Add(this.labelComPort);
            this.Name = "Form1";
            this.Text = "GPD-3303S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.groupBoxBeep.ResumeLayout(false);
            this.groupBoxBeep.PerformLayout();
            this.tabControlCh.ResumeLayout(false);
            this.tabPageCh1.ResumeLayout(false);
            this.tabPageCh1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIch1)).EndInit();
            this.tabPageCh2.ResumeLayout(false);
            this.tabPageCh2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIch2)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.GroupBox groupBoxBeep;
        private System.Windows.Forms.RadioButton radioButtonBeepOn;
        private System.Windows.Forms.RadioButton radioButtonBeepOff;
        private System.Windows.Forms.TabControl tabControlCh;
        private System.Windows.Forms.TabPage tabPageCh1;
        private System.Windows.Forms.TabPage tabPageCh2;
        private System.Windows.Forms.TextBox textBoxOutputCurrentCh1;
        private System.Windows.Forms.Label labelOutputCurrentCh1;
        private System.Windows.Forms.TextBox textBoxOutputCurrentCh2;
        private System.Windows.Forms.Label labelOutputCurrentCh2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownIch1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownIch2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownVch1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownVch2;
        private System.Windows.Forms.Button buttonRefreshCurrentCh1;
        private System.Windows.Forms.Button buttonRefreshCurrentCh2;
        private System.Windows.Forms.Button buttonLocal;
    }
}

