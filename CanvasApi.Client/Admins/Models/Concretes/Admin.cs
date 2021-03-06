﻿using CanvasApi.Client.Admins.Enums;
using CanvasApi.Client.Roles.Models;
using CanvasApi.Client.Roles.Models.Concrete;
using CanvasApi.Client.Users.Models;
using CanvasApi.Client.Users.Models.Concrete;

namespace CanvasApi.Client.Admins.Models
{
    internal class Admin : IAdmin
    {
        public long Id { get; set; }

        public string Role { get; set; }

        public User User { get; set; }
        IUser IAdmin.User => User;

        public AdminListWorkflowState WorkflowState { get; set; }
    }
}
