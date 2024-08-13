
namespace Courrier_Ado.Layout
{
    partial class Swivi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Swivi));
            this.PannelDepart = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pannelArriver = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PannelDepart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pannelArriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PannelDepart
            // 
            this.PannelDepart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PannelDepart.Controls.Add(this.pictureBox1);
            this.PannelDepart.Controls.Add(this.label1);
            this.PannelDepart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PannelDepart.Location = new System.Drawing.Point(125, 263);
            this.PannelDepart.Name = "PannelDepart";
            this.PannelDepart.Size = new System.Drawing.Size(484, 168);
            this.PannelDepart.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 84);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suivi Courrier \r\n      Départ";
            // 
            // pannelArriver
            // 
            this.pannelArriver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pannelArriver.Controls.Add(this.label2);
            this.pannelArriver.Controls.Add(this.pictureBox2);
            this.pannelArriver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pannelArriver.Location = new System.Drawing.Point(759, 263);
            this.pannelArriver.Name = "pannelArriver";
            this.pannelArriver.Size = new System.Drawing.Size(484, 168);
            this.pannelArriver.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 84);
            this.label2.TabIndex = 3;
            this.label2.Text = "Suivi Courrier\r\n     Arrivée";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Swivi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PannelDepart);
            this.Controls.Add(this.pannelArriver);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Swivi";
            this.Size = new System.Drawing.Size(1368, 694);
            this.PannelDepart.ResumeLayout(false);
            this.PannelDepart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pannelArriver.ResumeLayout(false);
            this.pannelArriver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PannelDepart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pannelArriver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
