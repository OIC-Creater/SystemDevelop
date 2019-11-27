using LogAdapter;
using NLog;
using ObjectDatabase;
using SystemDevelop.DataModels;
using Logger = NLog.Logger;

/*namespace SystemDevelop
{
    class DatabaseInstance
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public static readonly ObjectDatabase.ObjectDatabase Database;

        public static readonly DataTable<Product> ProductTable;
        public static readonly DataTable<Shop> ShopTable;
        public static readonly DataTable<Status> StatusTable;
        public static readonly DataTable<Department> DepartmentTable;
        public static readonly DataTable<Order> OrderTable;
        public static readonly DataTable<Ordering> OrderingTable;
        public static readonly DataTable<Stock> StockTable;

        static DatabaseInstance()
        {
            Database = new ObjectDatabase.ObjectDatabase("db.accdb", logCallback: OnLog);
            ProductTable = new DataTable<Product>("商品");
            ManufacturerTable = new DataTable<Manufacturer>("メーカー");
            DepartmentTable = new DataTable<Department>("部署");
            EmployeeTable = new DataTable<Employee>("社員");
            OrderTable = new DataTable<Order>("受注");
            OrderingTable = new DataTable<Ordering>("発注");
            StockTable = new DataTable<Stock>("在庫");
            Database.AddTable(ManufacturerTable);
            Database.AddTable(ProductTable);
            Database.AddTable(DepartmentTable);
            Database.AddTable(EmployeeTable);
            Database.AddTable(OrderingTable);
            Database.AddTable(OrderTable);
            Database.AddTable(StockTable);

            ProductTable.Union(ManufacturerTable);
            EmployeeTable.Union(DepartmentTable);
            OrderTable.Union(EmployeeTable, "EmployeeId");
            OrderTable.Union(ProductTable, "ProductId");
            OrderingTable.Union(ProductTable, "ProductId");
            OrderingTable.Union(EmployeeTable, "EmployeeId");
            StockTable.Union(ProductTable);
        }

        private static void OnLog(ILogMessage msg)
        {
            _logger.Info(msg.Data);
        }
    }
}*/
