namespace Hospital.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly date { get; set; }
        public TimeOnly time { get; set; }

        public int doctorId { get; set; }
        public Doctor doctor { get; set; }
    }
}
