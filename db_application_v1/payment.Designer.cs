namespace db_application_v1
{
    partial class payment
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.radioButton_customerCard = new System.Windows.Forms.RadioButton();
            this.radioButton_newCard = new System.Windows.Forms.RadioButton();
            this.textBox_customerCard = new System.Windows.Forms.TextBox();
            this.textBox_newCard = new System.Windows.Forms.TextBox();
            this.label_defaultCard = new System.Windows.Forms.Label();
            this.label_newCard = new System.Windows.Forms.Label();
            this.textBox_OrderDetails = new System.Windows.Forms.TextBox();
            this.radioButton_creditCard = new System.Windows.Forms.RadioButton();
            this.radioButton_debitCard = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Choice_prepay = new System.Windows.Forms.RadioButton();
            this.label_prepayVoucher = new System.Windows.Forms.Label();
            this.radioButton_prepayVoucher = new System.Windows.Forms.RadioButton();
            this.textBox_prepayVoucher = new System.Windows.Forms.TextBox();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buy now";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 542);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 2;
            this.button_cancel.Text = "Close";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // radioButton_customerCard
            // 
            this.radioButton_customerCard.AutoSize = true;
            this.radioButton_customerCard.Location = new System.Drawing.Point(15, 254);
            this.radioButton_customerCard.Name = "radioButton_customerCard";
            this.radioButton_customerCard.Size = new System.Drawing.Size(85, 17);
            this.radioButton_customerCard.TabIndex = 3;
            this.radioButton_customerCard.TabStop = true;
            this.radioButton_customerCard.Text = "radioButton1";
            this.radioButton_customerCard.UseVisualStyleBackColor = true;
            this.radioButton_customerCard.CheckedChanged += new System.EventHandler(this.radioButton_customerCard_CheckedChanged);
            // 
            // radioButton_newCard
            // 
            this.radioButton_newCard.AutoSize = true;
            this.radioButton_newCard.Location = new System.Drawing.Point(15, 395);
            this.radioButton_newCard.Name = "radioButton_newCard";
            this.radioButton_newCard.Size = new System.Drawing.Size(85, 17);
            this.radioButton_newCard.TabIndex = 4;
            this.radioButton_newCard.TabStop = true;
            this.radioButton_newCard.Text = "radioButton2";
            this.radioButton_newCard.UseVisualStyleBackColor = true;
            this.radioButton_newCard.CheckedChanged += new System.EventHandler(this.radioButton_newCard_CheckedChanged);
            // 
            // textBox_customerCard
            // 
            this.textBox_customerCard.Location = new System.Drawing.Point(33, 253);
            this.textBox_customerCard.Name = "textBox_customerCard";
            this.textBox_customerCard.ReadOnly = true;
            this.textBox_customerCard.Size = new System.Drawing.Size(238, 20);
            this.textBox_customerCard.TabIndex = 5;
            this.textBox_customerCard.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_newCard
            // 
            this.textBox_newCard.Location = new System.Drawing.Point(33, 395);
            this.textBox_newCard.Name = "textBox_newCard";
            this.textBox_newCard.Size = new System.Drawing.Size(238, 20);
            this.textBox_newCard.TabIndex = 6;
            // 
            // label_defaultCard
            // 
            this.label_defaultCard.AutoSize = true;
            this.label_defaultCard.Location = new System.Drawing.Point(12, 237);
            this.label_defaultCard.Name = "label_defaultCard";
            this.label_defaultCard.Size = new System.Drawing.Size(91, 13);
            this.label_defaultCard.TabIndex = 0;
            this.label_defaultCard.Text = "Your default card:";
            this.label_defaultCard.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_newCard
            // 
            this.label_newCard.AutoSize = true;
            this.label_newCard.Location = new System.Drawing.Point(12, 379);
            this.label_newCard.Name = "label_newCard";
            this.label_newCard.Size = new System.Drawing.Size(56, 13);
            this.label_newCard.TabIndex = 0;
            this.label_newCard.Text = "New card:";
            this.label_newCard.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_OrderDetails
            // 
            this.textBox_OrderDetails.Location = new System.Drawing.Point(15, 37);
            this.textBox_OrderDetails.Multiline = true;
            this.textBox_OrderDetails.Name = "textBox_OrderDetails";
            this.textBox_OrderDetails.ReadOnly = true;
            this.textBox_OrderDetails.Size = new System.Drawing.Size(271, 182);
            this.textBox_OrderDetails.TabIndex = 10;
            // 
            // radioButton_creditCard
            // 
            this.radioButton_creditCard.AutoSize = true;
            this.radioButton_creditCard.Location = new System.Drawing.Point(6, 19);
            this.radioButton_creditCard.Name = "radioButton_creditCard";
            this.radioButton_creditCard.Size = new System.Drawing.Size(77, 17);
            this.radioButton_creditCard.TabIndex = 7;
            this.radioButton_creditCard.TabStop = true;
            this.radioButton_creditCard.Text = "Credit Card";
            this.radioButton_creditCard.UseVisualStyleBackColor = true;
            this.radioButton_creditCard.CheckedChanged += new System.EventHandler(this.radioButton_creditCard_CheckedChanged);
            // 
            // radioButton_debitCard
            // 
            this.radioButton_debitCard.AutoSize = true;
            this.radioButton_debitCard.Location = new System.Drawing.Point(87, 19);
            this.radioButton_debitCard.Name = "radioButton_debitCard";
            this.radioButton_debitCard.Size = new System.Drawing.Size(75, 17);
            this.radioButton_debitCard.TabIndex = 8;
            this.radioButton_debitCard.TabStop = true;
            this.radioButton_debitCard.Text = "Debit Card";
            this.radioButton_debitCard.UseVisualStyleBackColor = true;
            this.radioButton_debitCard.CheckedChanged += new System.EventHandler(this.radioButton_debitCard_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Choice_prepay);
            this.groupBox1.Controls.Add(this.radioButton_debitCard);
            this.groupBox1.Controls.Add(this.radioButton_creditCard);
            this.groupBox1.Location = new System.Drawing.Point(12, 327);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 49);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose new payment type";
            // 
            // radioButton_Choice_prepay
            // 
            this.radioButton_Choice_prepay.AutoSize = true;
            this.radioButton_Choice_prepay.Location = new System.Drawing.Point(169, 19);
            this.radioButton_Choice_prepay.Name = "radioButton_Choice_prepay";
            this.radioButton_Choice_prepay.Size = new System.Drawing.Size(101, 17);
            this.radioButton_Choice_prepay.TabIndex = 9;
            this.radioButton_Choice_prepay.TabStop = true;
            this.radioButton_Choice_prepay.Text = "Prepay Voucher";
            this.radioButton_Choice_prepay.UseVisualStyleBackColor = true;
            this.radioButton_Choice_prepay.CheckedChanged += new System.EventHandler(this.radioButton_Choice_prepay_CheckedChanged);
            // 
            // label_prepayVoucher
            // 
            this.label_prepayVoucher.AutoSize = true;
            this.label_prepayVoucher.Location = new System.Drawing.Point(12, 429);
            this.label_prepayVoucher.Name = "label_prepayVoucher";
            this.label_prepayVoucher.Size = new System.Drawing.Size(83, 13);
            this.label_prepayVoucher.TabIndex = 0;
            this.label_prepayVoucher.Text = "Prepay Voucher";
            this.label_prepayVoucher.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButton_prepayVoucher
            // 
            this.radioButton_prepayVoucher.AutoSize = true;
            this.radioButton_prepayVoucher.Location = new System.Drawing.Point(15, 445);
            this.radioButton_prepayVoucher.Name = "radioButton_prepayVoucher";
            this.radioButton_prepayVoucher.Size = new System.Drawing.Size(85, 17);
            this.radioButton_prepayVoucher.TabIndex = 4;
            this.radioButton_prepayVoucher.TabStop = true;
            this.radioButton_prepayVoucher.Text = "radioButton2";
            this.radioButton_prepayVoucher.UseVisualStyleBackColor = true;
            this.radioButton_prepayVoucher.CheckedChanged += new System.EventHandler(this.radioButton_prepayVoucher_CheckedChanged);
            // 
            // textBox_prepayVoucher
            // 
            this.textBox_prepayVoucher.Location = new System.Drawing.Point(33, 445);
            this.textBox_prepayVoucher.Name = "textBox_prepayVoucher";
            this.textBox_prepayVoucher.Size = new System.Drawing.Size(238, 20);
            this.textBox_prepayVoucher.TabIndex = 6;
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdate.Location = new System.Drawing.Point(95, 304);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(100, 20);
            this.labelUpdate.TabIndex = 12;
            this.labelUpdate.Text = "Update Card";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(99, 471);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 572);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_OrderDetails);
            this.Controls.Add(this.textBox_prepayVoucher);
            this.Controls.Add(this.textBox_newCard);
            this.Controls.Add(this.radioButton_prepayVoucher);
            this.Controls.Add(this.textBox_customerCard);
            this.Controls.Add(this.radioButton_newCard);
            this.Controls.Add(this.radioButton_customerCard);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_prepayVoucher);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_newCard);
            this.Controls.Add(this.label_defaultCard);
            this.Controls.Add(this.label1);
            this.Name = "payment";
            this.Text = "Payment method";
            this.Load += new System.EventHandler(this.payment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.RadioButton radioButton_customerCard;
        private System.Windows.Forms.RadioButton radioButton_newCard;
        private System.Windows.Forms.TextBox textBox_customerCard;
        private System.Windows.Forms.TextBox textBox_newCard;
        private System.Windows.Forms.Label label_defaultCard;
        private System.Windows.Forms.Label label_newCard;
        private System.Windows.Forms.TextBox textBox_OrderDetails;
        private System.Windows.Forms.RadioButton radioButton_creditCard;
        private System.Windows.Forms.RadioButton radioButton_debitCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_prepayVoucher;
        private System.Windows.Forms.RadioButton radioButton_prepayVoucher;
        private System.Windows.Forms.TextBox textBox_prepayVoucher;
        private System.Windows.Forms.RadioButton radioButton_Choice_prepay;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Button buttonSubmit;
    }
}