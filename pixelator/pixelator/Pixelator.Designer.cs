namespace pixelator
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
            this.components = new System.ComponentModel.Container();
            this.pnlfunction = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cobColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.trbProportion = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cobMethod = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBlur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPixelate = new System.Windows.Forms.TextBox();
            this.trbBlur = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trbPixelate = new System.Windows.Forms.TrackBar();
            this.btnPixelation = new System.Windows.Forms.Button();
            this.btnPixelate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picSource = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picOutput = new System.Windows.Forms.PictureBox();
            this.pnlfunction.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbProportion)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPixelate)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlfunction
            // 
            this.pnlfunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.pnlfunction.Controls.Add(this.label6);
            this.pnlfunction.Controls.Add(this.labTime);
            this.pnlfunction.Controls.Add(this.panel3);
            this.pnlfunction.Controls.Add(this.panel4);
            this.pnlfunction.Controls.Add(this.btnPixelate);
            this.pnlfunction.Location = new System.Drawing.Point(0, 39);
            this.pnlfunction.Name = "pnlfunction";
            this.pnlfunction.Size = new System.Drawing.Size(465, 1107);
            this.pnlfunction.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(14, 850);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Time:";
            // 
            // labTime
            // 
            this.labTime.AutoSize = true;
            this.labTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labTime.Location = new System.Drawing.Point(74, 850);
            this.labTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(44, 18);
            this.labTime.TabIndex = 8;
            this.labTime.Text = "Time";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.btnColor);
            this.panel3.Location = new System.Drawing.Point(3, 381);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(462, 369);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cobColor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 105);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // cobColor
            // 
            this.cobColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobColor.Enabled = false;
            this.cobColor.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cobColor.FormattingEnabled = true;
            this.cobColor.Items.AddRange(new object[] {
            "2",
            "4",
            "8",
            "12",
            "16",
            "20",
            "24",
            "32",
            "64",
            "128",
            "256"});
            this.cobColor.Location = new System.Drawing.Point(3, 39);
            this.cobColor.Name = "cobColor";
            this.cobColor.Size = new System.Drawing.Size(457, 44);
            this.cobColor.TabIndex = 2;
            this.cobColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Colors In Palette:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Controls.Add(this.trbProportion);
            this.panel5.Controls.Add(this.checkBox1);
            this.panel5.Controls.Add(this.cobMethod);
            this.panel5.Location = new System.Drawing.Point(3, 93);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(444, 105);
            this.panel5.TabIndex = 5;
            this.panel5.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(357, 45);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 28);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // trbProportion
            // 
            this.trbProportion.Enabled = false;
            this.trbProportion.Location = new System.Drawing.Point(8, 45);
            this.trbProportion.Maximum = 100;
            this.trbProportion.Name = "trbProportion";
            this.trbProportion.Size = new System.Drawing.Size(339, 69);
            this.trbProportion.TabIndex = 12;
            this.trbProportion.Value = 1;
            this.trbProportion.ValueChanged += new System.EventHandler(this.trbProportion_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Location = new System.Drawing.Point(8, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(209, 25);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Pixelization method";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cobMethod
            // 
            this.cobMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobMethod.Enabled = false;
            this.cobMethod.FormattingEnabled = true;
            this.cobMethod.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cobMethod.Location = new System.Drawing.Point(165, 15);
            this.cobMethod.Name = "cobMethod";
            this.cobMethod.Size = new System.Drawing.Size(121, 26);
            this.cobMethod.TabIndex = 11;
            this.cobMethod.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.btnColor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnColor.Location = new System.Drawing.Point(0, 3);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(464, 75);
            this.btnColor.TabIndex = 4;
            this.btnColor.Text = "Colors";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.btnPixelation);
            this.panel4.Location = new System.Drawing.Point(3, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(462, 357);
            this.panel4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBlur);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPixelate);
            this.panel1.Controls.Add(this.trbBlur);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trbPixelate);
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 255);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            // 
            // txtBlur
            // 
            this.txtBlur.Enabled = false;
            this.txtBlur.Location = new System.Drawing.Point(360, 141);
            this.txtBlur.Name = "txtBlur";
            this.txtBlur.Size = new System.Drawing.Size(84, 28);
            this.txtBlur.TabIndex = 10;
            this.txtBlur.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtBlur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Blur:";
            // 
            // txtPixelate
            // 
            this.txtPixelate.Enabled = false;
            this.txtPixelate.Location = new System.Drawing.Point(360, 51);
            this.txtPixelate.Name = "txtPixelate";
            this.txtPixelate.Size = new System.Drawing.Size(84, 28);
            this.txtPixelate.TabIndex = 2;
            this.txtPixelate.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPixelate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // trbBlur
            // 
            this.trbBlur.Enabled = false;
            this.trbBlur.Location = new System.Drawing.Point(14, 141);
            this.trbBlur.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trbBlur.Maximum = 200;
            this.trbBlur.Minimum = 2;
            this.trbBlur.Name = "trbBlur";
            this.trbBlur.Size = new System.Drawing.Size(339, 69);
            this.trbBlur.TabIndex = 7;
            this.trbBlur.Value = 5;
            this.trbBlur.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pixelate Factor:";
            // 
            // trbPixelate
            // 
            this.trbPixelate.Enabled = false;
            this.trbPixelate.Location = new System.Drawing.Point(14, 51);
            this.trbPixelate.Maximum = 50;
            this.trbPixelate.Minimum = 1;
            this.trbPixelate.Name = "trbPixelate";
            this.trbPixelate.Size = new System.Drawing.Size(339, 69);
            this.trbPixelate.TabIndex = 0;
            this.trbPixelate.Value = 5;
            this.trbPixelate.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // btnPixelation
            // 
            this.btnPixelation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.btnPixelation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPixelation.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPixelation.Location = new System.Drawing.Point(0, 3);
            this.btnPixelation.Name = "btnPixelation";
            this.btnPixelation.Size = new System.Drawing.Size(464, 75);
            this.btnPixelation.TabIndex = 0;
            this.btnPixelation.Text = "Pixelation";
            this.btnPixelation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPixelation.UseVisualStyleBackColor = false;
            this.btnPixelation.Click += new System.EventHandler(this.btnPixelation_Click);
            // 
            // btnPixelate
            // 
            this.btnPixelate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPixelate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.btnPixelate.Enabled = false;
            this.btnPixelate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPixelate.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPixelate.Location = new System.Drawing.Point(6, 885);
            this.btnPixelate.Name = "btnPixelate";
            this.btnPixelate.Size = new System.Drawing.Size(450, 75);
            this.btnPixelate.TabIndex = 3;
            this.btnPixelate.Text = "Pixelate";
            this.btnPixelate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPixelate.UseVisualStyleBackColor = false;
            this.btnPixelate.Click += new System.EventHandler(this.btnPixelate_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(131, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 28);
            this.toolStripMenuItem1.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.saveAsToolStripMenuItem.Text = "Save";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(67, 28);
            this.toolStripMenuItem4.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pnlmenu
            // 
            this.pnlmenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.pnlmenu.Location = new System.Drawing.Point(14, 3);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(1660, 36);
            this.pnlmenu.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(58)))), ((int)(((byte)(79)))));
            this.splitContainer1.Location = new System.Drawing.Point(471, 42);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.picSource);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picOutput);
            this.splitContainer1.Size = new System.Drawing.Size(1203, 969);
            this.splitContainer1.SplitterDistance = 528;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 2;
            // 
            // picSource
            // 
            this.picSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picSource.Location = new System.Drawing.Point(16, 21);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(1162, 494);
            this.picSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSource.TabIndex = 0;
            this.picSource.TabStop = false;
            this.picSource.DragDrop += new System.Windows.Forms.DragEventHandler(this.picSource_DragDrop);
            this.picSource.DragEnter += new System.Windows.Forms.DragEventHandler(this.picSource_DragEnter);
            this.picSource.Paint += new System.Windows.Forms.PaintEventHandler(this.picSource_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(14, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Source Image:";
            // 
            // picOutput
            // 
            this.picOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picOutput.Location = new System.Drawing.Point(16, 15);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(1162, 425);
            this.picOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOutput.TabIndex = 1;
            this.picOutput.TabStop = false;
            this.picOutput.Paint += new System.Windows.Forms.PaintEventHandler(this.picOutput_Paint);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1684, 1023);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlmenu);
            this.Controls.Add(this.pnlfunction);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pixelator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlfunction.ResumeLayout(false);
            this.pnlfunction.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbProportion)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbPixelate)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlfunction;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPixelate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbPixelate;
        private System.Windows.Forms.Button btnPixelation;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnPixelate;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobColor;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trbBlur;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBlur;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cobMethod;
        private System.Windows.Forms.TrackBar trbProportion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.Label labTime;
        private System.Windows.Forms.Label label6;
    }
}

