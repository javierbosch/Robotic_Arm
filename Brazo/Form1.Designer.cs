namespace Brazo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BS_trackBar = new System.Windows.Forms.TrackBar();
            this.SS_trackBar = new System.Windows.Forms.TrackBar();
            this.ES_trackBar = new System.Windows.Forms.TrackBar();
            this.WFS_trackBar = new System.Windows.Forms.TrackBar();
            this.WRS_trackBar = new System.Windows.Forms.TrackBar();
            this.GS_trackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.macro10 = new System.Windows.Forms.Button();
            this.macro9 = new System.Windows.Forms.Button();
            this.macro8 = new System.Windows.Forms.Button();
            this.macro7 = new System.Windows.Forms.Button();
            this.macro6 = new System.Windows.Forms.Button();
            this.macro5 = new System.Windows.Forms.Button();
            this.macro4 = new System.Windows.Forms.Button();
            this.macro3 = new System.Windows.Forms.Button();
            this.macro2 = new System.Windows.Forms.Button();
            this.macro1 = new System.Windows.Forms.Button();
            this.BS_textBox = new System.Windows.Forms.TextBox();
            this.SS_textBox = new System.Windows.Forms.TextBox();
            this.ES_textBox = new System.Windows.Forms.TextBox();
            this.WFS_textBox = new System.Windows.Forms.TextBox();
            this.WRS_textBox = new System.Windows.Forms.TextBox();
            this.GS_textBox = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BS_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SS_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ES_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WFS_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WRS_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GS_trackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.BS_trackBar.Location = new System.Drawing.Point(5, 23);
            this.BS_trackBar.Maximum = 180;
            this.BS_trackBar.Name = "trackBar1";
            this.BS_trackBar.Size = new System.Drawing.Size(326, 45);
            this.BS_trackBar.TabIndex = 0;
            this.BS_trackBar.Scroll += new System.EventHandler(this.BaseServo_Scroll);
            // 
            // trackBar2
            // 
            this.SS_trackBar.Location = new System.Drawing.Point(5, 74);
            this.SS_trackBar.Maximum = 180;
            this.SS_trackBar.Name = "trackBar2";
            this.SS_trackBar.Size = new System.Drawing.Size(326, 45);
            this.SS_trackBar.TabIndex = 1;
            this.SS_trackBar.Scroll += new System.EventHandler(this.ShoulderServo_Scroll);
            // 
            // trackBar3
            // 
            this.ES_trackBar.Location = new System.Drawing.Point(5, 125);
            this.ES_trackBar.Maximum = 180;
            this.ES_trackBar.Name = "trackBar3";
            this.ES_trackBar.Size = new System.Drawing.Size(326, 45);
            this.ES_trackBar.TabIndex = 2;
            this.ES_trackBar.Scroll += new System.EventHandler(this.ElbowServo_Scroll);
            // 
            // trackBar4
            // 
            this.WFS_trackBar.Location = new System.Drawing.Point(379, 23);
            this.WFS_trackBar.Maximum = 180;
            this.WFS_trackBar.Name = "trackBar4";
            this.WFS_trackBar.Size = new System.Drawing.Size(326, 45);
            this.WFS_trackBar.TabIndex = 3;
            this.WFS_trackBar.Scroll += new System.EventHandler(this.WristFlexServo);
            // 
            // trackBar5
            // 
            this.WRS_trackBar.Location = new System.Drawing.Point(379, 74);
            this.WRS_trackBar.Maximum = 180;
            this.WRS_trackBar.Name = "trackBar5";
            this.WRS_trackBar.Size = new System.Drawing.Size(326, 45);
            this.WRS_trackBar.TabIndex = 4;
            this.WRS_trackBar.Scroll += new System.EventHandler(this.WristRotateServo_Scroll);
            // 
            // trackBar6
            // 
            this.GS_trackBar.Location = new System.Drawing.Point(379, 125);
            this.GS_trackBar.Maximum = 180;
            this.GS_trackBar.Name = "trackBar6";
            this.GS_trackBar.Size = new System.Drawing.Size(326, 45);
            this.GS_trackBar.TabIndex = 5;
            this.GS_trackBar.Scroll += new System.EventHandler(this.GripperServo_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Base servo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Shoulder servo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Elbow servo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gripper servo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Wrist rotate servo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wrist flex servo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 61);
            this.button1.TabIndex = 12;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Home_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.macro10);
            this.panel1.Controls.Add(this.macro9);
            this.panel1.Controls.Add(this.macro8);
            this.panel1.Controls.Add(this.macro7);
            this.panel1.Controls.Add(this.macro6);
            this.panel1.Controls.Add(this.macro5);
            this.panel1.Controls.Add(this.macro4);
            this.panel1.Controls.Add(this.macro3);
            this.panel1.Controls.Add(this.macro2);
            this.panel1.Controls.Add(this.macro1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(386, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 61);
            this.panel1.TabIndex = 13;
            // 
            // macro10
            // 
            this.macro10.Location = new System.Drawing.Point(268, 32);
            this.macro10.Name = "macro10";
            this.macro10.Size = new System.Drawing.Size(60, 22);
            this.macro10.TabIndex = 9;
            this.macro10.Text = "Macro10";
            this.macro10.UseVisualStyleBackColor = true;
            this.macro10.Click += new System.EventHandler(this.Macro10_Click);
            // 
            // macro9
            // 
            this.macro9.Location = new System.Drawing.Point(202, 32);
            this.macro9.Name = "macro9";
            this.macro9.Size = new System.Drawing.Size(60, 22);
            this.macro9.TabIndex = 8;
            this.macro9.Text = "Macro9";
            this.macro9.UseVisualStyleBackColor = true;
            this.macro9.Click += new System.EventHandler(this.Macro9_Click);
            // 
            // macro8
            // 
            this.macro8.Location = new System.Drawing.Point(136, 32);
            this.macro8.Name = "macro8";
            this.macro8.Size = new System.Drawing.Size(60, 22);
            this.macro8.TabIndex = 7;
            this.macro8.Text = "Macro8";
            this.macro8.UseVisualStyleBackColor = true;
            this.macro8.Click += new System.EventHandler(this.Macro8_Click);
            // 
            // macro7
            // 
            this.macro7.Location = new System.Drawing.Point(70, 32);
            this.macro7.Name = "macro7";
            this.macro7.Size = new System.Drawing.Size(60, 22);
            this.macro7.TabIndex = 6;
            this.macro7.Text = "Macro7";
            this.macro7.UseVisualStyleBackColor = true;
            this.macro7.Click += new System.EventHandler(this.Macro7_Click);
            // 
            // macro6
            // 
            this.macro6.Location = new System.Drawing.Point(4, 32);
            this.macro6.Name = "macro6";
            this.macro6.Size = new System.Drawing.Size(60, 22);
            this.macro6.TabIndex = 5;
            this.macro6.Text = "Macro6";
            this.macro6.UseVisualStyleBackColor = true;
            this.macro6.Click += new System.EventHandler(this.Macro6_Click);
            // 
            // macro5
            // 
            this.macro5.Location = new System.Drawing.Point(268, 4);
            this.macro5.Name = "macro5";
            this.macro5.Size = new System.Drawing.Size(60, 22);
            this.macro5.TabIndex = 4;
            this.macro5.Text = "Macro5";
            this.macro5.UseVisualStyleBackColor = true;
            this.macro5.Click += new System.EventHandler(this.Macro5_Click);
            // 
            // macro4
            // 
            this.macro4.Location = new System.Drawing.Point(202, 4);
            this.macro4.Name = "macro4";
            this.macro4.Size = new System.Drawing.Size(60, 22);
            this.macro4.TabIndex = 3;
            this.macro4.Text = "Macro4";
            this.macro4.UseVisualStyleBackColor = true;
            this.macro4.Click += new System.EventHandler(this.Macro4_Click);
            // 
            // macro3
            // 
            this.macro3.Location = new System.Drawing.Point(136, 4);
            this.macro3.Name = "macro3";
            this.macro3.Size = new System.Drawing.Size(60, 22);
            this.macro3.TabIndex = 2;
            this.macro3.Text = "Macro3";
            this.macro3.UseVisualStyleBackColor = true;
            this.macro3.Click += new System.EventHandler(this.Macro3_Click);
            // 
            // macro2
            // 
            this.macro2.Location = new System.Drawing.Point(70, 4);
            this.macro2.Name = "macro2";
            this.macro2.Size = new System.Drawing.Size(60, 22);
            this.macro2.TabIndex = 1;
            this.macro2.Text = "Macro2";
            this.macro2.UseVisualStyleBackColor = true;
            this.macro2.Click += new System.EventHandler(this.Macro2_Click);
            // 
            // macro1
            // 
            this.macro1.Location = new System.Drawing.Point(4, 4);
            this.macro1.Name = "macro1";
            this.macro1.Size = new System.Drawing.Size(60, 22);
            this.macro1.TabIndex = 0;
            this.macro1.Text = "Macro1";
            this.macro1.UseVisualStyleBackColor = true;
            this.macro1.Click += new System.EventHandler(this.Macro1_Click);
            // 
            // textBox1
            // 
            this.BS_textBox.Enabled = false;
            this.BS_textBox.Location = new System.Drawing.Point(337, 23);
            this.BS_textBox.MaxLength = 3;
            this.BS_textBox.Name = "textBox1";
            this.BS_textBox.Size = new System.Drawing.Size(29, 20);
            this.BS_textBox.TabIndex = 14;
            this.BS_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BS_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BaseServo_KeyDown);
            // 
            // textBox2
            // 
            this.SS_textBox.Enabled = false;
            this.SS_textBox.Location = new System.Drawing.Point(337, 74);
            this.SS_textBox.MaxLength = 3;
            this.SS_textBox.Name = "textBox2";
            this.SS_textBox.Size = new System.Drawing.Size(29, 20);
            this.SS_textBox.TabIndex = 15;
            this.SS_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SS_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShoulderServo_KeyDown);
            // 
            // textBox3
            // 
            this.ES_textBox.Enabled = false;
            this.ES_textBox.Location = new System.Drawing.Point(337, 125);
            this.ES_textBox.MaxLength = 3;
            this.ES_textBox.Name = "textBox3";
            this.ES_textBox.Size = new System.Drawing.Size(29, 20);
            this.ES_textBox.TabIndex = 16;
            this.ES_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ES_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ElbowServo_KeyDown);
            // 
            // textBox4
            // 
            this.WFS_textBox.Enabled = false;
            this.WFS_textBox.Location = new System.Drawing.Point(711, 23);
            this.WFS_textBox.MaxLength = 3;
            this.WFS_textBox.Name = "textBox4";
            this.WFS_textBox.Size = new System.Drawing.Size(29, 20);
            this.WFS_textBox.TabIndex = 17;
            this.WFS_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WFS_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WristFlexServo_KeyDown);
            // 
            // textBox5
            // 
            this.WRS_textBox.Enabled = false;
            this.WRS_textBox.Location = new System.Drawing.Point(711, 74);
            this.WRS_textBox.MaxLength = 3;
            this.WRS_textBox.Name = "textBox5";
            this.WRS_textBox.Size = new System.Drawing.Size(29, 20);
            this.WRS_textBox.TabIndex = 18;
            this.WRS_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WRS_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WristRotateServo_KeyDown);
            // 
            // textBox6
            // 
            this.GS_textBox.Enabled = false;
            this.GS_textBox.Location = new System.Drawing.Point(711, 125);
            this.GS_textBox.MaxLength = 3;
            this.GS_textBox.Name = "textBox6";
            this.GS_textBox.Size = new System.Drawing.Size(29, 20);
            this.GS_textBox.TabIndex = 19;
            this.GS_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GS_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GripperServo_KeyDown);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(309, 181);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(47, 22);
            this.button10.TabIndex = 20;
            this.button10.Text = "Pro UI";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ProIU_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 242);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.GS_textBox);
            this.Controls.Add(this.WRS_textBox);
            this.Controls.Add(this.WFS_textBox);
            this.Controls.Add(this.ES_textBox);
            this.Controls.Add(this.SS_textBox);
            this.Controls.Add(this.BS_textBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GS_trackBar);
            this.Controls.Add(this.WRS_trackBar);
            this.Controls.Add(this.WFS_trackBar);
            this.Controls.Add(this.ES_trackBar);
            this.Controls.Add(this.SS_trackBar);
            this.Controls.Add(this.BS_trackBar);
            this.Name = "Form1";
            this.Text = "Robotic Arm";
            ((System.ComponentModel.ISupportInitialize)(this.BS_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SS_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ES_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WFS_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WRS_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GS_trackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar BS_trackBar;
        private System.Windows.Forms.TrackBar SS_trackBar;
        private System.Windows.Forms.TrackBar ES_trackBar;
        private System.Windows.Forms.TrackBar WFS_trackBar;
        private System.Windows.Forms.TrackBar WRS_trackBar;
        private System.Windows.Forms.TrackBar GS_trackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button macro6;
        private System.Windows.Forms.Button macro5;
        private System.Windows.Forms.Button macro4;
        private System.Windows.Forms.Button macro3;
        private System.Windows.Forms.Button macro2;
        private System.Windows.Forms.Button macro1;
        private System.Windows.Forms.Button macro8;
        private System.Windows.Forms.Button macro7;
        private System.Windows.Forms.TextBox BS_textBox;
        private System.Windows.Forms.TextBox SS_textBox;
        private System.Windows.Forms.TextBox ES_textBox;
        private System.Windows.Forms.TextBox WFS_textBox;
        private System.Windows.Forms.TextBox WRS_textBox;
        private System.Windows.Forms.TextBox GS_textBox;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button macro10;
        private System.Windows.Forms.Button macro9;
    }
}

