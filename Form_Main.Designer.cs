namespace Allinpay
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
            this.button_Query_Test = new System.Windows.Forms.Button();
            this.groupBox_Payment = new System.Windows.Forms.GroupBox();
            this.button_TenderQRImage = new System.Windows.Forms.Button();
            this.button_TenderQRScan = new System.Windows.Forms.Button();
            this.button_TenderCCard = new System.Windows.Forms.Button();
            this.groupBox_Void = new System.Windows.Forms.GroupBox();
            this.button_VoidQR = new System.Windows.Forms.Button();
            this.button_VoidCard = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_RefundQR = new System.Windows.Forms.Button();
            this.button_RefundCard = new System.Windows.Forms.Button();
            this.groupBox_other = new System.Windows.Forms.GroupBox();
            this.button_DeviceInfo = new System.Windows.Forms.Button();
            this.button_Settle = new System.Windows.Forms.Button();
            this.button_LoadMKey = new System.Windows.Forms.Button();
            this.button_Reprint = new System.Windows.Forms.Button();
            this.button_SignIn = new System.Windows.Forms.Button();
            this.groupBox_Auth = new System.Windows.Forms.GroupBox();
            this.button_AuthCancelConfirm = new System.Windows.Forms.Button();
            this.button_AuthConfirm = new System.Windows.Forms.Button();
            this.button_AuthCancel = new System.Windows.Forms.Button();
            this.button_Auth = new System.Windows.Forms.Button();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox_Payment.SuspendLayout();
            this.groupBox_Void.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_other.SuspendLayout();
            this.groupBox_Auth.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Query_Test
            // 
            this.button_Query_Test.Location = new System.Drawing.Point(6, 19);
            this.button_Query_Test.Name = "button_Query_Test";
            this.button_Query_Test.Size = new System.Drawing.Size(75, 23);
            this.button_Query_Test.TabIndex = 0;
            this.button_Query_Test.Text = " Query Test";
            this.button_Query_Test.UseVisualStyleBackColor = true;
            this.button_Query_Test.Click += new System.EventHandler(this.button_TestQuery_Click);
            // 
            // groupBox_Payment
            // 
            this.groupBox_Payment.Controls.Add(this.button_TenderQRImage);
            this.groupBox_Payment.Controls.Add(this.button_TenderQRScan);
            this.groupBox_Payment.Controls.Add(this.button_TenderCCard);
            this.groupBox_Payment.Location = new System.Drawing.Point(7, 12);
            this.groupBox_Payment.Name = "groupBox_Payment";
            this.groupBox_Payment.Size = new System.Drawing.Size(86, 108);
            this.groupBox_Payment.TabIndex = 1;
            this.groupBox_Payment.TabStop = false;
            this.groupBox_Payment.Text = "Payment";
            // 
            // button_TenderQRImage
            // 
            this.button_TenderQRImage.Location = new System.Drawing.Point(6, 77);
            this.button_TenderQRImage.Name = "button_TenderQRImage";
            this.button_TenderQRImage.Size = new System.Drawing.Size(75, 23);
            this.button_TenderQRImage.TabIndex = 3;
            this.button_TenderQRImage.Text = " QR Image";
            this.button_TenderQRImage.UseVisualStyleBackColor = true;
            this.button_TenderQRImage.Click += new System.EventHandler(this.button_TenderQRImage_Click);
            // 
            // button_TenderQRScan
            // 
            this.button_TenderQRScan.Location = new System.Drawing.Point(6, 48);
            this.button_TenderQRScan.Name = "button_TenderQRScan";
            this.button_TenderQRScan.Size = new System.Drawing.Size(75, 23);
            this.button_TenderQRScan.TabIndex = 2;
            this.button_TenderQRScan.Text = " QR Scan";
            this.button_TenderQRScan.UseVisualStyleBackColor = true;
            this.button_TenderQRScan.Click += new System.EventHandler(this.button_TenderQRScan_Click);
            // 
            // button_TenderCCard
            // 
            this.button_TenderCCard.Location = new System.Drawing.Point(6, 19);
            this.button_TenderCCard.Name = "button_TenderCCard";
            this.button_TenderCCard.Size = new System.Drawing.Size(75, 23);
            this.button_TenderCCard.TabIndex = 2;
            this.button_TenderCCard.Text = " CARD";
            this.button_TenderCCard.UseVisualStyleBackColor = true;
            this.button_TenderCCard.Click += new System.EventHandler(this.button_TenderCCard_Click);
            // 
            // groupBox_Void
            // 
            this.groupBox_Void.Controls.Add(this.button_VoidQR);
            this.groupBox_Void.Controls.Add(this.button_VoidCard);
            this.groupBox_Void.Location = new System.Drawing.Point(99, 12);
            this.groupBox_Void.Name = "groupBox_Void";
            this.groupBox_Void.Size = new System.Drawing.Size(86, 108);
            this.groupBox_Void.TabIndex = 2;
            this.groupBox_Void.TabStop = false;
            this.groupBox_Void.Text = "Void";
            // 
            // button_VoidQR
            // 
            this.button_VoidQR.Location = new System.Drawing.Point(6, 48);
            this.button_VoidQR.Name = "button_VoidQR";
            this.button_VoidQR.Size = new System.Drawing.Size(75, 23);
            this.button_VoidQR.TabIndex = 2;
            this.button_VoidQR.Text = " QR";
            this.button_VoidQR.UseVisualStyleBackColor = true;
            this.button_VoidQR.Click += new System.EventHandler(this.button_VoidQR_Click);
            // 
            // button_VoidCard
            // 
            this.button_VoidCard.Location = new System.Drawing.Point(6, 19);
            this.button_VoidCard.Name = "button_VoidCard";
            this.button_VoidCard.Size = new System.Drawing.Size(75, 23);
            this.button_VoidCard.TabIndex = 2;
            this.button_VoidCard.Text = " CARD";
            this.button_VoidCard.UseVisualStyleBackColor = true;
            this.button_VoidCard.Click += new System.EventHandler(this.button_VoidCard_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_RefundQR);
            this.groupBox1.Controls.Add(this.button_RefundCard);
            this.groupBox1.Location = new System.Drawing.Point(191, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 108);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Refund";
            // 
            // button_RefundQR
            // 
            this.button_RefundQR.Location = new System.Drawing.Point(6, 48);
            this.button_RefundQR.Name = "button_RefundQR";
            this.button_RefundQR.Size = new System.Drawing.Size(75, 23);
            this.button_RefundQR.TabIndex = 2;
            this.button_RefundQR.Text = " QR";
            this.button_RefundQR.UseVisualStyleBackColor = true;
            this.button_RefundQR.Click += new System.EventHandler(this.button_RefundQR_Click);
            // 
            // button_RefundCard
            // 
            this.button_RefundCard.Location = new System.Drawing.Point(6, 19);
            this.button_RefundCard.Name = "button_RefundCard";
            this.button_RefundCard.Size = new System.Drawing.Size(75, 23);
            this.button_RefundCard.TabIndex = 2;
            this.button_RefundCard.Text = " CARD";
            this.button_RefundCard.UseVisualStyleBackColor = true;
            this.button_RefundCard.Click += new System.EventHandler(this.button_RefundCard_Click);
            // 
            // groupBox_other
            // 
            this.groupBox_other.Controls.Add(this.button_DeviceInfo);
            this.groupBox_other.Controls.Add(this.button_Settle);
            this.groupBox_other.Controls.Add(this.button_LoadMKey);
            this.groupBox_other.Controls.Add(this.button_Reprint);
            this.groupBox_other.Controls.Add(this.button_SignIn);
            this.groupBox_other.Controls.Add(this.button_Query_Test);
            this.groupBox_other.Location = new System.Drawing.Point(7, 126);
            this.groupBox_other.Name = "groupBox_other";
            this.groupBox_other.Size = new System.Drawing.Size(270, 76);
            this.groupBox_other.TabIndex = 4;
            this.groupBox_other.TabStop = false;
            this.groupBox_other.Text = "Other";
            // 
            // button_DeviceInfo
            // 
            this.button_DeviceInfo.Location = new System.Drawing.Point(190, 48);
            this.button_DeviceInfo.Name = "button_DeviceInfo";
            this.button_DeviceInfo.Size = new System.Drawing.Size(75, 23);
            this.button_DeviceInfo.TabIndex = 5;
            this.button_DeviceInfo.Text = "DeviceInfo";
            this.button_DeviceInfo.UseVisualStyleBackColor = true;
            this.button_DeviceInfo.Click += new System.EventHandler(this.button_DeviceInfo_Click);
            // 
            // button_Settle
            // 
            this.button_Settle.Location = new System.Drawing.Point(98, 48);
            this.button_Settle.Name = "button_Settle";
            this.button_Settle.Size = new System.Drawing.Size(75, 23);
            this.button_Settle.TabIndex = 4;
            this.button_Settle.Text = "Settle";
            this.button_Settle.UseVisualStyleBackColor = true;
            this.button_Settle.Click += new System.EventHandler(this.button_Settle_Click);
            // 
            // button_LoadMKey
            // 
            this.button_LoadMKey.Location = new System.Drawing.Point(6, 48);
            this.button_LoadMKey.Name = "button_LoadMKey";
            this.button_LoadMKey.Size = new System.Drawing.Size(75, 23);
            this.button_LoadMKey.TabIndex = 3;
            this.button_LoadMKey.Text = "MasterKey";
            this.button_LoadMKey.UseVisualStyleBackColor = true;
            this.button_LoadMKey.Click += new System.EventHandler(this.button_LoadMKey_Click);
            // 
            // button_Reprint
            // 
            this.button_Reprint.Location = new System.Drawing.Point(190, 19);
            this.button_Reprint.Name = "button_Reprint";
            this.button_Reprint.Size = new System.Drawing.Size(75, 23);
            this.button_Reprint.TabIndex = 2;
            this.button_Reprint.Text = "Reprint";
            this.button_Reprint.UseVisualStyleBackColor = true;
            this.button_Reprint.Click += new System.EventHandler(this.button_Reprint_Click);
            // 
            // button_SignIn
            // 
            this.button_SignIn.Location = new System.Drawing.Point(98, 19);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(75, 23);
            this.button_SignIn.TabIndex = 1;
            this.button_SignIn.Text = "SignIn";
            this.button_SignIn.UseVisualStyleBackColor = true;
            this.button_SignIn.Click += new System.EventHandler(this.button_SignIn_Click);
            // 
            // groupBox_Auth
            // 
            this.groupBox_Auth.Controls.Add(this.button_AuthCancelConfirm);
            this.groupBox_Auth.Controls.Add(this.button_AuthConfirm);
            this.groupBox_Auth.Controls.Add(this.button_AuthCancel);
            this.groupBox_Auth.Controls.Add(this.button_Auth);
            this.groupBox_Auth.Location = new System.Drawing.Point(283, 12);
            this.groupBox_Auth.Name = "groupBox_Auth";
            this.groupBox_Auth.Size = new System.Drawing.Size(85, 190);
            this.groupBox_Auth.TabIndex = 5;
            this.groupBox_Auth.TabStop = false;
            this.groupBox_Auth.Text = "Pre-Auth";
            // 
            // button_AuthCancelConfirm
            // 
            this.button_AuthCancelConfirm.Location = new System.Drawing.Point(5, 161);
            this.button_AuthCancelConfirm.Name = "button_AuthCancelConfirm";
            this.button_AuthCancelConfirm.Size = new System.Drawing.Size(75, 23);
            this.button_AuthCancelConfirm.TabIndex = 4;
            this.button_AuthCancelConfirm.Text = "Void Auth";
            this.button_AuthCancelConfirm.UseVisualStyleBackColor = true;
            this.button_AuthCancelConfirm.Click += new System.EventHandler(this.button_AuthCancelConfirm_Click);
            // 
            // button_AuthConfirm
            // 
            this.button_AuthConfirm.Location = new System.Drawing.Point(6, 132);
            this.button_AuthConfirm.Name = "button_AuthConfirm";
            this.button_AuthConfirm.Size = new System.Drawing.Size(75, 23);
            this.button_AuthConfirm.TabIndex = 3;
            this.button_AuthConfirm.Text = "Auth";
            this.button_AuthConfirm.UseVisualStyleBackColor = true;
            this.button_AuthConfirm.Click += new System.EventHandler(this.button_AuthConfirm_Click);
            // 
            // button_AuthCancel
            // 
            this.button_AuthCancel.Location = new System.Drawing.Point(6, 48);
            this.button_AuthCancel.Name = "button_AuthCancel";
            this.button_AuthCancel.Size = new System.Drawing.Size(75, 52);
            this.button_AuthCancel.TabIndex = 2;
            this.button_AuthCancel.Text = "Void Pre-Auth ";
            this.button_AuthCancel.UseVisualStyleBackColor = true;
            this.button_AuthCancel.Click += new System.EventHandler(this.button_AuthCancel_Click);
            // 
            // button_Auth
            // 
            this.button_Auth.Location = new System.Drawing.Point(6, 19);
            this.button_Auth.Name = "button_Auth";
            this.button_Auth.Size = new System.Drawing.Size(75, 23);
            this.button_Auth.TabIndex = 2;
            this.button_Auth.Text = "Pre-Auth";
            this.button_Auth.UseVisualStyleBackColor = true;
            this.button_Auth.Click += new System.EventHandler(this.button_Auth_Click);
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Enabled = false;
            this.richTextBox_output.Location = new System.Drawing.Point(7, 221);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.Size = new System.Drawing.Size(361, 197);
            this.richTextBox_output.TabIndex = 6;
            this.richTextBox_output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output";
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(293, 426);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 8;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 461);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.groupBox_Auth);
            this.Controls.Add(this.groupBox_other);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Void);
            this.Controls.Add(this.groupBox_Payment);
            this.Name = "Form_Main";
            this.Text = "AllinPay Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Payment.ResumeLayout(false);
            this.groupBox_Void.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox_other.ResumeLayout(false);
            this.groupBox_Auth.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Query_Test;
        private System.Windows.Forms.GroupBox groupBox_Payment;
        private System.Windows.Forms.Button button_TenderQRImage;
        private System.Windows.Forms.Button button_TenderQRScan;
        private System.Windows.Forms.Button button_TenderCCard;
        private System.Windows.Forms.GroupBox groupBox_Void;
        private System.Windows.Forms.Button button_VoidQR;
        private System.Windows.Forms.Button button_VoidCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_RefundQR;
        private System.Windows.Forms.Button button_RefundCard;
        private System.Windows.Forms.GroupBox groupBox_other;
        private System.Windows.Forms.Button button_DeviceInfo;
        private System.Windows.Forms.Button button_Settle;
        private System.Windows.Forms.Button button_LoadMKey;
        private System.Windows.Forms.Button button_Reprint;
        private System.Windows.Forms.Button button_SignIn;
        private System.Windows.Forms.GroupBox groupBox_Auth;
        private System.Windows.Forms.Button button_AuthCancelConfirm;
        private System.Windows.Forms.Button button_AuthConfirm;
        private System.Windows.Forms.Button button_AuthCancel;
        private System.Windows.Forms.Button button_Auth;
        private System.Windows.Forms.RichTextBox richTextBox_output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Clear;
    }
}

