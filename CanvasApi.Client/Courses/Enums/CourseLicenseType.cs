using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Courses.Enums
{
    public enum CourseLicenseType
    {
        /// <summary>
        /// 'private' (Private Copyrighted)
        /// </summary>
        [EnumSerializedValue("private")] Private,

        /// <summary>
        /// 'cc_by_nc_nd' (CC Attribution Non-Commercial No Derivatives)
        /// </summary>
        [EnumSerializedValue("cc_by_nc_nd")] NoneCommercialNoDerivatives,

        /// <summary>
        /// 'cc_by_nc_sa' (CC Attribution Non-Commercial Share Alike)
        /// </summary>
        [EnumSerializedValue("cc_by_nc_sa")] CcAttributionNonCommercialShareAlike,

        /// <summary>
        /// 'cc_by_nc' (CC Attribution Non-Commercial)
        /// </summary>
        [EnumSerializedValue("cc_by_nc")] CcAttributionNonCommercial,

        /// <summary>
        /// 'cc_by_nd' (CC Attribution No Derivatives)
        /// </summary>
        [EnumSerializedValue("cc_by_nd")] CcAttributionNoDerivatives,

        /// <summary>
        /// 'cc_by_sa' (CC Attribution Share Alike)
        /// </summary>
        [EnumSerializedValue("cc_by_sa")] CcAttributionShareAlike,

        /// <summary>
        /// 'cc_by' (CC Attribution)
        /// </summary>
        [EnumSerializedValue("cc_by")] CcAttribution
    }
}
