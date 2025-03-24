namespace ParcelDeliveryGame
{
    partial class InstructionScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionScreen));
            this.logoLabel1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.textLabel1 = new System.Windows.Forms.Label();
            this.textLabel2 = new System.Windows.Forms.Label();
            this.textLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logoLabel1
            // 
            this.logoLabel1.Image = ((System.Drawing.Image)(resources.GetObject("logoLabel1.Image")));
            this.logoLabel1.Location = new System.Drawing.Point(328, 29);
            this.logoLabel1.Name = "logoLabel1";
            this.logoLabel1.Size = new System.Drawing.Size(395, 173);
            this.logoLabel1.TabIndex = 4;
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
            this.exitButton.Location = new System.Drawing.Point(580, 377);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 38);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.Moccasin;
            this.menuButton.FlatAppearance.BorderSize = 3;
            this.menuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.menuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(375, 377);
            this.menuButton.Margin = new System.Windows.Forms.Padding(2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(201, 38);
            this.menuButton.TabIndex = 5;
            this.menuButton.Text = "MENU";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // textLabel1
            // 
            this.textLabel1.BackColor = System.Drawing.Color.Transparent;
            this.textLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textLabel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel1.ForeColor = System.Drawing.Color.Black;
            this.textLabel1.Location = new System.Drawing.Point(251, 149);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(549, 93);
            this.textLabel1.TabIndex = 7;
            this.textLabel1.Text = "You are a parcel delivery person. Your mission is to fly around the world deliver" +
    "ing parcels to the continent in need. This is displayed in the left most border " +
    "of the game screen. ";
            this.textLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textLabel2
            // 
            this.textLabel2.BackColor = System.Drawing.Color.Transparent;
            this.textLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textLabel2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel2.ForeColor = System.Drawing.Color.Black;
            this.textLabel2.Location = new System.Drawing.Point(251, 251);
            this.textLabel2.Name = "textLabel2";
            this.textLabel2.Size = new System.Drawing.Size(549, 47);
            this.textLabel2.TabIndex = 8;
            this.textLabel2.Text = "How do you win and how do you lose? Simple you win by delivering 12 parcels befor" +
    "e the 30 second clock expires. ";
            this.textLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textLabel3
            // 
            this.textLabel3.BackColor = System.Drawing.Color.Transparent;
            this.textLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textLabel3.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel3.ForeColor = System.Drawing.Color.Black;
            this.textLabel3.Location = new System.Drawing.Point(251, 315);
            this.textLabel3.Name = "textLabel3";
            this.textLabel3.Size = new System.Drawing.Size(549, 47);
            this.textLabel3.TabIndex = 9;
            this.textLabel3.Text = "Use the arrow keys to move and the space bar to drop a package.";
            this.textLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.textLabel3);
            this.Controls.Add(this.textLabel2);
            this.Controls.Add(this.textLabel1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.logoLabel1);
            this.Name = "InstructionScreen";
            this.Size = new System.Drawing.Size(1050, 450);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label logoLabel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label textLabel1;
        private System.Windows.Forms.Label textLabel2;
        private System.Windows.Forms.Label textLabel3;
    }
}
