using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetUz.Json
{
    public static class JsonConverter
    {
        public static TSource JsonAs<TSource>(this string json)
        {
            return JsonConvert.DeserializeObject<TSource>(json);
        }
        public static string AsJson(this object ob)
        {
            return JsonConvert.SerializeObject(ob);
        }
    }
}
