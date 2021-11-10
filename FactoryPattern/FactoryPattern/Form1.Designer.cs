﻿
namespace FactoryPattern
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSelectCar = new System.Windows.Forms.Button();
            this.btnSelectBall = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnSelectPresent = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.btnColor3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(13, 13);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(775, 99);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btnSelectCar
            // 
            this.btnSelectCar.Location = new System.Drawing.Point(13, 118);
            this.btnSelectCar.Name = "btnSelectCar";
            this.btnSelectCar.Size = new System.Drawing.Size(98, 46);
            this.btnSelectCar.TabIndex = 1;
            this.btnSelectCar.Text = "CAR";
            this.btnSelectCar.UseVisualStyleBackColor = true;
            this.btnSelectCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSelectBall
            // 
            this.btnSelectBall.Location = new System.Drawing.Point(117, 118);
            this.btnSelectBall.Name = "btnSelectBall";
            this.btnSelectBall.Size = new System.Drawing.Size(98, 46);
            this.btnSelectBall.TabIndex = 2;
            this.btnSelectBall.Text = "BALL";
            this.btnSelectBall.UseVisualStyleBackColor = true;
            this.btnSelectBall.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(325, 118);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(89, 17);
            this.lblNext.TabIndex = 3;
            this.lblNext.Text = "Coming next:";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.DarkCyan;
            this.btnColor.Location = new System.Drawing.Point(117, 170);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(98, 46);
            this.btnColor.TabIndex = 4;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnSelectPresent
            // 
            this.btnSelectPresent.Location = new System.Drawing.Point(221, 118);
            this.btnSelectPresent.Name = "btnSelectPresent";
            this.btnSelectPresent.Size = new System.Drawing.Size(98, 46);
            this.btnSelectPresent.TabIndex = 5;
            this.btnSelectPresent.Text = "PRESENT";
            this.btnSelectPresent.UseVisualStyleBackColor = true;
            this.btnSelectPresent.Click += new System.EventHandler(this.btnSelectPresent_Click);
            // 
            // btnColor2
            // 
            this.btnColor2.BackColor = System.Drawing.Color.Fuchsia;
            this.btnColor2.Location = new System.Drawing.Point(221, 170);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(98, 46);
            this.btnColor2.TabIndex = 6;
            this.btnColor2.UseVisualStyleBackColor = false;
            this.btnColor2.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColor3
            // 
            this.btnColor3.BackColor = System.Drawing.Color.DarkCyan;
            this.btnColor3.Location = new System.Drawing.Point(221, 222);
            this.btnColor3.Name = "btnColor3";
            this.btnColor3.Size = new System.Drawing.Size(98, 46);
            this.btnColor3.TabIndex = 7;
            this.btnColor3.UseVisualStyleBackColor = false;
            this.btnColor3.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.btnColor3);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.btnSelectPresent);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.btnSelectBall);
            this.Controls.Add(this.btnSelectCar);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btnSelectCar;
        private System.Windows.Forms.Button btnSelectBall;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnSelectPresent;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Button btnColor3;
    }
}

