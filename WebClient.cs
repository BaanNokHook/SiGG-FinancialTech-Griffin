using GM.Model.Common;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GM.ClientAPI
{
    public class WebClient
    {
        private readonly HttpClient _client;

        public WebClient(HttpClient client)
        {
            _client = client;
        }
        
        public ResultWithModel<T> Post<T>(string requestUri, object model)
        {
            ResultWithModel<T> rwm = new ResultWithModel<T>();
            
            try
            {
                Type type = typeof(T);
                using (var requestWriter = new System.IO.StringWriter())
                {
                    var requestSerializer = JsonSerializer.Create();
                    requestSerializer.Serialize(requestWriter, model);
                    var content = new StringContent(requestWriter.ToString(), System.Text.Encoding.UTF8, "application/json");
                    using (var response = _client.PostAsync(requestUri, content).Result)
                    {
                        try
                        {
                            response.EnsureSuccessStatusCode();
                            var stream = response.Content.ReadAsStreamAsync().Result;
                            using (JsonTextReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream)))
                            {
                                JObject jo = JObject.Load(jsonReader);
                                foreach (JProperty jp in jo.Properties())
                                {
                                    if (jp.Name == "data")
                                    {
                                        if (type.Name.Contains("List"))
                                        {
                                            //Type itemType = type.GetGenericArguments()[0].DeclaringType;
                                            if (jp.Value.HasValues)
                                            {
                                                var jpChild = jp.Value.First();
                                                rwm.Data = JsonConvert.DeserializeObject<T>(jpChild.First().ToString());
                                            }
                                            else
                                            {
                                                rwm.Data = default(T);
                                            }
                                        }
                                        else //if (type.Name.Equals("DataSet") || type.Name.Equals("Object"))
                                        {
                                            rwm.Data = jp.Value.ToObject<T>();
                                        }
                                    }
                                    else if (jp.Name.ToLower() == "success")
                                    {
                                        rwm.Success = (bool)jp.Value;
                                    }
                                    else if (jp.Name.ToLower() == "howmanyrecord")
                                    {
                                        rwm.HowManyRecord = (int)jp.Value;
                                    }
                                    else if (jp.Name.ToLower() == "message")
                                    {
                                        rwm.Message = jp.Value.ToString();
                                    }
                                    else if (jp.Name.ToLower() == "refcode")
                                    {
                                        rwm.RefCode = (int)jp.Value;
                                    }
                                    else if (jp.Name.ToLower() == "serverity")
                                    {
                                        rwm.Serverity = jp.Value.ToString();
                                    }
                                }
                            }
                        }
                        catch (HttpRequestException)
                        {
                            if (response.StatusCode == HttpStatusCode.NotFound)
                            {
                                throw new Exception("NotFound");
                            }
                            else
                            {
                                throw;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                rwm.Message = ex.Message;
                rwm.Success = false;
                rwm.Data = default(T);
            }

            return rwm;
        }

        public ResultWithModel<T> Get<T>(string requestUri)
        {
            ResultWithModel<T> rwm = new ResultWithModel<T>();
            try
            {
                Type type = typeof(T);
                using (var response = _client.GetAsync(Uri.EscapeUriString(requestUri)).Result)
                {
                    try
                    {
                        response.EnsureSuccessStatusCode();
                        var stream = response.Content.ReadAsStreamAsync().Result;
                        using (JsonTextReader jsonReader = new JsonTextReader(new System.IO.StreamReader(stream)))
                        {
                            JObject jo = JObject.Load(jsonReader);
                            foreach (JProperty jp in jo.Properties())
                            {
                                if (jp.Name == "data")
                                {
                                    if (type.Name.Contains("List"))
                                    {
                                        //Type itemType = type.GetGenericArguments()[0].DeclaringType;
                                        if (jp.Value.HasValues)
                                        {
                                            var jpChild = jp.Value.First();
                                            rwm.Data = JsonConvert.DeserializeObject<T>(jpChild.First().ToString());
                                        }
                                        else
                                        {
                                            rwm.Data = default(T);
                                        }
                                    }
                                    else //if (type.Name.Equals("DataSet"))
                                    {
                                        rwm.Data = jp.Value.ToObject<T>();
                                    }
                                }
                                else if (jp.Name.ToLower() == "success")
                                {
                                    rwm.Success = (bool)jp.Value;
                                }
                                else if (jp.Name.ToLower() == "howmanyrecord")
                                {
                                    rwm.HowManyRecord = (int)jp.Value;
                                }
                                else if (jp.Name.ToLower() == "message")
                                {
                                    rwm.Message = jp.Value.ToString();
                                }
                                else if (jp.Name.ToLower() == "refcode")
                                {
                                    rwm.RefCode = (int)jp.Value
                                }
                                else if (jp.Name.ToLower() == "serverity")
                                {
                                    rwm.Serverity = jp.Value.ToString();
                                }
                            }
                        }
                    }
                    catch (HttpRequestException)
                    {
                        if (response.StatusCode == HttpStatusCode.NotFound)
                        {
                            throw new Exception("NotFound");
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                rwm.Message = ex.Message;
                rwm.Success = false;
                rwm.Data = default(T);
            }
            
            return rwm;
        }

        private T ReadAsJsonAsync<T>(HttpContent content)
        {
            string json = content.ReadAsStringAsync().Result;
            T value = JsonConvert.DeserializeObject<T>(json);
            return value;
        }
    }
}