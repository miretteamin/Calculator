namespace Mirette_Calculator
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.PotentialEnergy = new System.Windows.Forms.Button();
            this.KineticEnergy = new System.Windows.Forms.Button();
            this.MechanicalEnergy = new System.Windows.Forms.Button();
            this.Mass = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.vtiftxt = new System.Windows.Forms.TextBox();
            this.vtitxt = new System.Windows.Forms.TextBox();
            this.resultlbl = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.Label();
            this.teitxt = new System.Windows.Forms.TextBox();
            this.Equal = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmingCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algebraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phisicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.Acceleration = new System.Windows.Forms.Button();
            this.Force = new System.Windows.Forms.Button();
            this.deltaT = new System.Windows.Forms.Label();
            this.temftxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tfcb = new System.Windows.Forms.ComboBox();
            this.ticb = new System.Windows.Forms.ComboBox();
            this.dtcb = new System.Windows.Forms.ComboBox();
            this.vfcb = new System.Windows.Forms.ComboBox();
            this.vicb = new System.Windows.Forms.ComboBox();
            this.acc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculate the";
            // 
            // PotentialEnergy
            // 
            this.PotentialEnergy.BackColor = System.Drawing.Color.White;
            this.PotentialEnergy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PotentialEnergy.FlatAppearance.BorderSize = 3;
            this.PotentialEnergy.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.PotentialEnergy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PotentialEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.PotentialEnergy.ForeColor = System.Drawing.Color.Blue;
            this.PotentialEnergy.Location = new System.Drawing.Point(168, 71);
            this.PotentialEnergy.Name = "PotentialEnergy";
            this.PotentialEnergy.Size = new System.Drawing.Size(114, 40);
            this.PotentialEnergy.TabIndex = 2;
            this.PotentialEnergy.Text = "Potential Energy";
            this.PotentialEnergy.UseMnemonic = false;
            this.PotentialEnergy.UseVisualStyleBackColor = false;
            this.PotentialEnergy.Click += new System.EventHandler(this.PotentialEnergy_Click);
            // 
            // KineticEnergy
            // 
            this.KineticEnergy.BackColor = System.Drawing.Color.White;
            this.KineticEnergy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.KineticEnergy.FlatAppearance.BorderSize = 3;
            this.KineticEnergy.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.KineticEnergy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.KineticEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.KineticEnergy.ForeColor = System.Drawing.Color.Blue;
            this.KineticEnergy.Location = new System.Drawing.Point(318, 71);
            this.KineticEnergy.Name = "KineticEnergy";
            this.KineticEnergy.Size = new System.Drawing.Size(114, 40);
            this.KineticEnergy.TabIndex = 3;
            this.KineticEnergy.Text = "Kinetic Energy";
            this.KineticEnergy.UseMnemonic = false;
            this.KineticEnergy.UseVisualStyleBackColor = false;
            this.KineticEnergy.Click += new System.EventHandler(this.KineticEnergy_Click);
            // 
            // MechanicalEnergy
            // 
            this.MechanicalEnergy.BackColor = System.Drawing.Color.White;
            this.MechanicalEnergy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MechanicalEnergy.FlatAppearance.BorderSize = 3;
            this.MechanicalEnergy.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MechanicalEnergy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.MechanicalEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.MechanicalEnergy.ForeColor = System.Drawing.Color.Blue;
            this.MechanicalEnergy.Location = new System.Drawing.Point(465, 71);
            this.MechanicalEnergy.Name = "MechanicalEnergy";
            this.MechanicalEnergy.Size = new System.Drawing.Size(114, 40);
            this.MechanicalEnergy.TabIndex = 4;
            this.MechanicalEnergy.Text = "Mechanical Energy";
            this.MechanicalEnergy.UseMnemonic = false;
            this.MechanicalEnergy.UseVisualStyleBackColor = false;
            this.MechanicalEnergy.Click += new System.EventHandler(this.MechanicalEnergy_Click);
            // 
            // Mass
            // 
            this.Mass.AutoSize = true;
            this.Mass.BackColor = System.Drawing.SystemColors.Control;
            this.Mass.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Mass.Location = new System.Drawing.Point(3, 185);
            this.Mass.Name = "Mass";
            this.Mass.Size = new System.Drawing.Size(73, 17);
            this.Mass.TabIndex = 4;
            this.Mass.Text = "Mass (Kg)";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.BackColor = System.Drawing.SystemColors.Control;
            this.Speed.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Speed.Location = new System.Drawing.Point(0, 233);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(101, 17);
            this.Speed.TabIndex = 5;
            this.Speed.Text = "Speed (m/s^2)";
            // 
            // vtiftxt
            // 
            this.vtiftxt.BackColor = System.Drawing.Color.White;
            this.vtiftxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtiftxt.ForeColor = System.Drawing.Color.Blue;
            this.vtiftxt.Location = new System.Drawing.Point(103, 230);
            this.vtiftxt.MaxLength = 10;
            this.vtiftxt.Multiline = true;
            this.vtiftxt.Name = "vtiftxt";
            this.vtiftxt.Size = new System.Drawing.Size(78, 24);
            this.vtiftxt.TabIndex = 9;
            this.vtiftxt.TextChanged += new System.EventHandler(this.vtiftxt_TextChanged);
            this.vtiftxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Speedtxt_KeyPress);
            // 
            // vtitxt
            // 
            this.vtitxt.BackColor = System.Drawing.Color.White;
            this.vtitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vtitxt.ForeColor = System.Drawing.Color.Blue;
            this.vtitxt.Location = new System.Drawing.Point(101, 181);
            this.vtitxt.MaxLength = 10;
            this.vtitxt.Multiline = true;
            this.vtitxt.Name = "vtitxt";
            this.vtitxt.Size = new System.Drawing.Size(78, 24);
            this.vtitxt.TabIndex = 7;
            this.vtitxt.TextChanged += new System.EventHandler(this.vtitxt_TextChanged);
            this.vtitxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Masstxt_KeyPress);
            // 
            // resultlbl
            // 
            this.resultlbl.AutoSize = true;
            this.resultlbl.BackColor = System.Drawing.SystemColors.Control;
            this.resultlbl.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.resultlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.resultlbl.Location = new System.Drawing.Point(294, 291);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(0, 23);
            this.resultlbl.TabIndex = 9;
            // 
            // Height
            // 
            this.Height.AutoSize = true;
            this.Height.BackColor = System.Drawing.SystemColors.Control;
            this.Height.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Height.Location = new System.Drawing.Point(303, 181);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(77, 17);
            this.Height.TabIndex = 10;
            this.Height.Text = "Height (m)";
            this.Height.Click += new System.EventHandler(this.Height_Click);
            // 
            // teitxt
            // 
            this.teitxt.BackColor = System.Drawing.Color.White;
            this.teitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teitxt.ForeColor = System.Drawing.Color.Blue;
            this.teitxt.Location = new System.Drawing.Point(382, 178);
            this.teitxt.MaxLength = 10;
            this.teitxt.Multiline = true;
            this.teitxt.Name = "teitxt";
            this.teitxt.Size = new System.Drawing.Size(89, 24);
            this.teitxt.TabIndex = 8;
            this.teitxt.TextChanged += new System.EventHandler(this.teitxt_TextChanged);
            this.teitxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Heightxt_KeyPress);
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.White;
            this.Equal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Equal.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.Equal.Location = new System.Drawing.Point(185, 287);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(76, 30);
            this.Equal.TabIndex = 10;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
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
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.optionsToolStripMenuItem.Text = "Calculators";
            // 
            // basicToolStripMenuItem
            // 
            this.basicToolStripMenuItem.CheckOnClick = true;
            this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
            this.basicToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.basicToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.basicToolStripMenuItem.Text = "Basic";
            this.basicToolStripMenuItem.Click += new System.EventHandler(this.basicToolStripMenuItem_Click_2);
            // 
            // programmingCalculatorToolStripMenuItem
            // 
            this.programmingCalculatorToolStripMenuItem.CheckOnClick = true;
            this.programmingCalculatorToolStripMenuItem.Name = "programmingCalculatorToolStripMenuItem";
            this.programmingCalculatorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.programmingCalculatorToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.programmingCalculatorToolStripMenuItem.Text = "Programming Calculator";
            this.programmingCalculatorToolStripMenuItem.Click += new System.EventHandler(this.programmingCalculatorToolStripMenuItem_Click_2);
            // 
            // algebraToolStripMenuItem
            // 
            this.algebraToolStripMenuItem.CheckOnClick = true;
            this.algebraToolStripMenuItem.Name = "algebraToolStripMenuItem";
            this.algebraToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.algebraToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.algebraToolStripMenuItem.Text = "Equations";
            this.algebraToolStripMenuItem.Click += new System.EventHandler(this.algebraToolStripMenuItem_Click_2);
            // 
            // phisicsToolStripMenuItem
            // 
            this.phisicsToolStripMenuItem.CheckOnClick = true;
            this.phisicsToolStripMenuItem.Name = "phisicsToolStripMenuItem";
            this.phisicsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.phisicsToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.phisicsToolStripMenuItem.Text = "Physics";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vladimir Script", 15F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(-4, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Mirette Amin";
            // 
            // Acceleration
            // 
            this.Acceleration.BackColor = System.Drawing.Color.White;
            this.Acceleration.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Acceleration.FlatAppearance.BorderSize = 3;
            this.Acceleration.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Acceleration.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Acceleration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Acceleration.ForeColor = System.Drawing.Color.Blue;
            this.Acceleration.Location = new System.Drawing.Point(620, 71);
            this.Acceleration.Name = "Acceleration";
            this.Acceleration.Size = new System.Drawing.Size(114, 40);
            this.Acceleration.TabIndex = 5;
            this.Acceleration.Text = "Acceleration";
            this.Acceleration.UseMnemonic = false;
            this.Acceleration.UseVisualStyleBackColor = false;
            this.Acceleration.Click += new System.EventHandler(this.Acceleration_Click);
            // 
            // Force
            // 
            this.Force.BackColor = System.Drawing.Color.White;
            this.Force.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Force.FlatAppearance.BorderSize = 3;
            this.Force.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Force.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Force.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Force.ForeColor = System.Drawing.Color.Blue;
            this.Force.Location = new System.Drawing.Point(15, 71);
            this.Force.Name = "Force";
            this.Force.Size = new System.Drawing.Size(114, 40);
            this.Force.TabIndex = 1;
            this.Force.Text = "Force";
            this.Force.UseMnemonic = false;
            this.Force.UseVisualStyleBackColor = false;
            this.Force.Click += new System.EventHandler(this.Force_Click);
            // 
            // deltaT
            // 
            this.deltaT.AutoSize = true;
            this.deltaT.BackColor = System.Drawing.SystemColors.Control;
            this.deltaT.Font = new System.Drawing.Font("Arial Black", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.deltaT.Location = new System.Drawing.Point(530, 196);
            this.deltaT.Name = "deltaT";
            this.deltaT.Size = new System.Drawing.Size(62, 28);
            this.deltaT.TabIndex = 54;
            this.deltaT.Text = "or ∆t";
            // 
            // temftxt
            // 
            this.temftxt.BackColor = System.Drawing.Color.White;
            this.temftxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temftxt.ForeColor = System.Drawing.Color.Blue;
            this.temftxt.Location = new System.Drawing.Point(382, 228);
            this.temftxt.MaxLength = 10;
            this.temftxt.Multiline = true;
            this.temftxt.Name = "temftxt";
            this.temftxt.Size = new System.Drawing.Size(89, 25);
            this.temftxt.TabIndex = 57;
            this.temftxt.TextChanged += new System.EventHandler(this.temftxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.Location = new System.Drawing.Point(303, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Final Time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tfcb
            // 
            this.tfcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfcb.FormattingEnabled = true;
            this.tfcb.Items.AddRange(new object[] {
            "sec",
            "min",
            "heures"});
            this.tfcb.Location = new System.Drawing.Point(476, 228);
            this.tfcb.Margin = new System.Windows.Forms.Padding(2);
            this.tfcb.Name = "tfcb";
            this.tfcb.Size = new System.Drawing.Size(70, 24);
            this.tfcb.TabIndex = 62;
            this.tfcb.SelectedIndexChanged += new System.EventHandler(this.tfcb_SelectedIndexChanged);
            // 
            // ticb
            // 
            this.ticb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticb.FormattingEnabled = true;
            this.ticb.Items.AddRange(new object[] {
            "sec",
            "min",
            "heures"});
            this.ticb.Location = new System.Drawing.Point(476, 178);
            this.ticb.Margin = new System.Windows.Forms.Padding(2);
            this.ticb.Name = "ticb";
            this.ticb.Size = new System.Drawing.Size(70, 24);
            this.ticb.TabIndex = 61;
            this.ticb.SelectedIndexChanged += new System.EventHandler(this.ticb_SelectedIndexChanged);
            // 
            // dtcb
            // 
            this.dtcb.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtcb.FormattingEnabled = true;
            this.dtcb.Items.AddRange(new object[] {
            "sec",
            "min",
            "heures"});
            this.dtcb.Location = new System.Drawing.Point(691, 200);
            this.dtcb.Margin = new System.Windows.Forms.Padding(2);
            this.dtcb.Name = "dtcb";
            this.dtcb.Size = new System.Drawing.Size(72, 24);
            this.dtcb.TabIndex = 60;
            // 
            // vfcb
            // 
            this.vfcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vfcb.FormattingEnabled = true;
            this.vfcb.Items.AddRange(new object[] {
            "m/sec",
            "m/min",
            "km/min",
            "km/h"});
            this.vfcb.Location = new System.Drawing.Point(185, 230);
            this.vfcb.Margin = new System.Windows.Forms.Padding(2);
            this.vfcb.Name = "vfcb";
            this.vfcb.Size = new System.Drawing.Size(72, 24);
            this.vfcb.TabIndex = 59;
            this.vfcb.SelectedIndexChanged += new System.EventHandler(this.vfcb_SelectedIndexChanged);
            // 
            // vicb
            // 
            this.vicb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vicb.FormattingEnabled = true;
            this.vicb.Items.AddRange(new object[] {
            "m/sec",
            "m/min",
            "km/min",
            "km/h"});
            this.vicb.Location = new System.Drawing.Point(184, 181);
            this.vicb.Margin = new System.Windows.Forms.Padding(2);
            this.vicb.Name = "vicb";
            this.vicb.Size = new System.Drawing.Size(70, 24);
            this.vicb.TabIndex = 58;
            this.vicb.SelectedIndexChanged += new System.EventHandler(this.vicb_SelectedIndexChanged);
            // 
            // acc
            // 
            this.acc.AutoSize = true;
            this.acc.BackColor = System.Drawing.Color.White;
            this.acc.Font = new System.Drawing.Font("Arial", 14F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.acc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.acc.Location = new System.Drawing.Point(501, 287);
            this.acc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.acc.Name = "acc";
            this.acc.Size = new System.Drawing.Size(134, 23);
            this.acc.TabIndex = 63;
            this.acc.Text = "Acceleration ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(589, 201);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 14;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 64;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(768, 329);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.tfcb);
            this.Controls.Add(this.ticb);
            this.Controls.Add(this.dtcb);
            this.Controls.Add(this.vfcb);
            this.Controls.Add(this.vicb);
            this.Controls.Add(this.temftxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deltaT);
            this.Controls.Add(this.Force);
            this.Controls.Add(this.Acceleration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.teitxt);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.vtitxt);
            this.Controls.Add(this.vtiftxt);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.Mass);
            this.Controls.Add(this.MechanicalEnergy);
            this.Controls.Add(this.KineticEnergy);
            this.Controls.Add(this.PotentialEnergy);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(784, 368);
            this.MinimumSize = new System.Drawing.Size(784, 368);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Physics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PotentialEnergy;
        private System.Windows.Forms.Button KineticEnergy;
        private System.Windows.Forms.Button MechanicalEnergy;
        private System.Windows.Forms.Label Mass;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.TextBox vtiftxt;
        private System.Windows.Forms.TextBox vtitxt;
        private System.Windows.Forms.Label resultlbl;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.TextBox teitxt;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Acceleration;
        private System.Windows.Forms.Button Force;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmingCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algebraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phisicsToolStripMenuItem;
        private System.Windows.Forms.Label deltaT;
        private System.Windows.Forms.TextBox temftxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tfcb;
        private System.Windows.Forms.ComboBox ticb;
        private System.Windows.Forms.ComboBox dtcb;
        private System.Windows.Forms.ComboBox vfcb;
        private System.Windows.Forms.ComboBox vicb;
        private System.Windows.Forms.Label acc;
        private System.Windows.Forms.TextBox textBox1;
    }
}