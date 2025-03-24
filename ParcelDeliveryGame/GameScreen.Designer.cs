namespace ParcelDeliveryGame
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.backLabel = new System.Windows.Forms.Label();
            this.seperateLabal = new System.Windows.Forms.Label();
            this.textLabel1 = new System.Windows.Forms.Label();
            this.targetLabel = new System.Windows.Forms.Label();
            this.textLabel2 = new System.Windows.Forms.Label();
            this.deliveriesMadeLabel = new System.Windows.Forms.Label();
            this.stopwatch = new System.Windows.Forms.Timer(this.components);
            this.logoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // backLabel
            // 
            this.backLabel.BackColor = System.Drawing.Color.Moccasin;
            this.backLabel.Location = new System.Drawing.Point(8, 8);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(184, 434);
            this.backLabel.TabIndex = 0;
            // 
            // seperateLabal
            // 
            this.seperateLabal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.seperateLabal.Location = new System.Drawing.Point(198, 0);
            this.seperateLabal.Name = "seperateLabal";
            this.seperateLabal.Size = new System.Drawing.Size(5, 450);
            this.seperateLabal.TabIndex = 1;
            this.seperateLabal.Text = "label1";
            // 
            // textLabel1
            // 
            this.textLabel1.BackColor = System.Drawing.Color.Moccasin;
            this.textLabel1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel1.Location = new System.Drawing.Point(59, 31);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(80, 23);
            this.textLabel1.TabIndex = 2;
            this.textLabel1.Text = "Target:";
            this.textLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // targetLabel
            // 
            this.targetLabel.BackColor = System.Drawing.Color.Moccasin;
            this.targetLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetLabel.ForeColor = System.Drawing.Color.DimGray;
            this.targetLabel.Location = new System.Drawing.Point(21, 68);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(156, 23);
            this.targetLabel.TabIndex = 3;
            this.targetLabel.Text = "Text";
            this.targetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textLabel2
            // 
            this.textLabel2.BackColor = System.Drawing.Color.Moccasin;
            this.textLabel2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel2.Location = new System.Drawing.Point(45, 208);
            this.textLabel2.Name = "textLabel2";
            this.textLabel2.Size = new System.Drawing.Size(118, 23);
            this.textLabel2.TabIndex = 4;
            this.textLabel2.Text = "Deliveries:";
            this.textLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deliveriesMadeLabel
            // 
            this.deliveriesMadeLabel.BackColor = System.Drawing.Color.Moccasin;
            this.deliveriesMadeLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveriesMadeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.deliveriesMadeLabel.Location = new System.Drawing.Point(23, 241);
            this.deliveriesMadeLabel.Name = "deliveriesMadeLabel";
            this.deliveriesMadeLabel.Size = new System.Drawing.Size(156, 23);
            this.deliveriesMadeLabel.TabIndex = 5;
            this.deliveriesMadeLabel.Text = "Text";
            this.deliveriesMadeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopwatch
            // 
            this.stopwatch.Interval = 30000;
            this.stopwatch.Tick += new System.EventHandler(this.stopwatch_Tick);
            // 
            // logoLabel
            // 
            this.logoLabel.BackColor = System.Drawing.Color.Moccasin;
            this.logoLabel.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoLabel.ForeColor = System.Drawing.Color.DimGray;
            this.logoLabel.Image = ((System.Drawing.Image)(resources.GetObject("logoLabel.Image")));
            this.logoLabel.Location = new System.Drawing.Point(7, 125);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(185, 73);
            this.logoLabel.TabIndex = 6;
            this.logoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.Controls.Add(this.logoLabel);
            this.Controls.Add(this.deliveriesMadeLabel);
            this.Controls.Add(this.textLabel2);
            this.Controls.Add(this.targetLabel);
            this.Controls.Add(this.textLabel1);
            this.Controls.Add(this.seperateLabal);
            this.Controls.Add(this.backLabel);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1050, 450);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label seperateLabal;
        private System.Windows.Forms.Label textLabel1;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.Label textLabel2;
        private System.Windows.Forms.Label deliveriesMadeLabel;
        private System.Windows.Forms.Timer stopwatch;
        private System.Windows.Forms.Label logoLabel;
    }
}
