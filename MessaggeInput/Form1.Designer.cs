
namespace MessaggeInput
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
            this.StuClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StuName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StuNumber = new System.Windows.Forms.TextBox();
            this.Commit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.StuGender = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StuClass
            // 
            this.StuClass.FormattingEnabled = true;
            this.StuClass.Items.AddRange(new object[] {
            "1班",
            "2班",
            "3班",
            "4班",
            "5班",
            "6班"});
            this.StuClass.Location = new System.Drawing.Point(64, 48);
            this.StuClass.Name = "StuClass";
            this.StuClass.Size = new System.Drawing.Size(121, 20);
            this.StuClass.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "班级";
            // 
            // StuName
            // 
            this.StuName.Location = new System.Drawing.Point(64, 99);
            this.StuName.Name = "StuName";
            this.StuName.Size = new System.Drawing.Size(100, 21);
            this.StuName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "学号";
            // 
            // StuNumber
            // 
            this.StuNumber.Location = new System.Drawing.Point(64, 134);
            this.StuNumber.Name = "StuNumber";
            this.StuNumber.Size = new System.Drawing.Size(100, 21);
            this.StuNumber.TabIndex = 5;
            // 
            // Commit
            // 
            this.Commit.Location = new System.Drawing.Point(29, 317);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(75, 23);
            this.Commit.TabIndex = 8;
            this.Commit.Text = "提交";
            this.Commit.UseVisualStyleBackColor = true;
            this.Commit.Click += new System.EventHandler(this.Commit_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(157, 316);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 9;
            this.Save.Text = "保存";
            this.Save.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // StuGender
            // 
            this.StuGender.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StuGender.CheckOnClick = true;
            this.StuGender.FormattingEnabled = true;
            this.StuGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.StuGender.Location = new System.Drawing.Point(64, 181);
            this.StuGender.Name = "StuGender";
            this.StuGender.Size = new System.Drawing.Size(41, 36);
            this.StuGender.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "性别";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(477, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(283, 384);
            this.textBox1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(558, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "已提交学生信息";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "输入学生信息后，点击提交按钮，全部学生输入完毕后，点击保存按钮";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StuGender);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.StuNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StuName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StuClass);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StuClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StuName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StuNumber;
        private System.Windows.Forms.Button Commit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.CheckedListBox StuGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

