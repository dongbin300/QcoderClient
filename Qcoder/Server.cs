﻿using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Qcoder
{
    class Server
    {
        public JObject jo;
        public string errorMessage;
        public JObject data;
        public JObject connection;
        public string accessToken;
        public string userIP;
        public string refreshToken;
        public string updDate;
        public string connState;
        public JObject account;
        public string regDate;
        public string atExpirationDate;
        public string userID;
        public string state;
        public string userNick;
        public bool success;
        public int rspCode;
        public string errorCode;

        private static Server instance = new Server();

        private Server() { }

        public static Server GetInstance()
        {
            return instance;
        }

        public string GetRequest(string url)
        {
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        public string GetRequest(string url, string getData)
        {
            WebRequest request = WebRequest.Create($"{url}?{getData}");
            request.Method = "GET";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        public string GetRequest(string url, string header, string value)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            request.Headers[header] = value;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        public string GetRequest(string url, string header, string value, string getData)
        {
            WebRequest request = WebRequest.Create($"{url}?{getData}");
            request.Method = "GET";
            request.Headers[header] = value;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        public string GetRequest(string url, string header, string value, string header2, string value2)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "GET";
            request.Headers[header] = value;
            request.Headers[header2] = value2;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        public string PostRequest(string url, string postData)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        public string PostRequest(string url, string header, string value, string postData)
        {
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.Headers[header] = value;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            dataStream.Close();
            response.Close();
            return responseFromServer;
        }

        public string Regist(string id, string password, string nickname)
        {
            string url = "https://devworld.net/qcoder/api/register.jsp";
            string postData = $"user_id={id}&user_pw={password}&user_nick={nickname}";
            return PostRequest(url, postData);
        }

        public string Unregist(string accessToken, string id, string reason)
        {
            string url = "https://devworld.net/qcoder/api/unregister.jsp";
            string postData = $"user_id={id}&reason={reason}";
            return PostRequest(url, "X-Access-Token", accessToken, postData);
        }

        public string Login(string id, string password)
        {
            string url = "https://devworld.net/qcoder/api/login.jsp";
            string postData = $"user_id={id}&user_pw={password}";
            return PostRequest(url, postData);
        }

        public string Logout(string accessToken)
        {
            string url = "https://devworld.net/qcoder/api/logout.jsp";
            return GetRequest(url, "X-Access-Token", accessToken);
        }

        public string ReissueToken(string accessToken, string refreshToken)
        {
            string url = "https://devworld.net/qcoder/api/getNewAccessToken.jsp";
            return GetRequest(url, "X-Access-Token", accessToken, "X-Refresh-Token", refreshToken);
        }

        public string RequestDataList(string accessToken, string type)
        {
            string url = "https://devworld.net/qcoder/api/getDataList.jsp";
            string getData = $"type={type}";
            return GetRequest(url, "X-Access-Token", accessToken, getData);
        }

        public string TryToHackNaver()
        {
            return GetRequest("https://www.naver.com");
        }

        public void ReadJSON(string JSONstring)
        {
            jo = JObject.Parse(JSONstring);
            errorMessage = (string)jo["error_msg"];
            data = (JObject)jo["data"];
            try
            {
                connection = (JObject)data["connection"];
                accessToken = (string)connection["access_token"];
                userIP = (string)connection["user_ip"];
                refreshToken = (string)connection["refresh_token"];
                atExpirationDate = (string)connection["at_expiration_date"];
                updDate = (string)connection["upd_date"];
                connState = (string)connection["conn_state"];
                account = (JObject)data["account"];
                regDate = (string)account["reg_date"];
                userID = (string)account["user_id"];
                state = (string)account["state"];
                userNick = (string)account["user_nick"];
            }
            catch (NullReferenceException)
            {

            }
            success = (bool)jo["success"];
            rspCode = (int)jo["rsp_code"];
            errorCode = (string)jo["error_code"];
        }
    }
}
