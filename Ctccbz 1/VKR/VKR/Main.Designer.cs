namespace VKR
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.DeliveryRusBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpressDeliveryRus = new System.Windows.Forms.ToolStripMenuItem();
            this.RegularDeliveryRus = new System.Windows.Forms.ToolStripMenuItem();
            this.DeliveryInterBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpressDeliveryInter = new System.Windows.Forms.ToolStripMenuItem();
            this.RegularDeliveryInter = new System.Windows.Forms.ToolStripMenuItem();
            this.TrackingBtn = new System.Windows.Forms.Button();
            this.Calc_Btn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.Gold;
            this.Menu.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeliveryRusBtn,
            this.DeliveryInterBtn});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(489, 31);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // DeliveryRusBtn
            // 
            this.DeliveryRusBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExpressDeliveryRus,
            this.RegularDeliveryRus});
            this.DeliveryRusBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryRusBtn.Name = "DeliveryRusBtn";
            this.DeliveryRusBtn.Size = new System.Drawing.Size(173, 27);
            this.DeliveryRusBtn.Text = "Доставка по России";
            // 
            // ExpressDeliveryRus
            // 
            this.ExpressDeliveryRus.Name = "ExpressDeliveryRus";
            this.ExpressDeliveryRus.Size = new System.Drawing.Size(231, 28);
            this.ExpressDeliveryRus.Text = "Экспресс-дооставка";
            this.ExpressDeliveryRus.Click += new System.EventHandler(this.ExpressDeliveryRus_Click);
            // 
            // RegularDeliveryRus
            // 
            this.RegularDeliveryRus.Name = "RegularDeliveryRus";
            this.RegularDeliveryRus.Size = new System.Drawing.Size(231, 28);
            this.RegularDeliveryRus.Text = "Обычная доставка";
            this.RegularDeliveryRus.Click += new System.EventHandler(this.RegularDeliveryRus_Click);
            // 
            // DeliveryInterBtn
            // 
            this.DeliveryInterBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExpressDeliveryInter,
            this.RegularDeliveryInter});
            this.DeliveryInterBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliveryInterBtn.Name = "DeliveryInterBtn";
            this.DeliveryInterBtn.Size = new System.Drawing.Size(214, 27);
            this.DeliveryInterBtn.Text = "Международная доставка";
            // 
            // ExpressDeliveryInter
            // 
            this.ExpressDeliveryInter.Name = "ExpressDeliveryInter";
            this.ExpressDeliveryInter.Size = new System.Drawing.Size(222, 28);
            this.ExpressDeliveryInter.Text = "Экспресс-доставка";
            // 
            // RegularDeliveryInter
            // 
            this.RegularDeliveryInter.Name = "RegularDeliveryInter";
            this.RegularDeliveryInter.Size = new System.Drawing.Size(222, 28);
            this.RegularDeliveryInter.Text = "Обычная доставка";
            this.RegularDeliveryInter.Click += new System.EventHandler(this.RegularDeliveryInter_Click);
            // 
            // TrackingBtn
            // 
            this.TrackingBtn.BackColor = System.Drawing.Color.White;
            this.TrackingBtn.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.TrackingBtn.FlatAppearance.BorderSize = 2;
            this.TrackingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrackingBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TrackingBtn.Location = new System.Drawing.Point(13, 60);
            this.TrackingBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TrackingBtn.Name = "TrackingBtn";
            this.TrackingBtn.Size = new System.Drawing.Size(212, 56);
            this.TrackingBtn.TabIndex = 1;
            this.TrackingBtn.Text = "Отслеживание товара";
            this.TrackingBtn.UseVisualStyleBackColor = false;
            this.TrackingBtn.Click += new System.EventHandler(this.TrackingBtn_Click);
            // 
            // Calc_Btn
            // 
            this.Calc_Btn.BackColor = System.Drawing.Color.White;
            this.Calc_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Calc_Btn.FlatAppearance.BorderSize = 2;
            this.Calc_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calc_Btn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calc_Btn.Location = new System.Drawing.Point(13, 132);
            this.Calc_Btn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Calc_Btn.Name = "Calc_Btn";
            this.Calc_Btn.Size = new System.Drawing.Size(212, 59);
            this.Calc_Btn.TabIndex = 2;
            this.Calc_Btn.Text = "Калькулятор расчета стоимости";
            this.Calc_Btn.UseVisualStyleBackColor = false;
            this.Calc_Btn.Click += new System.EventHandler(this.Calc_Btn_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.Image = global::VKR.Properties.Resources.Logo1;
            this.Logo.Location = new System.Drawing.Point(393, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(96, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 229);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Calc_Btn);
            this.Controls.Add(this.TrackingBtn);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem DeliveryRusBtn;
        private System.Windows.Forms.ToolStripMenuItem ExpressDeliveryRus;
        private System.Windows.Forms.ToolStripMenuItem RegularDeliveryRus;
        private System.Windows.Forms.ToolStripMenuItem DeliveryInterBtn;
        private System.Windows.Forms.ToolStripMenuItem ExpressDeliveryInter;
        private System.Windows.Forms.ToolStripMenuItem RegularDeliveryInter;
        private System.Windows.Forms.Button TrackingBtn;
        private System.Windows.Forms.Button Calc_Btn;
        public new System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.PictureBox Logo;
    }
}

