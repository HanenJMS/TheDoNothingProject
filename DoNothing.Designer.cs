namespace The_Do_Nothing_Project
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
            this.Mover = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MoveFile = new System.Windows.Forms.Button();
            this.Filing = new System.Windows.Forms.Label();
            this.CreateFile = new System.Windows.Forms.Button();
            this.DeleteFile = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.Write = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.textBox1.Location = new System.Drawing.Point(31, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(499, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // Mover
            // 
            this.Mover.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Mover.Location = new System.Drawing.Point(166, 43);
            this.Mover.Name = "Mover";
            this.Mover.Size = new System.Drawing.Size(133, 66);
            this.Mover.TabIndex = 8;
            this.Mover.Text = "Mover";
            this.Mover.UseVisualStyleBackColor = false;
            this.Mover.Click += new System.EventHandler(this.Mover_Click);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Create.Location = new System.Drawing.Point(8, 44);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(133, 66);
            this.Create.TabIndex = 10;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Delete.Location = new System.Drawing.Point(334, 43);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(133, 66);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "Create";
            this.textBox2.Location = new System.Drawing.Point(31, 129);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(499, 102);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Directory";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mover);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Create);
            this.groupBox1.Controls.Add(this.Delete);
            this.groupBox1.Location = new System.Drawing.Point(31, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 131);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Copy);
            this.groupBox2.Controls.Add(this.Read);
            this.groupBox2.Controls.Add(this.Write);
            this.groupBox2.Controls.Add(this.MoveFile);
            this.groupBox2.Controls.Add(this.Filing);
            this.groupBox2.Controls.Add(this.CreateFile);
            this.groupBox2.Controls.Add(this.DeleteFile);
            this.groupBox2.Location = new System.Drawing.Point(31, 237);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 271);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // MoveFile
            // 
            this.MoveFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MoveFile.Location = new System.Drawing.Point(166, 37);
            this.MoveFile.Name = "MoveFile";
            this.MoveFile.Size = new System.Drawing.Size(133, 66);
            this.MoveFile.TabIndex = 8;
            this.MoveFile.Text = "MoveFile";
            this.MoveFile.UseVisualStyleBackColor = false;
            this.MoveFile.Click += new System.EventHandler(this.MoveFile_Click);
            // 
            // Filing
            // 
            this.Filing.AutoSize = true;
            this.Filing.Location = new System.Drawing.Point(18, 18);
            this.Filing.Name = "Filing";
            this.Filing.Size = new System.Drawing.Size(29, 16);
            this.Filing.TabIndex = 13;
            this.Filing.Text = "File";
            // 
            // CreateFile
            // 
            this.CreateFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CreateFile.Location = new System.Drawing.Point(15, 37);
            this.CreateFile.Name = "CreateFile";
            this.CreateFile.Size = new System.Drawing.Size(133, 66);
            this.CreateFile.TabIndex = 10;
            this.CreateFile.Text = "CreateFile";
            this.CreateFile.UseVisualStyleBackColor = false;
            this.CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // DeleteFile
            // 
            this.DeleteFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteFile.Location = new System.Drawing.Point(317, 37);
            this.DeleteFile.Name = "DeleteFile";
            this.DeleteFile.Size = new System.Drawing.Size(133, 66);
            this.DeleteFile.TabIndex = 11;
            this.DeleteFile.Text = "DeleteFile";
            this.DeleteFile.UseVisualStyleBackColor = false;
            this.DeleteFile.Click += new System.EventHandler(this.DeleteFile_Click);
            // 
            // Read
            // 
            this.Read.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Read.Location = new System.Drawing.Point(166, 137);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(133, 66);
            this.Read.TabIndex = 14;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = false;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // Write
            // 
            this.Write.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Write.Location = new System.Drawing.Point(15, 137);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(133, 66);
            this.Write.TabIndex = 15;
            this.Write.Text = "Write";
            this.Write.UseVisualStyleBackColor = false;
            this.Write.Click += new System.EventHandler(this.Write_Click);
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Copy.Location = new System.Drawing.Point(317, 137);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(133, 66);
            this.Copy.TabIndex = 16;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // DoNothing
            // 
            this.AccessibleDescription = "An Application about Nothing";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(889, 585);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "DoNothing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Do Nothinger";
            this.Load += new System.EventHandler(this.DoNothing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Mover;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button MoveFile;
        private System.Windows.Forms.Label Filing;
        private System.Windows.Forms.Button CreateFile;
        private System.Windows.Forms.Button DeleteFile;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button Write;
    }
}

