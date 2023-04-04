using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Allinpay
{
    public static class MisConfig
    {
        public static string OPER_NO = "SmartEnergy";
        public static string CURRENCY = "SGD";
        public static string IP = "192.168.137.131";

        #region 4. Parameters Description
        // Card Logo ( CARD_ORGN Property
        public enum Card_Type
        {
            UNION = 00, // union pay 
            VISA = 01, // VISA
            Master_Card = 02, // master card
            JCB = 03, // JCB
            Dinner_Club = 04, // dinners club
            American_Express = 05 // American express
        }

        // Payment Channel（TRANS_CHANNEL Property） 
        public enum Payment_Channel
        {
            ALP, // Alipay wallet  
            WXP, // Wechat wallet 
            UNP, // union pay 
            PNP, // PayNow
        }

        // Business Type（BUSINESS_ID Property） 
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

        // Transaction State（TRANS_STATE Field） 
        public enum Transaction_State
        {
            PAIED, // Paid
            FAIL, //  Payment failed
            PAYING, //  paying
            RETURNED, //  Returned
            VOID, //  Voided
            REVOKED, //  Revoked
        }

        // Currency（CURRENCY Field） 
        public enum Currency 
        {
            HKD, //  HKD
            RMB, //  CNY
            SGD, //  SGD
        }

        // Return Code(REJCODE Field) 
        public enum Return_Code
        {
            Successful_transaction = 00, // Successful acceptance or transaction
            Check_card_issuer = 01, // Please ask the cardholder to contact the card-issuing bank 
            Invalid_merchant = 03, //  Invalid merchant 
            Invalid_card = 04, //  This card should be swallowed（ATM） This card is invalid（POS） 
            Identity_authentication_failed = 05, //  Cardholder authentication failed 
            
            Partial_amount_approved = 10, // Display part of the approved amount and prompt the operator 
            VIP_customer = 11, //  Very important person approval（VIP） This is a VIP customer
            Invalid_transaction = 12, //  Invalid related transaction 
            Invalid_amount = 13, //  Invalid amount 
            Invalid_card_number = 14, //   Invalid card number (no such account number) 

            Invalid_issuer = 15, // There is no corresponding issuer for this card 
            Approval_third_track = 16, // Approval of updating the third track
            Card_not_initialized = 21, // The card is not initialized or inactivated card 
            transaction_error = 22, //   The operation is wrong, or the number of days allowed for the transaction has been exceeded 
            Original_transaction_notfound = 25, //  No original transaction, please contact the card issuer 
            
            Message_format_error = 30, //  Please try again 
            Suspicion_Card = 34, //  Suspicion of cheating Cheating card, swallowed card 
            Limited_tried_Pin = 38, //   Trying input more than allowed PIN  The number of incorrect passwords  exceeds the limit, please contact the  card issuer
            Transactions_NotSupported = 40, //  The requestfunction is notyet supported Transactions not supported by the card issuer
            Loss_report_card = 41, //  This card has been reported as lost or swallowed（ATM）Loss Report card（POS） 
           
            Stolen_card = 43, //  This card has been confiscated, please contact the card issuer（ATM）Stolen card（POS） 
            Insufficient_funds = 51, //   Insufficient available balance 
            Expired_card = 54, //  The card has expired 
            PIN_Incorrect = 55, //   PIN Wrong password 
            Block_transactions = 57, //  Unallowed transactions by cardholders This card is not allowed for transaction 

            Invalid_Transactions = 58, //  Transactions that are not allowed on the terminalThe card issuer does not allow the card to conduct this transaction on this terminal 
            Card_verification_error = 59, //  Suspicion of cheating 
            Exceeded_amount_limit = 61, //  The transaction amount exceeds the limit
            Restricted_card = 62, //   Restricted card 
            Wrong_Amount = 64, //  The original amount is wrong The transaction amount does not match the original transaction
            
            Excess_withdrawal_limit = 65, //  Excess of withdrawal/consumption times limit
            Transaction_times_out = 68, //  Issuing bank's response times out Transaction times out, please try again 
            Excess_PIN_limit = 75, //  The allowed times of PINinput exceeds the limit The times of incorrect passwords exceeds the limit 
            Day_End_Warning = 90, //  Processing at the end of the day The system is daily settling, please  try again later
            Abnormal_issuer = 91, //  The issuer cannot operate The issuer's status is abnormal, please  try again later
            
            Timeout_issuer = 92, //  Financial institutions or  intermediate network facilities cannot be found or reachable The issuer line is abnormal, please try   again later
            Repeat_transaction = 94, //   Decline, repeat transaction, please try  again later
            invalid_UnionPay= 96, //  The UnionPay processing center system is abnormal or invalid Rejected, the exchange center is  abnormal, please try again later
            terminal_not_registered = 97, //   ATM/POS terminal number not found The terminal number is not registered
            Issuer_timedout  = 98, //   UnionPay processing center cannot receive the card issuer's response 
            
            Incorrect_PIN = 99, //  PIN format is wrong PIN format is wrong, please sign in  again
            A0, //  MAC authentication failed MAC check error, please sign in again
            AS, //  MAC authentication failed Unknown transaction result
            REPRINT_LAST_RECEIPT = 166, //  PLS REPRINT LAST RECEIPT The last receipt was not successfully printed, please reprint it
    }
        #endregion end of 4. Parameters Description
    }
}
