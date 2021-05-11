
namespace QlySinhVienLab4
{
    partial class frmEmployeeManagement
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grb_Employee = new System.Windows.Forms.GroupBox();
            this.dgv_Employee = new System.Windows.Forms.DataGridView();
            this.grb_button = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.txt_EmployeeID = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.grb_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).BeginInit();
            this.grb_button.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên ĐN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lương";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mật khẩu";
            // 
            // grb_Employee
            // 
            this.grb_Employee.Controls.Add(this.txt_password);
            this.grb_Employee.Controls.Add(this.txt_salary);
            this.grb_Employee.Controls.Add(this.txt_fullname);
            this.grb_Employee.Controls.Add(this.txt_username);
            this.grb_Employee.Controls.Add(this.txt_Email);
            this.grb_Employee.Controls.Add(this.txt_EmployeeID);
            this.grb_Employee.Controls.Add(this.label5);
            this.grb_Employee.Controls.Add(this.label7);
            this.grb_Employee.Controls.Add(this.label2);
            this.grb_Employee.Controls.Add(this.label6);
            this.grb_Employee.Controls.Add(this.label3);
            this.grb_Employee.Controls.Add(this.label4);
            this.grb_Employee.Location = new System.Drawing.Point(22, 56);
            this.grb_Employee.Name = "grb_Employee";
            this.grb_Employee.Size = new System.Drawing.Size(746, 128);
            this.grb_Employee.TabIndex = 7;
            this.grb_Employee.TabStop = false;
            this.grb_Employee.Text = "Thông tin nhân viên";
            // 
            // dgv_Employee
            // 
            this.dgv_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee.Location = new System.Drawing.Point(22, 204);
            this.dgv_Employee.Name = "dgv_Employee";
            this.dgv_Employee.RowTemplate.Height = 25;
            this.dgv_Employee.Size = new System.Drawing.Size(731, 150);
            this.dgv_Employee.TabIndex = 8;
            // 
            // grb_button
            // 
            this.grb_button.Controls.Add(this.btn_exit);
            this.grb_button.Controls.Add(this.btn_cancel);
            this.grb_button.Controls.Add(this.btn_Save);
            this.grb_button.Controls.Add(this.btn_update);
            this.grb_button.Controls.Add(this.btn_Delete);
            this.grb_button.Controls.Add(this.btn_Add);
            this.grb_button.Location = new System.Drawing.Point(67, 376);
            this.grb_button.Name = "grb_button";
            this.grb_button.Size = new System.Drawing.Size(658, 62);
            this.grb_button.TabIndex = 9;
            this.grb_button.TabStop = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(6, 22);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(107, 22);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(210, 22);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(333, 23);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(445, 22);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(558, 22);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // txt_EmployeeID
            // 
            this.txt_EmployeeID.Location = new System.Drawing.Point(64, 18);
            this.txt_EmployeeID.Name = "txt_EmployeeID";
            this.txt_EmployeeID.Size = new System.Drawing.Size(194, 23);
            this.txt_EmployeeID.TabIndex = 7;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(64, 50);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(194, 23);
            this.txt_Email.TabIndex = 8;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(64, 85);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(194, 23);
            this.txt_username.TabIndex = 9;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(381, 22);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(227, 23);
            this.txt_fullname.TabIndex = 10;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(382, 56);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(226, 23);
            this.txt_salary.TabIndex = 11;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(382, 85);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(226, 23);
            this.txt_password.TabIndex = 12;
            // 
            // frmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grb_button);
            this.Controls.Add(this.dgv_Employee);
            this.Controls.Add(this.grb_Employee);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployeeManagement";
            this.Text = "Quản lý nhân viên";
            this.grb_Employee.ResumeLayout(false);
            this.grb_Employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee)).EndInit();
            this.grb_button.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grb_Employee;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_EmployeeID;
        private System.Windows.Forms.DataGridView dgv_Employee;
        private System.Windows.Forms.GroupBox grb_button;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
    }
}