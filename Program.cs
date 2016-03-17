using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Documentation
{
    class CSharpSamples
    {
        static void Main(string[] args)
        {
            //Remark

            //GetEbayCategoryByProductName();
            //GetAmazonCategoryByProductName();
            //GetAmazonCategoryByEbayCategory();
            //GetEbayCategoryByAmazonCategory();
            //GetEbayCategoryRelations();
            //GetAmazonCategoryRelations();
            //GetEbayEnvironment();
            //GetAmazonEnvironment();

            Console.ReadLine();
        }

        static void GetEbayCategoryByProductName()
        {
            //The server base api endPoint
            string endPoint = "http://api.ecommerceapi.org/v1/";
            //Function Name
            string functionName = "GetEbayCategoryByProductName";
            string apiAddress = string.Format("{0}{1}", endPoint, functionName);


            //Your Private token, get after registration in your dashboard, the token changes when you replace program
            string myToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJQcm9ncmFtSWQiOjIsIkdyb3VwSWRlbnRpZmllciI6IjFkNzE5NjAyLTk5MmUtNGI5Yy1iNjNjLWU1Y2M3MjlmYTRjNiIsIlVzZXJJZCI6OH0.OCnNwEHkZxA_oI6QikzcSoF5nxdnoRQm_6MJ6uvB_e4";

            //Your ClientId you get after registration, you can see it in your dashboard
            string myClientId = "LPDiCbpal0aUD4nM5mz9Pw";
            HttpResponseMessage res = null;




            var bodyRequest = new
            {
                //This field should contain string with the product title\Name (max-80 chars)
                ProductName = "Cup of tea small",
                //This field should contain the target ebay environment code for more information see "GetEbayEnvironment" function
                TargetEbayEnvironment = 0//US
            };


            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new System.Uri(apiAddress);

                //Pass the token in the header
                _httpClient.DefaultRequestHeaders.Add("Token", myToken);

                //Pass the clientId in the header
                _httpClient.DefaultRequestHeaders.Add("ClientId", myClientId);
                var myTask = _httpClient.PostAsJsonAsync(apiAddress, bodyRequest);

                res = myTask.Result;
            }

            string jsonResult = null;

            //res.Content.ReadAsStringAsync(); //You can use this string and serialize by yourself
            res.Content.ReadAsStringAsync().ContinueWith(task =>
            {
                jsonResult = task.Result;
            }).Wait();

            //This function print the result after deserialize it. you can see this method in out documentation.
            DisplayResult(jsonResult);
        }

        static void GetAmazonCategoryByProductName()
        {
            //The server base api endPoint
            string endPoint = "http://api.ecommerceapi.org/v1/";
            //Function Name
            string functionName = "GetAmazonCategoryByProductName";
            string apiAddress = string.Format("{0}{1}", endPoint, functionName);


            //Your Private token, get after registration in your dashboard, the token changes when you replace program
            string myToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJQcm9ncmFtSWQiOjIsIkdyb3VwSWRlbnRpZmllciI6IjFkNzE5NjAyLTk5MmUtNGI5Yy1iNjNjLWU1Y2M3MjlmYTRjNiIsIlVzZXJJZCI6OH0.OCnNwEHkZxA_oI6QikzcSoF5nxdnoRQm_6MJ6uvB_e4";

            //Your ClientId you get after registration, you can see it in your dashboard
            string myClientId = "LPDiCbpal0aUD4nM5mz9Pw";
            HttpResponseMessage res = null;




            var bodyRequest = new
            {
                //This field should contain string with the product title\Name (max-80 chars)
                ProductName = "Cup of tea small",
                //This field should contain the target ebay environment code for more information see "GetEbayEnvironment" function
                TargetAmazonEnvironment = 1//com
            };


            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new System.Uri(apiAddress);

                //Pass the token in the header
                _httpClient.DefaultRequestHeaders.Add("Token", myToken);

                //Pass the clientId in the header
                _httpClient.DefaultRequestHeaders.Add("ClientId", myClientId);
                var myTask = _httpClient.PostAsJsonAsync(apiAddress, bodyRequest);

                res = myTask.Result;
            }

            string jsonResult = null;

            //res.Content.ReadAsStringAsync(); //You can use this string and serialize by yourself
            res.Content.ReadAsStringAsync().ContinueWith(task =>
            {
                jsonResult = task.Result;
            }).Wait();

            //This function print the result after deserialize it. you can see this method in out documentation.
            DisplayResult(jsonResult);
        }

        static void GetAmazonCategoryByEbayCategory()
        {
            //The server base api endPoint
            string endPoint = "http://api.ecommerceapi.org/v1/";
            //Function Name
            string functionName = "GetAmazonCategoryByEbayCategory";
            string apiAddress = string.Format("{0}{1}", endPoint, functionName);


            //Your Private token, get after registration in your dashboard, the token changes when you replace program
            string myToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJQcm9ncmFtSWQiOjIsIkdyb3VwSWRlbnRpZmllciI6IjFkNzE5NjAyLTk5MmUtNGI5Yy1iNjNjLWU1Y2M3MjlmYTRjNiIsIlVzZXJJZCI6OH0.OCnNwEHkZxA_oI6QikzcSoF5nxdnoRQm_6MJ6uvB_e4";

            //Your ClientId you get after registration, you can see it in your dashboard
            string myClientId = "LPDiCbpal0aUD4nM5mz9Pw";
            HttpResponseMessage res = null;




            var bodyRequest = new
            {
                //This field should contain string with the product title\Name (max-80 chars)
                EbayCategoryId = 34053, //Radio Control Vehicles > Airplanes & Helicopters
                //This field should contain the target ebay environment code for more information see "GetEbayEnvironment" function
                ResponseAmazonEnvironment = 1,//com
                RequestEbayEnvironment = 0//us
            };


            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new System.Uri(apiAddress);

                //Pass the token in the header
                _httpClient.DefaultRequestHeaders.Add("Token", myToken);

                //Pass the clientId in the header
                _httpClient.DefaultRequestHeaders.Add("ClientId", myClientId);
                var myTask = _httpClient.PostAsJsonAsync(apiAddress, bodyRequest);

                res = myTask.Result;
            }

            string jsonResult = null;

            //res.Content.ReadAsStringAsync(); //You can use this string and serialize by yourself
            res.Content.ReadAsStringAsync().ContinueWith(task =>
            {
                jsonResult = task.Result;
            }).Wait();

            //This function print the result after deserialize it. you can see this method in out documentation.
            DisplayResult(jsonResult);
        }

        static void GetEbayCategoryByAmazonCategory()
        {
            //The server base api endPoint
            string endPoint = "http://api.ecommerceapi.org/v1/";
            //Function Name
            string functionName = "GetEbayCategoryByAmazonCategory";
            string apiAddress = string.Format("{0}{1}", endPoint, functionName);


            //Your Private token, get after registration in your dashboard, the token changes when you replace program
            string myToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJQcm9ncmFtSWQiOjIsIkdyb3VwSWRlbnRpZmllciI6IjFkNzE5NjAyLTk5MmUtNGI5Yy1iNjNjLWU1Y2M3MjlmYTRjNiIsIlVzZXJJZCI6OH0.OCnNwEHkZxA_oI6QikzcSoF5nxdnoRQm_6MJ6uvB_e4";

            //Your ClientId you get after registration, you can see it in your dashboard
            string myClientId = "LPDiCbpal0aUD4nM5mz9Pw";
            HttpResponseMessage res = null;




            var bodyRequest = new
            {
                //This field should contain string with the product title\Name (max-80 chars)
                BrowseNodeId = 2232158011,// - Helicopter Kits
                //This field should contain the target ebay environment code for more information see "GetEbayEnvironment" function
                RequestAmazonEnvironment = 1,//com
                ResponseEbayEnvironment = 0//us
            };


            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new System.Uri(apiAddress);

                //Pass the token in the header
                _httpClient.DefaultRequestHeaders.Add("Token", myToken);

                //Pass the clientId in the header
                _httpClient.DefaultRequestHeaders.Add("ClientId", myClientId);
                var myTask = _httpClient.PostAsJsonAsync(apiAddress, bodyRequest);

                res = myTask.Result;
            }

            string jsonResult = null;

            //res.Content.ReadAsStringAsync(); //You can use this string and serialize by yourself
            res.Content.ReadAsStringAsync().ContinueWith(task =>
            {
                jsonResult = task.Result;
            }).Wait();

            //This function print the result after deserialize it. you can see this method in out documentation.
            DisplayResult(jsonResult);
        }

        static void GetEbayCategoryRelations()
        {
            //The server base api endPoint
            string endPoint = "http://api.ecommerceapi.org/v1/";
            //Function Name
            string functionName = "GetEbayCategoryRelations";
            string apiAddress = string.Format("{0}{1}", endPoint, functionName);


            //Your Private token, get after registration in your dashboard, the token changes when you replace program
            string myToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJQcm9ncmFtSWQiOjIsIkdyb3VwSWRlbnRpZmllciI6IjFkNzE5NjAyLTk5MmUtNGI5Yy1iNjNjLWU1Y2M3MjlmYTRjNiIsIlVzZXJJZCI6OH0.OCnNwEHkZxA_oI6QikzcSoF5nxdnoRQm_6MJ6uvB_e4";

            //Your ClientId you get after registration, you can see it in your dashboard
            string myClientId = "LPDiCbpal0aUD4nM5mz9Pw";
            HttpResponseMessage res = null;




            var bodyRequest = new
            {
                EbayCategoryId = 300,
                
                RequestEbayEnvironment = 0//us
            };


            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new System.Uri(apiAddress);

                //Pass the token in the header
                _httpClient.DefaultRequestHeaders.Add("Token", myToken);

                //Pass the clientId in the header
                _httpClient.DefaultRequestHeaders.Add("ClientId", myClientId);
                var myTask = _httpClient.PostAsJsonAsync(apiAddress, bodyRequest);

                res = myTask.Result;
            }

            string jsonResult = null;

            //res.Content.ReadAsStringAsync(); //You can use this string and serialize by yourself
            res.Content.ReadAsStringAsync().ContinueWith(task =>
            {
                jsonResult = task.Result;
            }).Wait();

            //This function print the result after deserialize it. you can see this method in out documentation.
            DisplayResult(jsonResult);
        }

        static void GetAmazonCategoryRelations()
        {
            //The server base api endPoint
            string endPoint = "http://api.ecommerceapi.org/v1/";
            //Function Name
            string functionName = "GetAmazonCategoryRelations";
            string apiAddress = string.Format("{0}{1}", endPoint, functionName);


            //Your Private token, get after registration in your dashboard, the token changes when you replace program
            string myToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJQcm9ncmFtSWQiOjIsIkdyb3VwSWRlbnRpZmllciI6IjFkNzE5NjAyLTk5MmUtNGI5Yy1iNjNjLWU1Y2M3MjlmYTRjNiIsIlVzZXJJZCI6OH0.OCnNwEHkZxA_oI6QikzcSoF5nxdnoRQm_6MJ6uvB_e4";

            //Your ClientId you get after registration, you can see it in your dashboard
            string myClientId = "LPDiCbpal0aUD4nM5mz9Pw";
            HttpResponseMessage res = null;




            var bodyRequest = new
            {
                BrowseNodeId = 1294868011,

                requestAmazonEnvironment = 0//us
            };


            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new System.Uri(apiAddress);

                //Pass the token in the header
                _httpClient.DefaultRequestHeaders.Add("Token", myToken);

                //Pass the clientId in the header
                _httpClient.DefaultRequestHeaders.Add("ClientId", myClientId);
                var myTask = _httpClient.PostAsJsonAsync(apiAddress, bodyRequest);

                res = myTask.Result;
            }

            string jsonResult = null;

            //res.Content.ReadAsStringAsync(); //You can use this string and serialize by yourself
            res.Content.ReadAsStringAsync().ContinueWith(task =>
            {
                jsonResult = task.Result;
            }).Wait();

            //This function print the result after deserialize it. you can see this method in out documentation.
            DisplayResult(jsonResult);
        }

        static void GetEbayEnvironment()
        {
            //The server base api endPoint
            string endPoint = "http://api.ecommerceapi.org/v1/";
            //Function Name
            string functionName = "GetEbayEnvironment";
            string apiAddress = string.Format("{0}{1}", endPoint, functionName);


            //Your Private token, get after registration in your dashboard, the token changes when you replace program
            string myToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJQcm9ncmFtSWQiOjIsIkdyb3VwSWRlbnRpZmllciI6IjFkNzE5NjAyLTk5MmUtNGI5Yy1iNjNjLWU1Y2M3MjlmYTRjNiIsIlVzZXJJZCI6OH0.OCnNwEHkZxA_oI6QikzcSoF5nxdnoRQm_6MJ6uvB_e4";

            //Your ClientId you get after registration, you can see it in your dashboard
            string myClientId = "LPDiCbpal0aUD4nM5mz9Pw";
            HttpResponseMessage res = null;


            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new System.Uri(apiAddress);

                //Pass the token in the header
                _httpClient.DefaultRequestHeaders.Add("Token", myToken);

                //Pass the clientId in the header
                _httpClient.DefaultRequestHeaders.Add("ClientId", myClientId);
                var myTask = _httpClient.PostAsync(apiAddress, null);//AsJsonAsync(apiAddress,null);

                res = myTask.Result;
            }

            string jsonResult = null;

            //res.Content.ReadAsStringAsync(); //You can use this string and serialize by yourself
            res.Content.ReadAsStringAsync().ContinueWith(task =>
            {
                jsonResult = task.Result;
            }).Wait();

            dynamic objectResult = JsonConvert.DeserializeObject(jsonResult) as dynamic;//Declare dynamic object

            //indicate whether the request success or not, allways return a value
            bool? isSuccess = objectResult.responseMessage.success;


            var returnMessages = (objectResult.responseMessage.message as JArray).ToList();

            if (!isSuccess.Value)
            {
                foreach (var errorMsg in returnMessages)
                {
                    Console.WriteLine("Error: {0}", errorMsg);
                }
            }
            else
            {
                Console.WriteLine("Result:");

                //objectResult.resultCategories - This list contain the result categories response
                if (objectResult.environments != null)
                {
                    foreach (dynamic resultEnv in objectResult.environments)
                    {
                        //resultCategory.id - This field will contain the categoryId\Node in the target platform that pass in the request.
                        long? id = resultEnv.id;
                        //resultCategory.id - This field will contain the category Name\Node Name in the target platform that pass in the request.
                        string name = resultEnv.name;

                        Console.WriteLine("{0} - {1}", id, name);
                    }
                }
            }

        }

        static void GetAmazonEnvironment()
        {
            //The server base api endPoint
            string endPoint = "http://api.ecommerceapi.org/v1/";
            //Function Name
            string functionName = "GetAmazonEnvironment";
            string apiAddress = string.Format("{0}{1}", endPoint, functionName);


            //Your Private token, get after registration in your dashboard, the token changes when you replace program
            string myToken = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJQcm9ncmFtSWQiOjIsIkdyb3VwSWRlbnRpZmllciI6IjFkNzE5NjAyLTk5MmUtNGI5Yy1iNjNjLWU1Y2M3MjlmYTRjNiIsIlVzZXJJZCI6OH0.OCnNwEHkZxA_oI6QikzcSoF5nxdnoRQm_6MJ6uvB_e4";

            //Your ClientId you get after registration, you can see it in your dashboard
            string myClientId = "LPDiCbpal0aUD4nM5mz9Pw";
            HttpResponseMessage res = null;


            using (HttpClient _httpClient = new HttpClient())
            {
                _httpClient.BaseAddress = new System.Uri(apiAddress);

                //Pass the token in the header
                _httpClient.DefaultRequestHeaders.Add("Token", myToken);

                //Pass the clientId in the header
                _httpClient.DefaultRequestHeaders.Add("ClientId", myClientId);
                var myTask = _httpClient.PostAsync(apiAddress, null);//AsJsonAsync(apiAddress,null);

                res = myTask.Result;
            }

            string jsonResult = null;

            //res.Content.ReadAsStringAsync(); //You can use this string and serialize by yourself
            res.Content.ReadAsStringAsync().ContinueWith(task =>
            {
                jsonResult = task.Result;
            }).Wait();

            dynamic objectResult = JsonConvert.DeserializeObject(jsonResult) as dynamic;//Declare dynamic object

            //indicate whether the request success or not, allways return a value
            bool? isSuccess = objectResult.responseMessage.success;


            var returnMessages = (objectResult.responseMessage.message as JArray).ToList();

            if (!isSuccess.Value)
            {
                foreach (var errorMsg in returnMessages)
                {
                    Console.WriteLine("Error: {0}", errorMsg);
                }
            }
            else
            {
                Console.WriteLine("Result:");

                //objectResult.resultCategories - This list contain the result categories response
                if (objectResult.environments != null)
                {
                    foreach (dynamic resultEnv in objectResult.environments)
                    {
                        //resultCategory.id - This field will contain the categoryId\Node in the target platform that pass in the request.
                        long? id = resultEnv.id;
                        //resultCategory.id - This field will contain the category Name\Node Name in the target platform that pass in the request.
                        string name = resultEnv.name;

                        Console.WriteLine("{0} - {1}", id, name);
                    }
                }
            }

        }

        public static void DisplayResult(string jsonResult)
        {
            dynamic objectResult = JsonConvert.DeserializeObject(jsonResult) as dynamic;//Declare dynamic object

            //indicate whether the request success or not, allways return a value
            bool? isSuccess = objectResult.responseMessage.success;

            //id is Success flag contain "false"-value the field below will contain why the request failed
            //this field can contain value even the request success, the field will contain warning.
            var returnMessages = (objectResult.responseMessage.message as JArray).ToList();

            if (!isSuccess.Value)
            {
                foreach (var errorMsg in returnMessages)
                {
                    Console.WriteLine("Error: {0}", errorMsg);
                }
            }
            else
            {
                Console.WriteLine("Result:");

                //objectResult.resultCategories - This list contain the result categories response
                if (objectResult.resultCategories != null)
                {
                    foreach (dynamic resultCategory in objectResult.resultCategories)
                    {
                        //resultCategory.id - This field will contain the categoryId\Node in the target platform that pass in the request.
                        long? categoryId = resultCategory.id;
                        //resultCategory.id - This field will contain the category Name\Node Name in the target platform that pass in the request.
                        string categoryName = resultCategory.name;

                        Console.WriteLine("{0} - {1}", categoryId, categoryName);
                    }
                }
            }
        }
    }
}
