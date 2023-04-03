using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Allinpay
{
    public class RequestClient
    {
        public class PostResponse
        {
            public string Status { get; set; }
            public int StatusCode { get; set; }
            public ErrorResponse Error { get; set; }
            public int? Id { get; set; }
            public PostResponse()
            {
                Error = new ErrorResponse();
            }
        }

        public class ErrorResponse
        {
            public int Code { get; set; }
            public string Description { get; set; }
        }

        #region 

        public async Task<PostResponse> PostAllinPayApiService(AllinpayRequestModel allinpayRequestModel)
        {
            PostResponse Response = new PostResponse();
            try
            {
                AllinPayApiService APIService = new AllinPayApiService(MisConfig.URL, null);
                Response = await APIService.Post(allinpayRequestModel);
                return Response;
            }
            catch (Exception ex)
            {
                return Response;
            }
        }
        #endregion

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
