﻿namespace Treashure
{
    partial class Form4
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
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            splitter1 = new Splitter();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.MidnightBlue;
            pictureBox6.BackgroundImage = Properties.Resources.iconamoon_exit_light;
            pictureBox6.Location = new Point(4, 374);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(69, 64);
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.MidnightBlue;
            pictureBox5.Image = Properties.Resources.Vector1;
            pictureBox5.Location = new Point(11, 273);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(62, 52);
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.MidnightBlue;
            pictureBox4.BackgroundImage = Properties.Resources.ion_binoculars;
            pictureBox4.Location = new Point(13, 212);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(60, 55);
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Aqua;
            pictureBox3.BackgroundImage = Properties.Resources.mdi_report_bar;
            pictureBox3.Location = new Point(20, 157);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 49);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.MidnightBlue;
            pictureBox2.BackgroundImage = Properties.Resources.material_symbols_home;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Cursor = Cursors.Cross;
            pictureBox2.Location = new Point(13, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 61);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.MidnightBlue;
            pictureBox1.BackgroundImage = Properties.Resources.Vector;
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 73);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.BackColor = Color.MidnightBlue;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(80, 450);
            splitter1.TabIndex = 7;
            splitter1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(274, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 26);
            label1.TabIndex = 14;
            label1.Text = "TRASH AND TPS STATS";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.TPS_Manager;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(splitter1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Splitter splitter1;
        private Label label1;
    }
}