namespace Треугольники_для_тестирования
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Verifications = new System.Windows.Forms.Label();
            this.SideB = new System.Windows.Forms.TextBox();
            this.SideC = new System.Windows.Forms.TextBox();
            this.SideA = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.MinimumSize = new System.Drawing.Size(516, 280);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.Verifications);
            this.splitContainer1.Panel1.Controls.Add(this.SideB);
            this.splitContainer1.Panel1.Controls.Add(this.SideC);
            this.splitContainer1.Panel1.Controls.Add(this.SideA);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Result);
            this.splitContainer1.Panel2.Controls.Add(this.Start);
            this.splitContainer1.Size = new System.Drawing.Size(516, 280);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.TabIndex = 6;
            // 
            // Verifications
            // 
            this.Verifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Verifications.AutoSize = true;
            this.Verifications.ForeColor = System.Drawing.Color.Maroon;
            this.Verifications.Location = new System.Drawing.Point(119, 52);
            this.Verifications.Name = "Verifications";
            this.Verifications.Size = new System.Drawing.Size(0, 16);
            this.Verifications.TabIndex = 9;
            this.Verifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SideB
            // 
            this.SideB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SideB.ForeColor = System.Drawing.Color.Black;
            this.SideB.Location = new System.Drawing.Point(185, 92);
            this.SideB.Name = "SideB";
            this.SideB.Size = new System.Drawing.Size(126, 22);
            this.SideB.TabIndex = 8;
            this.SideB.TextChanged += new System.EventHandler(this.SideA_TextChanged);
            // 
            // SideC
            // 
            this.SideC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SideC.ForeColor = System.Drawing.Color.Black;
            this.SideC.Location = new System.Drawing.Point(347, 92);
            this.SideC.Name = "SideC";
            this.SideC.Size = new System.Drawing.Size(134, 22);
            this.SideC.TabIndex = 7;
            this.SideC.TextChanged += new System.EventHandler(this.SideA_TextChanged);
            // 
            // SideA
            // 
            this.SideA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SideA.BackColor = System.Drawing.Color.White;
            this.SideA.ForeColor = System.Drawing.Color.Black;
            this.SideA.Location = new System.Drawing.Point(25, 92);
            this.SideA.Name = "SideA";
            this.SideA.Size = new System.Drawing.Size(119, 22);
            this.SideA.TabIndex = 6;
            this.SideA.TextChanged += new System.EventHandler(this.SideA_TextChanged);
            // 
            // Result
            // 
            this.Result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(159, 20);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 16);
            this.Result.TabIndex = 6;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Start.AutoSize = true;
            this.Start.Location = new System.Drawing.Point(162, 50);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(165, 43);
            this.Start.TabIndex = 5;
            this.Start.Text = "Проверить";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите стороны треуголника";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 282);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(535, 329);
            this.Name = "Form1";
            this.Text = "Треугольники";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label Verifications;
        private System.Windows.Forms.TextBox SideB;
        private System.Windows.Forms.TextBox SideC;
        private System.Windows.Forms.TextBox SideA;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
    }
}

