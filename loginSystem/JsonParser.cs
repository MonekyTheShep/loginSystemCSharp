using Newtonsoft.Json;
namespace loginSystem
{
class JsonParser
  {
    public dynamic data;

    /// <summary>pass json data and stuff.</summary>
    /// <param name="data">data</param>
    public JsonParser(dynamic data)
    {
        this.data = data;
    }


    // currently deserialising through functions doesnt work dynamically
    public dynamic deserializeJson()
    {
        return JsonConvert.DeserializeObject<dynamic>(data);
    }

    public dynamic serializeJson()
    {
        return JsonConvert.SerializeObject(data);
    }
  }
}

