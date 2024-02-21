using TimeManager.DAL.Enums;

namespace TimeManager.BLL.DTO.Consultation
{
    public record ConsultationExtendedDataDto
    {
        public int Id { get; set; }
        public PriorityLevel Priority { get; set; }
        public ConsultationCategory Category { get; set; }
        public DateTime ConsultationDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public int SubjectId { get; set; }
    }
}
