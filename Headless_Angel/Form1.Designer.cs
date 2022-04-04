namespace Headless_Angel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBox1 = new System.Windows.Forms.NumericUpDown();
            this.Textbox2 = new System.Windows.Forms.NumericUpDown();
            this.plus = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Textbox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.AccessibleName = "TextBox1";
            this.TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.ForeColor = System.Drawing.Color.Cornsilk;
            this.TextBox1.Location = new System.Drawing.Point(12, 19);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(258, 16);
            this.TextBox1.TabIndex = 0;
            this.TextBox1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Textbox2
            // 
            this.Textbox2.AccessibleDescription = "";
            this.Textbox2.AccessibleName = "Textbox2";
            this.Textbox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Textbox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Textbox2.ForeColor = System.Drawing.Color.Cornsilk;
            this.Textbox2.Location = new System.Drawing.Point(12, 45);
            this.Textbox2.Name = "Textbox2";
            this.Textbox2.Size = new System.Drawing.Size(258, 16);
            this.Textbox2.TabIndex = 1;
            this.Textbox2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // plus
            // 
            this.plus.AccessibleName = "plus1";
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.Color.Snow;
            this.plus.Location = new System.Drawing.Point(12, 82);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 33);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.PlusEvent);
            // 
            // button2
            // 
            this.button2.AccessibleName = "Minus";
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(78, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.AccessibleName = "Division";
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(144, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.AccessibleName = "Multipl";
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(210, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "*";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.MulteplEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(282, 134);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Textbox2);
            this.Controls.Add(this.TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Textbox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown TextBox1;
        private System.Windows.Forms.NumericUpDown Textbox2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

