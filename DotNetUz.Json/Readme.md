You can use DotNetUz.Json such as following:
we created for you extension method

// get request + async
var client = new HttpClient();
Course course = client.GetJson<Course>("api");

// post request + async
var client = new HttpClient();
Course course = client.PostJson<Course>("api", content);

// deserializing
string json = "somejson";
Course course = json.JsonAs<Course>();

// serializing
Course course = new Course() { };
string json = course.AsJson();

site: https://dot-net.uz
telegram channel: https://t.me/uz_dotnet
telegram group chat: https://t.me/uz_dotnet_chat
