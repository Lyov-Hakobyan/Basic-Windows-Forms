namespace WindowsFormsPractice
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
            this.CalculationResultsText = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Equals_Button = new System.Windows.Forms.Button();
            this.Dot_Button = new System.Windows.Forms.Button();
            this.Zero_Button = new System.Windows.Forms.Button();
            this.Plus_Button = new System.Windows.Forms.Button();
            this.Three_Button = new System.Windows.Forms.Button();
            this.Two_Button = new System.Windows.Forms.Button();
            this.One_Button = new System.Windows.Forms.Button();
            this.Minus_Button = new System.Windows.Forms.Button();
            this.Six_Button = new System.Windows.Forms.Button();
            this.Five_Button = new System.Windows.Forms.Button();
            this.Four_Button = new System.Windows.Forms.Button();
            this.Multiply_Button = new System.Windows.Forms.Button();
            this.Nine_Button = new System.Windows.Forms.Button();
            this.Eight_Button = new System.Windows.Forms.Button();
            this.Seven_Button = new System.Windows.Forms.Button();
            this.Divide_Button = new System.Windows.Forms.Button();
            this.DELETE_Button = new System.Windows.Forms.Button();
            this.CE_Button = new System.Windows.Forms.Button();
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculationResultsText
            // 
            this.CalculationResultsText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculationResultsText.BackColor = System.Drawing.Color.FloralWhite;
            this.CalculationResultsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculationResultsText.Cursor = System.Windows.Forms.Cursors.Default;
            this.CalculationResultsText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculationResultsText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CalculationResultsText.Location = new System.Drawing.Point(15, 88);
            this.CalculationResultsText.Name = "CalculationResultsText";
            this.CalculationResultsText.Size = new System.Drawing.Size(234, 62);
            this.CalculationResultsText.TabIndex = 1;
            this.CalculationResultsText.Text = "Please enter an equation and press ENTER or =";
            this.CalculationResultsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsPanel.BackColor = System.Drawing.Color.Firebrick;
            this.ButtonsPanel.ColumnCount = 4;
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.58333F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsPanel.Controls.Add(this.Equals_Button, 3, 4);
            this.ButtonsPanel.Controls.Add(this.Dot_Button, 2, 4);
            this.ButtonsPanel.Controls.Add(this.Zero_Button, 1, 4);
            this.ButtonsPanel.Controls.Add(this.Plus_Button, 3, 3);
            this.ButtonsPanel.Controls.Add(this.Three_Button, 2, 3);
            this.ButtonsPanel.Controls.Add(this.Two_Button, 1, 3);
            this.ButtonsPanel.Controls.Add(this.One_Button, 0, 3);
            this.ButtonsPanel.Controls.Add(this.Minus_Button, 3, 2);
            this.ButtonsPanel.Controls.Add(this.Six_Button, 2, 2);
            this.ButtonsPanel.Controls.Add(this.Five_Button, 1, 2);
            this.ButtonsPanel.Controls.Add(this.Four_Button, 0, 2);
            this.ButtonsPanel.Controls.Add(this.Multiply_Button, 3, 1);
            this.ButtonsPanel.Controls.Add(this.Nine_Button, 2, 1);
            this.ButtonsPanel.Controls.Add(this.Eight_Button, 1, 1);
            this.ButtonsPanel.Controls.Add(this.Seven_Button, 0, 1);
            this.ButtonsPanel.Controls.Add(this.Divide_Button, 3, 0);
            this.ButtonsPanel.Controls.Add(this.DELETE_Button, 2, 0);
            this.ButtonsPanel.Controls.Add(this.CE_Button, 0, 0);
            this.ButtonsPanel.Location = new System.Drawing.Point(12, 153);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.RowCount = 5;
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonsPanel.Size = new System.Drawing.Size(240, 172);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // Equals_Button
            // 
            this.Equals_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equals_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Equals_Button.Location = new System.Drawing.Point(182, 139);
            this.Equals_Button.Name = "Equals_Button";
            this.Equals_Button.Size = new System.Drawing.Size(55, 30);
            this.Equals_Button.TabIndex = 20;
            this.Equals_Button.Text = "=";
            this.Equals_Button.UseVisualStyleBackColor = true;
            this.Equals_Button.Click += new System.EventHandler(this.Equals_Button_Click);
            // 
            // Dot_Button
            // 
            this.Dot_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dot_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Dot_Button.Location = new System.Drawing.Point(122, 139);
            this.Dot_Button.Name = "Dot_Button";
            this.Dot_Button.Size = new System.Drawing.Size(54, 30);
            this.Dot_Button.TabIndex = 19;
            this.Dot_Button.Text = ".";
            this.Dot_Button.UseVisualStyleBackColor = true;
            this.Dot_Button.Click += new System.EventHandler(this.Dot_Button_Click);
            // 
            // Zero_Button
            // 
            this.Zero_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zero_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Zero_Button.Location = new System.Drawing.Point(63, 139);
            this.Zero_Button.Name = "Zero_Button";
            this.Zero_Button.Size = new System.Drawing.Size(53, 30);
            this.Zero_Button.TabIndex = 18;
            this.Zero_Button.Text = "0";
            this.Zero_Button.UseVisualStyleBackColor = true;
            this.Zero_Button.Click += new System.EventHandler(this.Zero_Button_Click);
            // 
            // Plus_Button
            // 
            this.Plus_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plus_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Plus_Button.Location = new System.Drawing.Point(182, 105);
            this.Plus_Button.Name = "Plus_Button";
            this.Plus_Button.Size = new System.Drawing.Size(55, 28);
            this.Plus_Button.TabIndex = 16;
            this.Plus_Button.Text = "+";
            this.Plus_Button.UseVisualStyleBackColor = true;
            this.Plus_Button.Click += new System.EventHandler(this.Plus_Button_Click);
            // 
            // Three_Button
            // 
            this.Three_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Three_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Three_Button.Location = new System.Drawing.Point(122, 105);
            this.Three_Button.Name = "Three_Button";
            this.Three_Button.Size = new System.Drawing.Size(54, 28);
            this.Three_Button.TabIndex = 15;
            this.Three_Button.Text = "3";
            this.Three_Button.UseVisualStyleBackColor = true;
            this.Three_Button.Click += new System.EventHandler(this.Three_Button_Click);
            // 
            // Two_Button
            // 
            this.Two_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Two_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Two_Button.Location = new System.Drawing.Point(63, 105);
            this.Two_Button.Name = "Two_Button";
            this.Two_Button.Size = new System.Drawing.Size(53, 28);
            this.Two_Button.TabIndex = 14;
            this.Two_Button.Text = "2";
            this.Two_Button.UseVisualStyleBackColor = true;
            this.Two_Button.Click += new System.EventHandler(this.Two_Button_Click);
            // 
            // One_Button
            // 
            this.One_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.One_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.One_Button.Location = new System.Drawing.Point(3, 105);
            this.One_Button.Name = "One_Button";
            this.One_Button.Size = new System.Drawing.Size(54, 28);
            this.One_Button.TabIndex = 13;
            this.One_Button.Text = "1";
            this.One_Button.UseVisualStyleBackColor = true;
            this.One_Button.Click += new System.EventHandler(this.One_Button_Click);
            // 
            // Minus_Button
            // 
            this.Minus_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minus_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Minus_Button.Location = new System.Drawing.Point(182, 71);
            this.Minus_Button.Name = "Minus_Button";
            this.Minus_Button.Size = new System.Drawing.Size(55, 28);
            this.Minus_Button.TabIndex = 12;
            this.Minus_Button.Text = "-";
            this.Minus_Button.UseVisualStyleBackColor = true;
            this.Minus_Button.Click += new System.EventHandler(this.Minus_Button_Click);
            // 
            // Six_Button
            // 
            this.Six_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Six_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Six_Button.Location = new System.Drawing.Point(122, 71);
            this.Six_Button.Name = "Six_Button";
            this.Six_Button.Size = new System.Drawing.Size(54, 28);
            this.Six_Button.TabIndex = 11;
            this.Six_Button.Text = "6";
            this.Six_Button.UseVisualStyleBackColor = true;
            this.Six_Button.Click += new System.EventHandler(this.Six_Button_Click);
            // 
            // Five_Button
            // 
            this.Five_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Five_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Five_Button.Location = new System.Drawing.Point(63, 71);
            this.Five_Button.Name = "Five_Button";
            this.Five_Button.Size = new System.Drawing.Size(53, 28);
            this.Five_Button.TabIndex = 10;
            this.Five_Button.Text = "5";
            this.Five_Button.UseVisualStyleBackColor = true;
            this.Five_Button.Click += new System.EventHandler(this.Five_Button_Click);
            // 
            // Four_Button
            // 
            this.Four_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Four_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Four_Button.Location = new System.Drawing.Point(3, 71);
            this.Four_Button.Name = "Four_Button";
            this.Four_Button.Size = new System.Drawing.Size(54, 28);
            this.Four_Button.TabIndex = 9;
            this.Four_Button.Text = "4";
            this.Four_Button.UseVisualStyleBackColor = true;
            this.Four_Button.Click += new System.EventHandler(this.Four_Button_Click);
            // 
            // Multiply_Button
            // 
            this.Multiply_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Multiply_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Multiply_Button.Location = new System.Drawing.Point(182, 37);
            this.Multiply_Button.Name = "Multiply_Button";
            this.Multiply_Button.Size = new System.Drawing.Size(55, 28);
            this.Multiply_Button.TabIndex = 8;
            this.Multiply_Button.Text = "*";
            this.Multiply_Button.UseVisualStyleBackColor = true;
            this.Multiply_Button.Click += new System.EventHandler(this.Multiply_Button_Click);
            // 
            // Nine_Button
            // 
            this.Nine_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nine_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Nine_Button.Location = new System.Drawing.Point(122, 37);
            this.Nine_Button.Name = "Nine_Button";
            this.Nine_Button.Size = new System.Drawing.Size(54, 28);
            this.Nine_Button.TabIndex = 7;
            this.Nine_Button.Text = "9";
            this.Nine_Button.UseVisualStyleBackColor = true;
            this.Nine_Button.Click += new System.EventHandler(this.Nine_Button_Click);
            // 
            // Eight_Button
            // 
            this.Eight_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eight_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Eight_Button.Location = new System.Drawing.Point(63, 37);
            this.Eight_Button.Name = "Eight_Button";
            this.Eight_Button.Size = new System.Drawing.Size(53, 28);
            this.Eight_Button.TabIndex = 6;
            this.Eight_Button.Text = "8";
            this.Eight_Button.UseVisualStyleBackColor = true;
            this.Eight_Button.Click += new System.EventHandler(this.Eight_Button_Click);
            // 
            // Seven_Button
            // 
            this.Seven_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Seven_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Seven_Button.Location = new System.Drawing.Point(3, 37);
            this.Seven_Button.Name = "Seven_Button";
            this.Seven_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Seven_Button.Size = new System.Drawing.Size(54, 28);
            this.Seven_Button.TabIndex = 5;
            this.Seven_Button.Text = "7";
            this.Seven_Button.UseVisualStyleBackColor = true;
            this.Seven_Button.Click += new System.EventHandler(this.Seven_Button_Click);
            // 
            // Divide_Button
            // 
            this.Divide_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divide_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Divide_Button.Location = new System.Drawing.Point(182, 3);
            this.Divide_Button.Name = "Divide_Button";
            this.Divide_Button.Size = new System.Drawing.Size(55, 28);
            this.Divide_Button.TabIndex = 4;
            this.Divide_Button.Text = "/";
            this.Divide_Button.UseVisualStyleBackColor = true;
            this.Divide_Button.Click += new System.EventHandler(this.Divide_Button_Click);
            // 
            // DELETE_Button
            // 
            this.DELETE_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DELETE_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.DELETE_Button.Location = new System.Drawing.Point(122, 3);
            this.DELETE_Button.Name = "DELETE_Button";
            this.DELETE_Button.Size = new System.Drawing.Size(54, 28);
            this.DELETE_Button.TabIndex = 3;
            this.DELETE_Button.Text = "Delete";
            this.DELETE_Button.UseVisualStyleBackColor = true;
            this.DELETE_Button.Click += new System.EventHandler(this.DELETE_Button_Click);
            // 
            // CE_Button
            // 
            this.CE_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CE_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CE_Button.ForeColor = System.Drawing.Color.DarkBlue;
            this.CE_Button.Location = new System.Drawing.Point(3, 3);
            this.CE_Button.Name = "CE_Button";
            this.CE_Button.Size = new System.Drawing.Size(54, 28);
            this.CE_Button.TabIndex = 1;
            this.CE_Button.Text = "CE";
            this.CE_Button.UseVisualStyleBackColor = true;
            this.CE_Button.Click += new System.EventHandler(this.CE_Button_Click);
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.BackColor = System.Drawing.SystemColors.Menu;
            this.UserInputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInputText.Location = new System.Drawing.Point(15, 13);
            this.UserInputText.Multiline = true;
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(234, 72);
            this.UserInputText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.Equals_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.CancelButton = this.CE_Button;
            this.ClientSize = new System.Drawing.Size(264, 340);
            this.Controls.Add(this.UserInputText);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.CalculationResultsText);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.MinimumSize = new System.Drawing.Size(280, 379);
            this.Name = "Form1";
            this.Text = "la";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CalculationResultsText;
        private System.Windows.Forms.TableLayoutPanel ButtonsPanel;
        private System.Windows.Forms.Button CE_Button;
        private System.Windows.Forms.Button Equals_Button;
        private System.Windows.Forms.Button Dot_Button;
        private System.Windows.Forms.Button Zero_Button;
        private System.Windows.Forms.Button Plus_Button;
        private System.Windows.Forms.Button Three_Button;
        private System.Windows.Forms.Button Two_Button;
        private System.Windows.Forms.Button One_Button;
        private System.Windows.Forms.Button Minus_Button;
        private System.Windows.Forms.Button Six_Button;
        private System.Windows.Forms.Button Five_Button;
        private System.Windows.Forms.Button Four_Button;
        private System.Windows.Forms.Button Multiply_Button;
        private System.Windows.Forms.Button Nine_Button;
        private System.Windows.Forms.Button Eight_Button;
        private System.Windows.Forms.Button Seven_Button;
        private System.Windows.Forms.Button Divide_Button;
        private System.Windows.Forms.Button DELETE_Button;
        private System.Windows.Forms.TextBox UserInputText;
    }
}

