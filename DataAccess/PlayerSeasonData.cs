namespace DataTypes
{
    public class PlayerSeasonData
    {
        public Int16 Season { get; set; }
        public int PlayerID { get; set; }
        public int? Age { get; set; }
        public int? YearsExperience { get; set; }
        public string? League { get; set; }
        public string? Team { get; set; }
        public string? Position { get; set; }
        public Int16? Games { get; set; }
        public float? PointsPerGame { get; set; }
        public float? AssistsPerGame { get; set; }
        public float? BlocksPerGame { get; set; }
        public float? ReboundsPerGame { get; set; }
        public float? EffectiveFGPercentage { get; set; }
    }
}
