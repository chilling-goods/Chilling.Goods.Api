using System.Runtime.Serialization;

namespace Chilling.Platform.Redis.Exceptions;

[Serializable]
public class RedisKeyUndefinedException : Exception
{
    private static string _message = @"Указанный ключ не найден(key={0})";

    public RedisKeyUndefinedException(string key)
        :base(string.Format(_message, key))
    {
    }
    
    public RedisKeyUndefinedException(SerializationInfo info, StreamingContext context):base(info, context)
    {
    }
}