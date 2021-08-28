using System;
namespace UkrainianN.Common.ViewModels.Users.V1
{
    public class UserShortViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
    }
}