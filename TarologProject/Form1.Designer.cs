namespace TarologProject
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundButtonExit = new TarologProject.RoundButton();
            this.roundButtonMore = new TarologProject.RoundButton();
            this.roundButtonStart = new TarologProject.RoundButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.roundButtonExit);
            this.panel1.Controls.Add(this.roundButtonMore);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.roundButtonStart);
            this.panel1.Location = new System.Drawing.Point(163, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(980, 914);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 412);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(219, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(573, 50);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(33, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(895, 214);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // roundButtonExit
            // 
            this.roundButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.roundButtonExit.AnimationInterval = 1;
            this.roundButtonExit.AutoSize = true;
            this.roundButtonExit.BackColor = System.Drawing.Color.Transparent;
            this.roundButtonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButtonExit.BackgroundImage")));
            this.roundButtonExit.BackgroundSpeed = 40;
            this.roundButtonExit.BackHoverColor = System.Drawing.Color.HotPink;
            this.roundButtonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButtonExit.CustomButtonText = "Выход";
            this.roundButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonExit.Font = new System.Drawing.Font("Kudry Weird Headline", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.roundButtonExit.Location = new System.Drawing.Point(202, 762);
            this.roundButtonExit.Name = "roundButtonExit";
            this.roundButtonExit.Size = new System.Drawing.Size(600, 100);
            this.roundButtonExit.SmoothCorrectionFactor = 1.5D;
            this.roundButtonExit.TabIndex = 7;
            this.roundButtonExit.TextHoverColor = System.Drawing.Color.Bisque;
            this.toolTip1.SetToolTip(this.roundButtonExit, "Закончить сеанс");
            this.roundButtonExit.UseSmoothSpeedIncrement = true;
            this.roundButtonExit.UseVisualStyleBackColor = false;
            this.roundButtonExit.Click += new System.EventHandler(this.roundButtonExit_Click);
            // 
            // roundButtonMore
            // 
            this.roundButtonMore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.roundButtonMore.AnimationInterval = 1;
            this.roundButtonMore.AutoSize = true;
            this.roundButtonMore.BackColor = System.Drawing.Color.Transparent;
            this.roundButtonMore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButtonMore.BackgroundImage")));
            this.roundButtonMore.BackgroundSpeed = 40;
            this.roundButtonMore.BackHoverColor = System.Drawing.Color.HotPink;
            this.roundButtonMore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButtonMore.CustomButtonText = "Познать мудрость Таро";
            this.roundButtonMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonMore.Font = new System.Drawing.Font("Kudry Weird Headline", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButtonMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.roundButtonMore.Location = new System.Drawing.Point(202, 638);
            this.roundButtonMore.Name = "roundButtonMore";
            this.roundButtonMore.Size = new System.Drawing.Size(600, 100);
            this.roundButtonMore.SmoothCorrectionFactor = 1.5D;
            this.roundButtonMore.TabIndex = 6;
            this.roundButtonMore.TextHoverColor = System.Drawing.Color.Bisque;
            this.toolTip1.SetToolTip(this.roundButtonMore, "Узнать, как работает система гаданий");
            this.roundButtonMore.UseSmoothSpeedIncrement = true;
            this.roundButtonMore.UseVisualStyleBackColor = false;
            this.roundButtonMore.Click += new System.EventHandler(this.roundButtonMore_Click);
            // 
            // roundButtonStart
            // 
            this.roundButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.roundButtonStart.AnimationInterval = 1;
            this.roundButtonStart.AutoSize = true;
            this.roundButtonStart.BackColor = System.Drawing.Color.Transparent;
            this.roundButtonStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButtonStart.BackgroundImage")));
            this.roundButtonStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roundButtonStart.BackgroundSpeed = 40;
            this.roundButtonStart.BackHoverColor = System.Drawing.Color.HotPink;
            this.roundButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roundButtonStart.CustomButtonText = "Погрузиться в гадания";
            this.roundButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonStart.Font = new System.Drawing.Font("Kudry Weird Headline", 26F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(55)))), ((int)(((byte)(88)))));
            this.roundButtonStart.Location = new System.Drawing.Point(202, 515);
            this.roundButtonStart.Name = "roundButtonStart";
            this.roundButtonStart.Size = new System.Drawing.Size(600, 100);
            this.roundButtonStart.SmoothCorrectionFactor = 1.5D;
            this.roundButtonStart.TabIndex = 2;
            this.roundButtonStart.TextHoverColor = System.Drawing.Color.Bisque;
            this.toolTip1.SetToolTip(this.roundButtonStart, "Перейти к окну выбора тем предсказаний");
            this.roundButtonStart.UseSmoothSpeedIncrement = true;
            this.roundButtonStart.UseVisualStyleBackColor = false;
            this.roundButtonStart.Click += new System.EventHandler(this.roundButtonStart_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1278, 1069);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1300, 1000);
            this.Name = "MainPage";
            this.ShowInTaskbar = false;
            this.Text = "Главная страница";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundButton roundButtonStart;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private RoundButton roundButtonExit;
        private RoundButton roundButtonMore;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

