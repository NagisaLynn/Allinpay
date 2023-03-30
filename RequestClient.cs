using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allinpay
{
    public class RequestClient
    {
        public static string post(Map<String, String> param)
        {
            try
            {
                if (PosEnum.LANDI.equals(MisConfig.POS))
                {
                    return HttpUtils.postForm(MisConfig.URL, param);
                }
                else
                {
                    return HttpUtils.post(MisConfig.URL, param);
                }
            }
            catch(Exception ex)
            {

            }
        }

        public static string getTransTraceNo()
        {
            try
            {
                DateTime now = DateTime.Now;
                string time = now.ToString("yyyyMMddHHmmss");
                return time + randomString(6);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string getTransOrderNo()
        {
            try
            {
                DateTime now = DateTime.Now;
                string time = now.ToString("yyyyMMddHHmmss");
                return time + randomString(2);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string randomString(int count)
        {
            try
            {
                Random random = new Random();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    sb.Append(random.Next(10));
                }
                return sb.ToString();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
