namespace Couvee_P3L_Kelompok2
{
    partial class Form_Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonService = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonCustomer = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customerControl1 = new Couvee_P3L_Kelompok2.CustomerControl();
            this.employeeControl1 = new Couvee_P3L_Kelompok2.EmployeeControl();
            this.serviceControl1 = new Couvee_P3L_Kelompok2.ServiceControl();
            this.productControl1 = new Couvee_P3L_Kelompok2.ProductControl();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(271, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "MAIN MENU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(235, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1027, 106);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Black;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(861, 31);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(143, 35);
            this.buttonLogout.TabIndex = 12;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Couvee_P3L_Kelompok2.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(7, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.customerControl1);
            this.panel4.Controls.Add(this.employeeControl1);
            this.panel4.Controls.Add(this.serviceControl1);
            this.panel4.Controls.Add(this.productControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(235, 103);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1027, 570);
            this.panel4.TabIndex = 13;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // buttonProduct
            // 
            this.buttonProduct.FlatAppearance.BorderSize = 0;
            this.buttonProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonProduct.Image = global::Couvee_P3L_Kelompok2.Properties.Resources.product6;
            this.buttonProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProduct.Location = new System.Drawing.Point(16, 168);
            this.buttonProduct.Margin = new System.Windows.Forms.Padding(4);
            this.buttonProduct.Name = "buttonProduct";
            this.buttonProduct.Size = new System.Drawing.Size(219, 55);
            this.buttonProduct.TabIndex = 11;
            this.buttonProduct.Text = "PRODUCT";
            this.buttonProduct.UseVisualStyleBackColor = true;
            this.buttonProduct.Click += new System.EventHandler(this.buttonProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(79, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "KOUVEE PET";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonService
            // 
            this.buttonService.FlatAppearance.BorderSize = 0;
            this.buttonService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonService.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonService.Image = global::Couvee_P3L_Kelompok2.Properties.Resources.service2;
            this.buttonService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonService.Location = new System.Drawing.Point(16, 231);
            this.buttonService.Margin = new System.Windows.Forms.Padding(4);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(219, 55);
            this.buttonService.TabIndex = 12;
            this.buttonService.Text = "SERVICE";
            this.buttonService.UseVisualStyleBackColor = true;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::Couvee_P3L_Kelompok2.Properties.Resources.dog_solid1;
            this.pictureBox1.Location = new System.Drawing.Point(16, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(113, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "SHOP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.FlatAppearance.BorderSize = 0;
            this.buttonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEmployee.Image = global::Couvee_P3L_Kelompok2.Properties.Resources.employee2;
            this.buttonEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployee.Location = new System.Drawing.Point(16, 293);
            this.buttonEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(219, 55);
            this.buttonEmployee.TabIndex = 13;
            this.buttonEmployee.Text = "EMPLOYEE";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // buttonCustomer
            // 
            this.buttonCustomer.FlatAppearance.BorderSize = 0;
            this.buttonCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCustomer.Image = global::Couvee_P3L_Kelompok2.Properties.Resources.customer2;
            this.buttonCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCustomer.Location = new System.Drawing.Point(16, 356);
            this.buttonCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCustomer.Name = "buttonCustomer";
            this.buttonCustomer.Size = new System.Drawing.Size(219, 55);
            this.buttonCustomer.TabIndex = 14;
            this.buttonCustomer.Text = "CUSTOMER";
            this.buttonCustomer.UseVisualStyleBackColor = true;
            this.buttonCustomer.Click += new System.EventHandler(this.button4_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.White;
            this.SidePanel.Location = new System.Drawing.Point(0, 168);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(13, 55);
            this.SidePanel.TabIndex = 13;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(80, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 14;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.buttonCustomer);
            this.panel1.Controls.Add(this.buttonEmployee);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonService);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 673);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // customerControl1
            // 
            this.customerControl1.Location = new System.Drawing.Point(0, 0);
            this.customerControl1.Name = "customerControl1";
            this.customerControl1.Size = new System.Drawing.Size(1027, 571);
            this.customerControl1.TabIndex = 3;
            this.customerControl1.Load += new System.EventHandler(this.customerControl1_Load);
            // 
            // employeeControl1
            // 
            this.employeeControl1.Location = new System.Drawing.Point(0, 0);
            this.employeeControl1.Name = "employeeControl1";
            this.employeeControl1.Size = new System.Drawing.Size(1027, 571);
            this.employeeControl1.TabIndex = 2;
            // 
            // serviceControl1
            // 
            this.serviceControl1.Location = new System.Drawing.Point(0, 0);
            this.serviceControl1.Name = "serviceControl1";
            this.serviceControl1.Size = new System.Drawing.Size(1027, 710);
            this.serviceControl1.TabIndex = 1;
            this.serviceControl1.Load += new System.EventHandler(this.serviceControl1_Load);
            // 
            // productControl1
            // 
            this.productControl1.Location = new System.Drawing.Point(0, 0);
            this.productControl1.Name = "productControl1";
            this.productControl1.Size = new System.Drawing.Size(1027, 571);
            this.productControl1.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private ServiceControl serviceControl1;
        private ProductControl productControl1;
        private System.Windows.Forms.Button buttonProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button buttonCustomer;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private EmployeeControl employeeControl1;
        private CustomerControl customerControl1;
        private System.Windows.Forms.Button buttonLogout;
    }
}