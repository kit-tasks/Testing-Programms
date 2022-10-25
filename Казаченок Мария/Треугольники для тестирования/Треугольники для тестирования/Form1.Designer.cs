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
            this.label1 = new System.Windows.Forms.Label();
            this.verifications = new System.Windows.Forms.Label();
            this.sideB = new System.Windows.Forms.TextBox();
            this.sideC = new System.Windows.Forms.TextBox();
            this.sideA = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.verifications);
            this.splitContainer1.Panel1.Controls.Add(this.sideB);
            this.splitContainer1.Panel1.Controls.Add(this.sideC);
            this.splitContainer1.Panel1.Controls.Add(this.sideA);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.result);
            this.splitContainer1.Panel2.Controls.Add(this.start);
            this.splitContainer1.Size = new System.Drawing.Size(516, 280);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите стороны треуголника";
            // 
            // verifications
            // 
            this.verifications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.verifications.AutoSize = true;
            this.verifications.ForeColor = System.Drawing.Color.Maroon;
            this.verifications.Location = new System.Drawing.Point(119, 52);
            this.verifications.Name = "verifications";
            this.verifications.Size = new System.Drawing.Size(0, 16);
            this.verifications.TabIndex = 9;
            this.verifications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sideB
            // 
            this.sideB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sideB.ForeColor = System.Drawing.Color.Black;
            this.sideB.Location = new System.Drawing.Point(185, 92);
            this.sideB.Name = "sideB";
            this.sideB.Size = new System.Drawing.Size(126, 22);
            this.sideB.TabIndex = 2;
            this.sideB.TextChanged += new System.EventHandler(this.SideA_TextChanged);
            // 
            // sideC
            // 
            this.sideC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sideC.ForeColor = System.Drawing.Color.Black;
            this.sideC.Location = new System.Drawing.Point(347, 92);
            this.sideC.Name = "sideC";
            this.sideC.Size = new System.Drawing.Size(134, 22);
            this.sideC.TabIndex = 3;
            this.sideC.TextChanged += new System.EventHandler(this.SideA_TextChanged);
            // 
            // sideA
            // 
            this.sideA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sideA.BackColor = System.Drawing.Color.White;
            this.sideA.ForeColor = System.Drawing.Color.Black;
            this.sideA.Location = new System.Drawing.Point(25, 92);
            this.sideA.Name = "sideA";
            this.sideA.Size = new System.Drawing.Size(119, 22);
            this.sideA.TabIndex = 1;
            this.sideA.TextChanged += new System.EventHandler(this.SideA_TextChanged);
            // 
            // result
            // 
            this.result.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(144, 23);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 16);
            this.result.TabIndex = 6;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(162, 50);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(165, 43);
            this.start.TabIndex = 4;
            this.start.Text = "Проверить";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
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
        private System.Windows.Forms.Label verifications;
        private System.Windows.Forms.TextBox sideB;
        private System.Windows.Forms.TextBox sideC;
        private System.Windows.Forms.TextBox sideA;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label1;
    }
}

