namespace CanvasApi.Client.Accounts.Models;

public class TermsOfService
{
    /// <summary>
    /// Terms Of Service id
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    ///The given type for the Terms of Service 
    /// </summary>
    public string TermsType { get; set; }

    /// <summary>
    /// Boolean dictating if the user must accept Terms of Service 
    /// </summary>
    public bool? Passive { get; set; }

    /// <summary>
    /// The id of the root account that owns the Terms of Service 
    /// </summary>
    public int? AccountId { get; set; }

    /// <summary>
    /// Content of the Terms of Service 
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// The type of self registration allowed 
    /// </summary>
    public string SelfRegistrationTypeRaw { get; set; }

    [JsonIgnore]
    public SelfRegistrationTypes? SelfRegistrationType => Enum.TryParse<SelfRegistrationTypes>(this.SelfRegistrationTypeRaw, out var value) ? value : null;
}