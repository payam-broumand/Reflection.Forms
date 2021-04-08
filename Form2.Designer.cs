namespace Forms
{
    partial class Form2
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
            this.btnLoadAssembly = new System.Windows.Forms.Button();
            this.txtAssemblyName = new System.Windows.Forms.TextBox();
            this.listAssemblyDataTypes = new System.Windows.Forms.ListView();
            this.listAssemblyMetaData = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnLoadAssembly
            // 
            this.btnLoadAssembly.Location = new System.Drawing.Point(557, 12);
            this.btnLoadAssembly.Name = "btnLoadAssembly";
            this.btnLoadAssembly.Size = new System.Drawing.Size(102, 36);
            this.btnLoadAssembly.TabIndex = 0;
            this.btnLoadAssembly.Text = "Get Assembly";
            this.btnLoadAssembly.UseVisualStyleBackColor = true;
            // 
            // txtAssemblyName
            // 
            this.txtAssemblyName.Location = new System.Drawing.Point(12, 12);
            this.txtAssemblyName.Multiline = true;
            this.txtAssemblyName.Name = "txtAssemblyName";
            this.txtAssemblyName.Size = new System.Drawing.Size(539, 36);
            this.txtAssemblyName.TabIndex = 1;
            // 
            // listAssemblyDataTypes
            // 
            this.listAssemblyDataTypes.HideSelection = false;
            this.listAssemblyDataTypes.Location = new System.Drawing.Point(12, 54);
            this.listAssemblyDataTypes.Name = "listAssemblyDataTypes";
            this.listAssemblyDataTypes.Size = new System.Drawing.Size(316, 384);
            this.listAssemblyDataTypes.TabIndex = 2;
            this.listAssemblyDataTypes.UseCompatibleStateImageBehavior = false;
            // 
            // listAssemblyMetaData
            // 
            this.listAssemblyMetaData.HideSelection = false;
            this.listAssemblyMetaData.Location = new System.Drawing.Point(334, 54);
            this.listAssemblyMetaData.Name = "listAssemblyMetaData";
            this.listAssemblyMetaData.Size = new System.Drawing.Size(325, 384);
            this.listAssemblyMetaData.TabIndex = 2;
            this.listAssemblyMetaData.UseCompatibleStateImageBehavior = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.listAssemblyMetaData);
            this.Controls.Add(this.listAssemblyDataTypes);
            this.Controls.Add(this.txtAssemblyName);
            this.Controls.Add(this.btnLoadAssembly);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadAssembly;
        private System.Windows.Forms.TextBox txtAssemblyName;
        private System.Windows.Forms.ListView listAssemblyDataTypes;
        private System.Windows.Forms.ListView listAssemblyMetaData;
    }
}