namespace SportsClubRegistration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formTitle = new Label();
            label_Name = new Label();
            TextBox_name = new MaskedTextBox();
            label_DOB = new Label();
            dateTimePicker_DOB = new DateTimePicker();
            label_membershipType = new Label();
            comboBox_membershipType = new ComboBox();
            GB_personalInformation = new GroupBox();
            TextBox_adress = new MaskedTextBox();
            label_address = new Label();
            GB_contactInformation = new GroupBox();
            TextBox_email = new MaskedTextBox();
            label_email = new Label();
            TextBox_mobile = new MaskedTextBox();
            label_Mobile = new Label();
            GB_heaithInformation = new GroupBox();
            TextBox_helthConditions = new MaskedTextBox();
            label_healthConditions = new Label();
            GB_membershipInformation = new GroupBox();
            TextBox_paymentAmount = new MaskedTextBox();
            label_paymentAmount = new Label();
            comboBox_paymentMethod = new ComboBox();
            label_paymentMethod = new Label();
            dateTimePicker_membershipStartDate = new DateTimePicker();
            label_memberShipStartDate = new Label();
            button_submit = new Button();
            button_cancel = new Button();
            GB_personalInformation.SuspendLayout();
            GB_contactInformation.SuspendLayout();
            GB_heaithInformation.SuspendLayout();
            GB_membershipInformation.SuspendLayout();
            SuspendLayout();
            // 
            // formTitle
            // 
            formTitle.AutoSize = true;
            formTitle.Font = new Font("Segoe UI Historic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formTitle.Location = new Point(286, 21);
            formTitle.Name = "formTitle";
            formTitle.Size = new Size(631, 46);
            formTitle.TabIndex = 0;
            formTitle.Text = "Sports Club New Member Registration";
            // 
            // label_Name
            // 
            label_Name.AutoSize = true;
            label_Name.Location = new Point(30, 39);
            label_Name.Name = "label_Name";
            label_Name.Size = new Size(79, 20);
            label_Name.TabIndex = 1;
            label_Name.Text = "Full Name";
            label_Name.Click += label2_Click;
            // 
            // TextBox_name
            // 
            TextBox_name.Location = new Point(178, 39);
            TextBox_name.Name = "TextBox_name";
            TextBox_name.Size = new Size(923, 27);
            TextBox_name.TabIndex = 2;
            TextBox_name.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label_DOB
            // 
            label_DOB.AutoSize = true;
            label_DOB.Location = new Point(30, 83);
            label_DOB.Name = "label_DOB";
            label_DOB.Size = new Size(98, 20);
            label_DOB.TabIndex = 3;
            label_DOB.Text = "Date Of Birth";
            // 
            // dateTimePicker_DOB
            // 
            dateTimePicker_DOB.Location = new Point(178, 85);
            dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            dateTimePicker_DOB.Size = new Size(343, 27);
            dateTimePicker_DOB.TabIndex = 4;
            // 
            // label_membershipType
            // 
            label_membershipType.AutoSize = true;
            label_membershipType.Location = new Point(607, 90);
            label_membershipType.Name = "label_membershipType";
            label_membershipType.Size = new Size(131, 20);
            label_membershipType.TabIndex = 5;
            label_membershipType.Text = "MemberShip type";
            // 
            // comboBox_membershipType
            // 
            comboBox_membershipType.FormattingEnabled = true;
            comboBox_membershipType.Items.AddRange(new object[] { "player", "coach", "supporter" });
            comboBox_membershipType.Location = new Point(758, 87);
            comboBox_membershipType.Name = "comboBox_membershipType";
            comboBox_membershipType.Size = new Size(343, 28);
            comboBox_membershipType.TabIndex = 6;
            // 
            // GB_personalInformation
            // 
            GB_personalInformation.BackColor = Color.Snow;
            GB_personalInformation.Controls.Add(TextBox_adress);
            GB_personalInformation.Controls.Add(label_address);
            GB_personalInformation.Controls.Add(comboBox_membershipType);
            GB_personalInformation.Controls.Add(label_membershipType);
            GB_personalInformation.Controls.Add(dateTimePicker_DOB);
            GB_personalInformation.Controls.Add(label_DOB);
            GB_personalInformation.Controls.Add(TextBox_name);
            GB_personalInformation.Controls.Add(label_Name);
            GB_personalInformation.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            GB_personalInformation.ForeColor = SystemColors.ControlText;
            GB_personalInformation.Location = new Point(12, 89);
            GB_personalInformation.Name = "GB_personalInformation";
            GB_personalInformation.Size = new Size(1135, 172);
            GB_personalInformation.TabIndex = 7;
            GB_personalInformation.TabStop = false;
            GB_personalInformation.Text = "Personal Information";
            GB_personalInformation.Enter += groupBox1_Enter;
            // 
            // TextBox_adress
            // 
            TextBox_adress.Location = new Point(178, 126);
            TextBox_adress.Name = "TextBox_adress";
            TextBox_adress.Size = new Size(923, 27);
            TextBox_adress.TabIndex = 8;
            // 
            // label_address
            // 
            label_address.AutoSize = true;
            label_address.Location = new Point(30, 126);
            label_address.Name = "label_address";
            label_address.Size = new Size(63, 20);
            label_address.TabIndex = 7;
            label_address.Text = "Address";
            // 
            // GB_contactInformation
            // 
            GB_contactInformation.BackColor = Color.Snow;
            GB_contactInformation.Controls.Add(TextBox_email);
            GB_contactInformation.Controls.Add(label_email);
            GB_contactInformation.Controls.Add(TextBox_mobile);
            GB_contactInformation.Controls.Add(label_Mobile);
            GB_contactInformation.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            GB_contactInformation.ForeColor = SystemColors.ControlText;
            GB_contactInformation.Location = new Point(12, 281);
            GB_contactInformation.Name = "GB_contactInformation";
            GB_contactInformation.Size = new Size(1135, 102);
            GB_contactInformation.TabIndex = 8;
            GB_contactInformation.TabStop = false;
            GB_contactInformation.Text = "Contact Information";
            // 
            // TextBox_email
            // 
            TextBox_email.Location = new Point(178, 44);
            TextBox_email.Name = "TextBox_email";
            TextBox_email.Size = new Size(343, 27);
            TextBox_email.TabIndex = 12;
            // 
            // label_email
            // 
            label_email.AutoSize = true;
            label_email.Location = new Point(30, 44);
            label_email.Name = "label_email";
            label_email.Size = new Size(46, 20);
            label_email.TabIndex = 11;
            label_email.Text = "Email";
            // 
            // TextBox_mobile
            // 
            TextBox_mobile.Location = new Point(758, 44);
            TextBox_mobile.Name = "TextBox_mobile";
            TextBox_mobile.Size = new Size(343, 27);
            TextBox_mobile.TabIndex = 10;
            // 
            // label_Mobile
            // 
            label_Mobile.AutoSize = true;
            label_Mobile.Location = new Point(610, 44);
            label_Mobile.Name = "label_Mobile";
            label_Mobile.Size = new Size(57, 20);
            label_Mobile.TabIndex = 9;
            label_Mobile.Text = "Mobile";
            // 
            // GB_heaithInformation
            // 
            GB_heaithInformation.BackColor = Color.Snow;
            GB_heaithInformation.Controls.Add(TextBox_helthConditions);
            GB_heaithInformation.Controls.Add(label_healthConditions);
            GB_heaithInformation.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            GB_heaithInformation.ForeColor = SystemColors.ControlText;
            GB_heaithInformation.Location = new Point(12, 399);
            GB_heaithInformation.Name = "GB_heaithInformation";
            GB_heaithInformation.Size = new Size(1135, 125);
            GB_heaithInformation.TabIndex = 9;
            GB_heaithInformation.TabStop = false;
            GB_heaithInformation.Text = "Health Information";
            GB_heaithInformation.Enter += groupBox3_Enter;
            // 
            // TextBox_helthConditions
            // 
            TextBox_helthConditions.Location = new Point(178, 56);
            TextBox_helthConditions.Name = "TextBox_helthConditions";
            TextBox_helthConditions.Size = new Size(923, 27);
            TextBox_helthConditions.TabIndex = 12;
            // 
            // label_healthConditions
            // 
            label_healthConditions.AutoSize = true;
            label_healthConditions.Location = new Point(30, 39);
            label_healthConditions.Name = "label_healthConditions";
            label_healthConditions.Size = new Size(133, 60);
            label_healthConditions.TabIndex = 11;
            label_healthConditions.Text = "Health conditions \r\nor special\r\nconsiderations";
            // 
            // GB_membershipInformation
            // 
            GB_membershipInformation.BackColor = Color.Snow;
            GB_membershipInformation.Controls.Add(TextBox_paymentAmount);
            GB_membershipInformation.Controls.Add(label_paymentAmount);
            GB_membershipInformation.Controls.Add(comboBox_paymentMethod);
            GB_membershipInformation.Controls.Add(label_paymentMethod);
            GB_membershipInformation.Controls.Add(dateTimePicker_membershipStartDate);
            GB_membershipInformation.Controls.Add(label_memberShipStartDate);
            GB_membershipInformation.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            GB_membershipInformation.ForeColor = SystemColors.ControlText;
            GB_membershipInformation.Location = new Point(12, 552);
            GB_membershipInformation.Name = "GB_membershipInformation";
            GB_membershipInformation.Size = new Size(1135, 172);
            GB_membershipInformation.TabIndex = 10;
            GB_membershipInformation.TabStop = false;
            GB_membershipInformation.Text = "MemberShip Information";
            // 
            // TextBox_paymentAmount
            // 
            TextBox_paymentAmount.Location = new Point(178, 86);
            TextBox_paymentAmount.Name = "TextBox_paymentAmount";
            TextBox_paymentAmount.Size = new Size(343, 27);
            TextBox_paymentAmount.TabIndex = 14;
            // 
            // label_paymentAmount
            // 
            label_paymentAmount.AutoSize = true;
            label_paymentAmount.Location = new Point(30, 86);
            label_paymentAmount.Name = "label_paymentAmount";
            label_paymentAmount.Size = new Size(128, 20);
            label_paymentAmount.TabIndex = 13;
            label_paymentAmount.Text = "Payment Amount";
            // 
            // comboBox_paymentMethod
            // 
            comboBox_paymentMethod.FormattingEnabled = true;
            comboBox_paymentMethod.Items.AddRange(new object[] { "cash", "card", "online trasfer" });
            comboBox_paymentMethod.Location = new Point(758, 83);
            comboBox_paymentMethod.Name = "comboBox_paymentMethod";
            comboBox_paymentMethod.Size = new Size(343, 28);
            comboBox_paymentMethod.TabIndex = 6;
            // 
            // label_paymentMethod
            // 
            label_paymentMethod.AutoSize = true;
            label_paymentMethod.Location = new Point(610, 86);
            label_paymentMethod.Name = "label_paymentMethod";
            label_paymentMethod.Size = new Size(127, 20);
            label_paymentMethod.TabIndex = 5;
            label_paymentMethod.Text = "Payment Method";
            // 
            // dateTimePicker_membershipStartDate
            // 
            dateTimePicker_membershipStartDate.Location = new Point(178, 39);
            dateTimePicker_membershipStartDate.Name = "dateTimePicker_membershipStartDate";
            dateTimePicker_membershipStartDate.Size = new Size(343, 27);
            dateTimePicker_membershipStartDate.TabIndex = 4;
            // 
            // label_memberShipStartDate
            // 
            label_memberShipStartDate.AutoSize = true;
            label_memberShipStartDate.Location = new Point(30, 39);
            label_memberShipStartDate.Name = "label_memberShipStartDate";
            label_memberShipStartDate.Size = new Size(77, 20);
            label_memberShipStartDate.TabIndex = 1;
            label_memberShipStartDate.Text = "Start Date";
            // 
            // button_submit
            // 
            button_submit.BackColor = Color.GreenYellow;
            button_submit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button_submit.ForeColor = Color.Black;
            button_submit.Location = new Point(950, 760);
            button_submit.Name = "button_submit";
            button_submit.Size = new Size(163, 54);
            button_submit.TabIndex = 11;
            button_submit.Text = "Submit";
            button_submit.UseVisualStyleBackColor = false;
            button_submit.Click += button1_Click;
            // 
            // button_cancel
            // 
            button_cancel.BackColor = Color.IndianRed;
            button_cancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            button_cancel.ForeColor = Color.Bisque;
            button_cancel.Location = new Point(622, 760);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(163, 54);
            button_cancel.TabIndex = 12;
            button_cancel.Text = "Cancel";
            button_cancel.UseVisualStyleBackColor = false;
            button_cancel.Click += button_cancel_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1159, 853);
            Controls.Add(button_cancel);
            Controls.Add(button_submit);
            Controls.Add(GB_membershipInformation);
            Controls.Add(GB_heaithInformation);
            Controls.Add(GB_contactInformation);
            Controls.Add(GB_personalInformation);
            Controls.Add(formTitle);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Sports Club New Member Registration Form";
            Load += Form1_Load;
            GB_personalInformation.ResumeLayout(false);
            GB_personalInformation.PerformLayout();
            GB_contactInformation.ResumeLayout(false);
            GB_contactInformation.PerformLayout();
            GB_heaithInformation.ResumeLayout(false);
            GB_heaithInformation.PerformLayout();
            GB_membershipInformation.ResumeLayout(false);
            GB_membershipInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label formTitle;
        private Label label_Name;
        private MaskedTextBox TextBox_name;
        private Label label_DOB;
        private DateTimePicker dateTimePicker_DOB;
        private Label label_membershipType;
        private ComboBox comboBox_membershipType;
        private GroupBox GB_personalInformation;
        private MaskedTextBox TextBox_adress;
        private Label label_address;
        private GroupBox GB_contactInformation;
        private MaskedTextBox TextBox_email;
        private Label label_email;
        private MaskedTextBox TextBox_mobile;
        private Label label_Mobile;
        private GroupBox GB_heaithInformation;
        private MaskedTextBox TextBox_helthConditions;
        private Label label_healthConditions;
        private GroupBox GB_membershipInformation;
        private ComboBox comboBox_paymentMethod;
        private Label label_paymentMethod;
        private DateTimePicker dateTimePicker_membershipStartDate;
        private Label label_memberShipStartDate;
        private MaskedTextBox TextBox_paymentAmount;
        private Label label_paymentAmount;
        private Button button_submit;
        private Button button_cancel;
    }
}