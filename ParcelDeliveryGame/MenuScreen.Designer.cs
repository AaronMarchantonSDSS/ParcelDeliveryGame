namespace ParcelDeliveryGame
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuScreen));
            this.startButton = new System.Windows.Forms.Button();
            this.instructionsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.logoLabel1 = new System.Windows.Forms.Label();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.startButton.FlatAppearance.BorderSize = 3;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(375, 268);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(301, 90);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "S T A R T";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // instructionsButton
            // 
            this.instructionsButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.instructionsButton.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.instructionsButton.FlatAppearance.BorderSize = 3;
            this.instructionsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.instructionsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.instructionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructionsButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsButton.Location = new System.Drawing.Point(375, 362);
            this.instructionsButton.Margin = new System.Windows.Forms.Padding(2);
            this.instructionsButton.Name = "instructionsButton";
            this.instructionsButton.Size = new System.Drawing.Size(201, 38);
            this.instructionsButton.TabIndex = 1;
            this.instructionsButton.Text = "INSTRUCTIONS";
            this.instructionsButton.UseVisualStyleBackColor = false;
            this.instructionsButton.Click += new System.EventHandler(this.instructionsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.exitButton.FlatAppearance.BorderSize = 3;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(580, 362);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 38);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // logoLabel1
            // 
            this.logoLabel1.Image = ((System.Drawing.Image)(resources.GetObject("logoLabel1.Image")));
            this.logoLabel1.Location = new System.Drawing.Point(327, 22);
            this.logoLabel1.Name = "logoLabel1";
            this.logoLabel1.Size = new System.Drawing.Size(395, 173);
            this.logoLabel1.TabIndex = 3;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.BackColor = System.Drawing.Color.LightBlue;
            this.gameOverLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(375, 214);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(301, 23);
            this.gameOverLabel.TabIndex = 4;
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.logoLabel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.instructionsButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(1050, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button instructionsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label logoLabel1;
        private System.Windows.Forms.Label gameOverLabel;
    }
}
