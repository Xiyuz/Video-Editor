using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

/// <summary>
/// JsonHelper 
/// </summary>
public class JsonHelper
{
    /// <summary>
    /// Converting into JSON format
    /// </summary>
    /// <param name="o">Object</param>
    /// <returns>json string</returns>
    public static string SerializeObject(object o)
    {
        string json = JsonConvert.SerializeObject(o);
        return json;
    }

    /// <summary>
    /// converting back to object
    /// </summary>
    /// <typeparam name="T">object type</typeparam>
    /// <param name="json">json string(eg.{"ID":"112","Name":"Anna"})</param>
    /// <returns>The actual object</returns>
    public static T DeserializeJsonToObject<T>(string json) where T : class
    {
        JsonSerializer serializer = new JsonSerializer();
        StringReader sr = new StringReader(json);
        object o = serializer.Deserialize(new JsonTextReader(sr), typeof(T));
        T t = o as T;
        return t;
    }

    /// <summary>
    /// Converting back to object list
    /// </summary>
    /// <typeparam name="T">object type</typeparam>
    /// <param name="json">json string(eg.[{"ID":"112","Name":"Anna"}])</param>
    /// <returns>list of object</returns>
    public static List<T> DeserializeJsonToList<T>(string json) where T : class
    {
        JsonSerializer serializer = new JsonSerializer();
        StringReader sr = new StringReader(json);
        object o = serializer.Deserialize(new JsonTextReader(sr), typeof(List<T>));
        List<T> list = o as List<T>;
        return list;
    }

    /// <summary>
    /// Converting back to anonymous object
    /// </summary>
    /// <typeparam name="T">anonymous object type</typeparam>
    /// <param name="json">json string</param>
    /// <param name="anonymousTypeObject">anonymous object</param>
    /// <returns>anonymous object</returns>
    public static T DeserializeAnonymousType<T>(string json, T anonymousTypeObject)
    {
        T t = JsonConvert.DeserializeAnonymousType(json, anonymousTypeObject);
        return t;
    }
}