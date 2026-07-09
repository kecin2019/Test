HttpClient client = new();
HttpResponseMessage response = await client.GetAsync("http://www.baidu.com");
WriteLine("Baidu's home page has {0:N0} bytes.", response.Content.Headers.ContentLength);