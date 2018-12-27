namespace pictReader
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInputFolder = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.保存button = new System.Windows.Forms.Button();
            this.放大button = new System.Windows.Forms.Button();
            this.缩小button = new System.Windows.Forms.Button();
            this.SaveFolder = new System.Windows.Forms.TextBox();
            this.AllFilesbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(445, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 496);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWeel);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(445, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "上一张";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(540, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "下一张";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "文件路径";
            // 
            // tbInputFolder
            // 
            this.tbInputFolder.Location = new System.Drawing.Point(95, 9);
            this.tbInputFolder.Name = "tbInputFolder";
            this.tbInputFolder.Size = new System.Drawing.Size(250, 21);
            this.tbInputFolder.TabIndex = 5;
            this.tbInputFolder.Text = "D:\\建设方案\\CD000006\\20181117-1";
            this.tbInputFolder.TextChanged += new System.EventHandler(this.tbImageFoder_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "打开...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(131, 44);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(297, 508);
            this.listBox.TabIndex = 7;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // 保存button
            // 
            this.保存button.Location = new System.Drawing.Point(858, 9);
            this.保存button.Name = "保存button";
            this.保存button.Size = new System.Drawing.Size(75, 23);
            this.保存button.TabIndex = 8;
            this.保存button.Text = "保存";
            this.保存button.UseVisualStyleBackColor = true;
            this.保存button.Click += new System.EventHandler(this.button4_Click);
            // 
            // 放大button
            // 
            this.放大button.BackColor = System.Drawing.Color.Transparent;
            this.放大button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.放大button.Location = new System.Drawing.Point(24, 136);
            this.放大button.Name = "放大button";
            this.放大button.Size = new System.Drawing.Size(75, 23);
            this.放大button.TabIndex = 9;
            this.放大button.Text = "放大";
            this.放大button.UseVisualStyleBackColor = false;
            this.放大button.Click += new System.EventHandler(this.放大button_Click);
            // 
            // 缩小button
            // 
            this.缩小button.Location = new System.Drawing.Point(24, 207);
            this.缩小button.Name = "缩小button";
            this.缩小button.Size = new System.Drawing.Size(75, 23);
            this.缩小button.TabIndex = 10;
            this.缩小button.Text = "缩小";
            this.缩小button.UseVisualStyleBackColor = true;
            this.缩小button.Click += new System.EventHandler(this.缩小button_Click);
            // 
            // SaveFolder
            // 
            this.SaveFolder.Location = new System.Drawing.Point(640, 9);
            this.SaveFolder.Name = "SaveFolder";
            this.SaveFolder.Size = new System.Drawing.Size(212, 21);
            this.SaveFolder.TabIndex = 11;
            this.SaveFolder.Text = "D:\\MJDNN\\edge\\images\\train";
            // 
            // AllFilesbutton
            // 
            this.AllFilesbutton.Location = new System.Drawing.Point(24, 61);
            this.AllFilesbutton.Name = "AllFilesbutton";
            this.AllFilesbutton.Size = new System.Drawing.Size(75, 23);
            this.AllFilesbutton.TabIndex = 12;
            this.AllFilesbutton.Text = "文件列表";
            this.AllFilesbutton.UseVisualStyleBackColor = true;
            this.AllFilesbutton.Click += new System.EventHandler(this.AllFilesbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 552);
            this.Controls.Add(this.AllFilesbutton);
            this.Controls.Add(this.SaveFolder);
            this.Controls.Add(this.缩小button);
            this.Controls.Add(this.放大button);
            this.Controls.Add(this.保存button);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbInputFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

	}

	#endregion

	private System.Windows.Forms.PictureBox pictureBox1;
	private System.Windows.Forms.Button button1;
	private System.Windows.Forms.Button button2;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.TextBox tbInputFolder;
	private System.Windows.Forms.Button button3;
	private System.Windows.Forms.ListBox listBox;
	private System.Windows.Forms.Button 保存button;
	private System.Windows.Forms.Button 放大button;
	private System.Windows.Forms.Button 缩小button;
	private System.Windows.Forms.TextBox SaveFolder;
	private System.Windows.Forms.Button AllFilesbutton;
    }
}

