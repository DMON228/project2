namespace VKR
{
    partial class CargoControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.HeightBox = new System.Windows.Forms.TextBox();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.LengthBox = new System.Windows.Forms.TextBox();
            this.Done_Btn = new System.Windows.Forms.Button();
            this.Weight_lb = new System.Windows.Forms.Label();
            this.Weight_Txt = new System.Windows.Forms.TextBox();
            this.MaksWeight_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Maks_Lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeightBox
            // 
            this.HeightBox.BackColor = System.Drawing.SystemColors.Window;
            this.HeightBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightBox.ForeColor = System.Drawing.Color.Black;
            this.HeightBox.Location = new System.Drawing.Point(156, 146);
            this.HeightBox.Name = "HeightBox";
            this.HeightBox.Size = new System.Drawing.Size(92, 30);
            this.HeightBox.TabIndex = 0;
            this.HeightBox.Text = "0";
            this.HeightBox.Click += new System.EventHandler(this.HeightBox_Click);
            this.HeightBox.TextChanged += new System.EventHandler(this.HeightBox_TextChanged);
            this.HeightBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightBox_KeyPress);
            this.HeightBox.Leave += new System.EventHandler(this.HeightBox_Leave);
            // 
            // WidthBox
            // 
            this.WidthBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthBox.Location = new System.Drawing.Point(267, 146);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(92, 30);
            this.WidthBox.TabIndex = 1;
            this.WidthBox.Text = "0";
            this.WidthBox.Click += new System.EventHandler(this.WidthBox_Click);
            this.WidthBox.TextChanged += new System.EventHandler(this.WidthBox_TextChanged);
            this.WidthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthBox_KeyPress);
            this.WidthBox.Leave += new System.EventHandler(this.WidthBox_Leave);
            // 
            // LengthBox
            // 
            this.LengthBox.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthBox.Location = new System.Drawing.Point(379, 146);
            this.LengthBox.Name = "LengthBox";
            this.LengthBox.Size = new System.Drawing.Size(92, 30);
            this.LengthBox.TabIndex = 2;
            this.LengthBox.Text = "0";
            this.LengthBox.Click += new System.EventHandler(this.LengthBox_Click);
            this.LengthBox.TextChanged += new System.EventHandler(this.LengthBox_TextChanged);
            this.LengthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LengthBox_KeyPress);
            this.LengthBox.Leave += new System.EventHandler(this.LengthBox_Leave);
            // 
            // Done_Btn
            // 
            this.Done_Btn.BackColor = System.Drawing.Color.White;
            this.Done_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Done_Btn.FlatAppearance.BorderSize = 2;
            this.Done_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done_Btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Done_Btn.Location = new System.Drawing.Point(66, 361);
            this.Done_Btn.Name = "Done_Btn";
            this.Done_Btn.Size = new System.Drawing.Size(491, 38);
            this.Done_Btn.TabIndex = 48;
            this.Done_Btn.Text = "Готово";
            this.Done_Btn.UseVisualStyleBackColor = false;
            this.Done_Btn.Click += new System.EventHandler(this.Done_Btn_Click);
            // 
            // Weight_lb
            // 
            this.Weight_lb.AutoSize = true;
            this.Weight_lb.BackColor = System.Drawing.SystemColors.Control;
            this.Weight_lb.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weight_lb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Weight_lb.Location = new System.Drawing.Point(186, 292);
            this.Weight_lb.Name = "Weight_lb";
            this.Weight_lb.Size = new System.Drawing.Size(42, 15);
            this.Weight_lb.TabIndex = 46;
            this.Weight_lb.Text = "Вес, кг";
            // 
            // Weight_Txt
            // 
            this.Weight_Txt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weight_Txt.Location = new System.Drawing.Point(189, 310);
            this.Weight_Txt.Name = "Weight_Txt";
            this.Weight_Txt.Size = new System.Drawing.Size(118, 30);
            this.Weight_Txt.TabIndex = 47;
            this.Weight_Txt.Click += new System.EventHandler(this.Weight_Txt_Click);
            this.Weight_Txt.TextChanged += new System.EventHandler(this.Weight_Txt_TextChanged);
            this.Weight_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Weight_Txt_KeyPress);
            // 
            // MaksWeight_lbl
            // 
            this.MaksWeight_lbl.AutoSize = true;
            this.MaksWeight_lbl.BackColor = System.Drawing.SystemColors.Control;
            this.MaksWeight_lbl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaksWeight_lbl.ForeColor = System.Drawing.Color.Red;
            this.MaksWeight_lbl.Location = new System.Drawing.Point(186, 343);
            this.MaksWeight_lbl.Name = "MaksWeight_lbl";
            this.MaksWeight_lbl.Size = new System.Drawing.Size(203, 15);
            this.MaksWeight_lbl.TabIndex = 50;
            this.MaksWeight_lbl.Text = "Максимальный вес одного места 50";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::VKR.Properties.Resources.CargoRu;
            this.panel1.Controls.Add(this.Maks_Lbl);
            this.panel1.Location = new System.Drawing.Point(66, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 279);
            this.panel1.TabIndex = 3;
            // 
            // Maks_Lbl
            // 
            this.Maks_Lbl.AutoSize = true;
            this.Maks_Lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(189)))), ((int)(((byte)(0)))));
            this.Maks_Lbl.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Maks_Lbl.ForeColor = System.Drawing.Color.Red;
            this.Maks_Lbl.Location = new System.Drawing.Point(87, 217);
            this.Maks_Lbl.Name = "Maks_Lbl";
            this.Maks_Lbl.Size = new System.Drawing.Size(285, 15);
            this.Maks_Lbl.TabIndex = 49;
            this.Maks_Lbl.Text = "Максимально допустимые размеры - 120x80x80см";
            // 
            // CargoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaksWeight_lbl);
            this.Controls.Add(this.Done_Btn);
            this.Controls.Add(this.Weight_lb);
            this.Controls.Add(this.Weight_Txt);
            this.Controls.Add(this.LengthBox);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.HeightBox);
            this.Controls.Add(this.panel1);
            this.Name = "CargoControl";
            this.Size = new System.Drawing.Size(660, 421);
            this.Load += new System.EventHandler(this.CargoControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Weight_lb;
        private System.Windows.Forms.Label Maks_Lbl;
        private System.Windows.Forms.Label MaksWeight_lbl;
        public System.Windows.Forms.TextBox WidthBox;
        public System.Windows.Forms.TextBox LengthBox;
        public System.Windows.Forms.TextBox Weight_Txt;
        public System.Windows.Forms.TextBox HeightBox;
        public System.Windows.Forms.Button Done_Btn;
    }
}
