namespace db_application_v1
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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_results = new System.Windows.Forms.ListBox();
            this.button_view = new System.Windows.Forms.Button();
            this.button_account = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label_customerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(13, 69);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(227, 20);
            this.textBox_input.TabIndex = 0;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(246, 69);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(85, 20);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Search";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Show results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Searching for a game then press \'Search\'";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search Result:";
            // 
            // listBox_results
            // 
            this.listBox_results.FormattingEnabled = true;
            this.listBox_results.Location = new System.Drawing.Point(12, 145);
            this.listBox_results.Name = "listBox_results";
            this.listBox_results.Size = new System.Drawing.Size(318, 95);
            this.listBox_results.TabIndex = 5;
            // 
            // button_view
            // 
            this.button_view.Location = new System.Drawing.Point(255, 246);
            this.button_view.Name = "button_view";
            this.button_view.Size = new System.Drawing.Size(75, 23);
            this.button_view.TabIndex = 6;
            this.button_view.Text = "View Game";
            this.button_view.UseVisualStyleBackColor = true;
            this.button_view.Click += new System.EventHandler(this.button_view_Click);
            // 
            // button_account
            // 
            this.button_account.Location = new System.Drawing.Point(256, 7);
            this.button_account.Name = "button_account";
            this.button_account.Size = new System.Drawing.Size(75, 23);
            this.button_account.TabIndex = 7;
            this.button_account.Text = "Account";
            this.button_account.UseVisualStyleBackColor = true;
            this.button_account.Click += new System.EventHandler(this.button_account_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Welcome:";
            // 
            // label_customerName
            // 
            this.label_customerName.AutoSize = true;
            this.label_customerName.Location = new System.Drawing.Point(77, 12);
            this.label_customerName.Name = "label_customerName";
            this.label_customerName.Size = new System.Drawing.Size(55, 13);
            this.label_customerName.TabIndex = 8;
            this.label_customerName.Text = "Username";
            // 
            // Form1
            // 
            this.AcceptButton = this.Enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 291);
            this.Controls.Add(this.label_customerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_account);
            this.Controls.Add(this.button_view);
            this.Controls.Add(this.listBox_results);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form1";
            this.Text = "Waikato.co Games";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_results;
        private System.Windows.Forms.Button button_view;
        private System.Windows.Forms.Button button_account;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_customerName;
    }
}

