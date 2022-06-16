namespace diplom_work
{
    partial class confirm_form
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
            this.yes_btn = new System.Windows.Forms.Button();
            this.no_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fio_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.product_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yes_btn
            // 
            this.yes_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.yes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yes_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.yes_btn.Location = new System.Drawing.Point(36, 195);
            this.yes_btn.Name = "yes_btn";
            this.yes_btn.Size = new System.Drawing.Size(111, 40);
            this.yes_btn.TabIndex = 17;
            this.yes_btn.Text = "Да";
            this.yes_btn.UseVisualStyleBackColor = false;
            this.yes_btn.Click += new System.EventHandler(this.yes_btn_Click);
            // 
            // no_btn
            // 
            this.no_btn.BackColor = System.Drawing.Color.Red;
            this.no_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.no_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.no_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.no_btn.Location = new System.Drawing.Point(272, 195);
            this.no_btn.Name = "no_btn";
            this.no_btn.Size = new System.Drawing.Size(111, 40);
            this.no_btn.TabIndex = 18;
            this.no_btn.Text = "Нет";
            this.no_btn.UseVisualStyleBackColor = false;
            this.no_btn.Click += new System.EventHandler(this.no_btn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Пользователь:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fio_lbl
            // 
            this.fio_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_lbl.ForeColor = System.Drawing.Color.White;
            this.fio_lbl.Location = new System.Drawing.Point(1, 51);
            this.fio_lbl.Name = "fio_lbl";
            this.fio_lbl.Size = new System.Drawing.Size(409, 24);
            this.fio_lbl.TabIndex = 20;
            this.fio_lbl.Text = "Имя";
            this.fio_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Сдал инвентарь:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product_lbl
            // 
            this.product_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_lbl.ForeColor = System.Drawing.Color.White;
            this.product_lbl.Location = new System.Drawing.Point(1, 118);
            this.product_lbl.Name = "product_lbl";
            this.product_lbl.Size = new System.Drawing.Size(409, 66);
            this.product_lbl.TabIndex = 22;
            this.product_lbl.Text = "Инвентарь";
            this.product_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // confirm_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(410, 247);
            this.Controls.Add(this.product_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fio_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.no_btn);
            this.Controls.Add(this.yes_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "confirm_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "confirm_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yes_btn;
        private System.Windows.Forms.Button no_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fio_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label product_lbl;
    }
}