namespace NoContact
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.richTextBoxNumbers = new System.Windows.Forms.RichTextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelNumbers = new System.Windows.Forms.Label();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.label9Menu = new System.Windows.Forms.Label();
            this.label8Menu = new System.Windows.Forms.Label();
            this.label11Menu = new System.Windows.Forms.Label();
            this.label10Menu = new System.Windows.Forms.Label();
            this.label7Menu = new System.Windows.Forms.Label();
            this.label4Menu = new System.Windows.Forms.Label();
            this.label3Menu = new System.Windows.Forms.Label();
            this.label5Menu = new System.Windows.Forms.Label();
            this.label6Menu = new System.Windows.Forms.Label();
            this.label2Menu = new System.Windows.Forms.Label();
            this.label1Menu = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 167);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(114, 27);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 32);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(288, 129);
            this.textBoxMessage.TabIndex = 1;
            // 
            // richTextBoxNumbers
            // 
            this.richTextBoxNumbers.Location = new System.Drawing.Point(306, 32);
            this.richTextBoxNumbers.Name = "richTextBoxNumbers";
            this.richTextBoxNumbers.Size = new System.Drawing.Size(146, 260);
            this.richTextBoxNumbers.TabIndex = 4;
            this.richTextBoxNumbers.Text = "";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(186, 167);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(114, 27);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(15, 12);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(53, 13);
            this.labelMessage.TabIndex = 6;
            this.labelMessage.Text = "Message:";
            // 
            // labelNumbers
            // 
            this.labelNumbers.AutoSize = true;
            this.labelNumbers.Location = new System.Drawing.Point(303, 9);
            this.labelNumbers.Name = "labelNumbers";
            this.labelNumbers.Size = new System.Drawing.Size(52, 13);
            this.labelNumbers.TabIndex = 7;
            this.labelNumbers.Text = "Numbers:";
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.label9Menu);
            this.groupBoxMenu.Controls.Add(this.label8Menu);
            this.groupBoxMenu.Controls.Add(this.label11Menu);
            this.groupBoxMenu.Controls.Add(this.label10Menu);
            this.groupBoxMenu.Controls.Add(this.label7Menu);
            this.groupBoxMenu.Controls.Add(this.label4Menu);
            this.groupBoxMenu.Controls.Add(this.label3Menu);
            this.groupBoxMenu.Controls.Add(this.label5Menu);
            this.groupBoxMenu.Controls.Add(this.label6Menu);
            this.groupBoxMenu.Controls.Add(this.label2Menu);
            this.groupBoxMenu.Controls.Add(this.label1Menu);
            this.groupBoxMenu.Location = new System.Drawing.Point(12, 200);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(288, 92);
            this.groupBoxMenu.TabIndex = 8;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // label9Menu
            // 
            this.label9Menu.AutoSize = true;
            this.label9Menu.Location = new System.Drawing.Point(144, 32);
            this.label9Menu.Name = "label9Menu";
            this.label9Menu.Size = new System.Drawing.Size(102, 13);
            this.label9Menu.TabIndex = 11;
            this.label9Menu.Text = "Start a conversation";
            // 
            // label8Menu
            // 
            this.label8Menu.AutoSize = true;
            this.label8Menu.Location = new System.Drawing.Point(144, 16);
            this.label8Menu.Name = "label8Menu";
            this.label8Menu.Size = new System.Drawing.Size(64, 13);
            this.label8Menu.TabIndex = 10;
            this.label8Menu.Text = "Button start:";
            // 
            // label11Menu
            // 
            this.label11Menu.AutoSize = true;
            this.label11Menu.Location = new System.Drawing.Point(144, 76);
            this.label11Menu.Name = "label11Menu";
            this.label11Menu.Size = new System.Drawing.Size(142, 13);
            this.label11Menu.TabIndex = 9;
            this.label11Menu.Text = "clean message and numbers";
            // 
            // label10Menu
            // 
            this.label10Menu.AutoSize = true;
            this.label10Menu.Location = new System.Drawing.Point(144, 60);
            this.label10Menu.Name = "label10Menu";
            this.label10Menu.Size = new System.Drawing.Size(72, 13);
            this.label10Menu.TabIndex = 8;
            this.label10Menu.Text = "Button Reset:";
            // 
            // label7Menu
            // 
            this.label7Menu.AutoSize = true;
            this.label7Menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7Menu.Location = new System.Drawing.Point(7, 76);
            this.label7Menu.Name = "label7Menu";
            this.label7Menu.Size = new System.Drawing.Size(76, 13);
            this.label7Menu.TabIndex = 7;
            this.label7Menu.Text = "Phone number";
            // 
            // label4Menu
            // 
            this.label4Menu.AutoSize = true;
            this.label4Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4Menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4Menu.Location = new System.Drawing.Point(50, 33);
            this.label4Menu.Name = "label4Menu";
            this.label4Menu.Size = new System.Drawing.Size(64, 17);
            this.label4Menu.TabIndex = 6;
            this.label4Menu.Text = "0000000";
            // 
            // label3Menu
            // 
            this.label3Menu.AutoSize = true;
            this.label3Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Menu.ForeColor = System.Drawing.Color.Blue;
            this.label3Menu.Location = new System.Drawing.Point(20, 33);
            this.label3Menu.Name = "label3Menu";
            this.label3Menu.Size = new System.Drawing.Size(32, 17);
            this.label3Menu.TabIndex = 5;
            this.label3Menu.Text = "702";
            // 
            // label5Menu
            // 
            this.label5Menu.AutoSize = true;
            this.label5Menu.ForeColor = System.Drawing.Color.Red;
            this.label5Menu.Location = new System.Drawing.Point(7, 50);
            this.label5Menu.Name = "label5Menu";
            this.label5Menu.Size = new System.Drawing.Size(131, 13);
            this.label5Menu.TabIndex = 4;
            this.label5Menu.Text = "International Direct Dialing";
            // 
            // label6Menu
            // 
            this.label6Menu.AutoSize = true;
            this.label6Menu.ForeColor = System.Drawing.Color.Blue;
            this.label6Menu.Location = new System.Drawing.Point(7, 63);
            this.label6Menu.Name = "label6Menu";
            this.label6Menu.Size = new System.Drawing.Size(115, 13);
            this.label6Menu.TabIndex = 3;
            this.label6Menu.Text = "Direct Distance Dialing";
            // 
            // label2Menu
            // 
            this.label2Menu.AutoSize = true;
            this.label2Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Menu.ForeColor = System.Drawing.Color.Red;
            this.label2Menu.Location = new System.Drawing.Point(7, 33);
            this.label2Menu.Name = "label2Menu";
            this.label2Menu.Size = new System.Drawing.Size(16, 17);
            this.label2Menu.TabIndex = 2;
            this.label2Menu.Text = "1";
            // 
            // label1Menu
            // 
            this.label1Menu.AutoSize = true;
            this.label1Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Menu.Location = new System.Drawing.Point(7, 16);
            this.label1Menu.Name = "label1Menu";
            this.label1Menu.Size = new System.Drawing.Size(124, 17);
            this.label1Menu.TabIndex = 1;
            this.label1Menu.Text = "Example numbers:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 300);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(464, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Enabled = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(220, 17);
            this.toolStripStatusLabel1.Text = "Developed by Luciano Lima - Haunting3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.labelNumbers);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.richTextBoxNumbers);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 360);
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No contact WPP";
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.RichTextBox richTextBoxNumbers;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelNumbers;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Label label4Menu;
        private System.Windows.Forms.Label label3Menu;
        private System.Windows.Forms.Label label5Menu;
        private System.Windows.Forms.Label label6Menu;
        private System.Windows.Forms.Label label2Menu;
        private System.Windows.Forms.Label label1Menu;
        private System.Windows.Forms.Label label7Menu;
        private System.Windows.Forms.Label label9Menu;
        private System.Windows.Forms.Label label8Menu;
        private System.Windows.Forms.Label label11Menu;
        private System.Windows.Forms.Label label10Menu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

