namespace WhiteNoiseMachine
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
			this.timeLabel = new System.Windows.Forms.Label();
			this.timeDisplayInterval = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.fadeInTextField = new System.Windows.Forms.TextBox();
			this.fadeInTextLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLabel.Location = new System.Drawing.Point(105, 122);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(127, 32);
			this.timeLabel.TabIndex = 0;
			this.timeLabel.Text = "0:00 PM";
			this.timeLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// timeDisplayInterval
			// 
			this.timeDisplayInterval.Enabled = true;
			this.timeDisplayInterval.Interval = 1000;
			this.timeDisplayInterval.Tick += new System.EventHandler(this.timeDisplayInterval_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(83, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "The time is currently";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(45, 242);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(187, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Noise fade-in will begin at";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(300, 242);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 20);
			this.label4.TabIndex = 5;
			this.label4.Text = "and will fade-out at";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(333, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 20);
			this.label6.TabIndex = 7;
			this.label6.Text = "Noise starts in";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(326, 122);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(116, 32);
			this.label7.TabIndex = 6;
			this.label7.Text = "0 hours";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// fadeInTextField
			// 
			this.fadeInTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.fadeInTextField.Enabled = false;
			this.fadeInTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fadeInTextField.Location = new System.Drawing.Point(111, 276);
			this.fadeInTextField.MaxLength = 8;
			this.fadeInTextField.Name = "fadeInTextField";
			this.fadeInTextField.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fadeInTextField.Size = new System.Drawing.Size(121, 39);
			this.fadeInTextField.TabIndex = 8;
			this.fadeInTextField.Text = "4:00 AM";
			this.fadeInTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.fadeInTextField.Visible = false;
			this.fadeInTextField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fadeInTextField_KeyDown);
			// 
			// fadeInTextLabel
			// 
			this.fadeInTextLabel.AutoSize = true;
			this.fadeInTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fadeInTextLabel.Location = new System.Drawing.Point(112, 331);
			this.fadeInTextLabel.Name = "fadeInTextLabel";
			this.fadeInTextLabel.Size = new System.Drawing.Size(120, 32);
			this.fadeInTextLabel.TabIndex = 9;
			this.fadeInTextLabel.Text = "4:00 AM";
			this.fadeInTextLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.fadeInTextLabel.Click += new System.EventHandler(this.fadeInTextLabel_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 561);
			this.Controls.Add(this.fadeInTextLabel);
			this.Controls.Add(this.fadeInTextField);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.timeLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "White Noise Machine";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Timer timeDisplayInterval;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox fadeInTextField;
		private System.Windows.Forms.Label fadeInTextLabel;
	}
}

