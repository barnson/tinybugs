﻿namespace RobMensching.TinyBugs.ViewModels
{
    using System.Collections.Generic;
    using RobMensching.TinyBugs.Models;

    public class RootViewModel
    {
        public RootViewModel()
        {
        }

        public List<CompleteIssue> Issues { get; set; }

        public Pagination Page { get; set; }
    }
}