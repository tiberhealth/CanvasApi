using System;
namespace CanvasApi.Client.Assignments.Models
{
    public interface IScoreStatistic
    {
        /// <summary>
        /// Min score
        /// </summary>
        decimal? Min { get; }

        /// <summary>
        /// Max score
        /// </summary>
        decimal? Max { get; }

        /// <summary>
        /// Mean score
        /// </summary>
        decimal? Mean { get; }
    }
}
