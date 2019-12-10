using System.Data.OleDb;

namespace SystemDevelop.Interface
{
    interface IDatabese
    {
        OleDbConnection OleDb { set; }
        void Update();
        void Add();
        void Get();
    }
}
