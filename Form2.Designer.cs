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
            this.listAssemblyDataTypes = new System.Windows.Forms.ListBox();
            this.txtMetaData = new System.Windows.Forms.TextBox();
            this.btnCreateInstance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadAssembly
            // 
            this.btnLoadAssembly.Location = new System.Drawing.Point(449, 12);
            this.btnLoadAssembly.Name = "btnLoadAssembly";
            this.btnLoadAssembly.Size = new System.Drawing.Size(102, 36);
            this.btnLoadAssembly.TabIndex = 0;
            this.btnLoadAssembly.Text = "Get Assembly";
            this.btnLoadAssembly.UseVisualStyleBackColor = true;
            this.btnLoadAssembly.Click += new System.EventHandler(this.btnLoadAssembly_Click);
            // 
            // txtAssemblyName
            // 
            this.txtAssemblyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAssemblyName.Location = new System.Drawing.Point(12, 12);
            this.txtAssemblyName.Multiline = true;
            this.txtAssemblyName.Name = "txtAssemblyName";
            this.txtAssemblyName.Size = new System.Drawing.Size(431, 36);
            this.txtAssemblyName.TabIndex = 1;
            // 
            // listAssemblyDataTypes
            // 
            this.listAssemblyDataTypes.FormattingEnabled = true;
            this.listAssemblyDataTypes.Location = new System.Drawing.Point(12, 54);
            this.listAssemblyDataTypes.Name = "listAssemblyDataTypes";
            this.listAssemblyDataTypes.Size = new System.Drawing.Size(269, 381);
            this.listAssemblyDataTypes.TabIndex = 2;
            this.listAssemblyDataTypes.SelectedIndexChanged += new System.EventHandler(this.listAssemblyDataTypes_SelectedIndexChanged);
            // 
            // txtMetaData
            // 
            this.txtMetaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetaData.Location = new System.Drawing.Point(287, 54);
            this.txtMetaData.Multiline = true;
            this.txtMetaData.Name = "txtMetaData";
            this.txtMetaData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMetaData.Size = new System.Drawing.Size(372, 381);
            this.txtMetaData.TabIndex = 1;
            // 
            // btnCreateInstance
            // 
            this.btnCreateInstance.Location = new System.Drawing.Point(557, 12);
            this.btnCreateInstance.Name = "btnCreateInstance";
            this.btnCreateInstance.Size = new System.Drawing.Size(102, 36);
            this.btnCreateInstance.TabIndex = 0;
            this.btnCreateInstance.Text = "Create Instance";
            this.btnCreateInstance.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.listAssemblyDataTypes);
            this.Controls.Add(this.txtMetaData);
            this.Controls.Add(this.txtAssemblyName);
            this.Controls.Add(this.btnCreateInstance);
            this.Controls.Add(this.btnLoadAssembly);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadAssembly;
        private System.Windows.Forms.TextBox txtAssemblyName;
        private System.Windows.Forms.ListBox listAssemblyDataTypes;
        private System.Windows.Forms.TextBox txtMetaData;
        private System.Windows.Forms.Button btnCreateInstance;
    }
}