
namespace A3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.curvelength = new System.Windows.Forms.Button();
            this.pBlack = new System.Windows.Forms.CheckBox();
            this.pRed = new System.Windows.Forms.CheckBox();
            this.pBlue = new System.Windows.Forms.CheckBox();
            this.lineBlack = new System.Windows.Forms.CheckBox();
            this.lineRed = new System.Windows.Forms.CheckBox();
            this.lineBlue = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mouseStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel1.Location = new System.Drawing.Point(-7, -11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 242);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Firebrick;
            this.exit.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(443, 365);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(145, 43);
            this.exit.TabIndex = 1;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // curvelength
            // 
            this.curvelength.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.curvelength.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curvelength.Location = new System.Drawing.Point(12, 361);
            this.curvelength.Name = "curvelength";
            this.curvelength.Size = new System.Drawing.Size(166, 31);
            this.curvelength.TabIndex = 2;
            this.curvelength.Text = "CURVE LENGTH";
            this.curvelength.UseVisualStyleBackColor = false;
            this.curvelength.MouseClick += new System.Windows.Forms.MouseEventHandler(this.curvelength_MouseClick);
            // 
            // pBlack
            // 
            this.pBlack.AutoSize = true;
            this.pBlack.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBlack.Location = new System.Drawing.Point(242, 245);
            this.pBlack.Name = "pBlack";
            this.pBlack.Size = new System.Drawing.Size(71, 20);
            this.pBlack.TabIndex = 4;
            this.pBlack.Text = "Black";
            this.pBlack.UseVisualStyleBackColor = true;
            this.pBlack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBlack_MouseClick);
            // 
            // pRed
            // 
            this.pRed.AutoSize = true;
            this.pRed.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pRed.Location = new System.Drawing.Point(342, 245);
            this.pRed.Name = "pRed";
            this.pRed.Size = new System.Drawing.Size(58, 20);
            this.pRed.TabIndex = 5;
            this.pRed.Text = "Red";
            this.pRed.UseVisualStyleBackColor = true;
            this.pRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pRed_MouseClick);
            // 
            // pBlue
            // 
            this.pBlue.AutoSize = true;
            this.pBlue.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBlue.Location = new System.Drawing.Point(431, 245);
            this.pBlue.Name = "pBlue";
            this.pBlue.Size = new System.Drawing.Size(63, 20);
            this.pBlue.TabIndex = 6;
            this.pBlue.Text = "Blue";
            this.pBlue.UseVisualStyleBackColor = true;
            this.pBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pBlue_MouseClick);
            // 
            // lineBlack
            // 
            this.lineBlack.AutoSize = true;
            this.lineBlack.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBlack.Location = new System.Drawing.Point(242, 299);
            this.lineBlack.Name = "lineBlack";
            this.lineBlack.Size = new System.Drawing.Size(71, 20);
            this.lineBlack.TabIndex = 7;
            this.lineBlack.Text = "Black";
            this.lineBlack.UseVisualStyleBackColor = true;
            this.lineBlack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lineBlack_MouseClick);
            // 
            // lineRed
            // 
            this.lineRed.AutoSize = true;
            this.lineRed.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineRed.Location = new System.Drawing.Point(342, 299);
            this.lineRed.Name = "lineRed";
            this.lineRed.Size = new System.Drawing.Size(58, 20);
            this.lineRed.TabIndex = 8;
            this.lineRed.Text = "Red";
            this.lineRed.UseVisualStyleBackColor = true;
            this.lineRed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lineRed_MouseClick);
            // 
            // lineBlue
            // 
            this.lineBlue.AutoSize = true;
            this.lineBlue.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineBlue.Location = new System.Drawing.Point(431, 299);
            this.lineBlue.Name = "lineBlue";
            this.lineBlue.Size = new System.Drawing.Size(63, 20);
            this.lineBlue.TabIndex = 9;
            this.lineBlue.Text = "Blue";
            this.lineBlue.UseVisualStyleBackColor = true;
            this.lineBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lineBlue_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(184, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mouseStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // mouseStatus
            // 
            this.mouseStatus.Name = "mouseStatus";
            this.mouseStatus.Size = new System.Drawing.Size(68, 20);
            this.mouseStatus.Text = "X : -  Y : -";
            // 
            // listBox1
            // 
            this.listBox1.AccessibleName = "";
            this.listBox1.BackColor = System.Drawing.Color.MistyRose;
            this.listBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(599, 237);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 180);
            this.listBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Point Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Select Line Color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lineBlue);
            this.Controls.Add(this.lineRed);
            this.Controls.Add(this.lineBlack);
            this.Controls.Add(this.pBlue);
            this.Controls.Add(this.pRed);
            this.Controls.Add(this.pBlack);
            this.Controls.Add(this.curvelength);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button curvelength;
        private System.Windows.Forms.CheckBox pBlack;
        private System.Windows.Forms.CheckBox pRed;
        private System.Windows.Forms.CheckBox pBlue;
        private System.Windows.Forms.CheckBox lineBlack;
        private System.Windows.Forms.CheckBox lineRed;
        private System.Windows.Forms.CheckBox lineBlue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel mouseStatus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

