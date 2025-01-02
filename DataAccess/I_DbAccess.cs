using DataTypes;

namespace DataAccess
{
    public interface I_DbAccess
    {
        List<PlayerInfo> GetPlayerInfo(uint count = 0);
    }
}