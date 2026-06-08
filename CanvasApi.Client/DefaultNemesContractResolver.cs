namespace CanvasApi.Client;

/// <summary>
/// Names resolution for Newtonsoft to follow Canvas naming structure. 
/// </summary>
public class DefaultNemesContractResolver: DefaultContractResolver
{
    private JsonPropertyAttribute JsonProperty { get; set; }
    protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
    {
        this.JsonProperty = member.GetCustomAttribute<JsonPropertyAttribute>();
        return base.CreateProperty(member, memberSerialization);
    }

    protected override string ResolvePropertyName(string propertyName) {
        var jsonPropertyName = this.JsonProperty is null ? propertyName.ToUnderscore() : base.ResolvePropertyName(propertyName);
        return jsonPropertyName;
    }
}