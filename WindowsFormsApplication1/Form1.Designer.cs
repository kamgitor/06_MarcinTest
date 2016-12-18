namespace WindowsFormsApplication1
{
    partial class MojaApka
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
            this.button1 = new System.Windows.Forms.Button();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.Klikacz1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ptaszek = new System.Windows.Forms.CheckBox();
            this.Klikacz2 = new System.Windows.Forms.RadioButton();
            this.CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Baton 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Input1
            // 
            this.Input1.Location = new System.Drawing.Point(22, 22);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(75, 20);
            this.Input1.TabIndex = 1;
            // 
            // Input2
            // 
            this.Input2.Location = new System.Drawing.Point(148, 22);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(75, 20);
            this.Input2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(22, 114);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(100, 18);
            this.ProgressBar.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Baton 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Klikacz1
            // 
            this.Klikacz1.AutoSize = true;
            this.Klikacz1.Location = new System.Drawing.Point(148, 114);
            this.Klikacz1.Name = "Klikacz1";
            this.Klikacz1.Size = new System.Drawing.Size(65, 17);
            this.Klikacz1.TabIndex = 6;
            this.Klikacz1.TabStop = true;
            this.Klikacz1.Text = "Klikacz1";
            this.Klikacz1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Klikacz2);
            this.groupBox1.Controls.Add(this.Ptaszek);
            this.groupBox1.Controls.Add(this.Input1);
            this.groupBox1.Controls.Add(this.Klikacz1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Input2);
            this.groupBox1.Controls.Add(this.ProgressBar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 184);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zmienne jakieś";
            // 
            // Ptaszek
            // 
            this.Ptaszek.AutoSize = true;
            this.Ptaszek.Location = new System.Drawing.Point(22, 152);
            this.Ptaszek.Name = "Ptaszek";
            this.Ptaszek.Size = new System.Drawing.Size(64, 17);
            this.Ptaszek.TabIndex = 7;
            this.Ptaszek.Text = "Ptaszek";
            this.Ptaszek.UseVisualStyleBackColor = true;
            // 
            // Klikacz2
            // 
            this.Klikacz2.AutoSize = true;
            this.Klikacz2.Location = new System.Drawing.Point(148, 138);
            this.Klikacz2.Name = "Klikacz2";
            this.Klikacz2.Size = new System.Drawing.Size(65, 17);
            this.Klikacz2.TabIndex = 8;
            this.Klikacz2.TabStop = true;
            this.Klikacz2.Text = "Klikacz2";
            this.Klikacz2.UseVisualStyleBackColor = true;
            // 
            // CheckedListBox
            // 
            this.CheckedListBox.FormattingEnabled = true;
            this.CheckedListBox.Location = new System.Drawing.Point(334, 49);
            this.CheckedListBox.Name = "CheckedListBox";
            this.CheckedListBox.Size = new System.Drawing.Size(155, 109);
            this.CheckedListBox.TabIndex = 8;
            // 
            // MojaApka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 435);
            this.Controls.Add(this.CheckedListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "MojaApka";
            this.Text = "Moja pierwsza apka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton Klikacz1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Klikacz2;
        private System.Windows.Forms.CheckBox Ptaszek;
        private System.Windows.Forms.CheckedListBox CheckedListBox;
    }
}

