namespace VsualSorfWF
{
	partial class Sort
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelTime = new System.Windows.Forms.Label();
            this.maxLim = new System.Windows.Forms.NumericUpDown();
            this.minLim = new System.Windows.Forms.NumericUpDown();
            this.GnomeSort = new System.Windows.Forms.Button();
            this.ShellSort = new System.Windows.Forms.Button();
            this.InsertionSort = new System.Windows.Forms.Button();
            this.ShakerSort = new System.Windows.Forms.Button();
            this.countElements = new System.Windows.Forms.NumericUpDown();
            this.SortVibor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countElements)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LabelTime);
            this.groupBox1.Controls.Add(this.maxLim);
            this.groupBox1.Controls.Add(this.minLim);
            this.groupBox1.Controls.Add(this.GnomeSort);
            this.groupBox1.Controls.Add(this.ShellSort);
            this.groupBox1.Controls.Add(this.InsertionSort);
            this.groupBox1.Controls.Add(this.ShakerSort);
            this.groupBox1.Controls.Add(this.countElements);
            this.groupBox1.Controls.Add(this.SortVibor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 411);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1301, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Location = new System.Drawing.Point(521, 43);
            this.LabelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(0, 16);
            this.LabelTime.TabIndex = 18;
            // 
            // maxLim
            // 
            this.maxLim.Location = new System.Drawing.Point(310, 45);
            this.maxLim.Margin = new System.Windows.Forms.Padding(4);
            this.maxLim.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxLim.Name = "maxLim";
            this.maxLim.Size = new System.Drawing.Size(132, 22);
            this.maxLim.TabIndex = 17;
            this.maxLim.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // minLim
            // 
            this.minLim.Location = new System.Drawing.Point(162, 43);
            this.minLim.Margin = new System.Windows.Forms.Padding(4);
            this.minLim.Name = "minLim";
            this.minLim.Size = new System.Drawing.Size(132, 22);
            this.minLim.TabIndex = 16;
            this.minLim.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GnomeSort
            // 
            this.GnomeSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GnomeSort.Location = new System.Drawing.Point(1139, 24);
            this.GnomeSort.Margin = new System.Windows.Forms.Padding(4);
            this.GnomeSort.Name = "GnomeSort";
            this.GnomeSort.Size = new System.Drawing.Size(99, 43);
            this.GnomeSort.TabIndex = 13;
            this.GnomeSort.Text = "Gnome";
            this.GnomeSort.UseVisualStyleBackColor = true;
            this.GnomeSort.Click += new System.EventHandler(this.GnomeSort_Click);
            // 
            // ShellSort
            // 
            this.ShellSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShellSort.Location = new System.Drawing.Point(1019, 23);
            this.ShellSort.Margin = new System.Windows.Forms.Padding(4);
            this.ShellSort.Name = "ShellSort";
            this.ShellSort.Size = new System.Drawing.Size(99, 43);
            this.ShellSort.TabIndex = 12;
            this.ShellSort.Text = "Shell";
            this.ShellSort.UseVisualStyleBackColor = true;
            this.ShellSort.Click += new System.EventHandler(this.ShellSort_Click);
            // 
            // InsertionSort
            // 
            this.InsertionSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertionSort.Location = new System.Drawing.Point(894, 23);
            this.InsertionSort.Margin = new System.Windows.Forms.Padding(4);
            this.InsertionSort.Name = "InsertionSort";
            this.InsertionSort.Size = new System.Drawing.Size(99, 43);
            this.InsertionSort.TabIndex = 11;
            this.InsertionSort.Text = "Insertion";
            this.InsertionSort.UseVisualStyleBackColor = true;
            this.InsertionSort.Click += new System.EventHandler(this.InsertionSort_Click);
            // 
            // ShakerSort
            // 
            this.ShakerSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShakerSort.Location = new System.Drawing.Point(771, 23);
            this.ShakerSort.Margin = new System.Windows.Forms.Padding(4);
            this.ShakerSort.Name = "ShakerSort";
            this.ShakerSort.Size = new System.Drawing.Size(103, 42);
            this.ShakerSort.TabIndex = 10;
            this.ShakerSort.Text = "Shaker";
            this.ShakerSort.UseVisualStyleBackColor = true;
            this.ShakerSort.Click += new System.EventHandler(this.ShakerSort_Click);
            // 
            // countElements
            // 
            this.countElements.Location = new System.Drawing.Point(8, 43);
            this.countElements.Margin = new System.Windows.Forms.Padding(4);
            this.countElements.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.countElements.Name = "countElements";
            this.countElements.Size = new System.Drawing.Size(132, 22);
            this.countElements.TabIndex = 7;
            this.countElements.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // SortVibor
            // 
            this.SortVibor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SortVibor.Location = new System.Drawing.Point(656, 23);
            this.SortVibor.Margin = new System.Windows.Forms.Padding(4);
            this.SortVibor.Name = "SortVibor";
            this.SortVibor.Size = new System.Drawing.Size(96, 42);
            this.SortVibor.TabIndex = 6;
            this.SortVibor.Text = "Viborom";
            this.SortVibor.UseVisualStyleBackColor = true;
            this.SortVibor.Click += new System.EventHandler(this.SortVibor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Верхняя граница";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Нижняя граница";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во элементов ";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1301, 389);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отображение сортировок";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(8, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1285, 358);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Время";
            // 
            // Sort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(669, 410);
            this.Name = "Sort";
            this.Text = "Sort";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countElements)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button SortVibor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.NumericUpDown countElements;
        private System.Windows.Forms.Button ShakerSort;
        private System.Windows.Forms.Button InsertionSort;
        private System.Windows.Forms.Button ShellSort;
        private System.Windows.Forms.Button GnomeSort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxLim;
        private System.Windows.Forms.NumericUpDown minLim;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label label4;
    }
}

