using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Allinpay
{
    public static class MisConfig
    {
        public static string OPER_NO = "SmartEnergy";
        public static string CURRENCY = "SGD";
        public static string IP = "192.168.137.131";

        public enum Business_Type{
            BUSI_SALE_BANK = 100100001, //Bank card payment
            BUSI_SALE_QR = 100300001, // scan QR code to pay
            BUSI_SALE_SCAN = 100300002, // QR Code payment

            BUSI_VOID_BANK = 200100001, // Bank card cancellation
            BUSI_VOID_QR = 200300001, // Scan QR code payment cancellation
            BUSI_REFUND_BANK = 300100001, // Bank card return goods
            BUSI_REFUND_QR = 300300001, // Scan QR code for returns

            BUSI_AUTH_BANK = 500100001, // Pre-authorization only bank cards are supported
            BUSI_AUTH_VOID_BANK = 510100001, // Revocation of pre-authorization, only bank cards are supported
            BUSI_AUTH_CM_BANK = 520100001, // Pre-authorization is complete, only bank cards are supported
            BUSI_AUTH_CM_VOID_BANK = 530100001, // The pre authorization is cancelled, only bank cards are supported

            BUSI_QUERY_ORDER_RESULT = 600000002, // Payment result inquiry
            BUSI_MANAGER_TRANS_LOAD_MKEY = 900100030, // Receive terminal master key
            BUSI_MANAGER_TRANS_LOGON = 900100001, // Terminal sign in 
            BUSI_MANAGER_TRANS_SETTLE = 900100002, // Terminal settlement
            BUSI_MANAGER_TRANS_REPRINT = 900100010, // Reprint the purchase order
            BUSI_MANAGER_LAST_TRANS_REPRINT = 900100020, // Reprint the purchase order
            BUSI_MANAGER_TRANS_REPRINT_SETTLE = 900100011, // Reprint statement
            BUSI_MANAGER_TRANS_PRINT_DETAIL = 900100012, // Print transaction details
            BUSI_MANAGER_TRANS_PRINT_TOTAL = 900100013, // Print transaction summary
            BUSI_MANAGER_SERVICE_READCARD = 900300001, // Card reading information
            BUSI_MANAGER_SERVICE_GET_BASIC_INFO = 900300005, // Get device  information
            BUSI_MANAGER_APP_CONFIG = 900200002, // parameter settings

        }
    }
}
