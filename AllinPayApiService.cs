﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static Allinpay.RequestClient;

namespace Allinpay
{
    public class AllinPayApiService
    {
        private readonly string domain;
        private readonly string controllerUrl;
        private readonly string accessToken;
        private HttpWebRequest httpWebRequest;
        private string response = string.Empty;
        public AllinPayApiService(string domain, string accessToken)
        {
            this.domain = domain;
            this.accessToken = accessToken;
            //controllerUrl = "api/Payment";
        }
        private void CreateHttpWebRequest(string method, string urlpart = null)
        {
            string url = domain + controllerUrl + urlpart;
            httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = method;
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Accept = "application/json";
            //httpWebRequest.TransferEncoding = "UTF-8";
            httpWebRequest.Headers.Add("authorization", "Bearer " + accessToken);
        }

        public async Task<PostResponse> Post(AllinpayRequestModel allinpayRequestModel)
        {
            try
            {
                string Stringify = JsonConvert.SerializeObject(allinpayRequestModel);
                CreateHttpWebRequest("POST");
                string serializedObject = string.Format("{{\"InsertEntity\":{0}}}", Stringify);
                //string serializedObject = string.Format("{{\"InsertEntity\":{0}}}", Stringify);
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(serializedObject);
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    response = await streamReader.ReadToEndAsync();
                }
            }
            catch (Exception ex)
            {
                //dataResponse = GetErrorWebResponse.GetResponse(500, ex.Message);
            }

            return JsonConvert.DeserializeObject<PostResponse>(response);
        }
    }
}