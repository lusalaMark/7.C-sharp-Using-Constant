namespace _7.C_sharp_Using_Constant
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
			this.btnFindPerimeter = new System.Windows.Forms.Button();
			this.txtSideLength = new System.Windows.Forms.TextBox();
			this.lblSideLength = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblPerimeter = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnFindPerimeter
			// 
			this.btnFindPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFindPerimeter.Location = new System.Drawing.Point(12, 105);
			this.btnFindPerimeter.Name = "btnFindPerimeter";
			this.btnFindPerimeter.Size = new System.Drawing.Size(222, 97);
			this.btnFindPerimeter.TabIndex = 5;
			this.btnFindPerimeter.Text = "FIND";
			this.btnFindPerimeter.UseVisualStyleBackColor = true;
			this.btnFindPerimeter.Click += new System.EventHandler(this.btnFindPerimeter_Click);
			// 
			// txtSideLength
			// 
			this.txtSideLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSideLength.Location = new System.Drawing.Point(12, 12);
			this.txtSideLength.Name = "txtSideLength";
			this.txtSideLength.Size = new System.Drawing.Size(222, 67);
			this.txtSideLength.TabIndex = 4;
			this.txtSideLength.TextChanged += new System.EventHandler(this.txtSideLength_TextChanged);
			// 
			// lblSideLength
			// 
			this.lblSideLength.AutoSize = true;
			this.lblSideLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSideLength.Location = new System.Drawing.Point(548, 237);
			this.lblSideLength.Name = "lblSideLength";
			this.lblSideLength.Size = new System.Drawing.Size(0, 61);
			this.lblSideLength.TabIndex = 7;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(575, 50);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(606, 479);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// lblPerimeter
			// 
			this.lblPerimeter.AutoSize = true;
			this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPerimeter.Location = new System.Drawing.Point(30, 427);
			this.lblPerimeter.Name = "lblPerimeter";
			this.lblPerimeter.Size = new System.Drawing.Size(0, 61);
			this.lblPerimeter.TabIndex = 8;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1236, 569);
			this.Controls.Add(this.lblPerimeter);
			this.Controls.Add(this.lblSideLength);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnFindPerimeter);
			this.Controls.Add(this.txtSideLength);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnFindPerimeter;
		private System.Windows.Forms.TextBox txtSideLength;
		private System.Windows.Forms.Label lblSideLength;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblPerimeter;
	}
}

