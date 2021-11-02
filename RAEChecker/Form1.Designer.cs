
namespace RAEChecker
{
    partial class FormRAE
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
            this.panel_base = new System.Windows.Forms.Panel();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.label_result = new System.Windows.Forms.Label();
            this.button_check = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            this.panel_base.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_base
            // 
            this.panel_base.Controls.Add(this.label_info);
            this.panel_base.Controls.Add(this.textBox_input);
            this.panel_base.Controls.Add(this.label_result);
            this.panel_base.Controls.Add(this.button_check);
            this.panel_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_base.Location = new System.Drawing.Point(0, 0);
            this.panel_base.Name = "panel_base";
            this.panel_base.Size = new System.Drawing.Size(800, 450);
            this.panel_base.TabIndex = 0;
            // 
            // textBox_input
            // 
            this.textBox_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_input.Location = new System.Drawing.Point(146, 77);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(515, 38);
            this.textBox_input.TabIndex = 2;
            // 
            // label_result
            // 
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(250, 173);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(300, 39);
            this.label_result.TabIndex = 1;
            this.label_result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_check
            // 
            this.button_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.Location = new System.Drawing.Point(309, 266);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(189, 56);
            this.button_check.TabIndex = 0;
            this.button_check.Text = "CHECK";
            this.button_check.UseVisualStyleBackColor = true;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // label_info
            // 
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.Location = new System.Drawing.Point(213, 345);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(380, 39);
            this.label_info.TabIndex = 3;
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_base);
            this.Name = "FormRAE";
            this.Text = "RAE Checker";
            this.panel_base.ResumeLayout(false);
            this.panel_base.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_base;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.Label label_info;
    }
}

