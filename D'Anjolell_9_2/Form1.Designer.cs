
namespace D_Anjolell_9_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtColaAmt = new System.Windows.Forms.TextBox();
            this.lblColaAmt = new System.Windows.Forms.Label();
            this.lblColaCost = new System.Windows.Forms.Label();
            this.btnCola = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGrape = new System.Windows.Forms.Button();
            this.lblGrapeCost = new System.Windows.Forms.Label();
            this.lblGrapeAmt = new System.Windows.Forms.Label();
            this.txtGrapeAmt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRtBr = new System.Windows.Forms.Button();
            this.lblRtBrCost = new System.Windows.Forms.Label();
            this.rtbrAmt = new System.Windows.Forms.Label();
            this.txtRtBrAmt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLemLim = new System.Windows.Forms.Button();
            this.lblLemLimCost = new System.Windows.Forms.Label();
            this.lblLemLimAmt = new System.Windows.Forms.Label();
            this.txtLemLimAmt = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnCream = new System.Windows.Forms.Button();
            this.lblCreamCost = new System.Windows.Forms.Label();
            this.lblCreamAmt = new System.Windows.Forms.Label();
            this.txtCreamAmt = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(291, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Select a Drink";
            // 
            // txtColaAmt
            // 
            this.txtColaAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtColaAmt.Location = new System.Drawing.Point(135, 92);
            this.txtColaAmt.Name = "txtColaAmt";
            this.txtColaAmt.ReadOnly = true;
            this.txtColaAmt.Size = new System.Drawing.Size(100, 28);
            this.txtColaAmt.TabIndex = 3;
            this.txtColaAmt.Text = "20";
            this.txtColaAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblColaAmt
            // 
            this.lblColaAmt.AutoSize = true;
            this.lblColaAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblColaAmt.Location = new System.Drawing.Point(133, 53);
            this.lblColaAmt.Name = "lblColaAmt";
            this.lblColaAmt.Size = new System.Drawing.Size(101, 24);
            this.lblColaAmt.TabIndex = 2;
            this.lblColaAmt.Text = "Drinks Left:";
            // 
            // lblColaCost
            // 
            this.lblColaCost.AutoSize = true;
            this.lblColaCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColaCost.Location = new System.Drawing.Point(149, 18);
            this.lblColaCost.Name = "lblColaCost";
            this.lblColaCost.Size = new System.Drawing.Size(60, 24);
            this.lblColaCost.TabIndex = 1;
            this.lblColaCost.Text = "$1.00";
            // 
            // btnCola
            // 
            this.btnCola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCola.BackgroundImage")));
            this.btnCola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCola.Location = new System.Drawing.Point(6, 21);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(105, 102);
            this.btnCola.TabIndex = 16;
            this.btnCola.UseVisualStyleBackColor = true;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCola);
            this.groupBox1.Controls.Add(this.lblColaCost);
            this.groupBox1.Controls.Add(this.lblColaAmt);
            this.groupBox1.Controls.Add(this.txtColaAmt);
            this.groupBox1.Location = new System.Drawing.Point(159, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 131);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGrape);
            this.groupBox2.Controls.Add(this.lblGrapeCost);
            this.groupBox2.Controls.Add(this.lblGrapeAmt);
            this.groupBox2.Controls.Add(this.txtGrapeAmt);
            this.groupBox2.Location = new System.Drawing.Point(406, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 131);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // btnGrape
            // 
            this.btnGrape.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGrape.BackgroundImage")));
            this.btnGrape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrape.Location = new System.Drawing.Point(6, 21);
            this.btnGrape.Name = "btnGrape";
            this.btnGrape.Size = new System.Drawing.Size(105, 102);
            this.btnGrape.TabIndex = 16;
            this.btnGrape.UseVisualStyleBackColor = true;
            this.btnGrape.Click += new System.EventHandler(this.btnGrape_Click);
            // 
            // lblGrapeCost
            // 
            this.lblGrapeCost.AutoSize = true;
            this.lblGrapeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrapeCost.Location = new System.Drawing.Point(149, 18);
            this.lblGrapeCost.Name = "lblGrapeCost";
            this.lblGrapeCost.Size = new System.Drawing.Size(60, 24);
            this.lblGrapeCost.TabIndex = 1;
            this.lblGrapeCost.Text = "$1.50";
            // 
            // lblGrapeAmt
            // 
            this.lblGrapeAmt.AutoSize = true;
            this.lblGrapeAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblGrapeAmt.Location = new System.Drawing.Point(133, 53);
            this.lblGrapeAmt.Name = "lblGrapeAmt";
            this.lblGrapeAmt.Size = new System.Drawing.Size(101, 24);
            this.lblGrapeAmt.TabIndex = 2;
            this.lblGrapeAmt.Text = "Drinks Left:";
            // 
            // txtGrapeAmt
            // 
            this.txtGrapeAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtGrapeAmt.Location = new System.Drawing.Point(135, 92);
            this.txtGrapeAmt.Name = "txtGrapeAmt";
            this.txtGrapeAmt.ReadOnly = true;
            this.txtGrapeAmt.Size = new System.Drawing.Size(100, 28);
            this.txtGrapeAmt.TabIndex = 3;
            this.txtGrapeAmt.Text = "20";
            this.txtGrapeAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRtBr);
            this.groupBox3.Controls.Add(this.lblRtBrCost);
            this.groupBox3.Controls.Add(this.rtbrAmt);
            this.groupBox3.Controls.Add(this.txtRtBrAmt);
            this.groupBox3.Location = new System.Drawing.Point(406, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 131);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            // 
            // btnRtBr
            // 
            this.btnRtBr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRtBr.BackgroundImage")));
            this.btnRtBr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRtBr.Location = new System.Drawing.Point(6, 21);
            this.btnRtBr.Name = "btnRtBr";
            this.btnRtBr.Size = new System.Drawing.Size(105, 102);
            this.btnRtBr.TabIndex = 16;
            this.btnRtBr.UseVisualStyleBackColor = true;
            this.btnRtBr.Click += new System.EventHandler(this.btnRtBr_Click);
            // 
            // lblRtBrCost
            // 
            this.lblRtBrCost.AutoSize = true;
            this.lblRtBrCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRtBrCost.Location = new System.Drawing.Point(149, 18);
            this.lblRtBrCost.Name = "lblRtBrCost";
            this.lblRtBrCost.Size = new System.Drawing.Size(60, 24);
            this.lblRtBrCost.TabIndex = 1;
            this.lblRtBrCost.Text = "$1.00";
            // 
            // rtbrAmt
            // 
            this.rtbrAmt.AutoSize = true;
            this.rtbrAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.rtbrAmt.Location = new System.Drawing.Point(133, 53);
            this.rtbrAmt.Name = "rtbrAmt";
            this.rtbrAmt.Size = new System.Drawing.Size(101, 24);
            this.rtbrAmt.TabIndex = 2;
            this.rtbrAmt.Text = "Drinks Left:";
            // 
            // txtRtBrAmt
            // 
            this.txtRtBrAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtRtBrAmt.Location = new System.Drawing.Point(135, 92);
            this.txtRtBrAmt.Name = "txtRtBrAmt";
            this.txtRtBrAmt.ReadOnly = true;
            this.txtRtBrAmt.Size = new System.Drawing.Size(100, 28);
            this.txtRtBrAmt.TabIndex = 3;
            this.txtRtBrAmt.Text = "20";
            this.txtRtBrAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLemLim);
            this.groupBox4.Controls.Add(this.lblLemLimCost);
            this.groupBox4.Controls.Add(this.lblLemLimAmt);
            this.groupBox4.Controls.Add(this.txtLemLimAmt);
            this.groupBox4.Location = new System.Drawing.Point(159, 185);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 131);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // btnLemLim
            // 
            this.btnLemLim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLemLim.BackgroundImage")));
            this.btnLemLim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLemLim.Location = new System.Drawing.Point(6, 21);
            this.btnLemLim.Name = "btnLemLim";
            this.btnLemLim.Size = new System.Drawing.Size(105, 102);
            this.btnLemLim.TabIndex = 16;
            this.btnLemLim.UseVisualStyleBackColor = true;
            this.btnLemLim.Click += new System.EventHandler(this.btnLemLim_Click);
            // 
            // lblLemLimCost
            // 
            this.lblLemLimCost.AutoSize = true;
            this.lblLemLimCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLemLimCost.Location = new System.Drawing.Point(149, 18);
            this.lblLemLimCost.Name = "lblLemLimCost";
            this.lblLemLimCost.Size = new System.Drawing.Size(60, 24);
            this.lblLemLimCost.TabIndex = 1;
            this.lblLemLimCost.Text = "$1.00";
            // 
            // lblLemLimAmt
            // 
            this.lblLemLimAmt.AutoSize = true;
            this.lblLemLimAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblLemLimAmt.Location = new System.Drawing.Point(133, 53);
            this.lblLemLimAmt.Name = "lblLemLimAmt";
            this.lblLemLimAmt.Size = new System.Drawing.Size(101, 24);
            this.lblLemLimAmt.TabIndex = 2;
            this.lblLemLimAmt.Text = "Drinks Left:";
            // 
            // txtLemLimAmt
            // 
            this.txtLemLimAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtLemLimAmt.Location = new System.Drawing.Point(135, 92);
            this.txtLemLimAmt.Name = "txtLemLimAmt";
            this.txtLemLimAmt.ReadOnly = true;
            this.txtLemLimAmt.Size = new System.Drawing.Size(100, 28);
            this.txtLemLimAmt.TabIndex = 3;
            this.txtLemLimAmt.Text = "20";
            this.txtLemLimAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCream);
            this.groupBox5.Controls.Add(this.lblCreamCost);
            this.groupBox5.Controls.Add(this.lblCreamAmt);
            this.groupBox5.Controls.Add(this.txtCreamAmt);
            this.groupBox5.Location = new System.Drawing.Point(159, 322);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(241, 131);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // btnCream
            // 
            this.btnCream.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCream.BackgroundImage")));
            this.btnCream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCream.Location = new System.Drawing.Point(6, 21);
            this.btnCream.Name = "btnCream";
            this.btnCream.Size = new System.Drawing.Size(105, 102);
            this.btnCream.TabIndex = 16;
            this.btnCream.UseVisualStyleBackColor = true;
            this.btnCream.Click += new System.EventHandler(this.btnCream_Click);
            // 
            // lblCreamCost
            // 
            this.lblCreamCost.AutoSize = true;
            this.lblCreamCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreamCost.Location = new System.Drawing.Point(149, 18);
            this.lblCreamCost.Name = "lblCreamCost";
            this.lblCreamCost.Size = new System.Drawing.Size(60, 24);
            this.lblCreamCost.TabIndex = 1;
            this.lblCreamCost.Text = "$1.50";
            // 
            // lblCreamAmt
            // 
            this.lblCreamAmt.AutoSize = true;
            this.lblCreamAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblCreamAmt.Location = new System.Drawing.Point(133, 53);
            this.lblCreamAmt.Name = "lblCreamAmt";
            this.lblCreamAmt.Size = new System.Drawing.Size(101, 24);
            this.lblCreamAmt.TabIndex = 2;
            this.lblCreamAmt.Text = "Drinks Left:";
            // 
            // txtCreamAmt
            // 
            this.txtCreamAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtCreamAmt.Location = new System.Drawing.Point(135, 92);
            this.txtCreamAmt.Name = "txtCreamAmt";
            this.txtCreamAmt.ReadOnly = true;
            this.txtCreamAmt.Size = new System.Drawing.Size(100, 28);
            this.txtCreamAmt.TabIndex = 3;
            this.txtCreamAmt.Text = "20";
            this.txtCreamAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotalSales);
            this.groupBox6.Controls.Add(this.txtTotalSales);
            this.groupBox6.Location = new System.Drawing.Point(406, 322);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(241, 131);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(66, 21);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(113, 24);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "Total Sales";
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtTotalSales.Location = new System.Drawing.Point(70, 74);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.ReadOnly = true;
            this.txtTotalSales.Size = new System.Drawing.Size(109, 28);
            this.txtTotalSales.TabIndex = 3;
            this.txtTotalSales.Text = "$0.00";
            this.txtTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnExit.Location = new System.Drawing.Point(346, 473);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 30);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtColaAmt;
        private System.Windows.Forms.Label lblColaAmt;
        private System.Windows.Forms.Label lblColaCost;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGrape;
        private System.Windows.Forms.Label lblGrapeCost;
        private System.Windows.Forms.Label lblGrapeAmt;
        private System.Windows.Forms.TextBox txtGrapeAmt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRtBr;
        private System.Windows.Forms.Label lblRtBrCost;
        private System.Windows.Forms.Label rtbrAmt;
        private System.Windows.Forms.TextBox txtRtBrAmt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLemLim;
        private System.Windows.Forms.Label lblLemLimCost;
        private System.Windows.Forms.Label lblLemLimAmt;
        private System.Windows.Forms.TextBox txtLemLimAmt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCream;
        private System.Windows.Forms.Label lblCreamCost;
        private System.Windows.Forms.Label lblCreamAmt;
        private System.Windows.Forms.TextBox txtCreamAmt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.Button btnExit;
    }
}

