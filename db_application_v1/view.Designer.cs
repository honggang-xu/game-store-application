namespace db_application_v1
{
    partial class view
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
            this.button_payment = new System.Windows.Forms.Button();
            this.label_gameTitle = new System.Windows.Forms.Label();
            this.textBox_gameDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_totalPrice = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_payment
            // 
            this.button_payment.Location = new System.Drawing.Point(197, 241);
            this.button_payment.Name = "button_payment";
            this.button_payment.Size = new System.Drawing.Size(75, 23);
            this.button_payment.TabIndex = 0;
            this.button_payment.Text = "Buy";
            this.button_payment.UseVisualStyleBackColor = true;
            this.button_payment.Click += new System.EventHandler(this.button_buy_Click);
            // 
            // label_gameTitle
            // 
            this.label_gameTitle.AutoSize = true;
            this.label_gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gameTitle.Location = new System.Drawing.Point(13, 13);
            this.label_gameTitle.Name = "label_gameTitle";
            this.label_gameTitle.Size = new System.Drawing.Size(84, 16);
            this.label_gameTitle.TabIndex = 1;
            this.label_gameTitle.Text = "Game Title";
            // 
            // textBox_gameDesc
            // 
            this.textBox_gameDesc.Location = new System.Drawing.Point(12, 48);
            this.textBox_gameDesc.Multiline = true;
            this.textBox_gameDesc.Name = "textBox_gameDesc";
            this.textBox_gameDesc.ReadOnly = true;
            this.textBox_gameDesc.Size = new System.Drawing.Size(260, 158);
            this.textBox_gameDesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Price:";
            // 
            // label_totalPrice
            // 
            this.label_totalPrice.AutoSize = true;
            this.label_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalPrice.Location = new System.Drawing.Point(197, 219);
            this.label_totalPrice.Name = "label_totalPrice";
            this.label_totalPrice.Size = new System.Drawing.Size(84, 16);
            this.label_totalPrice.TabIndex = 4;
            this.label_totalPrice.Text = "Total Price";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(16, 241);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_totalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_gameDesc);
            this.Controls.Add(this.label_gameTitle);
            this.Controls.Add(this.button_payment);
            this.Name = "view";
            this.Text = "View Game";
            this.Load += new System.EventHandler(this.view_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_payment;
        private System.Windows.Forms.Label label_gameTitle;
        private System.Windows.Forms.TextBox textBox_gameDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_totalPrice;
        private System.Windows.Forms.Button button_close;
    }
}