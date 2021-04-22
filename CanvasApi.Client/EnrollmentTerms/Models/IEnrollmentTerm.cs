using System;
namespace CanvasApi.Client.EnrollmentTerms.Models
{
    public interface IEnrollmentTerm: IEnrollmentDates
    {
        /// <summary>
        /// The unique identifier for the enrollment term.
        /// </summary>
        long Id { get; }

        /// <summary>
        ///  The SIS id of the term. Only included if the user has permission to view SIS
        /// information.
        /// </summary>
        string SisTermId { get; }

        /// <summary>
        /// the unique identifier for the SIS import. This field is only included if the
        /// user has permission to manage SIS information.
        /// </summary>
        long? SisImportId { get; }

        /// <summary>
        /// The name of the term.
        /// </summary>
        string Name { get; }

        IEnrollmentOverrides Overrides { get; }
    }
}
