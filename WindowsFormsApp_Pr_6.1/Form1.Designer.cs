namespace WindowsFormsApp_Pr_6._1
{
    partial class PetShop
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
            this.TurtleLook = new System.Windows.Forms.Button();
            this.FoodBuy = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Map = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TurtleLook
            // 
            this.TurtleLook.BackgroundImage = global::WindowsFormsApp_Pr_6._1.Properties.Resources.pet2;
            this.TurtleLook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TurtleLook.Location = new System.Drawing.Point(39, 235);
            this.TurtleLook.Name = "TurtleLook";
            this.TurtleLook.Size = new System.Drawing.Size(276, 183);
            this.TurtleLook.TabIndex = 0;
            this.TurtleLook.UseVisualStyleBackColor = true;
            this.TurtleLook.Click += new System.EventHandler(this.TurtleLook_Click);
            // 
            // FoodBuy
            // 
            this.FoodBuy.BackgroundImage = global::WindowsFormsApp_Pr_6._1.Properties.Resources.pet3;
            this.FoodBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FoodBuy.Location = new System.Drawing.Point(1012, 115);
            this.FoodBuy.Name = "FoodBuy";
            this.FoodBuy.Size = new System.Drawing.Size(212, 117);
            this.FoodBuy.TabIndex = 1;
            this.FoodBuy.UseVisualStyleBackColor = true;
            this.FoodBuy.Click += new System.EventHandler(this.FoodBuy_Click);
            // 
            // Exit
            // 
            this.Exit.BackgroundImage = global::WindowsFormsApp_Pr_6._1.Properties.Resources.exit;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(1059, 460);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(176, 71);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "ВЫХОД --->";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.ExitClick);
            // 
            // Map
            // 
            this.Map.BackgroundImage = global::WindowsFormsApp_Pr_6._1.Properties.Resources.карта3;
            this.Map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Map.Location = new System.Drawing.Point(9, 521);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(169, 85);
            this.Map.TabIndex = 4;
            this.Map.UseVisualStyleBackColor = true;
            this.Map.Click += new System.EventHandler(this.Map_Click);
            // 
            // PetShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp_Pr_6._1.Properties.Resources.pet;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1247, 707);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.FoodBuy);
            this.Controls.Add(this.TurtleLook);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PetShop";
            this.Text = "Хвосты и лапы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TurtleLook;
        private System.Windows.Forms.Button FoodBuy;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Map;
    }
}

