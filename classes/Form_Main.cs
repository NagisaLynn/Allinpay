using Allinpay.Properties;
using System;
using System.Windows.Forms;

namespace Allinpay
{
    public partial class Form_Main : Form
    {
        RequestClient requestClient = new RequestClient();
        public double Amount = 10.00;
        public Form_Main()
        {
            InitializeComponent();
            ConnectDevice();

           
        }

        public void ConnectDevice()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_Amount.Text = Amount.ToString();
        }

        public void StartMessage()
        {
            richTextBox_output.Text = "Please Wait";
        }


        #region 3.1 Collection Payment Tender
        // 3.1.1 Collection – Bank card 
        private async void button_TenderCCard_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_SALE_BANK).ToString(); //* Refer the documentation for the business ID - more like payment code
                allinpayRequestModel.AMOUNT = RequestClient.getAmountin12Digit(textBox_Amount.Text);  RequestClient.getAmountin12Digit(textBox_Amount.Text); //*
                allinpayRequestModel.MEMO = "Payment Card";
                allinpayRequestModel.CURRENCY = MisConfig.CURRENCY; //*
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo(); //*
                allinpayRequestModel.TRANS_ORDER_NO = RequestClient.getTransOrderNo(); //*
                allinpayRequestModel.DCC_FLAG = "EDC"; //*
                allinpayRequestModel.BUS_INFO = "01"; 
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel);
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_TenderCCard_Click. ", "--Payment Tender--", ex);
            }
        }

        // 3.1.2 Collection-code Scanning - Scan Customer QR Code
        private async void button_TenderQRScan_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_SALE_QR).ToString(); //*
                allinpayRequestModel.AMOUNT = RequestClient.getAmountin12Digit(textBox_Amount.Text); //*
                allinpayRequestModel.MEMO = "Payment QR Scan";
                allinpayRequestModel.CURRENCY = MisConfig.CURRENCY; //*
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo(); //*
                allinpayRequestModel.TRANS_ORDER_NO = RequestClient.getTransOrderNo(); //*
                allinpayRequestModel.BUS_INFO = "01";
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel);
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_TenderQRScan_Click. ", "--Payment Tender--", ex);
            }
        }

        // 3.1.3 Collection – QR Code Payment - Scan Merchant QR Code - Prompt QR code let customer to scan
        private async void button_TenderQRImage_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_SALE_SCAN).ToString();//*
                allinpayRequestModel.AMOUNT = RequestClient.getAmountin12Digit(textBox_Amount.Text); //*
                allinpayRequestModel.MEMO = "Payment QR Image";
                allinpayRequestModel.CURRENCY = MisConfig.CURRENCY; //*
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo(); //*
                allinpayRequestModel.TRANS_ORDER_NO = RequestClient.getTransOrderNo(); //*
                allinpayRequestModel.BUS_INFO = "01";
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel);  
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_TenderQRImage_Click. ", "--Payment Tender--", ex);
            }
        }
        #endregion  end of 3.1 Collection Payment Tender

        #region 3.2 Void 
        // 3.2.1 Void – bank card
        private async void button_VoidCard_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_VOID_BANK).ToString(); ; //*
                allinpayRequestModel.AMOUNT = RequestClient.getAmountin12Digit(textBox_Amount.Text); //*
                allinpayRequestModel.MEMO = "Void Card";
                allinpayRequestModel.CURRENCY = MisConfig.CURRENCY; //*
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo(); //*
                allinpayRequestModel.ORIG_TRACE_NO = textBox_Trans.Text.ToString(); //* // Original system reference number
                allinpayRequestModel.BUS_INFO = "01";
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel); 
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_VoidCard_Click. ", "--Void--", ex);
            }
        }

        // 3.2.2 Void – void by scanning code 
        private async void button_VoidQR_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_VOID_QR).ToString(); //*
                allinpayRequestModel.AMOUNT = RequestClient.getAmountin12Digit(textBox_Amount.Text); //*
                allinpayRequestModel.MEMO = "Void QR";
                allinpayRequestModel.CURRENCY = MisConfig.CURRENCY;
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo(); //*
                allinpayRequestModel.ORIG_TRACE_NO = textBox_Trans.Text.ToString(); //*  Original system reference number
                allinpayRequestModel.BUS_INFO = "01";
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel);  
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_VoidQR_Click. ", "--Void--", ex);
            }
        }
        #endregion  end of 3.2 Void 

        #region 3.3 Refund
        // 3.3.1 Refund – bank card 
        private async void button_RefundCard_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_REFUND_BANK).ToString(); //*
                allinpayRequestModel.AMOUNT = RequestClient.getAmountin12Digit(textBox_Amount.Text); //*
                allinpayRequestModel.MEMO = "Void Card";
                allinpayRequestModel.CURRENCY = MisConfig.CURRENCY; //*
                allinpayRequestModel.ORIG_REF_NO = textBox_Trans.Text.ToString(); //*
                //allinpayRequestModel.ORIG_TRACE_NO = MisConfig.ORIG_TRACE_NO; // will not prompt in terminal if this field is not empty
                allinpayRequestModel.ORIG_DATE = MisConfig.ORIG_DATE; //*
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo();   //*           
                allinpayRequestModel.BUS_INFO = "01";
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel);  
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_RefundCard_Click. ", "--Refund--", ex);
            }
        }

        // 3.3.2 Refund-Refund by Scanning Code
        private async void button_RefundQR_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_REFUND_QR).ToString(); //*
                allinpayRequestModel.AMOUNT = RequestClient.getAmountin12Digit(textBox_Amount.Text); //*
                allinpayRequestModel.MEMO = "Void QR";
                allinpayRequestModel.CURRENCY = MisConfig.CURRENCY; //*
                allinpayRequestModel.ORIG_TRANS_TICKET_NO = textBox_Trans.Text.ToString();  //*
                //allinpayRequestModel.ORIG_TRACE_NO = MisConfig.ORIG_TRACE_NO; // will not prompt in terminal if this field is not empty
                allinpayRequestModel.ORIG_DATE = MisConfig.ORIG_DATE;
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo(); //*
                allinpayRequestModel.BUS_INFO = "01";
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel);
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_RefundQR_Click. ", "--Refund--", ex);
            }
        }
        #endregion end of 3.3 Refund

        #region 3.4 Inquiry 
        // 3.4.1 Transaction Result Inquiry
        private async void button_TestQuery_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_QUERY_ORDER_RESULT).ToString();//*
                allinpayRequestModel.ORIG_DATE = MisConfig.ORIG_DATE;
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo();//*
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel); 
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_TestQuery_Click. ", "--Other--", ex);
            }
            
        }
        #endregion end of 3.4 Inquiry 


        #region 3.5. Authorization 
        // 3.5.1 Pre-authorization 
        private async void button_Auth_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_AUTH_BANK).ToString();//*
                allinpayRequestModel.AMOUNT = RequestClient.getAmountin12Digit(textBox_Amount.Text); //*
                allinpayRequestModel.MEMO = "Auth";
                allinpayRequestModel.CURRENCY = MisConfig.CURRENCY;//*
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo();
                allinpayRequestModel.BUS_INFO = "01";
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel);  
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_Auth_Click. ", "--Auth--", ex);
            }
        }

        // 3.5.2 Pre-authorization Voiding 
        private async void button_AuthCancel_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_AUTH_VOID_BANK).ToString();//*
                allinpayRequestModel.AMOUNT = RequestClient.getAmountin12Digit(textBox_Amount.Text); //*
                allinpayRequestModel.MEMO = "Auth Cancel";
                allinpayRequestModel.CURRENCY = MisConfig.CURRENCY;
                allinpayRequestModel.ORIG_AUTH_NO = textBox_Trans.Text.ToString();  //*
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo();
                allinpayRequestModel.BUS_INFO = "01";
                allinpayRequestModel.CARDNO = MisConfig.CARDNO;
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel); 
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_AuthCancel_Click. ", "--Auth--", ex);
            }
        }

        // 3.5.3 Pre-authorization Completion 
        private async void button_AuthConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_AUTH_CM_BANK).ToString(); //*
                allinpayRequestModel.AMOUNT = RequestClient.getAmountin12Digit(textBox_Amount.Text); //*
                allinpayRequestModel.MEMO = "Auth Tender";
                allinpayRequestModel.CURRENCY = MisConfig.CURRENCY; //*
                allinpayRequestModel.ORIG_AUTH_NO = textBox_Trans.Text.ToString(); //*
                allinpayRequestModel.ORIG_DATE = MisConfig.ORIG_DATE;//*
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo();     
                allinpayRequestModel.DCC_FLAG = "EDC";
                allinpayRequestModel.BUS_INFO = "01";
                allinpayRequestModel.CARDNO = MisConfig.CARDNO;
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel); 
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_AuthConfirm_Click. ", "--Auth--", ex);
            }
        }

        // 3.5.4 Voiding of Pre-authorization Completion
        private async void button_AuthCancelConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_AUTH_CM_VOID_BANK).ToString(); ; //*
                allinpayRequestModel.AMOUNT = RequestClient.getAmountin12Digit(textBox_Amount.Text); //*
                allinpayRequestModel.MEMO = "Auth Cancel Confirm";
                allinpayRequestModel.CURRENCY = MisConfig.CURRENCY;
                allinpayRequestModel.ORIG_TRACE_NO = textBox_Trans.Text.ToString(); //*
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo();
                allinpayRequestModel.BUS_INFO = "01";
                allinpayRequestModel.CARDNO = MisConfig.CARDNO;
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel);  
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_AuthCancelConfirm_Click. ", "--Auth--", ex);
            }
        }
        #endregion end of 3.5. Authorization 

        #region 3.6 Accessibility 
        // 3.6.1 Receiving Terminal Master Key 
        private async void button_LoadMKey_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_MANAGER_TRANS_LOAD_MKEY).ToString(); //*
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel);  
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_LoadMKey_Click. ", "--Other--", ex);
            }
        }

        // 3.6.2 Terminal Sign-on 
        private async void button_SignIn_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_MANAGER_TRANS_LOGON).ToString();  //*
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel); 
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_SignIn_Click. ", "--Other--", ex);
            }
        }

        // 3.6.3 Terminal Settlement 
        private async void button_Settle_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_MANAGER_TRANS_SETTLE).ToString();  //*
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel);  
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_Settle_Click. ", "--Other--", ex);
            }
        }

        // 3.6.4 Reprinting a Receipt & 3.6.5 Reprinting the Purchase Order 
        private async void button_Reprint_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.OPER_NO = MisConfig.OPER_NO;
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_MANAGER_TRANS_REPRINT).ToString();  //*
                allinpayRequestModel.ORIG_TRACE_NO = textBox_Trans.Text.ToString();  //*
                allinpayRequestModel.TRANS_TRACE_NO = RequestClient.getTransTraceNo();
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel);  
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_Reprint_Click. ", "--Other--", ex);
            }
        }

        // 3.7.1 Getting Device Information
        private async void button_DeviceInfo_Click(object sender, EventArgs e)
        {
            try
            {
                StartMessage();
                AllinpayRequestModel allinpayRequestModel = new AllinpayRequestModel();
                allinpayRequestModel.BUSINESS_ID = ((int)MisConfig.Business_Type.BUSI_MANAGER_SERVICE_GET_BASIC_INFO).ToString(); //*
                var result = await requestClient.PostAllinPayApiService(allinpayRequestModel);  
                Result(result);
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at button_DeviceInfo_Click. ", "--Other--", ex);
            }
        }
        #endregion end of Others

        private void button_Clear_Click(object sender, EventArgs e)
        {
            richTextBox_output.Text = " ";
            textBox_Trans.Text = "";
        }

        private void Result(RequestClient.PostResponse result)
        {
            richTextBox_output.Text = " ";
            
            string output = "";
            if (result.StatusCode == 200)
            {
                for (int i = 0; i < result.Status.Length; i++)
                {
                    char c = result.Status[i];
                    output += c;

                    // Check if the current character is a comma ',' and not within a JSON object or array
                    if (c == ',' && !IsWithinJson(result.Status, i))
                    {
                        output += Environment.NewLine; // Add a new line character
                        Console.WriteLine($"Added new line at index {i}");
                    }
                }
                richTextBox_output.Text = result.Status.ToString(); 
                RequestClient.WriteEventLog("Response : " + result.Status.ToString());
            }
            else { richTextBox_output.Text = result.Error.Description.ToString(); }
            textBox_Trans.Text = "";
        }

        bool IsWithinJson(string jsonString, int index)
        {
            int depth = 0;

            for (int i = 0; i < index; i++)
            {
                char c = jsonString[i];

                if (c == '{' || c == '[')
                {
                    depth++;
                }
                else if (c == '}' || c == ']')
                {
                    depth--;
                }
            }

            Console.WriteLine($"Index {index} has depth {depth}");
            return depth > 0;
        }
    }
}
