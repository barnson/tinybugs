﻿namespace RobMensching.TinyBugs.Models
{
    using System;
    using System.Collections.Generic;
    using ServiceStack.DataAnnotations;

    public class CompleteIssue
    {
        [BelongTo(typeof(Issue))]
        public int Id { get; set; }

        [BelongTo(typeof(User))]
        public string AssignedToUserEmail { get; set; }

        [BelongTo(typeof(User))]
        public string AssignedToUserName { get; set; }

        [BelongTo(typeof(User))]
        public string CreatedByUserEmail { get; set; }

        [BelongTo(typeof(User))]
        public string CreatedByUserName { get; set; }

        [BelongTo(typeof(Issue))]
        public DateTime CreatedAt { get; set; }

        [BelongTo(typeof(Issue))]
        public DateTime UpdatedAt { get; set; }

        [BelongTo(typeof(Issue))]
        public IssueStatus Status { get; set; }

        [BelongTo(typeof(Issue))]
        public string Resolution { get; set; }

        [BelongTo(typeof(Issue))]
        public string Release { get; set; }

        [BelongTo(typeof(Issue))]
        public string Area { get; set; }

        //[BelongTo(typeof(Issue))]
        //public List<string> Tags { get; private set; }

        [BelongTo(typeof(Issue))]
        public string Text { get; set; }

        [BelongTo(typeof(Issue))]
        public string TextRendered { get; set; }

        [BelongTo(typeof(Issue))]
        public string Title { get; set; }

        [BelongTo(typeof(Issue))]
        public IssueType Type { get; set; }

        [BelongTo(typeof(Issue))]
        public bool Private { get; set; }

        [BelongTo(typeof(Issue))]
        public int Votes { get; set; }

        public string Location { get; set; }

        public List<CompleteIssueComment> Comments { get; set; }
    }
}
