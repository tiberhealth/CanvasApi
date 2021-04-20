using System;
using System.ComponentModel;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.EnrollmentTerms.Enums
{
    [Multipart(EnumAsString = true)]
    public enum EnrollmentTermIncludes
    {
        [EnumSerializedValue("overrides")] Overrides
    }
}
