namespace C_WebApiTraining.Models
{
    public class Character
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public RpgClass Class { get; set; } = RpgClass.Knight;
        public bool IsDeleted { get; set; } = false;
        public DateTime DateCreated { get; set; }

        public User? User { get; set; }
    }
}
