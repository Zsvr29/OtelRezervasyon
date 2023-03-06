
namespace Solution.OtelDüzeltmeUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kingFloor = new System.Windows.Forms.FlowLayoutPanel();
            this.floor3 = new System.Windows.Forms.FlowLayoutPanel();
            this.floor2 = new System.Windows.Forms.FlowLayoutPanel();
            this.floor1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customerRezervation = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateexit = new System.Windows.Forms.DateTimePicker();
            this.datecoming = new System.Windows.Forms.DateTimePicker();
            this.txtphoneNumber = new System.Windows.Forms.TextBox();
            this.txtbirth = new System.Windows.Forms.TextBox();
            this.txtıdentity = new System.Windows.Forms.TextBox();
            this.txtnameSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.customerRezervation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kingFloor);
            this.groupBox1.Controls.Add(this.floor3);
            this.groupBox1.Controls.Add(this.floor2);
            this.groupBox1.Controls.Add(this.floor1);
            this.groupBox1.Location = new System.Drawing.Point(25, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odalar";
            // 
            // kingFloor
            // 
            this.kingFloor.Location = new System.Drawing.Point(16, 339);
            this.kingFloor.Name = "kingFloor";
            this.kingFloor.Size = new System.Drawing.Size(500, 100);
            this.kingFloor.TabIndex = 3;
            // 
            // floor3
            // 
            this.floor3.Location = new System.Drawing.Point(16, 233);
            this.floor3.Name = "floor3";
            this.floor3.Size = new System.Drawing.Size(500, 100);
            this.floor3.TabIndex = 2;
            // 
            // floor2
            // 
            this.floor2.Location = new System.Drawing.Point(16, 125);
            this.floor2.Name = "floor2";
            this.floor2.Size = new System.Drawing.Size(500, 100);
            this.floor2.TabIndex = 1;
            // 
            // floor1
            // 
            this.floor1.Location = new System.Drawing.Point(16, 19);
            this.floor1.Name = "floor1";
            this.floor1.Size = new System.Drawing.Size(500, 100);
            this.floor1.TabIndex = 0;
            // 
            // customerRezervation
            // 
            this.customerRezervation.Controls.Add(this.btnNext);
            this.customerRezervation.Controls.Add(this.btnAdd);
            this.customerRezervation.Controls.Add(this.dateexit);
            this.customerRezervation.Controls.Add(this.datecoming);
            this.customerRezervation.Controls.Add(this.txtphoneNumber);
            this.customerRezervation.Controls.Add(this.txtbirth);
            this.customerRezervation.Controls.Add(this.txtıdentity);
            this.customerRezervation.Controls.Add(this.txtnameSurname);
            this.customerRezervation.Controls.Add(this.label6);
            this.customerRezervation.Controls.Add(this.label5);
            this.customerRezervation.Controls.Add(this.label4);
            this.customerRezervation.Controls.Add(this.label3);
            this.customerRezervation.Controls.Add(this.label2);
            this.customerRezervation.Controls.Add(this.label1);
            this.customerRezervation.Location = new System.Drawing.Point(566, 42);
            this.customerRezervation.Name = "customerRezervation";
            this.customerRezervation.Size = new System.Drawing.Size(235, 424);
            this.customerRezervation.TabIndex = 1;
            this.customerRezervation.TabStop = false;
            this.customerRezervation.Text = "Müşteri Rezervasyon Bilgileri";
            this.customerRezervation.Enter += new System.EventHandler(this.customerRezervation_Enter);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(69, 339);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Geç";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(79, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateexit
            // 
            this.dateexit.Location = new System.Drawing.Point(69, 227);
            this.dateexit.Name = "dateexit";
            this.dateexit.Size = new System.Drawing.Size(159, 20);
            this.dateexit.TabIndex = 11;
            // 
            // datecoming
            // 
            this.datecoming.Location = new System.Drawing.Point(69, 188);
            this.datecoming.Name = "datecoming";
            this.datecoming.Size = new System.Drawing.Size(160, 20);
            this.datecoming.TabIndex = 10;
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.Location = new System.Drawing.Point(79, 141);
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtphoneNumber.TabIndex = 9;
            // 
            // txtbirth
            // 
            this.txtbirth.Location = new System.Drawing.Point(79, 106);
            this.txtbirth.Name = "txtbirth";
            this.txtbirth.Size = new System.Drawing.Size(100, 20);
            this.txtbirth.TabIndex = 8;
            // 
            // txtıdentity
            // 
            this.txtıdentity.Location = new System.Drawing.Point(79, 66);
            this.txtıdentity.Name = "txtıdentity";
            this.txtıdentity.Size = new System.Drawing.Size(100, 20);
            this.txtıdentity.TabIndex = 7;
            // 
            // txtnameSurname
            // 
            this.txtnameSurname.Location = new System.Drawing.Point(79, 29);
            this.txtnameSurname.Name = "txtnameSurname";
            this.txtnameSurname.Size = new System.Drawing.Size(100, 20);
            this.txtnameSurname.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Çıkış Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giriş Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dogum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 514);
            this.Controls.Add(this.customerRezervation);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Rezervasyon İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.customerRezervation.ResumeLayout(false);
            this.customerRezervation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox customerRezervation;
        private System.Windows.Forms.DateTimePicker dateexit;
        private System.Windows.Forms.DateTimePicker datecoming;
        private System.Windows.Forms.TextBox txtphoneNumber;
        private System.Windows.Forms.TextBox txtbirth;
        private System.Windows.Forms.TextBox txtıdentity;
        private System.Windows.Forms.TextBox txtnameSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel kingFloor;
        private System.Windows.Forms.FlowLayoutPanel floor3;
        private System.Windows.Forms.FlowLayoutPanel floor2;
        private System.Windows.Forms.FlowLayoutPanel floor1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
    }
}

