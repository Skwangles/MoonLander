namespace Moon_Lander
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
            this.components = new System.ComponentModel.Container();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.Fuel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(90, 9);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(85, 20);
            this.TB1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Name:";
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(90, 29);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(35, 20);
            this.TB2.TabIndex = 2;
            this.TB2.Text = "2500";
            // 
            // Fuel
            // 
            this.Fuel.AutoSize = true;
            this.Fuel.Location = new System.Drawing.Point(12, 32);
            this.Fuel.Name = "Fuel";
            this.Fuel.Size = new System.Drawing.Size(72, 13);
            this.Fuel.TabIndex = 3;
            this.Fuel.Text = "Fuel (0-5000):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.AutoSize = true;
            this.ErrorLbl.Location = new System.Drawing.Point(5, 84);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(113, 13);
            this.ErrorLbl.TabIndex = 5;
            this.ErrorLbl.Text = "Fuel Value Is Incorrect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 100);
            this.Controls.Add(this.ErrorLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Fuel);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.Label Fuel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ErrorLbl;
        private System.Windows.Forms.Timer timer1;
    }
}

