namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(button9, 2, 2);
            tableLayoutPanel1.Controls.Add(button8, 1, 2);
            tableLayoutPanel1.Controls.Add(button7, 0, 2);
            tableLayoutPanel1.Controls.Add(button6, 2, 1);
            tableLayoutPanel1.Controls.Add(button5, 1, 1);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(537, 521);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(173, 167);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += GameButtonClick;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(182, 3);
            button2.Name = "button2";
            button2.Size = new Size(173, 167);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += GameButtonClick;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(361, 3);
            button3.Name = "button3";
            button3.Size = new Size(173, 167);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += GameButtonClick;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(3, 176);
            button4.Name = "button4";
            button4.Size = new Size(173, 167);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += GameButtonClick;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(182, 176);
            button5.Name = "button5";
            button5.Size = new Size(173, 167);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += GameButtonClick;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(361, 176);
            button6.Name = "button6";
            button6.Size = new Size(173, 167);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += GameButtonClick;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(3, 349);
            button7.Name = "button7";
            button7.Size = new Size(173, 169);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += GameButtonClick;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(182, 349);
            button8.Name = "button8";
            button8.Size = new Size(173, 169);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += GameButtonClick;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(361, 349);
            button9.Name = "button9";
            button9.Size = new Size(173, 169);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += GameButtonClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 521);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
