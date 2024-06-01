namespace TarologProject.Pages
{
    partial class MoreForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoreForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundButtonMain = new TarologProject.RoundButton();
            this.roundButtonTopics = new TarologProject.RoundButton();
            this.roundButtonExit = new TarologProject.RoundButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.roundButtonMain);
            this.panel2.Controls.Add(this.roundButtonTopics);
            this.panel2.Controls.Add(this.roundButtonExit);
            this.panel2.Location = new System.Drawing.Point(212, 837);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 99);
            this.panel2.TabIndex = 13;
            // 
            // roundButtonMain
            // 
            this.roundButtonMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.roundButtonMain.AnimationInterval = 1;
            this.roundButtonMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.roundButtonMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButtonMain.BackgroundImage")));
            this.roundButtonMain.BackgroundSpeed = 40;
            this.roundButtonMain.BackHoverColor = System.Drawing.Color.HotPink;
            this.roundButtonMain.CustomButtonText = "Главная страница";
            this.roundButtonMain.FlatAppearance.BorderSize = 0;
            this.roundButtonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonMain.Font = new System.Drawing.Font("Inter Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(46)))), ((int)(((byte)(89)))));
            this.roundButtonMain.Location = new System.Drawing.Point(604, 18);
            this.roundButtonMain.Name = "roundButtonMain";
            this.roundButtonMain.Size = new System.Drawing.Size(210, 54);
            this.roundButtonMain.SmoothCorrectionFactor = 1.5D;
            this.roundButtonMain.TabIndex = 2;
            this.roundButtonMain.TextHoverColor = System.Drawing.Color.Bisque;
            this.toolTip1.SetToolTip(this.roundButtonMain, "Перейти в главное меню");
            this.roundButtonMain.UseSmoothSpeedIncrement = true;
            this.roundButtonMain.UseVisualStyleBackColor = false;
            this.roundButtonMain.Click += new System.EventHandler(this.roundButtonMain_Click);
            // 
            // roundButtonTopics
            // 
            this.roundButtonTopics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.roundButtonTopics.AnimationInterval = 1;
            this.roundButtonTopics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.roundButtonTopics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButtonTopics.BackgroundImage")));
            this.roundButtonTopics.BackgroundSpeed = 40;
            this.roundButtonTopics.BackHoverColor = System.Drawing.Color.HotPink;
            this.roundButtonTopics.CustomButtonText = "Погадать";
            this.roundButtonTopics.FlatAppearance.BorderSize = 0;
            this.roundButtonTopics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonTopics.Font = new System.Drawing.Font("Inter Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonTopics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(46)))), ((int)(((byte)(89)))));
            this.roundButtonTopics.Location = new System.Drawing.Point(321, 18);
            this.roundButtonTopics.Name = "roundButtonTopics";
            this.roundButtonTopics.Size = new System.Drawing.Size(210, 55);
            this.roundButtonTopics.SmoothCorrectionFactor = 1.5D;
            this.roundButtonTopics.TabIndex = 1;
            this.roundButtonTopics.TextHoverColor = System.Drawing.Color.Bisque;
            this.toolTip1.SetToolTip(this.roundButtonTopics, "Перейти к окну выбора тем предсказаний");
            this.roundButtonTopics.UseSmoothSpeedIncrement = true;
            this.roundButtonTopics.UseVisualStyleBackColor = false;
            this.roundButtonTopics.Click += new System.EventHandler(this.roundButtonTopics_Click);
            // 
            // roundButtonExit
            // 
            this.roundButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.roundButtonExit.AnimationInterval = 1;
            this.roundButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.roundButtonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundButtonExit.BackgroundImage")));
            this.roundButtonExit.BackgroundSpeed = 40;
            this.roundButtonExit.BackHoverColor = System.Drawing.Color.HotPink;
            this.roundButtonExit.CustomButtonText = "Выход";
            this.roundButtonExit.FlatAppearance.BorderSize = 0;
            this.roundButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButtonExit.Font = new System.Drawing.Font("Inter Light", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(46)))), ((int)(((byte)(89)))));
            this.roundButtonExit.Location = new System.Drawing.Point(26, 18);
            this.roundButtonExit.Name = "roundButtonExit";
            this.roundButtonExit.Size = new System.Drawing.Size(210, 54);
            this.roundButtonExit.SmoothCorrectionFactor = 1.5D;
            this.roundButtonExit.TabIndex = 0;
            this.roundButtonExit.TextHoverColor = System.Drawing.Color.Bisque;
            this.toolTip1.SetToolTip(this.roundButtonExit, "Закончить сеанс");
            this.roundButtonExit.UseSmoothSpeedIncrement = true;
            this.roundButtonExit.UseVisualStyleBackColor = false;
            this.roundButtonExit.Click += new System.EventHandler(this.roundButtonExit_Click);
            // 
            // MoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 948);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoreForm";
            this.Text = "Узнать больше о гаданиях";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private RoundButton roundButtonMain;
        private RoundButton roundButtonTopics;
        private RoundButton roundButtonExit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}