﻿namespace The_Do_Nothing_Project
{
    partial class DoNothing
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Move = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(593, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "Create";
            this.textBox1.Location = new System.Drawing.Point(153, 82);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 402);
            this.textBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(593, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(593, 250);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Create.Location = new System.Drawing.Point(593, 337);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(140, 66);
            this.Create.TabIndex = 4;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.button4_Click);
            // 
            // Move
            // 
            this.Move.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Move.Location = new System.Drawing.Point(593, 418);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(140, 66);
            this.Move.TabIndex = 5;
            this.Move.Text = "Move";
            this.Move.UseVisualStyleBackColor = false;
            this.Move.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(739, 337);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 66);
            this.button4.TabIndex = 6;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // DoNothing
            // 
            this.AccessibleDescription = "An Application about Nothing";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(889, 585);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Move);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "DoNothing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Do Nothinger";
            this.Load += new System.EventHandler(this.DoNothing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Button button4;
    }
}

