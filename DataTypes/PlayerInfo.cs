namespace DataTypes
{
    public class PlayerInfo
    {
        public int PlayerID { get; set; }
        public string Name { get; set; }
        public UInt16? BirthYear { get; set; }

        public PlayerInfo() { Name = "NA"; }

        public PlayerInfo(int playerID, string name, int? birthYear)
        {
            PlayerID = playerID;
            Name = name;
            BirthYear = birthYear > DateTime.Now.Year || birthYear < 1940 ? null : (UInt16)birthYear;
        }

        public override string ToString()
        {
            return $"Player: {PlayerID}, {Name}, {BirthYear}";
        }
    }
}
