namespace Forms
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
            this.txtMetaData = new System.Windows.Forms.TextBox();
            this.btnLoadMetaData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMetaData
            // 
            this.txtMetaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetaData.Location = new System.Drawing.Point(12, 12);
            this.txtMetaData.Multiline = true;
            this.txtMetaData.Name = "txtMetaData";
            this.txtMetaData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMetaData.Size = new System.Drawing.Size(446, 384);
            this.txtMetaData.TabIndex = 0;
            // 
            // btnLoadMetaData
            // 
            this.btnLoadMetaData.Location = new System.Drawing.Point(164, 402);
            this.btnLoadMetaData.Name = "btnLoadMetaData";
            this.btnLoadMetaData.Size = new System.Drawing.Size(123, 36);
            this.btnLoadMetaData.TabIndex = 1;
            this.btnLoadMetaData.Text = "Load DataType Info";
            this.btnLoadMetaData.UseVisualStyleBackColor = true;
            this.btnLoadMetaData.Click += new System.EventHandler(this.btnLoadMetaData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 450);
            this.Controls.Add(this.btnLoadMetaData);
            this.Controls.Add(this.txtMetaData);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetaData;
        private System.Windows.Forms.Button btnLoadMetaData;
    }
}

