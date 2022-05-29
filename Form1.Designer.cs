
namespace notas_escolars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.txt_nota01 = new System.Windows.Forms.TextBox();
            this.txt_nota02 = new System.Windows.Forms.TextBox();
            this.txt_nota03 = new System.Windows.Forms.TextBox();
            this.txt_nota04 = new System.Windows.Forms.TextBox();
            this.lb_exam = new System.Windows.Forms.Label();
            this.txt_exam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 170);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular Média";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 01:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nota 02:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota 03:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nota 04:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Média:";
            // 
            // txt_result
            // 
            this.txt_result.Enabled = false;
            this.txt_result.Location = new System.Drawing.Point(59, 422);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(234, 23);
            this.txt_result.TabIndex = 7;
            // 
            // txt_nota01
            // 
            this.txt_nota01.Location = new System.Drawing.Point(81, 210);
            this.txt_nota01.Name = "txt_nota01";
            this.txt_nota01.Size = new System.Drawing.Size(38, 23);
            this.txt_nota01.TabIndex = 8;
            // 
            // txt_nota02
            // 
            this.txt_nota02.Location = new System.Drawing.Point(81, 250);
            this.txt_nota02.Name = "txt_nota02";
            this.txt_nota02.Size = new System.Drawing.Size(38, 23);
            this.txt_nota02.TabIndex = 9;
            // 
            // txt_nota03
            // 
            this.txt_nota03.Location = new System.Drawing.Point(81, 289);
            this.txt_nota03.Name = "txt_nota03";
            this.txt_nota03.Size = new System.Drawing.Size(38, 23);
            this.txt_nota03.TabIndex = 10;
            // 
            // txt_nota04
            // 
            this.txt_nota04.Location = new System.Drawing.Point(81, 323);
            this.txt_nota04.Name = "txt_nota04";
            this.txt_nota04.Size = new System.Drawing.Size(38, 23);
            this.txt_nota04.TabIndex = 11;
            // 
            // lb_exam
            // 
            this.lb_exam.AutoSize = true;
            this.lb_exam.Enabled = false;
            this.lb_exam.Location = new System.Drawing.Point(12, 361);
            this.lb_exam.Name = "lb_exam";
            this.lb_exam.Size = new System.Drawing.Size(54, 17);
            this.lb_exam.TabIndex = 12;
            this.lb_exam.Text = "Exame:";
            // 
            // txt_exam
            // 
            this.txt_exam.Location = new System.Drawing.Point(81, 361);
            this.txt_exam.Name = "txt_exam";
            this.txt_exam.Size = new System.Drawing.Size(38, 23);
            this.txt_exam.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 457);
            this.Controls.Add(this.txt_exam);
            this.Controls.Add(this.lb_exam);
            this.Controls.Add(this.txt_nota04);
            this.Controls.Add(this.txt_nota03);
            this.Controls.Add(this.txt_nota02);
            this.Controls.Add(this.txt_nota01);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.TextBox txt_nota01;
        private System.Windows.Forms.TextBox txt_nota02;
        private System.Windows.Forms.TextBox txt_nota03;
        private System.Windows.Forms.TextBox txt_nota04;
        private System.Windows.Forms.Label lb_exam;
        private System.Windows.Forms.TextBox txt_exam;
    }
}

