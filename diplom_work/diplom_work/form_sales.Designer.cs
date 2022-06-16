namespace diplom_work
{
    partial class form_sales
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
            this.cost_lbl = new System.Windows.Forms.Label();
            this.fio_lbl = new System.Windows.Forms.Label();
            this.product_name_CB = new System.Windows.Forms.ComboBox();
            this.hour_nud = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit_lbl = new System.Windows.Forms.Label();
            this.buy_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hour_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // cost_lbl
            // 
            this.cost_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost_lbl.ForeColor = System.Drawing.Color.Lime;
            this.cost_lbl.Location = new System.Drawing.Point(48, 258);
            this.cost_lbl.Name = "cost_lbl";
            this.cost_lbl.Size = new System.Drawing.Size(354, 35);
            this.cost_lbl.TabIndex = 4;
            this.cost_lbl.Text = "0 р";
            this.cost_lbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // fio_lbl
            // 
            this.fio_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_lbl.ForeColor = System.Drawing.Color.White;
            this.fio_lbl.Location = new System.Drawing.Point(2, 42);
            this.fio_lbl.Name = "fio_lbl";
            this.fio_lbl.Size = new System.Drawing.Size(409, 24);
            this.fio_lbl.TabIndex = 0;
            this.fio_lbl.Text = "Имя";
            this.fio_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product_name_CB
            // 
            this.product_name_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_name_CB.FormattingEnabled = true;
            this.product_name_CB.Location = new System.Drawing.Point(25, 109);
            this.product_name_CB.Name = "product_name_CB";
            this.product_name_CB.Size = new System.Drawing.Size(369, 28);
            this.product_name_CB.TabIndex = 1;
            this.product_name_CB.SelectedIndexChanged += new System.EventHandler(this.product_name_CB_SelectedIndexChanged);
            // 
            // hour_nud
            // 
            this.hour_nud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hour_nud.Location = new System.Drawing.Point(149, 176);
            this.hour_nud.Name = "hour_nud";
            this.hour_nud.Size = new System.Drawing.Size(120, 26);
            this.hour_nud.TabIndex = 2;
            this.hour_nud.ValueChanged += new System.EventHandler(this.hour_nud_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(120, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время аренды(часов):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(182, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Товар";
            // 
            // exit_lbl
            // 
            this.exit_lbl.AutoSize = true;
            this.exit_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_lbl.ForeColor = System.Drawing.Color.White;
            this.exit_lbl.Location = new System.Drawing.Point(387, 2);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(24, 24);
            this.exit_lbl.TabIndex = 6;
            this.exit_lbl.Text = "X";
            this.exit_lbl.Click += new System.EventHandler(this.exit_lbl_Click);
            // 
            // buy_btn
            // 
            this.buy_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.buy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buy_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buy_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.buy_btn.Location = new System.Drawing.Point(161, 218);
            this.buy_btn.Name = "buy_btn";
            this.buy_btn.Size = new System.Drawing.Size(97, 31);
            this.buy_btn.TabIndex = 17;
            this.buy_btn.Text = "Пробить";
            this.buy_btn.UseVisualStyleBackColor = false;
            this.buy_btn.Click += new System.EventHandler(this.buy_btn_Click);
            // 
            // form_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(414, 302);
            this.Controls.Add(this.buy_btn);
            this.Controls.Add(this.exit_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cost_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hour_nud);
            this.Controls.Add(this.product_name_CB);
            this.Controls.Add(this.fio_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_sales";
            ((System.ComponentModel.ISupportInitialize)(this.hour_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cost_lbl;
        private System.Windows.Forms.Label fio_lbl;
        private System.Windows.Forms.ComboBox product_name_CB;
        private System.Windows.Forms.NumericUpDown hour_nud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label exit_lbl;
        private System.Windows.Forms.Button buy_btn;
    }
}