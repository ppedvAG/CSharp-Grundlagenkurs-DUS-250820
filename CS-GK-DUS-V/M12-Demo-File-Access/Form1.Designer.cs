namespace M12_Demo_File_Access
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
            this.btnAddTransport = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAsJSON = new System.Windows.Forms.Button();
            this.btnReadJSON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTransport
            // 
            this.btnAddTransport.Location = new System.Drawing.Point(62, 175);
            this.btnAddTransport.Name = "btnAddTransport";
            this.btnAddTransport.Size = new System.Drawing.Size(132, 49);
            this.btnAddTransport.TabIndex = 0;
            this.btnAddTransport.Text = "neues Transportmittel";
            this.btnAddTransport.UseVisualStyleBackColor = true;
            this.btnAddTransport.Click += new System.EventHandler(this.btnAddTransport_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(131, 21);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(164, 22);
            this.txtBoxName.TabIndex = 1;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Location = new System.Drawing.Point(129, 77);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(165, 22);
            this.numericUpDownPrice.TabIndex = 2;
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(129, 129);
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(165, 22);
            this.numericUpDownSpeed.TabIndex = 3;
            this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name: ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(10, 77);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Preis:";
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.Location = new System.Drawing.Point(10, 131);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(91, 17);
            this.lblMaxSpeed.TabIndex = 6;
            this.lblMaxSpeed.Text = "MaxGeschw.:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(62, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 61);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAsJSON
            // 
            this.btnSaveAsJSON.Location = new System.Drawing.Point(62, 335);
            this.btnSaveAsJSON.Name = "btnSaveAsJSON";
            this.btnSaveAsJSON.Size = new System.Drawing.Size(129, 58);
            this.btnSaveAsJSON.TabIndex = 8;
            this.btnSaveAsJSON.Text = "SaveAsJSON";
            this.btnSaveAsJSON.UseVisualStyleBackColor = true;
            this.btnSaveAsJSON.Click += new System.EventHandler(this.btnSaveAsJSON_Click);
            // 
            // btnReadJSON
            // 
            this.btnReadJSON.Location = new System.Drawing.Point(417, 21);
            this.btnReadJSON.Name = "btnReadJSON";
            this.btnReadJSON.Size = new System.Drawing.Size(129, 58);
            this.btnReadJSON.TabIndex = 9;
            this.btnReadJSON.Text = "ReadJSON";
            this.btnReadJSON.UseVisualStyleBackColor = true;
            this.btnReadJSON.Click += new System.EventHandler(this.btnReadJSON_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadJSON);
            this.Controls.Add(this.btnSaveAsJSON);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMaxSpeed);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnAddTransport);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTransport;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMaxSpeed;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAsJSON;
        private System.Windows.Forms.Button btnReadJSON;
    }
}

