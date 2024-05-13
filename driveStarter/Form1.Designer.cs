
namespace driveStarter
{
    partial class driveStarter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFunction = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.flpdrv = new System.Windows.Forms.FlowLayoutPanel();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDrives = new System.Windows.Forms.Label();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblFunction.Location = new System.Drawing.Point(12, 9);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(109, 18);
            this.lblFunction.TabIndex = 2;
            this.lblFunction.Text = "drives found";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.White;
            this.btnShowAll.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnShowAll.Location = new System.Drawing.Point(3, 3);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(200, 70);
            this.btnShowAll.TabIndex = 4;
            this.btnShowAll.Text = "show all drives";
            this.btnShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // flpdrv
            // 
            this.flpdrv.AutoSize = true;
            this.flpdrv.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpdrv.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpdrv.Location = new System.Drawing.Point(15, 37);
            this.flpdrv.Name = "flpdrv";
            this.flpdrv.Padding = new System.Windows.Forms.Padding(5);
            this.flpdrv.Size = new System.Drawing.Size(106, 207);
            this.flpdrv.TabIndex = 5;
            // 
            // flpButtons
            // 
            this.flpButtons.AutoSize = true;
            this.flpButtons.Controls.Add(this.btnShowAll);
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpButtons.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpButtons.Location = new System.Drawing.Point(124, 37);
            this.flpButtons.Margin = new System.Windows.Forms.Padding(0);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(206, 207);
            this.flpButtons.TabIndex = 6;
            // 
            // lblDrives
            // 
            this.lblDrives.AutoSize = true;
            this.lblDrives.Font = new System.Drawing.Font("Verdana", 12F);
            this.lblDrives.Location = new System.Drawing.Point(121, 9);
            this.lblDrives.Name = "lblDrives";
            this.lblDrives.Size = new System.Drawing.Size(108, 18);
            this.lblDrives.TabIndex = 10;
            this.lblDrives.Text = "drives ready";
            // 
            // driveStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(344, 253);
            this.Controls.Add(this.lblDrives);
            this.Controls.Add(this.flpButtons);
            this.Controls.Add(this.flpdrv);
            this.Controls.Add(this.lblFunction);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Name = "driveStarter";
            this.Text = "Windows Drive Starter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flpButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.FlowLayoutPanel flpdrv;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Label lblDrives;
    }
}

