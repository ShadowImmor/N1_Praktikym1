namespace Задание_1_г
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
            this.Plabel = new System.Windows.Forms.Label();
            this.Slabel = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.NumericUpDown();
            this.S = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.P)).BeginInit();
            this.SuspendLayout();
            // 
            // Plabel
            // 
            this.Plabel.AutoSize = true;
            this.Plabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plabel.Location = new System.Drawing.Point(12, 31);
            this.Plabel.Name = "Plabel";
            this.Plabel.Size = new System.Drawing.Size(490, 28);
            this.Plabel.TabIndex = 0;
            this.Plabel.Text = "Периметр равностороннего треугольника";
            // 
            // Slabel
            // 
            this.Slabel.AutoSize = true;
            this.Slabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Slabel.Location = new System.Drawing.Point(12, 103);
            this.Slabel.Name = "Slabel";
            this.Slabel.Size = new System.Drawing.Size(479, 28);
            this.Slabel.TabIndex = 1;
            this.Slabel.Text = "Площадь равностороннего треугольника";
            // 
            // P
            // 
            this.P.DecimalPlaces = 5;
            this.P.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P.Location = new System.Drawing.Point(525, 31);
            this.P.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(120, 36);
            this.P.TabIndex = 2;
            this.P.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.P.ValueChanged += new System.EventHandler(this.P_ValueChanged);
            // 
            // S
            // 
            this.S.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.S.Location = new System.Drawing.Point(525, 103);
            this.S.Name = "S";
            this.S.ReadOnly = true;
            this.S.Size = new System.Drawing.Size(120, 36);
            this.S.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 185);
            this.Controls.Add(this.S);
            this.Controls.Add(this.P);
            this.Controls.Add(this.Slabel);
            this.Controls.Add(this.Plabel);
            this.Name = "Form1";
            this.Text = "Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.P)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Plabel;
        private System.Windows.Forms.Label Slabel;
        private System.Windows.Forms.NumericUpDown P;
        private System.Windows.Forms.TextBox S;
    }
}

