namespace RegistrationForm_EnvironmentalSustainabilityProgramme
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
            textBoxName = new TextBox();
            label1 = new Label();
            labelName = new Label();
            label2 = new Label();
            textBoxOccupation = new TextBox();
            labelOccupation = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButtonWhatsapp = new RadioButton();
            radioButtoMobile = new RadioButton();
            radioButtonEmail = new RadioButton();
            labelComunicationMethod = new Label();
            labelEmail = new Label();
            label4 = new Label();
            textEmail = new TextBox();
            labelMobile = new Label();
            textBoxMobile = new TextBox();
            groupBox3 = new GroupBox();
            labelDateTime = new Label();
            dateTimePicker = new DateTimePicker();
            labelPreviousExpiriance = new Label();
            textBoxPerviousExpiriance = new TextBox();
            comboBoxLevelOfInterest = new ComboBox();
            label9 = new Label();
            labelLevelOfInterrest = new Label();
            buttonSubmit = new Button();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(170, 38);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(943, 27);
            textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(117, 23);
            label1.Name = "label1";
            label1.Size = new Size(981, 46);
            label1.TabIndex = 1;
            label1.Text = "Registration Form - Environmental Sustainability Programme";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelName.Location = new Point(26, 43);
            labelName.Name = "labelName";
            labelName.Size = new Size(71, 17);
            labelName.TabIndex = 2;
            labelName.Text = "Full Name";
            labelName.Click += labelName_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(0, 17);
            label2.TabIndex = 4;
            // 
            // textBoxOccupation
            // 
            textBoxOccupation.Location = new Point(170, 80);
            textBoxOccupation.Name = "textBoxOccupation";
            textBoxOccupation.Size = new Size(943, 27);
            textBoxOccupation.TabIndex = 3;
            // 
            // labelOccupation
            // 
            labelOccupation.AutoSize = true;
            labelOccupation.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelOccupation.Location = new Point(26, 85);
            labelOccupation.Name = "labelOccupation";
            labelOccupation.Size = new Size(80, 17);
            labelOccupation.TabIndex = 5;
            labelOccupation.Text = "Occupation";
            labelOccupation.Click += label3_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.ForeColor = SystemColors.ControlText;
            flowLayoutPanel1.Location = new Point(384, 317);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(8, 8);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Beige;
            groupBox1.Controls.Add(labelOccupation);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxOccupation);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Font = new Font("Segoe UI Historic", 9F);
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(49, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1139, 127);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Beige;
            groupBox2.Controls.Add(radioButtonWhatsapp);
            groupBox2.Controls.Add(radioButtoMobile);
            groupBox2.Controls.Add(radioButtonEmail);
            groupBox2.Controls.Add(labelComunicationMethod);
            groupBox2.Controls.Add(labelEmail);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textEmail);
            groupBox2.Controls.Add(labelMobile);
            groupBox2.Controls.Add(textBoxMobile);
            groupBox2.Font = new Font("Segoe UI Historic", 9F);
            groupBox2.ForeColor = SystemColors.ControlText;
            groupBox2.Location = new Point(49, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1139, 127);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contact Information";
            // 
            // radioButtonWhatsapp
            // 
            radioButtonWhatsapp.AutoSize = true;
            radioButtonWhatsapp.Location = new Point(902, 39);
            radioButtonWhatsapp.Name = "radioButtonWhatsapp";
            radioButtonWhatsapp.Size = new Size(99, 24);
            radioButtonWhatsapp.TabIndex = 9;
            radioButtonWhatsapp.TabStop = true;
            radioButtonWhatsapp.Text = "WhatsApp";
            radioButtonWhatsapp.UseVisualStyleBackColor = true;
            // 
            // radioButtoMobile
            // 
            radioButtoMobile.AutoSize = true;
            radioButtoMobile.Location = new Point(788, 73);
            radioButtoMobile.Name = "radioButtoMobile";
            radioButtoMobile.Size = new Size(77, 24);
            radioButtoMobile.TabIndex = 8;
            radioButtoMobile.TabStop = true;
            radioButtoMobile.Text = "Mobile";
            radioButtoMobile.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmail
            // 
            radioButtonEmail.AutoSize = true;
            radioButtonEmail.Location = new Point(788, 39);
            radioButtonEmail.Name = "radioButtonEmail";
            radioButtonEmail.Size = new Size(67, 24);
            radioButtonEmail.TabIndex = 7;
            radioButtonEmail.TabStop = true;
            radioButtonEmail.Text = "Email";
            radioButtonEmail.UseVisualStyleBackColor = true;
            // 
            // labelComunicationMethod
            // 
            labelComunicationMethod.AutoSize = true;
            labelComunicationMethod.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelComunicationMethod.Location = new Point(670, 39);
            labelComunicationMethod.Name = "labelComunicationMethod";
            labelComunicationMethod.Size = new Size(108, 51);
            labelComunicationMethod.TabIndex = 6;
            labelComunicationMethod.Text = "Prefered \r\nCommunication \r\nMehod";
            labelComunicationMethod.Click += label6_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelEmail.Location = new Point(26, 85);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(42, 17);
            labelEmail.TabIndex = 5;
            labelEmail.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new Point(6, 65);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 4;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(170, 85);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(414, 27);
            textEmail.TabIndex = 3;
            // 
            // labelMobile
            // 
            labelMobile.AutoSize = true;
            labelMobile.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelMobile.Location = new Point(26, 43);
            labelMobile.Name = "labelMobile";
            labelMobile.Size = new Size(49, 17);
            labelMobile.TabIndex = 2;
            labelMobile.Text = "Mobile";
            // 
            // textBoxMobile
            // 
            textBoxMobile.Location = new Point(170, 43);
            textBoxMobile.Name = "textBoxMobile";
            textBoxMobile.Size = new Size(414, 27);
            textBoxMobile.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Beige;
            groupBox3.Controls.Add(labelDateTime);
            groupBox3.Controls.Add(dateTimePicker);
            groupBox3.Controls.Add(labelPreviousExpiriance);
            groupBox3.Controls.Add(textBoxPerviousExpiriance);
            groupBox3.Controls.Add(comboBoxLevelOfInterest);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(labelLevelOfInterrest);
            groupBox3.Font = new Font("Segoe UI Historic", 9F);
            groupBox3.ForeColor = SystemColors.ControlText;
            groupBox3.Location = new Point(49, 405);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1139, 183);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Progame Information";
            // 
            // labelDateTime
            // 
            labelDateTime.AutoSize = true;
            labelDateTime.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelDateTime.Location = new Point(670, 43);
            labelDateTime.Name = "labelDateTime";
            labelDateTime.Size = new Size(84, 51);
            labelDateTime.TabIndex = 14;
            labelDateTime.Text = "date and \r\ntime\r\npreferences";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(788, 44);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(319, 27);
            dateTimePicker.TabIndex = 13;
            // 
            // labelPreviousExpiriance
            // 
            labelPreviousExpiriance.AutoSize = true;
            labelPreviousExpiriance.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelPreviousExpiriance.Location = new Point(26, 115);
            labelPreviousExpiriance.Name = "labelPreviousExpiriance";
            labelPreviousExpiriance.Size = new Size(138, 51);
            labelPreviousExpiriance.TabIndex = 12;
            labelPreviousExpiriance.Text = "Previous experience\r\nin related workshops\r\nor activities";
            // 
            // textBoxPerviousExpiriance
            // 
            textBoxPerviousExpiriance.Location = new Point(170, 125);
            textBoxPerviousExpiriance.Name = "textBoxPerviousExpiriance";
            textBoxPerviousExpiriance.Size = new Size(943, 27);
            textBoxPerviousExpiriance.TabIndex = 11;
            textBoxPerviousExpiriance.TextChanged += textBox3_TextChanged;
            // 
            // comboBoxLevelOfInterest
            // 
            comboBoxLevelOfInterest.FormattingEnabled = true;
            comboBoxLevelOfInterest.Items.AddRange(new object[] { "high", "mid", "low" });
            comboBoxLevelOfInterest.Location = new Point(170, 43);
            comboBoxLevelOfInterest.Name = "comboBoxLevelOfInterest";
            comboBoxLevelOfInterest.Size = new Size(363, 28);
            comboBoxLevelOfInterest.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 8.25F);
            label9.Location = new Point(6, 65);
            label9.Name = "label9";
            label9.Size = new Size(0, 17);
            label9.TabIndex = 4;
            // 
            // labelLevelOfInterrest
            // 
            labelLevelOfInterrest.AutoSize = true;
            labelLevelOfInterrest.BackColor = Color.Beige;
            labelLevelOfInterrest.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelLevelOfInterrest.Location = new Point(26, 43);
            labelLevelOfInterrest.Name = "labelLevelOfInterrest";
            labelLevelOfInterrest.Size = new Size(113, 51);
            labelLevelOfInterrest.TabIndex = 2;
            labelLevelOfInterrest.Text = "Level of interest \r\nin sustainability\r\ntopics";
            labelLevelOfInterrest.Click += label10_Click;
            // 
            // buttonSubmit
            // 
            buttonSubmit.BackColor = Color.YellowGreen;
            buttonSubmit.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmit.ForeColor = SystemColors.ControlText;
            buttonSubmit.Location = new Point(981, 641);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(207, 63);
            buttonSubmit.TabIndex = 11;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = false;
            buttonSubmit.Click += button1_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.IndianRed;
            buttonCancel.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = SystemColors.Control;
            buttonCancel.Location = new Point(719, 641);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(207, 63);
            buttonCancel.TabIndex = 12;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(1225, 743);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSubmit);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form1";
            Text = "Registration Form - Environmental Sustainability Programme";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Label labelName;
        private Label label2;
        private TextBox textBoxOccupation;
        private Label labelOccupation;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label labelComunicationMethod;
        private Label labelEmail;
        private Label label4;
        private TextBox textEmail;
        private Label labelMobile;
        private TextBox textBoxMobile;
        private RadioButton radioButtonWhatsapp;
        private RadioButton radioButtoMobile;
        private RadioButton radioButtonEmail;
        private GroupBox groupBox3;
        private ComboBox comboBoxLevelOfInterest;
        private Label label9;
        private Label labelLevelOfInterrest;
        private Label labelPreviousExpiriance;
        private TextBox textBoxPerviousExpiriance;
        private Label labelDateTime;
        private DateTimePicker dateTimePicker;
        private Button buttonSubmit;
        private Button buttonCancel;
    }
}
