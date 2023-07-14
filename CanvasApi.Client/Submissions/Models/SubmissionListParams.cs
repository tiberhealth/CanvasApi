using System;
using System.Collections.Generic;
using CanvasApi.Client.Submissions.Enums;

namespace CanvasApi.Client.Submissions.Models
{
    internal class SubmissionListParams : ISubmissionListParams
    {
        public IEnumerable<string> StudentIds { get; set; }
        public IEnumerable<long> AssignmentIds { get; set; }

        public bool? Grouped { get; set; }
        bool? ISubmissionListParams.Grouped
        {
            get => Grouped;
            set => Grouped = value;
        }

        public bool? PostToSis { get; set; }
        public DateTime? SubmittedSince { get; set; }
        public DateTime? GradedSince { get; set; }
        public long? GradingPeriodId { get; set; }
        public SubmissionWorkFlowStates? WorkFlowState { get; set; }
        public SubmissionEnrollmentStates? EnrollmentState { get; set; }
        public bool? StatedBasedOnDate { get; set; }
        public SubmissionListOrder? Order { get; set; }
        public SubmissionOrderDirection? OrderDirection { get; set; }
        public IEnumerable<SubmissionListInclude> Include { get; set; }
    }
}
