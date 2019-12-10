using System.Data;
using LogAdapter;
using NLog;
using ObjectDatabase;
using SystemDevelop.DataModels;
using Logger = NLog.Logger;

namespace SystemDevelop
{
    class DatabaseInstance
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public static readonly ObjectDatabase.ObjectDatabase Database;

        public static readonly DataTable<Product> ProductTable;
        public static readonly DataTable<Shop> ShopTable;
        public static readonly DataTable<Status> StatusTable;
        public static readonly DataTable<Affiliation> AffiliationTable;
        public static readonly DataTable<Maker> MakerTable;
        public static readonly DataTable<Pigeon> PigeonTable;
        public static readonly DataTable<Stock> StockTable;
        public static readonly DataTable<ReciveOrder> ReciveOrderTable;
        public static readonly DataTable<SalesOffice> SalesOfficeTable;
        public static readonly DataTable<Employee> EmployeeTable;
        public static readonly DataTable<ReciveOrderDetail> ReciveOrderDetailTable;
        public static readonly DataTable<Issue> IssueTabele;
        public static readonly DataTable<Order> OrderTable;
        public static readonly DataTable<OrderDetail> OrderDetailTable;
        public static readonly DataTable<Setting> SettingTable;
        public static readonly DataTable<Storing> StoringTable;

        static DatabaseInstance()
        {
            Database = new ObjectDatabase.ObjectDatabase("db.accdb", logCallback: OnLog);
            ProductTable = new DataTable<Product>("商品");
            ShopTable= new DataTable<Shop>("ショップ");
            StatusTable = new DataTable<Status>("ステータス");
            AffiliationTable = new DataTable<Affiliation>("所属");
            MakerTable = new DataTable<Maker>("メーカー");
            PigeonTable = new DataTable<Pigeon>("ハト");
            StockTable = new DataTable<Stock>("在庫");
            ReciveOrderTable = new DataTable<ReciveOrder>("受注");
            SalesOfficeTable = new DataTable<SalesOffice>("営業所");
            EmployeeTable = new DataTable<Employee>("社員");
            ReciveOrderDetailTable = new DataTable<ReciveOrderDetail>("受注詳細");
            IssueTabele = new DataTable<Issue>("出庫");
            OrderTable = new DataTable<Order>("発注");
            OrderDetailTable = new DataTable<OrderDetail>("発注詳細");
            SettingTable = new DataTable<Setting>("設定");
            StoringTable = new DataTable<Storing>("入庫");
            
            
            Database.AddTable(ProductTable);
            Database.AddTable(ShopTable);
            Database.AddTable(StatusTable);
            Database.AddTable(AffiliationTable);
            Database.AddTable(MakerTable);
            Database.AddTable(PigeonTable);
            Database.AddTable(StockTable);
            Database.AddTable(ReciveOrderTable);
            Database.AddTable(SalesOfficeTable);
            Database.AddTable(EmployeeTable);
            Database.AddTable(ReciveOrderDetailTable);
            Database.AddTable(IssueTabele);
            Database.AddTable(OrderTable);
            Database.AddTable(OrderDetailTable);
            Database.AddTable(SettingTable);
            Database.AddTable(StoringTable);
            
            ProductTable.Union(MakerTable,nameof(Maker.MakerId));
            //ProductTable.Union(SettingTable,nameof(Setting.SettingId));
            PigeonTable.Union(StatusTable,nameof(Status.StatusID));
            StockTable.Union(ProductTable);
            ReciveOrderTable.Union(EmployeeTable,nameof(Employee.EmployeeID));
            ReciveOrderTable.Union(SalesOfficeTable,nameof(SalesOffice.SalesOfficeID));
            ReciveOrderTable.Union(ShopTable,nameof(Shop.ShopID));
            EmployeeTable.Union(AffiliationTable);
            ReciveOrderDetailTable.Union(ReciveOrderTable,nameof(ReciveOrder.ReciveOrderID));
            ReciveOrderDetailTable.Union(ProductTable,nameof(Product.ProductID));
            IssueTabele.Union(ReciveOrderDetailTable,nameof(ReciveOrderDetail.ReciveOrderDetailID));
            IssueTabele.Union(EmployeeTable,nameof(Employee.EmployeeID));
        }

        private static void OnLog(ILogMessage msg)
        {
            _logger.Info(msg.Data);
        }
    }
}
