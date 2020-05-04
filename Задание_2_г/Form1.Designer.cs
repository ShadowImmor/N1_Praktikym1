namespace Задание_2_г
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
            this.Chlabel = new System.Windows.Forms.Label();
            this.Otlabel = new System.Windows.Forms.Label();
            this.Ot = new System.Windows.Forms.TextBox();
            this.Ch = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Ch)).BeginInit();
            this.SuspendLayout();
            // 
            // Chlabel
            // 
            this.Chlabel.AutoSize = true;
            this.Chlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Chlabel.Location = new System.Drawing.Point(27, 26);
            this.Chlabel.Name = "Chlabel";
            this.Chlabel.Size = new System.Drawing.Size(523, 28);
            this.Chlabel.TabIndex = 0;
            this.Chlabel.Text = "Введите целое число, для проверки чётности";
            // 
            // Otlabel
            // 
            this.Otlabel.AutoSize = true;
            this.Otlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Otlabel.Location = new System.Drawing.Point(27, 93);
            this.Otlabel.Name = "Otlabel";
            this.Otlabel.Size = new System.Drawing.Size(437, 28);
            this.Otlabel.TabIndex = 1;
            this.Otlabel.Text = "Является ли введённое число чётным";
            // 
            // Ot
            // 
            this.Ot.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ot.Location = new System.Drawing.Point(561, 93);
            this.Ot.Name = "Ot";
            this.Ot.ReadOnly = true;
            this.Ot.Size = new System.Drawing.Size(135, 36);
            this.Ot.TabIndex = 2;
            // 
            // Ch
            // 
            this.Ch.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ch.Location = new System.Drawing.Point(576, 24);
            this.Ch.Name = "Ch";
            this.Ch.Size = new System.Drawing.Size(120, 36);
            this.Ch.TabIndex = 3;
            this.Ch.ValueChanged += new System.EventHandler(this.Ch_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 148);
            this.Controls.Add(this.Ch);
            this.Controls.Add(this.Ot);
            this.Controls.Add(this.Otlabel);
            this.Controls.Add(this.Chlabel);
            this.Name = "Form1";
            this.Text = "Задание 2";
            ((System.ComponentModel.ISupportInitialize)(this.Ch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Chlabel;
        private System.Windows.Forms.Label Otlabel;
        private System.Windows.Forms.TextBox Ot;
        private System.Windows.Forms.NumericUpDown Ch;
    }
}

