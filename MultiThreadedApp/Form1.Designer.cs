namespace MultiThreadedApp
{
    partial class Form1
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
            this.pTarget = new System.Windows.Forms.Panel();
            this.bBike1 = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.bBike2 = new System.Windows.Forms.Button();
            this.bBike3 = new System.Windows.Forms.Button();
            this.bStep1 = new System.Windows.Forms.Button();
            this.pStart = new System.Windows.Forms.Panel();
            this.pRest = new System.Windows.Forms.Panel();
            this.bStep2 = new System.Windows.Forms.Button();
            this.bPixelCount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pTarget
            // 
            this.pTarget.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pTarget.Location = new System.Drawing.Point(725, 75);
            this.pTarget.Name = "pTarget";
            this.pTarget.Size = new System.Drawing.Size(190, 282);
            this.pTarget.TabIndex = 0;
            this.pTarget.Paint += new System.Windows.Forms.PaintEventHandler(this.pTarget_Paint);
            // 
            // bBike1
            // 
            this.bBike1.Font = new System.Drawing.Font("Webdings", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bBike1.Location = new System.Drawing.Point(12, 75);
            this.bBike1.Name = "bBike1";
            this.bBike1.Size = new System.Drawing.Size(150, 90);
            this.bBike1.TabIndex = 0;
            this.bBike1.Text = "b";
            this.bBike1.UseVisualStyleBackColor = true;
            this.bBike1.Click += new System.EventHandler(this.bike_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 363);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(150, 50);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bBike2
            // 
            this.bBike2.Font = new System.Drawing.Font("Webdings", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bBike2.Location = new System.Drawing.Point(12, 171);
            this.bBike2.Name = "bBike2";
            this.bBike2.Size = new System.Drawing.Size(150, 90);
            this.bBike2.TabIndex = 2;
            this.bBike2.Text = "b";
            this.bBike2.UseVisualStyleBackColor = true;
            this.bBike2.Click += new System.EventHandler(this.bike_Click);
            // 
            // bBike3
            // 
            this.bBike3.Font = new System.Drawing.Font("Webdings", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.bBike3.Location = new System.Drawing.Point(12, 267);
            this.bBike3.Name = "bBike3";
            this.bBike3.Size = new System.Drawing.Size(150, 90);
            this.bBike3.TabIndex = 3;
            this.bBike3.Text = "b";
            this.bBike3.UseVisualStyleBackColor = true;
            this.bBike3.Click += new System.EventHandler(this.bike_Click);
            // 
            // bStep1
            // 
            this.bStep1.Location = new System.Drawing.Point(223, 363);
            this.bStep1.Name = "bStep1";
            this.bStep1.Size = new System.Drawing.Size(190, 50);
            this.bStep1.TabIndex = 4;
            this.bStep1.Text = "Step1";
            this.bStep1.UseVisualStyleBackColor = true;
            this.bStep1.Click += new System.EventHandler(this.bStep1_Click);
            // 
            // pStart
            // 
            this.pStart.BackColor = System.Drawing.Color.SlateGray;
            this.pStart.Location = new System.Drawing.Point(223, 75);
            this.pStart.Name = "pStart";
            this.pStart.Size = new System.Drawing.Size(190, 282);
            this.pStart.TabIndex = 1;
            // 
            // pRest
            // 
            this.pRest.BackColor = System.Drawing.Color.SkyBlue;
            this.pRest.Location = new System.Drawing.Point(474, 75);
            this.pRest.Name = "pRest";
            this.pRest.Size = new System.Drawing.Size(190, 282);
            this.pRest.TabIndex = 2;
            // 
            // bStep2
            // 
            this.bStep2.Location = new System.Drawing.Point(474, 363);
            this.bStep2.Name = "bStep2";
            this.bStep2.Size = new System.Drawing.Size(190, 50);
            this.bStep2.TabIndex = 5;
            this.bStep2.Text = "Step2";
            this.bStep2.UseVisualStyleBackColor = true;
            this.bStep2.Click += new System.EventHandler(this.bStep2_Click);
            // 
            // bPixelCount
            // 
            this.bPixelCount.Location = new System.Drawing.Point(725, 363);
            this.bPixelCount.Name = "bPixelCount";
            this.bPixelCount.Size = new System.Drawing.Size(190, 50);
            this.bPixelCount.TabIndex = 6;
            this.bPixelCount.Text = "Pixel Count";
            this.bPixelCount.UseVisualStyleBackColor = true;
            this.bPixelCount.Click += new System.EventHandler(this.bVelocity_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 620);
            this.Controls.Add(this.bPixelCount);
            this.Controls.Add(this.bBike3);
            this.Controls.Add(this.bBike2);
            this.Controls.Add(this.bBike1);
            this.Controls.Add(this.pStart);
            this.Controls.Add(this.bStep2);
            this.Controls.Add(this.bStep1);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.pTarget);
            this.Controls.Add(this.pRest);
            this.Name = "Form2";
            this.Text = "Tour de France";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pTarget;
        private System.Windows.Forms.Button bBike1;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bBike2;
        private System.Windows.Forms.Button bBike3;
        private System.Windows.Forms.Button bStep1;
        private System.Windows.Forms.Panel pStart;
        private System.Windows.Forms.Panel pRest;
        private System.Windows.Forms.Button bStep2;
        private System.Windows.Forms.Button bPixelCount;
    }
}