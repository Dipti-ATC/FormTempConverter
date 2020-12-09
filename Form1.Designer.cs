
namespace FormTempConverter
{
    partial class TempConverter
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
            this.lblTempConverter = new System.Windows.Forms.Label();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFah = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.txtFah = new System.Windows.Forms.TextBox();
            this.btnCelToFah = new System.Windows.Forms.Button();
            this.btnFahToCel = new System.Windows.Forms.Button();
            this.grbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTempConverter
            // 
            this.lblTempConverter.AutoSize = true;
            this.lblTempConverter.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempConverter.Location = new System.Drawing.Point(68, 46);
            this.lblTempConverter.Name = "lblTempConverter";
            this.lblTempConverter.Size = new System.Drawing.Size(229, 27);
            this.lblTempConverter.TabIndex = 0;
            this.lblTempConverter.Text = "Temperature Converter";
            // 
            // grbButtons
            // 
            this.grbButtons.BackColor = System.Drawing.Color.SandyBrown;
            this.grbButtons.Controls.Add(this.btnFahToCel);
            this.grbButtons.Controls.Add(this.btnCelToFah);
            this.grbButtons.Controls.Add(this.txtFah);
            this.grbButtons.Controls.Add(this.txtCel);
            this.grbButtons.Controls.Add(this.lblFah);
            this.grbButtons.Controls.Add(this.lblCelsius);
            this.grbButtons.Location = new System.Drawing.Point(32, 96);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(301, 154);
            this.grbButtons.TabIndex = 1;
            this.grbButtons.TabStop = false;
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCelsius.Location = new System.Drawing.Point(41, 40);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCelsius.Size = new System.Drawing.Size(53, 17);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblFah
            // 
            this.lblFah.AutoSize = true;
            this.lblFah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFah.Location = new System.Drawing.Point(41, 90);
            this.lblFah.Name = "lblFah";
            this.lblFah.Size = new System.Drawing.Size(76, 17);
            this.lblFah.TabIndex = 1;
            this.lblFah.Text = "Fahrenheit";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(41, 60);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(100, 20);
            this.txtCel.TabIndex = 2;
            // 
            // txtFah
            // 
            this.txtFah.Location = new System.Drawing.Point(41, 119);
            this.txtFah.Name = "txtFah";
            this.txtFah.Size = new System.Drawing.Size(100, 20);
            this.txtFah.TabIndex = 3;
            // 
            // btnCelToFah
            // 
            this.btnCelToFah.Location = new System.Drawing.Point(190, 57);
            this.btnCelToFah.Name = "btnCelToFah";
            this.btnCelToFah.Size = new System.Drawing.Size(75, 23);
            this.btnCelToFah.TabIndex = 4;
            this.btnCelToFah.Text = "Cel To Fah";
            this.btnCelToFah.UseVisualStyleBackColor = true;
            this.btnCelToFah.Click += new System.EventHandler(this.btnCelToFah_Click);
            // 
            // btnFahToCel
            // 
            this.btnFahToCel.Location = new System.Drawing.Point(190, 116);
            this.btnFahToCel.Name = "btnFahToCel";
            this.btnFahToCel.Size = new System.Drawing.Size(75, 23);
            this.btnFahToCel.TabIndex = 5;
            this.btnFahToCel.Text = "Fah To Cel ";
            this.btnFahToCel.UseVisualStyleBackColor = true;
            this.btnFahToCel.Click += new System.EventHandler(this.btnFahToCel_Click);
            // 
            // TempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(391, 287);
            this.Controls.Add(this.grbButtons);
            this.Controls.Add(this.lblTempConverter);
            this.Name = "TempConverter";
            this.Text = "Temperature Converter";
            this.grbButtons.ResumeLayout(false);
            this.grbButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempConverter;
        private System.Windows.Forms.GroupBox grbButtons;
        private System.Windows.Forms.Button btnFahToCel;
        private System.Windows.Forms.Button btnCelToFah;
        private System.Windows.Forms.TextBox txtFah;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label lblFah;
        private System.Windows.Forms.Label lblCelsius;
    }
}

