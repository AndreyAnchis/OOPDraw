namespace OOPDraw1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPaint = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(50, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(702, 289);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            // 
            // buttonPaint
            // 
            this.buttonPaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPaint.Location = new System.Drawing.Point(126, 392);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(130, 48);
            this.buttonPaint.TabIndex = 1;
            this.buttonPaint.Text = "Промалювати";
            this.buttonPaint.UseVisualStyleBackColor = true;
            this.buttonPaint.Click += new System.EventHandler(this.ButtonPaint_Click);
            this.buttonPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonPaint_Paint);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(423, 392);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 48);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Стерти";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.labelName.Font = new System.Drawing.Font("Franklin Gothic Book", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(716, 439);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(148, 36);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Анчис А. О.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 484);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPaint);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPaint;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelName;
    }
}

