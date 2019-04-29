using System;
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
        public string expDate;
        public string userID;
        public string state;
        public string userNick;
        public bool success;
        public int rspCode;
        public string errorCode;

        public JArray list;
        public JObject thing;
        public string[] language;
        public string[] type;
        public string[] content;

        public int[] rankTpm;
        public int[] rankScore;
        public string[] rankRegDate;
        public int[] rankTimeLimit;
        public string[] rankUserID;
        public float[] rankAccuracy;
        public int[] rankInputDone;
        public int[] rankInputRight;


        private static Server instance = new Server();

        private Server() { }

        public static Server GetInstance()
        {
            return instance;
        }

        public string GetRequest(string url)
        {
            try
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
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
                return "";
            }
        }

        public string GetRequest(string url, string getData)
        {
            try
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
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
                return "";
            }
        }

        public string GetRequest(string url, string header, string value)
        {
            try
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
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
                return "";
            }
        }

        public string GetRequest(string url, string header, string value, string getData)
        {
            try
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
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
                return "";
            }
        }

        public string GetRequest(string url, string header, string value, string header2, string value2)
        {
            try
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
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
                return "";
            }
        }

        public string PostRequest(string url, string postData)
        {
            try
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
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
                return "";
            }
        }

        public string PostRequest(string url, string header, string value, string postData)
        {
            try
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
            catch (Exception ex)
            {
                Client.WriteErrorLog(Client.GenerateErrorMessage(new System.Diagnostics.StackTrace(true), ex));
                return "";
            }
        }

        public string Regist(string id, string password, string nickname)
        {
            string url = "https://api.qcoder.site/auth/register.jsp";
            string postData = $"user_id={id}&user_pw={password}&user_nick={nickname}";
            return PostRequest(url, postData);
        }

        public string Unregist(string accessToken, string id, string reason)
        {
            string url = "https://api.qcoder.site/auth/unregister.jsp";
            string postData = $"user_id={id}&reason={reason}";
            return PostRequest(url, "X-Access-Token", accessToken, postData);
        }

        public string Login(string id, string password)
        {
            string url = "https://api.qcoder.site/auth/login.jsp";
            string postData = $"user_id={id}&user_pw={password}";
            return PostRequest(url, postData);
        }

        public string Logout(string accessToken)
        {
            string url = "https://api.qcoder.site/auth/logout.jsp";
            return GetRequest(url, "X-Access-Token", accessToken);
        }

        public string ReissueToken(string accessToken, string refreshToken)
        {
            string url = "https://api.qcoder.site/auth/newAccessToken.jsp";
            return GetRequest(url, "X-Access-Token", accessToken, "X-Refresh-Token", refreshToken);
        }

        public string RequestDataList(string accessToken, string type)
        {
            string url = "https://api.qcoder.site/data/list.jsp";
            string getData = $"type={type}";
            return GetRequest(url, "X-Access-Token", accessToken, getData);
        }

        public string SaveRecord(TypeForm.TypeModes typeMode, string accessToken, int progressStage, int completionStage, float accuracy, int TPM, int score)
        {
            string url = string.Empty;
            string postData = string.Empty;
            switch (typeMode)
            {
                case TypeForm.TypeModes.Word:
                    url = "https://api.qcoder.site/record/word.jsp";
                    postData = $"time_limit={TypeForm.timeLimit[(int)typeMode]}&input_done={progressStage}&input_right={completionStage}&accuracy={accuracy}&tpm={TPM}&score={score}";
                    break;
                case TypeForm.TypeModes.Sentence:
                    url = "https://api.qcoder.site/record/sentence.jsp";
                    postData = $"time_limit={TypeForm.timeLimit[(int)typeMode]}&input_done={progressStage}&input_right={completionStage}&accuracy={accuracy}&tpm={TPM}&score={score}";
                    break;
                case TypeForm.TypeModes.Article:
                    url = "https://api.qcoder.site/record/article.jsp";
                    postData = $"time_limit={TypeForm.timeLimit[(int)typeMode]}&accuracy={accuracy}&tpm={TPM}&score={score}";
                    break;
            }
            return PostRequest(url, "X-Access-Token", accessToken, postData);
        }

        public string LoadRecord(string typeMode, string accessToken, string criteria, string order, int time_limit)
        {
            string url = string.Empty;
            string getData = string.Empty;
            switch (typeMode)
            {
                case "word":
                    url = "https://api.qcoder.site/ranking/word.jsp";
                    break;
                case "sentence":
                    url = "https://api.qcoder.site/ranking/sentence.jsp";
                    break;
                case "article":
                    url = "https://api.qcoder.site/ranking/article.jsp";
                    break;
            }
            getData = $"criteria={criteria}&order={order}&time_limit={time_limit}";
            return GetRequest(url, "X-Access-Token", accessToken, getData);
        }

        public void AccountJSON(string JSONstring)
        {
            jo = JObject.Parse(JSONstring);
            errorMessage = (string)jo["error_msg"];
            data = (JObject)jo["data"];
            try
            {
                connection = (JObject)data["connection"]; // nullable
                accessToken = (string)connection["access_token"];
                userIP = (string)connection["user_ip"];
                refreshToken = (string)connection["refresh_token"];
                expDate = (string)connection["at_expiration_date"];
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

        public void WordJSON(string JSONstring)
        {
            jo = JObject.Parse(JSONstring);
            errorMessage = (string)jo["error_msg"];
            data = (JObject)jo["data"];
            try
            {
                list = (JArray)data["list"]; // nullable
                language = new string[list.Count];
                type = new string[list.Count];
                content = new string[list.Count];
                for (int i = 0; i < list.Count; i++)
                {
                    thing = (JObject)list[i];
                    language[i] = (string)thing["language"];
                    type[i] = (string)thing["type"];
                    content[i] = (string)thing["content"];
                }
            }
            catch (NullReferenceException)
            {
                throw;
            }
            success = (bool)jo["success"];
            rspCode = (int)jo["rsp_code"];
            errorCode = (string)jo["error_code"];
        }

        public void RankingJSON(string JSONstring)
        {
            jo = JObject.Parse(JSONstring);
            errorMessage = (string)jo["error_msg"];
            data = (JObject)jo["data"];
            try
            {
                list = (JArray)data["list"]; // nullable
                rankTpm = new int[list.Count];
                rankScore = new int[list.Count];
                rankRegDate = new string[list.Count];
                rankTimeLimit = new int[list.Count];
                rankUserID = new string[list.Count];
                rankAccuracy = new float[list.Count];
                rankInputDone = new int[list.Count];
                rankInputRight = new int[list.Count];
                for (int i = 0; i < list.Count; i++)
                {
                    thing = (JObject)list[i];
                    rankTpm[i] = (int)thing["tpm"];
                    rankScore[i] = (int)thing["score"];
                    rankRegDate[i] = (string)thing["reg_date"];
                    rankTimeLimit[i] = (int)thing["time_limit"];
                    rankUserID[i] = (string)thing["user_id"];
                    rankAccuracy[i] = (float)thing["accuracy"];
                    try
                    {
                        rankInputDone[i] = (int)thing["input_done"];
                        rankInputRight[i] = (int)thing["input_right"];
                    }
                    catch (ArgumentNullException)
                    {

                    }

                }
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
