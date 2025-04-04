
namespace PresentationLayer
{
    partial class CoffeeShop
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
            this.lbWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWelcome
            // 
            this.lbWelcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbWelcome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.Location = new System.Drawing.Point(-4, 0);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(181, 106);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnSupplier);
            this.panel1.Controls.Add(this.lbWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 336);
            this.panel1.TabIndex = 1;
            // 
            // pnMain
            // 
            this.pnMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(180, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(515, 336);
            this.pnMain.TabIndex = 2;
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.LightGreen;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSupplier.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.DimGray;
            this.btnSupplier.Location = new System.Drawing.Point(1, 109);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(176, 38);
            this.btnSupplier.TabIndex = 0;
            this.btnSupplier.Text = "Supplier";
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 336);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel1);
            this.Name = "CoffeeShop";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CoffeeShop_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Button btnSupplier;
    }
}

