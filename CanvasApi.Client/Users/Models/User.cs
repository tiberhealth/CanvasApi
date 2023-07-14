using CanvasApi.Client.Enrollments.Models;
using System;
using System.Collections.Generic;

namespace CanvasApi.Client.Users.Models;

internal class User : IUser
{
    public long Id { get; set; }
    public string Uuid { get; set; }
    public string Name { get; set; }
    public string SortableName { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string ShortName { get; set; }
    public string SisUserId { get; set; }
    public long? SisImportId { get; set; }
    public string IntegrationId { get; set; }
    public string LoginId { get; set; }
    public string AvatarUrl { get; set; }
    public string AvatarState { get; set; }
    public IEnumerable<IEnrollment> Enrollments { get; set; }
    public string Email { get; set; }
    public string Locale { get; set; }
    public DateTime? LastLogin { get; set; }
    public string TimeZone { get; set; }
    public string Bio { get; set; }
}
