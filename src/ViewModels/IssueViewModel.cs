﻿namespace RobMensching.TinyBugs.ViewModels
{
    using System;
    using System.Collections.Generic;
    using RobMensching.TinyBugs.Models;
    using RobMensching.TinyBugs.Services;
    using ServiceStack.DataAnnotations;

    public class IssueViewModel
    {
        [BelongTo(typeof(Issue))]
        public int Id { get; set; }

        [BelongTo(typeof(Issue))]
        public long AssignedToUserId { get; set; }

        [BelongTo(typeof(User))]
        public string AssignedToUserEmail { get; set; }

        [BelongTo(typeof(User))]
        public string AssignedToUserName { get; set; }

        [BelongTo(typeof(Issue))]
        public long CreatedByUserId { get; set; }

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
        public string Title { get; set; }

        [BelongTo(typeof(Issue))]
        public IssueType Type { get; set; }

        [BelongTo(typeof(Issue))]
        public bool Private { get; set; }

        [BelongTo(typeof(Issue))]
        public int Votes { get; set; }

        public string Location { get; set; }

        public bool CouldTriage { get { return this.Status != IssueStatus.Untriaged; } }

        public string AssignedToUserUrl { get { return ConfigService.AppPath + "user/" + this.AssignedToUserId; } }

        public string CreatedByUserUrl { get { return ConfigService.AppPath + "user/" + this.CreatedByUserId; } }

        public RelativeDateViewModel CreatedRelative { get { return new RelativeDateViewModel(this.CreatedAt); } }

        public RelativeDateViewModel UpdatedRelative { get { return new RelativeDateViewModel(this.UpdatedAt); } }

        public BreadcrumbsViewModel Breadcrumbs { get; set; }

        public List<OptionViewModel> Areas { get; set; }

        public List<OptionViewModel> Releases { get; set; }

        public List<OptionViewModel> Types { get; set; }

        public List<IssueCommentViewModel> Comments { get; set; }

        public string TextRendered
        {
            get
            {
                try
                {
                    return new MarkdownDeep.Markdown() { NoFollowLinks = true, ExtraMode = true, SafeMode = true }.Transform(this.Text);
                }
                catch (Exception)
                {
                    return "<p>This issue cannot be rendered to Markdown. Consider simplifying the text of the isssue.</p>";
                }
            }
        }
    }
}
