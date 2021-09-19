namespace Computer
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Message = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonS2 = new System.Windows.Forms.RadioButton();
            this.radioButtonS1 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonHD1 = new System.Windows.Forms.RadioButton();
            this.radioButtonHD2 = new System.Windows.Forms.RadioButton();
            this.radioButtonS3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(7, 158);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 12);
            this.Message.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "无线鼠标",
            "摄像头",
            "打印机"});
            this.checkedListBox1.Location = new System.Drawing.Point(287, 72);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(76, 52);
            this.checkedListBox1.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 33;
            this.label5.Text = "配件";
            // 
            // radioButtonS2
            // 
            this.radioButtonS2.AutoSize = true;
            this.radioButtonS2.Location = new System.Drawing.Point(73, 21);
            this.radioButtonS2.Name = "radioButtonS2";
            this.radioButtonS2.Size = new System.Drawing.Size(59, 16);
            this.radioButtonS2.TabIndex = 1;
            this.radioButtonS2.TabStop = true;
            this.radioButtonS2.Text = "19英寸";
            this.radioButtonS2.UseVisualStyleBackColor = true;
            // 
            // radioButtonS1
            // 
            this.radioButtonS1.AutoSize = true;
            this.radioButtonS1.Location = new System.Drawing.Point(3, 21);
            this.radioButtonS1.Name = "radioButtonS1";
            this.radioButtonS1.Size = new System.Drawing.Size(59, 16);
            this.radioButtonS1.TabIndex = 0;
            this.radioButtonS1.TabStop = true;
            this.radioButtonS1.Text = "17英寸";
            this.radioButtonS1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "1G",
            "2G",
            "4G",
            "8G",
            "16G"});
            this.listBox1.Location = new System.Drawing.Point(287, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(58, 52);
            this.listBox1.TabIndex = 36;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonHD1);
            this.groupBox3.Controls.Add(this.radioButtonHD2);
            this.groupBox3.Location = new System.Drawing.Point(43, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 45);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            // 
            // radioButtonHD1
            // 
            this.radioButtonHD1.AutoSize = true;
            this.radioButtonHD1.Location = new System.Drawing.Point(3, 17);
            this.radioButtonHD1.Name = "radioButtonHD1";
            this.radioButtonHD1.Size = new System.Drawing.Size(47, 16);
            this.radioButtonHD1.TabIndex = 4;
            this.radioButtonHD1.TabStop = true;
            this.radioButtonHD1.Text = "500G";
            this.radioButtonHD1.UseVisualStyleBackColor = true;
            // 
            // radioButtonHD2
            // 
            this.radioButtonHD2.AutoSize = true;
            this.radioButtonHD2.Location = new System.Drawing.Point(83, 17);
            this.radioButtonHD2.Name = "radioButtonHD2";
            this.radioButtonHD2.Size = new System.Drawing.Size(35, 16);
            this.radioButtonHD2.TabIndex = 3;
            this.radioButtonHD2.TabStop = true;
            this.radioButtonHD2.Text = "1T";
            this.radioButtonHD2.UseVisualStyleBackColor = true;
            // 
            // radioButtonS3
            // 
            this.radioButtonS3.AutoSize = true;
            this.radioButtonS3.Location = new System.Drawing.Point(135, 21);
            this.radioButtonS3.Name = "radioButtonS3";
            this.radioButtonS3.Size = new System.Drawing.Size(59, 16);
            this.radioButtonS3.TabIndex = 2;
            this.radioButtonS3.TabStop = true;
            this.radioButtonS3.Text = "21英寸";
            this.radioButtonS3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 31;
            this.label4.Text = "硬盘";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonS3);
            this.groupBox2.Controls.Add(this.radioButtonS2);
            this.groupBox2.Controls.Add(this.radioButtonS1);
            this.groupBox2.Location = new System.Drawing.Point(43, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 48);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 29;
            this.label3.Text = "显示器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "内存";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "E8600(3.33GHz)",
            "E8500(3.16GHz)",
            "E7500(2.93GHz)"});
            this.comboBox1.Location = new System.Drawing.Point(43, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "CPU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 206);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonS2;
        private System.Windows.Forms.RadioButton radioButtonS1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonHD1;
        private System.Windows.Forms.RadioButton radioButtonHD2;
        private System.Windows.Forms.RadioButton radioButtonS3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;

    }
}

