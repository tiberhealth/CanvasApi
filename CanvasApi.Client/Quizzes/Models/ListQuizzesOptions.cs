using System;
using System.Collections.Generic;
using System.Text;

namespace CanvasApi.Client.Quizzes.Models
{
    internal class ListQuizzesOptions : IListQuizzesOptions
    {
        public string SearchTerm { get; set; }
    }
}
