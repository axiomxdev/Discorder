using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace Discorder
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Module1 = new System.Windows.Forms.PictureBox();
            this.Module2 = new System.Windows.Forms.PictureBox();
            this.Module3 = new System.Windows.Forms.PictureBox();
            this.Module4 = new System.Windows.Forms.PictureBox();
            this.Module5 = new System.Windows.Forms.PictureBox();
            this.Module6 = new System.Windows.Forms.PictureBox();
            this.Module7 = new System.Windows.Forms.PictureBox();
            this.Module8 = new System.Windows.Forms.PictureBox();
            this.PanelM1 = new System.Windows.Forms.Panel();
            this.PanelM2 = new System.Windows.Forms.Panel();
            this.PanelM3 = new System.Windows.Forms.Panel();
            this.PanelM4 = new System.Windows.Forms.Panel();
            this.PanelM5 = new System.Windows.Forms.Panel();
            this.PanelM6 = new System.Windows.Forms.Panel();
            this.PanelM7 = new System.Windows.Forms.Panel();
            this.PanelM8 = new System.Windows.Forms.Panel();
            this.M1News = new System.Windows.Forms.Panel();
            this.M1Stats = new System.Windows.Forms.Panel();
            this.M1Event = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module8)).BeginInit();
            this.PanelM8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 30);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1150, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 30);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1100, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 30);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1050, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discorder";
            // 
            // Module1
            // 
            this.Module1.BackColor = System.Drawing.Color.Transparent;
            this.Module1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Module1.ErrorImage = null;
            this.Module1.Image = ((System.Drawing.Image)(resources.GetObject("Module1.Image")));
            this.Module1.Location = new System.Drawing.Point(10, 40);
            this.Module1.Margin = new System.Windows.Forms.Padding(0);
            this.Module1.Name = "Module1";
            this.Module1.Size = new System.Drawing.Size(50, 50);
            this.Module1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Module1.TabIndex = 2;
            this.Module1.TabStop = false;
            // 
            // Module2
            // 
            this.Module2.BackColor = System.Drawing.Color.Transparent;
            this.Module2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Module2.ErrorImage = null;
            this.Module2.Image = ((System.Drawing.Image)(resources.GetObject("Module2.Image")));
            this.Module2.Location = new System.Drawing.Point(10, 100);
            this.Module2.Margin = new System.Windows.Forms.Padding(0);
            this.Module2.Name = "Module2";
            this.Module2.Size = new System.Drawing.Size(50, 50);
            this.Module2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Module2.TabIndex = 3;
            this.Module2.TabStop = false;
            // 
            // Module3
            // 
            this.Module3.BackColor = System.Drawing.Color.Transparent;
            this.Module3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Module3.ErrorImage = null;
            this.Module3.Image = ((System.Drawing.Image)(resources.GetObject("Module3.Image")));
            this.Module3.Location = new System.Drawing.Point(10, 160);
            this.Module3.Margin = new System.Windows.Forms.Padding(0);
            this.Module3.Name = "Module3";
            this.Module3.Size = new System.Drawing.Size(50, 50);
            this.Module3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Module3.TabIndex = 3;
            this.Module3.TabStop = false;
            // 
            // Module4
            // 
            this.Module4.BackColor = System.Drawing.Color.Transparent;
            this.Module4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Module4.ErrorImage = null;
            this.Module4.Image = ((System.Drawing.Image)(resources.GetObject("Module4.Image")));
            this.Module4.Location = new System.Drawing.Point(10, 220);
            this.Module4.Margin = new System.Windows.Forms.Padding(0);
            this.Module4.Name = "Module4";
            this.Module4.Size = new System.Drawing.Size(50, 50);
            this.Module4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Module4.TabIndex = 3;
            this.Module4.TabStop = false;
            // 
            // Module5
            // 
            this.Module5.BackColor = System.Drawing.Color.Transparent;
            this.Module5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Module5.ErrorImage = null;
            this.Module5.Image = ((System.Drawing.Image)(resources.GetObject("Module5.Image")));
            this.Module5.Location = new System.Drawing.Point(10, 280);
            this.Module5.Margin = new System.Windows.Forms.Padding(0);
            this.Module5.Name = "Module5";
            this.Module5.Size = new System.Drawing.Size(50, 50);
            this.Module5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Module5.TabIndex = 6;
            this.Module5.TabStop = false;
            // 
            // Module6
            // 
            this.Module6.BackColor = System.Drawing.Color.Transparent;
            this.Module6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Module6.ErrorImage = null;
            this.Module6.Image = ((System.Drawing.Image)(resources.GetObject("Module6.Image")));
            this.Module6.Location = new System.Drawing.Point(10, 340);
            this.Module6.Margin = new System.Windows.Forms.Padding(0);
            this.Module6.Name = "Module6";
            this.Module6.Size = new System.Drawing.Size(50, 50);
            this.Module6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Module6.TabIndex = 7;
            this.Module6.TabStop = false;
            // 
            // Module7
            // 
            this.Module7.BackColor = System.Drawing.Color.Transparent;
            this.Module7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Module7.ErrorImage = null;
            this.Module7.Image = ((System.Drawing.Image)(resources.GetObject("Module7.Image")));
            this.Module7.Location = new System.Drawing.Point(10, 400);
            this.Module7.Margin = new System.Windows.Forms.Padding(0);
            this.Module7.Name = "Module7";
            this.Module7.Size = new System.Drawing.Size(50, 50);
            this.Module7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Module7.TabIndex = 8;
            this.Module7.TabStop = false;
            // 
            // Module8
            // 
            this.Module8.BackColor = System.Drawing.Color.Transparent;
            this.Module8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Module8.ErrorImage = null;
            this.Module8.Image = ((System.Drawing.Image)(resources.GetObject("Module8.Image")));
            this.Module8.Location = new System.Drawing.Point(10, 460);
            this.Module8.Margin = new System.Windows.Forms.Padding(0);
            this.Module8.Name = "Module8";
            this.Module8.Size = new System.Drawing.Size(50, 50);
            this.Module8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Module8.TabIndex = 9;
            this.Module8.TabStop = false;
            // 
            // PanelM1
            // 
            this.PanelM1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelM1.Location = new System.Drawing.Point(70, 30);
            this.PanelM1.Name = "PanelM1";
            this.PanelM1.Size = new System.Drawing.Size(1130, 770);
            this.PanelM1.Controls.Add(this.M1Event);
            this.PanelM1.Controls.Add(this.M1Stats);
            this.PanelM1.Controls.Add(this.M1News);
            this.PanelM1.TabIndex = 5;
            // 
            // PanelM2
            // 
            this.PanelM2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelM2.Location = new System.Drawing.Point(70, 30);
            this.PanelM2.Name = "PanelM2";
            this.PanelM2.Size = new System.Drawing.Size(1130, 770);
            this.PanelM2.TabIndex = 10;
            this.PanelM2.Visible = false;
            // 
            // PanelM3
            // 
            this.PanelM3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelM3.Location = new System.Drawing.Point(70, 30);
            this.PanelM3.Name = "PanelM3";
            this.PanelM3.Size = new System.Drawing.Size(1130, 770);
            this.PanelM3.TabIndex = 11;
            this.PanelM3.Visible = false;
            // 
            // PanelM4
            // 
            this.PanelM4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelM4.Location = new System.Drawing.Point(70, 30);
            this.PanelM4.Name = "PanelM4";
            this.PanelM4.Size = new System.Drawing.Size(1130, 770);
            this.PanelM4.TabIndex = 12;
            this.PanelM4.Visible = false;
            // 
            // PanelM5
            // 
            this.PanelM5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelM5.Location = new System.Drawing.Point(70, 30);
            this.PanelM5.Name = "PanelM5";
            this.PanelM5.Size = new System.Drawing.Size(1130, 770);
            this.PanelM5.TabIndex = 13;
            this.PanelM5.Visible = false;
            // 
            // PanelM6
            // 
            this.PanelM6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelM6.Location = new System.Drawing.Point(70, 30);
            this.PanelM6.Name = "PanelM6";
            this.PanelM6.Size = new System.Drawing.Size(1130, 770);
            this.PanelM6.TabIndex = 14;
            this.PanelM6.Visible = false;
            // 
            // PanelM7
            // 
            this.PanelM7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelM7.Location = new System.Drawing.Point(70, 30);
            this.PanelM7.Name = "PanelM7";
            this.PanelM7.Size = new System.Drawing.Size(1130, 770);
            this.PanelM7.TabIndex = 15;
            this.PanelM7.Visible = false;
            // 
            // PanelM8
            // 
            this.PanelM8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PanelM8.Location = new System.Drawing.Point(70, 30);
            this.PanelM8.Name = "PanelM8";
            this.PanelM8.Size = new System.Drawing.Size(1130, 770);
            this.PanelM8.TabIndex = 16;
            this.PanelM8.Visible = false;
            // 
            // M1News
            // 
            this.M1News.Location = new System.Drawing.Point(30, 30);
            this.M1News.Name = "M1News";
            this.M1News.Size = new System.Drawing.Size(347, 710);
            this.M1News.TabIndex = 0;
            // 
            // M1Stats
            // 
            this.M1Stats.Location = new System.Drawing.Point(407, 30);
            this.M1Stats.Name = "M1Stats";
            this.M1Stats.Size = new System.Drawing.Size(692, 340);
            this.M1Stats.TabIndex = 1;
            // 
            // M1Event
            // 
            this.M1Event.Location = new System.Drawing.Point(407, 400);
            this.M1Event.Name = "M1Event";
            this.M1Event.Size = new System.Drawing.Size(692, 340);
            this.M1Event.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.PanelM8);
            this.Controls.Add(this.PanelM7);
            this.Controls.Add(this.PanelM6);
            this.Controls.Add(this.PanelM5);
            this.Controls.Add(this.PanelM4);
            this.Controls.Add(this.PanelM3);
            this.Controls.Add(this.PanelM2);
            this.Controls.Add(this.Module8);
            this.Controls.Add(this.Module7);
            this.Controls.Add(this.Module6);
            this.Controls.Add(this.Module5);
            this.Controls.Add(this.Module2);
            this.Controls.Add(this.Module3);
            this.Controls.Add(this.Module4);
            this.Controls.Add(this.Module1);
            this.Controls.Add(this.PanelM1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Discorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Module8)).EndInit();
            this.PanelM8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Module1;
        private System.Windows.Forms.PictureBox Module2;
        private System.Windows.Forms.PictureBox Module3;
        private System.Windows.Forms.PictureBox Module4;
        private System.Windows.Forms.Panel PanelM1;
        private System.Windows.Forms.PictureBox Module5;
        private System.Windows.Forms.PictureBox Module6;
        private System.Windows.Forms.PictureBox Module7;
        private System.Windows.Forms.PictureBox Module8;
        private System.Windows.Forms.Panel PanelM2;
        private System.Windows.Forms.Panel PanelM3;
        private System.Windows.Forms.Panel PanelM4;
        private System.Windows.Forms.Panel PanelM5;
        private System.Windows.Forms.Panel PanelM6;
        private System.Windows.Forms.Panel PanelM7;
        private System.Windows.Forms.Panel PanelM8;
        private System.Windows.Forms.Panel M1Event;
        private System.Windows.Forms.Panel M1Stats;
        private System.Windows.Forms.Panel M1News;
    }
}

