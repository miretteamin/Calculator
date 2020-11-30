namespace Mirette_Calculator
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Done = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctxt = new System.Windows.Forms.TextBox();
            this.btxt = new System.Windows.Forms.TextBox();
            this.atxt = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmingCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algebraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phisicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.White;
            this.Done.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Done.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold);
            this.Done.ForeColor = System.Drawing.Color.Black;
            this.Done.Location = new System.Drawing.Point(75, 261);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(79, 31);
            this.Done.TabIndex = 46;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 56);
            this.label1.TabIndex = 36;
            this.label1.Text = "ax+b=c";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Equations (first degree)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(57, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "a = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "b = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(56, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "c = ";
            // 
            // ctxt
            // 
            this.ctxt.BackColor = System.Drawing.Color.White;
            this.ctxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ctxt.ForeColor = System.Drawing.Color.Black;
            this.ctxt.Location = new System.Drawing.Point(118, 211);
            this.ctxt.MaxLength = 10;
            this.ctxt.Name = "ctxt";
            this.ctxt.Size = new System.Drawing.Size(47, 22);
            this.ctxt.TabIndex = 45;
            this.ctxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctxt_KeyPress);
            // 
            // btxt
            // 
            this.btxt.BackColor = System.Drawing.Color.White;
            this.btxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btxt.ForeColor = System.Drawing.Color.Black;
            this.btxt.Location = new System.Drawing.Point(118, 159);
            this.btxt.MaxLength = 10;
            this.btxt.Name = "btxt";
            this.btxt.Size = new System.Drawing.Size(47, 22);
            this.btxt.TabIndex = 44;
            this.btxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btxt_KeyPress);
            // 
            // atxt
            // 
            this.atxt.BackColor = System.Drawing.Color.White;
            this.atxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.atxt.ForeColor = System.Drawing.Color.Black;
            this.atxt.Location = new System.Drawing.Point(118, 110);
            this.atxt.MaxLength = 10;
            this.atxt.Name = "atxt";
            this.atxt.Size = new System.Drawing.Size(47, 22);
            this.atxt.TabIndex = 43;
            this.atxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.atxt_KeyPress);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.SystemColors.Control;
            this.Result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Result.Location = new System.Drawing.Point(80, 311);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 19);
            this.Result.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vladimir Script", 15F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(-4, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 48;
            this.label6.Text = "Mirette Amin";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(246, 25);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.CheckOnClick = true;
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicToolStripMenuItem,
            this.programmingCalculatorToolStripMenuItem,
            this.algebraToolStripMenuItem,
            this.phisicsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.optionsToolStripMenuItem.Text = "Calculators";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.CheckOnClick = true;
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.basicToolStripMenuItem.Text = "Basic";
            this.basicToolStripMenuItem.Click += new System.EventHandler(this.basicToolStripMenuItem_Click_1);
            // 
            // programmingCalculatorToolStripMenuItem
            // 
            this.programmingCalculatorToolStripMenuItem.CheckOnClick = true;
            this.programmingCalculatorToolStripMenuItem.Name = "programmingCalculatorToolStripMenuItem";
            this.programmingCalculatorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.programmingCalculatorToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.programmingCalculatorToolStripMenuItem.Text = "Programming Calculator";
            this.programmingCalculatorToolStripMenuItem.Click += new System.EventHandler(this.programmingCalculatorToolStripMenuItem_Click_1);
            // 
            // algebraToolStripMenuItem
            // 
            this.algebraToolStripMenuItem.CheckOnClick = true;
            this.algebraToolStripMenuItem.Name = "algebraToolStripMenuItem";
            this.algebraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.algebraToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.algebraToolStripMenuItem.Text = "Equations";
            // 
            // phisicsToolStripMenuItem
            // 
            this.phisicsToolStripMenuItem.CheckOnClick = true;
            this.phisicsToolStripMenuItem.Name = "phisicsToolStripMenuItem";
            this.phisicsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.phisicsToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.phisicsToolStripMenuItem.Text = "Physics";
            this.phisicsToolStripMenuItem.Click += new System.EventHandler(this.phisicsToolStripMenuItem_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(246, 373);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.atxt);
            this.Controls.Add(this.btxt);
            this.Controls.Add(this.ctxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Done);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(262, 412);
            this.MinimumSize = new System.Drawing.Size(262, 412);
            this.Name = "Form3";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctxt;
        private System.Windows.Forms.TextBox btxt;
        private System.Windows.Forms.TextBox atxt;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmingCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algebraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phisicsToolStripMenuItem;
    }
}