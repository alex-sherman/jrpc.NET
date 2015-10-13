using System.Windows.Forms;
namespace SampleApplication
{
    partial class ColorControl
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorRadio = new System.Windows.Forms.RadioButton();
            this.animationRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.animationBox = new System.Windows.Forms.GroupBox();
            this.flatColorBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.animationBox.SuspendLayout();
            this.flatColorBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(6, 121);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(260, 45);
            this.trackBar3.TabIndex = 7;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(6, 70);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(260, 45);
            this.trackBar2.TabIndex = 6;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 19);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(260, 45);
            this.trackBar1.TabIndex = 5;
            // 
            // colorRadio
            // 
            this.colorRadio.AutoSize = true;
            this.colorRadio.Location = new System.Drawing.Point(15, 19);
            this.colorRadio.Name = "colorRadio";
            this.colorRadio.Size = new System.Drawing.Size(69, 17);
            this.colorRadio.TabIndex = 8;
            this.colorRadio.TabStop = true;
            this.colorRadio.Text = "Flat Color";
            this.colorRadio.UseVisualStyleBackColor = true;
            this.colorRadio.CheckedChanged += new System.EventHandler(this.colorRadio_CheckedChanged);
            // 
            // animationRadio
            // 
            this.animationRadio.AutoSize = true;
            this.animationRadio.Location = new System.Drawing.Point(15, 38);
            this.animationRadio.Name = "animationRadio";
            this.animationRadio.Size = new System.Drawing.Size(71, 17);
            this.animationRadio.TabIndex = 9;
            this.animationRadio.TabStop = true;
            this.animationRadio.Text = "Animation";
            this.animationRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.colorRadio);
            this.groupBox1.Controls.Add(this.animationRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(119, 218);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Control";
            // 
            // animationBox
            // 
            this.animationBox.Controls.Add(this.comboBox1);
            this.animationBox.Location = new System.Drawing.Point(153, 22);
            this.animationBox.Name = "animationBox";
            this.animationBox.Size = new System.Drawing.Size(276, 208);
            this.animationBox.TabIndex = 11;
            this.animationBox.TabStop = false;
            this.animationBox.Text = "Animation";
            this.animationBox.Visible = false;
            // 
            // flatColorBox
            // 
            this.flatColorBox.Controls.Add(this.trackBar1);
            this.flatColorBox.Controls.Add(this.trackBar3);
            this.flatColorBox.Controls.Add(this.trackBar2);
            this.flatColorBox.Location = new System.Drawing.Point(154, 22);
            this.flatColorBox.Name = "flatColorBox";
            this.flatColorBox.Size = new System.Drawing.Size(275, 208);
            this.flatColorBox.TabIndex = 12;
            this.flatColorBox.TabStop = false;
            this.flatColorBox.Text = "Flat Color";
            this.flatColorBox.Visible = false;
            // 
            // ColorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 248);
            this.Controls.Add(this.flatColorBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.animationBox);
            this.Name = "ColorControl";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.animationBox.ResumeLayout(false);
            this.flatColorBox.ResumeLayout(false);
            this.flatColorBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private TrackBar trackBar3;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private RadioButton colorRadio;
        private RadioButton animationRadio;
        private GroupBox groupBox1;
        private GroupBox animationBox;
        private GroupBox flatColorBox;
    }
}

