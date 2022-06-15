namespace VKR
{
    public partial class Cargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargo));
            this.label1 = new System.Windows.Forms.Label();
            this.Weight_cargo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dimensions_cargo = new System.Windows.Forms.Label();
            this.SettingsCargo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Name = "label1";
            // 
            // Weight_cargo
            // 
            resources.ApplyResources(this.Weight_cargo, "Weight_cargo");
            this.Weight_cargo.Name = "Weight_cargo";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Name = "label3";
            // 
            // Dimensions_cargo
            // 
            resources.ApplyResources(this.Dimensions_cargo, "Dimensions_cargo");
            this.Dimensions_cargo.Name = "Dimensions_cargo";
            // 
            // SettingsCargo
            // 
            resources.ApplyResources(this.SettingsCargo, "SettingsCargo");
            this.SettingsCargo.BackgroundImage = global::VKR.Properties.Resources.Settings_30027;
            this.SettingsCargo.FlatAppearance.BorderSize = 0;
            this.SettingsCargo.Name = "SettingsCargo";
            this.SettingsCargo.UseVisualStyleBackColor = true;
            this.SettingsCargo.Click += new System.EventHandler(this.SettingsCargo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VKR.Properties.Resources.Cargolog;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Cargo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.SettingsCargo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Dimensions_cargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Weight_cargo);
            this.Controls.Add(this.label1);
            this.Name = "Cargo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label Weight_cargo;
        public System.Windows.Forms.Label Dimensions_cargo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button SettingsCargo;
    }
}
