using System;
using System.Threading.Tasks;
using System.IO;
using System.Data.Entity.Validation;
using System.Text;
using Newtonsoft.Json;
using System.Windows.Forms;

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
                AllinPayApiService APIService = new AllinPayApiService(MisConfig.IP, null);
                Response = await APIService.Post(allinpayRequestModel);
                return Response;
            }
            catch (Exception ex)
            {
                PostResponse postResponse = new PostResponse();
                postResponse.Status = "Error";
                postResponse.StatusCode = 500;
                postResponse.Error.Code = 500;
                postResponse.Error.Description = ex.InnerException.Message.ToString();
                return postResponse;
            }
        }
        #endregion

        public static string getAmountin12Digit(string amount)
        {
            try
            {
                // Convert amount to cents
                int cents = (int)(double.Parse(amount) * 100);

                // Convert cents to a 12-digit number as a string
                string result = cents.ToString().PadLeft(12, '0');

                return result;
            }
            catch (Exception ex)
            {
                RequestClient.WriteErrorLog("Error at getAmountin12Digit. ", "--RequestClient--", ex);
                return null;
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
                RequestClient.WriteErrorLog("Error at getTransTraceNo. ", "--RequestClient--", ex);
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
                RequestClient.WriteErrorLog("Error at getTransOrderNo. ", "--RequestClient--", ex);
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
                RequestClient.WriteErrorLog("Error at randomString. ", "--RequestClient--", ex);
                return null;
            }
        }


        public static void WriteEventLog(String strString)
        {
            try
            {
                string locationDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("EventLogs/"));

                if (!Directory.Exists(locationDirectory))
                    Directory.CreateDirectory(locationDirectory);

                String strPath = Path.Combine(locationDirectory, DateTime.Now.ToString("yyyy-MM-dd") + ".txt");
                if (!File.Exists(strPath))
                {
                    using (StreamWriter sw = File.CreateText(strPath))
                    {
                        sw.WriteLine("File created on " + DateTime.Now.ToString());
                    }
                }

                using (StreamWriter sw = File.AppendText(strPath))
                {
                    sw.WriteLine(DateTime.Now.ToString() + " : " + strString);
                }
            }
            catch (Exception ex)
            {
                //throw;
            }
        }

        public static void WriteErrorLog(String customErrorMessage, String controllerName, Exception error = null)
        {
            try
            {
                string locationDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("ErrorLogs/"));

                if (!Directory.Exists(locationDirectory))
                    Directory.CreateDirectory(locationDirectory);

                String strPath = Path.Combine(locationDirectory, DateTime.Now.ToString("yyyy-MM-dd") + ".txt");
                if (!File.Exists(strPath))
                {
                    using (StreamWriter sw = File.CreateText(strPath))
                    {
                        sw.WriteLine("File created on " + DateTime.Now.ToString());
                    }
                }

                using (StreamWriter sw = File.AppendText(strPath))
                {
                    sw.WriteLine(Environment.NewLine);
                    string errMessage = string.Format("{0} : {1} - {2}, {3}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff tt"), controllerName,
                        customErrorMessage, error != null ? error.ToLogString(Environment.StackTrace) : string.Empty);
                    sw.WriteLine(errMessage);
                    if (error != null)
                    {
                        try
                        {
                            DbEntityValidationException eFException = (DbEntityValidationException)error;
                            foreach (var eve in eFException.EntityValidationErrors)
                            {
                                sw.WriteLine(string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:", eve.Entry.Entity.GetType().Name, eve.Entry.State));
                                foreach (var ve in eve.ValidationErrors)
                                {
                                    sw.WriteLine(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                                }
                            }
                        }
                        catch (Exception)
                        {
                        }

                        if (error.InnerException != null)
                        {
                            sw.WriteLine("INNER EXCEPTION x1 : " + error.InnerException.Message);
                            if (error.InnerException.InnerException != null)
                            {
                                sw.WriteLine("INNER EXCEPTION x2 : " + error.InnerException.InnerException.Message);
                            }
                        }
                    }
                    sw.WriteLine(Environment.NewLine);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
