﻿namespace NetSpeakLite
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSpeak = new System.Windows.Forms.Button();
            this.comboBoxVoiceList = new System.Windows.Forms.ComboBox();
            this.buttonClearText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxQuick = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.listBoxTextLog = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownVolNA = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolNA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 21);
            this.textBox1.TabIndex = 0;
            // 
            // buttonSpeak
            // 
            this.buttonSpeak.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSpeak.Location = new System.Drawing.Point(685, 39);
            this.buttonSpeak.Name = "buttonSpeak";
            this.buttonSpeak.Size = new System.Drawing.Size(103, 47);
            this.buttonSpeak.TabIndex = 1;
            this.buttonSpeak.Text = "SPEAK";
            this.buttonSpeak.UseVisualStyleBackColor = true;
            this.buttonSpeak.Click += new System.EventHandler(this.buttonSpeak_Click);
            // 
            // comboBoxVoiceList
            // 
            this.comboBoxVoiceList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVoiceList.FormattingEnabled = true;
            this.comboBoxVoiceList.Location = new System.Drawing.Point(65, 39);
            this.comboBoxVoiceList.Name = "comboBoxVoiceList";
            this.comboBoxVoiceList.Size = new System.Drawing.Size(321, 20);
            this.comboBoxVoiceList.TabIndex = 2;
            this.comboBoxVoiceList.SelectedIndexChanged += new System.EventHandler(this.comboBoxVoiceList_SelectedIndexChanged);
            // 
            // buttonClearText
            // 
            this.buttonClearText.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClearText.Location = new System.Drawing.Point(627, 39);
            this.buttonClearText.Name = "buttonClearText";
            this.buttonClearText.Size = new System.Drawing.Size(52, 47);
            this.buttonClearText.TabIndex = 3;
            this.buttonClearText.Text = "Clear";
            this.buttonClearText.UseVisualStyleBackColor = true;
            this.buttonClearText.Click += new System.EventHandler(this.buttonClearText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Speaker";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(65, 65);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(54, 21);
            this.numericUpDownSpeed.TabIndex = 6;
            this.numericUpDownSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.numericUpDownSpeed_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vol.(Base)";
            // 
            // numericUpDownVolume
            // 
            this.numericUpDownVolume.Location = new System.Drawing.Point(208, 65);
            this.numericUpDownVolume.Name = "numericUpDownVolume";
            this.numericUpDownVolume.Size = new System.Drawing.Size(54, 21);
            this.numericUpDownVolume.TabIndex = 8;
            this.numericUpDownVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownVolume.ValueChanged += new System.EventHandler(this.numericUpDownVolume_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quick";
            // 
            // comboBoxQuick
            // 
            this.comboBoxQuick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuick.FormattingEnabled = true;
            this.comboBoxQuick.Items.AddRange(new object[] {
            "测试一下",
            "能听到吗",
            "草",
            "6",
            "乐",
            "海星",
            "布星",
            "喵喵喵"});
            this.comboBoxQuick.Location = new System.Drawing.Point(433, 64);
            this.comboBoxQuick.Name = "comboBoxQuick";
            this.comboBoxQuick.Size = new System.Drawing.Size(188, 20);
            this.comboBoxQuick.TabIndex = 10;
            this.comboBoxQuick.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuick_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClearLog);
            this.groupBox1.Controls.Add(this.listBoxTextLog);
            this.groupBox1.Location = new System.Drawing.Point(14, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClearLog.Location = new System.Drawing.Point(732, 20);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(36, 113);
            this.buttonClearLog.TabIndex = 13;
            this.buttonClearLog.Text = "X";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // listBoxTextLog
            // 
            this.listBoxTextLog.FormattingEnabled = true;
            this.listBoxTextLog.ItemHeight = 12;
            this.listBoxTextLog.Location = new System.Drawing.Point(7, 21);
            this.listBoxTextLog.Name = "listBoxTextLog";
            this.listBoxTextLog.Size = new System.Drawing.Size(719, 112);
            this.listBoxTextLog.TabIndex = 0;
            this.listBoxTextLog.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTextLog_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vol.(NA)";
            // 
            // numericUpDownVolNA
            // 
            this.numericUpDownVolNA.Location = new System.Drawing.Point(332, 65);
            this.numericUpDownVolNA.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownVolNA.Name = "numericUpDownVolNA";
            this.numericUpDownVolNA.Size = new System.Drawing.Size(54, 21);
            this.numericUpDownVolNA.TabIndex = 13;
            this.numericUpDownVolNA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownVolNA.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSpeak;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClearText;
            this.ClientSize = new System.Drawing.Size(799, 248);
            this.Controls.Add(this.numericUpDownVolNA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxQuick);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownVolume);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClearText);
            this.Controls.Add(this.comboBoxVoiceList);
            this.Controls.Add(this.buttonSpeak);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NetSpeakLite";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolNA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSpeak;
        private System.Windows.Forms.ComboBox comboBoxVoiceList;
        private System.Windows.Forms.Button buttonClearText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownVolume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxQuick;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxTextLog;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownVolNA;
    }
}

