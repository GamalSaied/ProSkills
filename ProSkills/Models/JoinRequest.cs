using System;

namespace ProSkills.Models.ClientSide
{
    public class JoinRequest
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int TraineeId { get; set; }
        public string PaymentProofPath { get; set; }
        public JoinRequestStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

        // Navigation properties
        public Course Course { get; set; }
        public Trainee Trainee { get; set; }
    }

    public enum JoinRequestStatus
    {
        Pending,
        Approved,
        Rejected
    }
}
