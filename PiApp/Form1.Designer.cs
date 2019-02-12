namespace PiApp
{
    partial class piCalc
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
            this.lbl_input = new System.Windows.Forms.Label();
            this.txtbx_input = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txtbx_output = new System.Windows.Forms.TextBox();
            this.lbl_output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(109, 182);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(78, 32);
            this.lbl_input.TabIndex = 0;
            this.lbl_input.Text = "Input";
            // 
            // txtbx_input
            // 
            this.txtbx_input.Location = new System.Drawing.Point(218, 179);
            this.txtbx_input.Name = "txtbx_input";
            this.txtbx_input.Size = new System.Drawing.Size(284, 38);
            this.txtbx_input.TabIndex = 1;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(218, 286);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(284, 97);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "CalcuLATER";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // txtbx_output
            // 
            this.txtbx_output.Location = new System.Drawing.Point(218, 452);
            this.txtbx_output.Name = "txtbx_output";
            this.txtbx_output.Size = new System.Drawing.Size(473, 38);
            this.txtbx_output.TabIndex = 4;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(109, 455);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(56, 32);
            this.lbl_output.TabIndex = 3;
            this.lbl_output.Text = "Pi: ";
            // 
            // piCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 735);
            this.Controls.Add(this.txtbx_output);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txtbx_input);
            this.Controls.Add(this.lbl_input);
            this.Name = "piCalc";
            this.Text = "Pi Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox txtbx_input;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txtbx_output;
        private System.Windows.Forms.Label lbl_output;
    }
}

