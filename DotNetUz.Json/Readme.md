<h4>You can use DotNetUz.Json such as following:
we created for you extension method </h4>


```csharp
// get request + async <br/>
var client = new HttpClient();
Course course = client.GetJson<Course>("api");

// post request + async <br/>
var client = new HttpClient();
Course course = client.PostJson<Course>("api", content);

// deserializing <br/>
string json = "somejson";
Course course = json.JsonAs<Course>();

// serializing <br/>
Course course = new Course() { };
string json = course.AsJson();
```

Site: https://dot-net.uz <br/>
Telegram channel: https://t.me/uz_dotnet <br/>
Telegram group chat: https://t.me/uz_dotnet_chat <br/>
