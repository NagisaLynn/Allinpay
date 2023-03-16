using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.Expando;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;

namespace Allinpay
{
    //public class clsAllinpayModel
    //{
    //    public string BUS_INFO { get; set; } // Optional; 
    //    public string DCC_FLAG { get; set; } // Optional; 
    //    public string BUS_INFO { get; set; } // Optional; 
    //    public string DCC_FLAG { get; set; } // Optional;
    //    public string BUS_INFO { get; set; } // Optional;
    //}

    #region 3.1.1 Collection – Bank card 
    public class CollectionRequestBankCard
    {
        public int OPER_NO { get; set; } // Optional; Operator number
        public int BUSINESS_ID { get; set; } // Required; Business type
        public int AMOUNT { get; set; } // Required; Amount (12 digit-number, cent as unit,completes it by adding 0 on left if the digit numbers are insufficient)
        public string MEMO { get; set; } // Optional; Meomo field
        public int TRANS_TRACE_NO { get; set; } // Required; Transaction unique identifier
        public int TRANS_ORDER_NO { get; set; } // Required; Commodity order number
        public string CURRENCY { get; set; } // Required; Currency (refer to Appendix-Currency)
        public string DCC_FLAG { get; set; } // Optional; Default EDC transaction （DCC/EDC）
        public string BUS_INFO { get; set; } // Optional; Expand field
    }

    public class CollectionReturnBankCard
    {
        public int BUSINESS_ID { get; set; } // Required; Business type
        public int AMOUNT { get; set; } // Required; Amount (12 digit-number, cent as unit,completes it by adding 0 on left if the digit numbers are insufficient)
        public string CURRENCY { get; set; } // Required; Currency (refer to Appendix-Currency)
        public string PAYCURRENCY { get; set; } // Optional; Payment currency
        public double EXCHANGE_RATE { get; set; } // Optional; Exchange rate
        
        public double ACTUALLY_AMOUNT { get; set; } // Required; The amount actually paid
        public string TRACE_NO { get; set; } // Required; Swift number
        public DateTime EXP_DATE { get; set; } // Required; Valid Date
        public string BATCH_NO { get; set; } // Required; Batch number
        public string MERCH_ID { get; set; } // Required; Business number

        public string MERCH_NAME { get; set; } // Required; Business name
        public string TER_ID { get; set; } // Required; Terminal number
        public string REF_NO { get; set; } // Required; System reference number
        public string AUTH_NO { get; set; } // Required; Authorization code
        public string REJCODE { get; set; } // Required; Return code

        public string CARD_ORGN { get; set; } // Optional; Card organization
        public string CARDNO { get; set; } // Required; Card number
        public DateTime DATE { get; set; } // Required; Transaction date
        public DateTime TIME { get; set; } // Required; Transaction time
        public string REJCODE_CN { get; set; } // Required; Return code explanation

        public string MEMO { get; set; } // Optional; Memo field
        public string TRANS_TRACE_NO { get; set; } // Optional; Transaction unique identifier
        public string BUS_INFO { get; set; } // Optional; Expand field
        public string TRANS_TICKET_NO { get; set; } // Optional; Transaction number
        public string OPER_NO { get; set; } // Optional; Operator number 
    }
    #endregion End of 3.1.1 Collection – Bank card 

    #region 3.1.2 Collection-code Scanning 
    // 3.1.2 Collection-code Scanning
    // Request pretty much same as CollectionRequestBankCard without Memo & Dcc_flag

    public class CollectionReturnScanning
    {
        public int BUSINESS_ID { get; set; } // Required; Business type
        public int AMOUNT { get; set; } // Required; Amount (12 digit-number, cent as unit,completes it by adding 0 on left if the digit numbers are insufficient)
        public string CURRENCY { get; set; } // Required; Currency (refer to Appendix-Currency)
        //public string PAYCURRENCY { get; set; } // Optional; Payment currency
        //public double EXCHANGE_RATE { get; set; } // Optional; Exchange rate

        //public double ACTUALLY_AMOUNT { get; set; } // Required; The amount actually paid
        public string TRACE_NO { get; set; } // Required; Swift number
        //public DateTime EXP_DATE { get; set; } // Required; Valid Date
        public string BATCH_NO { get; set; } // Required; Batch number
        public string MERCH_ID { get; set; } // Required; Business number

        public string MERCH_NAME { get; set; } // Required; Business name
        public string TER_ID { get; set; } // Required; Terminal number
        public string REF_NO { get; set; } // Required; System reference number
        //public string AUTH_NO { get; set; } // Required; Authorization code
        public string REJCODE { get; set; } // Required; Return code

        //public string CARD_ORGN { get; set; } // Optional; Card organization
        //public string CARDNO { get; set; } // Required; Card number
        public DateTime DATE { get; set; } // Required; Transaction date
        public DateTime TIME { get; set; } // Required; Transaction time
        public string REJCODE_CN { get; set; } // Required; Return code explanation

        public string TRANS_TRACE_NO { get; set; } // Optional; Transaction unique identifier
        public string BUS_INFO { get; set; } // Optional; Expand field
        // TRANS_CHANNEL & PRINT_FLAG are additional field
        public string TRANS_CHANNEL { get; set; } // Optional; Payment channel
        public string PRINT_FLAG { get; set; } // Optional; Print mark

        public string TRANS_TICKET_NO { get; set; } // Optional; Transaction number
        public string OPER_NO { get; set; } // Optional; Operator number 
    }
    #endregion End of 3.1.2 Collection-code Scanning 

    #region 3.2.1 Void - bank card
    public class VoidRequestBankCard
    {
        public int OPER_NO { get; set; } // Optional; Operator number
        public int BUSINESS_ID { get; set; } // Required; Business type
        public int AMOUNT { get; set; } // Required; Amount (12 digit-number, cent as unit,completes it by adding 0 on left if the digit numbers are insufficient)
        public string ORIG_TRACE_NO { get; set; } // Required; Original transaction document number
        public string TRANS_TRACE_NO { get; set; } // Required; Transaction unique identifier
        public string CURRENCY { get; set; } // Required; Currency (refer to Appendix-Currency)
        public string BUS_INFO { get; set; } // Optional; Expand field
    }

    public class VoidReturnBankCard
    {
        public int BUSINESS_ID { get; set; } // Required; Business type
        public int AMOUNT { get; set; } // Required; Amount (12 digit-number, cent as unit,completes it by adding 0 on left if the digit numbers are insufficient)
        //public string CURRENCY { get; set; } // Required; Currency (refer to Appendix-Currency)
        //public string PAYCURRENCY { get; set; } // Optional; Payment currency
        //public double EXCHANGE_RATE { get; set; } // Optional; Exchange rate

        //public double ACTUALLY_AMOUNT { get; set; } // Required; The amount actually paid
        public string TRACE_NO { get; set; } // Required; Swift number

        public DateTime EXP_DATE { get; set; } // Required; Valid Date
        public string BATCH_NO { get; set; } // Required; Batch number
        public string MERCH_ID { get; set; } // Required; Business number

        public string MERCH_NAME { get; set; } // Required; Business name
        public string TER_ID { get; set; } // Required; Terminal number
        public string REF_NO { get; set; } // Required; System reference number
        public string AUTH_NO { get; set; } // Required; Authorization code
        public string REJCODE { get; set; } // Required; Return code

        public string CARD_ORGN { get; set; } // Optional; Card organization
        public string CARDNO { get; set; } // Required; Card number
        public DateTime DATE { get; set; } // Required; Transaction date
        public DateTime TIME { get; set; } // Required; Transaction time
        public string REJCODE_CN { get; set; } // Required; Return code explanation

        public string MEMO { get; set; } // Optional; Memo field
        public string TRANS_TRACE_NO { get; set; } // Optional; Transaction unique identifier
        public string BUS_INFO { get; set; } // Optional; Expand field
        public string TRANS_TICKET_NO { get; set; } // Optional; Transaction number
        public string OPER_NO { get; set; } // Optional; Operator number 
    }
    #endregion End of 3.1.1 Collection – Bank card 
}
