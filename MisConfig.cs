using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Allinpay
{
    public static class MisConfig
    {
        /**
         * 请求地址 - request address
         */
        public static string URL = "http://192.168.1.110:9801/tran"; // LANDI
        //public static string URL = "http://" + IP + ":10021/allinpay"; // UROVO

        /**
         * 交易币种 - transaction currency
         */
            //    public static String CURRENCY = "HKD";
        public static string CURRENCY = "SGD";

        /**
         * 调整为MIS服务地址 - URL for terminal (recommad to assign static IP)
         */
        public static string IP = "192.168.1.110";
        //    public static String IP = "10.40.121.108";

        /**
         * 机具类型 - payment type
         */
        public static string POS = "LANDI";
        //    public static string POS = "UROVO";       
    }
}
