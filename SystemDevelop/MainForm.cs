﻿using System;
using System.Windows.Forms;
using System.Management;
using SystemDevelop.DataModels;
using SystemDevelop.Model;
using SystemDevelop.Model.DB;
using System.Linq;

namespace SystemDevelop
{
    public partial class MainForm : Form
    {
        private bool logined = false;
        private Employee employee;

        public MainForm()
        {
            InitializeComponent();

            loginControl.loginButton.Click += LoginButtonClick;
            loginControl.idTextBox.KeyDown += OnEnter;
            loginControl.passTextBox.KeyDown += OnEnter;
            headerControl.logoutButton.Click += LogoutButtonClick;
            headerControl.closeButton.Click += CloseButton_Click1;
            salesMenuBar.reciveAddButton.Click += ReciveButtonClick;
            salesMenuBar.reciveAddButton.Click += ReciveButtonClick;
            salesMenuBar.reciveListButton.Click += ReciveDetail_Click;
            salesMenuBar.pigeonButton.Click += Pigeon_Click;
            warehouseMenuBar.reciveListButton.Click += ReciveListButtonClick;
            warehouseMenuBar.orderListButton.Click += OrderAnButtonClick;
            warehouseMenuBar.stockListButton.Click += StockButtonClick;
            mainOfficeManuBar.employeeListButton.Click += EmployeeList_Click;
            mainOfficeManuBar.businessOfficeListButton.Click += salesOfficeList_Click;
            mainOfficeManuBar.shopListButton.Click += ShopList_Click;
            mainOfficeManuBar.manufacturerListButton.Click += ManufacturerList_Click1;
            mainOfficeManuBar.productListButton.Click += ProductListButton_Click;
            newProduct.productButton.Click += SettingButton_Click;
            settingConfi.Yes.Click += Yes_Click;
            settingConfi.No.Click += No_Click;
            loginControl.closeButton.Click += CloseButton_Click;
            empList.empDetailButton.Click += EmpDetailButton_Click;
            empList.empListAddButton.Click += EmpListAddButton_Click;
            empDetails.empCancelButton.Click += EmpCancel_Click;
            empAddControl.empAddButton.Click += EmpAddButton_Click;
            empAddControl.empCancelButton.Click += EmpCancelButton_Click;
            manufactureList.manufDetailButton.Click += ManufDetailButton_Click;
            manufactureDetails.manufCancelButton.Click += ManufCancel_Click;
            manufactureList.manufListAddButton.Click += ManufListAddButton_Click;
            manufactureAddControl.manufactureCancelButton.Click += ManufactureCancelButton_Click;
            shopList.shopDetailButton.Click += ShopDetailButton_Click;
            shopDetails.shopCancelButton.Click += ShopCancelButton_Click;
            shopList.shopListAddButton.Click += ShopListAddButton_Click;
            shopAddControl.shopCancelButton.Click += ShopCancelButton_Click1;
            salesOfficeList.salesOfficeDetailButton.Click += SalesOfficeDetailButton_Click;
            salesOfficeList.salesListAddButton.Click += SalesListAddButton_Click;
            salesOfficeDetails.salesOfficeCancelButton.Click += SalesOfficeCancelButton_Click;
            salesOfficeAddControl.salesCancelButton.Click += SalesCancelButton_Click;
            productList.productDetailButton.Click += ProductDetailButton_Click;
            productList.productListAddButton.Click += ProductListAddButton_Click;
            productDetails.productCancelButton.Click += ProductCancelButton_Click;
            productAddControl.productCancelButton.Click += ProductCancelButton_Click1;
            reciveControl.reciveDetailButton.Click += ReciveDetailButton_Click;
            reciveAddControl.VisibleChanged += ReciveAddControl_VisibleChanged;
            reciveListDetails.reciveCancelButton.Click += ReciveCancelButton_Click;
            reciveAddControl.addButton.Click += addButton_Click;
            pigeonList.pigeonDetailButton.Click += PigeonDetailButton_Click;
            pigeonDetails.pigeonCancelButton.Click += PigeonCancelButton_Click;
            pigeonList.pigeonListAddButton.Click += PigeonListAddButton_Click;
            pigeonAddControl.cancelButton.Click += CancelButton_Click;
            orderList2.orderDetailsButton.Click += OrderDetailsButton_Click;
            orderDetail.orderCancelButton.Click += OrderCancelButton_Click;
            orderList2.orderListAddButton.Click += OrderListAddButton_Click;
            orderAddControl.VisibleChanged += OrderAddControl_VisibleChanged;
            orderAddControl.orderCancelButton.Click += OrderCancelButton_Click1;
            stockList.stockDetailButton.Click += StockDetailButton_Click;
            stockList.stockListAddButton.Click += StockListAddButton_Click;
            stockDetail.stockCancelButton.Click += StockCancelButton_Click;
            stockAddControl.stockCancelButton.Click += StockCancelButton_Click1;
        }

        private void OrderAddControl_VisibleChanged(object sender, EventArgs e)
        {
            orderAddControl.orderId.Text = $"PO{(DatabaseInstance.OrderTable.Count + 1).ToString("00000")}";
            orderAddControl.productComboBox.Items.Clear();
            orderAddControl.productComboBox.Items.AddRange(DatabaseInstance.ProductTable.ToArray().Select(el => el.ProductName).ToArray());
        }

        private void ReciveAddControl_VisibleChanged(object sender, EventArgs e)
        {
            reciveAddControl.pigeonComboBox.Items.Clear();
            reciveAddControl.pigeonComboBox.Items.AddRange(DatabaseInstance.PigeonTable.ToArray().Select(el => el.PigeonName).ToArray());
            reciveAddControl.shopComboBox.Items.Clear();
            reciveAddControl.shopComboBox.Items.AddRange(DatabaseInstance.ShopTable.ToArray().Select(el => el.ShopName).ToArray());
            reciveAddControl.productComboBox.Items.Clear();
            reciveAddControl.productComboBox.Items.AddRange(DatabaseInstance.ProductTable.ToArray().Select(el => el.ProductName).ToArray());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
             DataSource.SetDataSource<ReciveOrderDetail>(reciveControl.reciveGridView, DatabaseInstance.ReciveOrderDetailTable);
        }

        private void StockCancelButton_Click1(object sender, EventArgs e)
        {
            stockAddControl.Visible = false;
            stockList.Visible = true;
            headerLists.Visible = true;
        }

        private void StockCancelButton_Click(object sender, EventArgs e)
        {
            stockDetail.Visible = false;
            stockList.Visible = true;
            headerLists.Visible = true;
        }

        private void OrderCancelButton_Click1(object sender, EventArgs e)
        {
            orderAddControl.Visible = false;
            orderList2.Visible = true;
            headerLists.Visible = true;
        }

        private void ProductCancelButton_Click1(object sender, EventArgs e)
        {
            productAddControl.Visible = false;
            productList.Visible = true;
            headerLists.Visible = true;
        }

        private void SalesCancelButton_Click(object sender, EventArgs e)
        {
            salesOfficeAddControl.Visible = false;
            salesOfficeList.Visible = true;
            headerLists.Visible = true;
        }

        private void ShopCancelButton_Click1(object sender, EventArgs e)
        {
            shopAddControl.Visible = false;
            shopList.Visible = true;
            headerLists.Visible = true;
        }

        private void ManufactureCancelButton_Click(object sender, EventArgs e)
        {
            manufactureAddControl.Visible = false;
            manufactureList.Visible = true;
            headerLists.Visible = true;
        }

        private void EmpCancelButton_Click(object sender, EventArgs e)
        {
            empAddControl.Visible = false;
            empList.Visible = true;
            headerLists.Visible = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            pigeonAddControl.Visible = false;
            pigeonList.Visible = true;
            headerLists.Visible = true;
        }

        private void StockListAddButton_Click(object sender, EventArgs e)
        {
            stockAddControl.Visible = true;
            headerLists.Visible = false;
            stockList.Visible = false;
        }

        private void OrderListAddButton_Click(object sender, EventArgs e)
        {
            orderAddControl.Visible = true;
            headerLists.Visible = false;
            reciveControl.Visible = false;
            orderList2.Visible = false;
            stockList.Visible = false;
        }

        private void ProductListAddButton_Click(object sender, EventArgs e)
        {
            productAddControl.Visible = true;
            headerLists.Visible = false;
            manufactureDetails.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            salesOfficeList.Visible = false;
            productList.Visible = false;
        }

        private void SalesListAddButton_Click(object sender, EventArgs e)
        {
            salesOfficeAddControl.Visible = true;
            headerLists.Visible = false;
            manufactureDetails.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            salesOfficeList.Visible = false;
            productList.Visible = false;
        }

        private void ShopListAddButton_Click(object sender, EventArgs e)
        {
            shopAddControl.Visible = true;
            headerLists.Visible = false;
            manufactureDetails.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            salesOfficeList.Visible = false;
            productList.Visible = false;
        }

        private void ManufListAddButton_Click(object sender, EventArgs e)
        {
            manufactureList.Visible = false;
            manufactureAddControl.Visible = true;
            headerLists.Visible = false;
            manufactureDetails.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            salesOfficeList.Visible = false;
            productList.Visible = false;
        }

        private void PigeonListAddButton_Click(object sender, EventArgs e)
        {
            pigeonAddControl.Visible = true;
            pigeonList.Visible = false;
            headerLists.Visible = false;
            reciveControl.Visible = false;
            reciveAddControl.Visible = false;
        }
        private void EmpAddButton_Click(object sender, EventArgs e)
        {
            empAddControl.Visible = false;
            empList.Visible = true;
            headerLists.Visible = true;
        }

        private void EmpListAddButton_Click(object sender, EventArgs e)
        {
            empAddControl.Visible = true;
            empList.Visible = false;
            headerLists.Visible = false;
        }

        private void StockDetailButton_Click(object sender, EventArgs e)
        {
            stockDetail.Visible = true;
            headerLists.Visible = false;
            stockList.Visible = false;
            reciveControl.Visible = false;
            orderList2.Visible = false;
        }

        private void OrderCancelButton_Click(object sender, EventArgs e)
        {
            orderDetail.Visible = false;
            headerLists.Visible = true;
            orderList2.Visible = true;
        }

        private void OrderDetailsButton_Click(object sender, EventArgs e)
        {
            orderDetail.Visible = true;
            orderList2.Visible = false;
            headerLists.Visible = false;
            reciveControl.Visible = false;
            stockList.Visible = false;
        }

        private void PigeonCancelButton_Click(object sender, EventArgs e)
        {
            pigeonDetails.Visible = false;
            headerLists.Visible = true;
            pigeonList.Visible = true;
        }

        private void PigeonDetailButton_Click(object sender, EventArgs e)
        {
            pigeonDetails.Visible = true;
            pigeonList.Visible = false;
            headerLists.Visible = false;
        }

        private void ReciveCancelButton_Click(object sender, EventArgs e)
        {
            reciveListDetails.Visible = false;
            reciveControl.Visible = true;
            headerLists.Visible = true;
        }

        private void ReciveDetailButton_Click(object sender, EventArgs e)
        {
            reciveListDetails.Visible = true;
            reciveControl.Visible = false;
            headerLists.Visible = false;
            reciveControl.Visible = false;
            reciveAddControl.Visible = false;
            pigeonList.Visible = false;
            orderList.Visible = false;
            warehouseControl.Visible = false;
        }

        private void ProductCancelButton_Click(object sender, EventArgs e)
        {
            productDetails.Visible = false;
            headerLists.Visible = true;
            productList.Visible = true;
        }

        private void ProductDetailButton_Click(object sender, EventArgs e)
        {
            productDetails.Visible = true;
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }
        private void SalesOfficeCancelButton_Click(object sender, EventArgs e)
        {
            salesOfficeDetails.Visible = false;
            headerLists.Visible = true;
            salesOfficeList.Visible = true;
        }

        private void SalesOfficeDetailButton_Click(object sender, EventArgs e)
        {
            salesOfficeDetails.Visible = true;
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }

        private void ShopCancelButton_Click(object sender, EventArgs e)
        {
            shopDetails.Visible = false;
            headerLists.Visible = true;
            shopList.Visible = true;
        }

        private void ShopDetailButton_Click(object sender, EventArgs e)
        {
            shopDetails.Visible = true;
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }

        private void ManufCancel_Click(object sender, EventArgs e)
        {
            manufactureDetails.Visible = false;
            manufactureList.Visible = true;
            headerLists.Visible = true;
        }

        private void ManufDetailButton_Click(object sender, EventArgs e)
        {
            manufactureDetails.Visible = true;
            manufactureAddControl.Visible = false;
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
        }

        private void EmpCancel_Click(object sender, EventArgs e)
        {
            empDetails.Visible = false;
            empList.Visible = true;
            headerLists.Visible = true;
        }

        private void EmpDetailButton_Click(object sender, EventArgs e)
        {
            empDetails.Visible = true;
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
            manufactureAddControl.Visible = false;
            shopAddControl.Visible = false;
            empDetails.SetDetail(empList.GetRowData());
        }

        private void CloseButton_Click1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void No_Click(object sender, EventArgs e)
        {
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            newProduct.Visible = true;
        }
        private void Yes_Click(object sender, EventArgs e)
        {
            headerLists.Visible = false;
            settingConfi.Visible = false;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            orderList2.Visible = false;
            newProduct.Visible = true;
        }
        
        private void SettingButton_Click(object sender, EventArgs e)
        {
            headerLists.Visible = false;
            settingConfi.Visible = true;
            newProduct.Visible = false;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            shopDetails.Visible = false;
        }
        private void ProductListButton_Click(object sender, EventArgs e)
        {
            productList.Visible = true;
            headerLists.Visible = true;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            newProduct.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productDetails.Visible = false;
            reciveListDetails.Visible = false;
            manufactureAddControl.Visible = false;
            shopAddControl.Visible = false;
            salesOfficeAddControl.Visible = false;
            productAddControl.Visible = false;
            empAddControl.Visible = false;
        }

        private void NewProduct_Click(object sender, EventArgs e)
        {
            headerLists.Visible =false;
            newProduct.Visible = true;
            manufactureList.Visible = false;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;

        }

        private void ManufacturerList_Click1(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            manufactureList.Visible = true;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            shopList.Visible = false;
            newProduct.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
            manufactureAddControl.Visible = false;
            shopAddControl.Visible = false;
            salesOfficeAddControl.Visible = false;
            productAddControl.Visible = false;
            empAddControl.Visible = false;
        }

        private void salesOfficeList_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            salesOfficeList.Visible = true;
            empList.Visible = false;
            shopList.Visible = false;
            manufactureList.Visible = false;
            newProduct.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
            manufactureAddControl.Visible = false;
            shopAddControl.Visible = false;
            salesOfficeAddControl.Visible = false;
            productAddControl.Visible = false;
            empAddControl.Visible = false;
        }

        private void ShopList_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            shopList.Visible = true;
            salesOfficeList.Visible = false;
            empList.Visible = false;
            manufactureList.Visible = false;
            newProduct.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
            manufactureAddControl.Visible = false;
            shopAddControl.Visible = false;
            salesOfficeAddControl.Visible = false;
            productAddControl.Visible = false;
            empAddControl.Visible = false;
        }

        private void ManufacturerList_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            salesOfficeList.Visible = true;
            empList.Visible = false;
            shopList.Visible = false;
            manufactureList.Visible = false;
            newProduct.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
            manufactureAddControl.Visible = false;
            shopAddControl.Visible = false;
            salesOfficeAddControl.Visible = false;
            productAddControl.Visible = false;
            empAddControl.Visible = false;
        }

        private void EmployeeList_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            empList.Visible = true;
            salesOfficeList.Visible = false;
            shopList.Visible = false;
            manufactureList.Visible = false;
            newProduct.Visible = false;
            reciveControl.Visible = false;
            empDetails.Visible = false;
            manufactureDetails.Visible = false;
            shopDetails.Visible = false;
            productList.Visible = false;
            productDetails.Visible = false;
            productList.Visible = false;
            reciveListDetails.Visible = false;
            manufactureAddControl.Visible = false;
            shopAddControl.Visible = false;
            salesOfficeAddControl.Visible = false;
            productAddControl.Visible = false;
            empAddControl.Visible =false;
        }
        
        private void StockButtonClick(object sender, EventArgs e)
        {
            orderList2.Visible = false;
            headerLists.Visible = true;
            stockList.Visible = true;
            warehouseControl.Visible = false;
            pigeonList.Visible = false;
            reciveControl.Visible = false;
            orderDetail.Visible = false;
            reciveListDetails.Visible = false;
            orderAddControl.Visible = false;
            stockAddControl.Visible = false;
            stockDetail.Visible = false;
        }
        private void ReciveListButtonClick(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            reciveControl.Visible = true;
            reciveAddControl.Visible = false;
            warehouseControl.Visible = false;
            orderList2.Visible = false;
            stockList.Visible = false;
            orderDetail.Visible = false;
            reciveListDetails.Visible = false;
            orderAddControl.Visible = false;
            stockAddControl.Visible = false;
        }
        private void OrderAnButtonClick(object sender,EventArgs e)
        {
            reciveAddControl.Visible = false;
            headerLists.Visible = true;
            orderList2.Visible = true;
            stockList.Visible = false;
            reciveControl.Visible = false;
            warehouseControl.Visible = false;
            orderDetail.Visible = false;
            reciveListDetails.Visible = false;
            stockDetail.Visible = false;
            orderAddControl.Visible = false;
            stockAddControl.Visible = false;
        }
        private void ReciveDetail_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            reciveControl.Visible = true;
            reciveAddControl.Visible = false;
            pigeonList.Visible = false;
            orderList2.Visible = false;
            warehouseControl.Visible = false;
            reciveListDetails.Visible = false;
            pigeonDetails.Visible = false;
            orderAddControl.Visible = false;
        }
        private void ReciveButtonClick(object sender, EventArgs e)
        {
            headerLists.Visible = false;
            reciveAddControl.Visible = true;
            reciveControl.Visible = false;
            pigeonList.Visible = false;
            orderList2.Visible = false;
            stockList.Visible = false;
            warehouseControl.Visible = false;
            reciveListDetails.Visible = false;
            pigeonDetails.Visible = false;
        }
        private void Pigeon_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            pigeonList.Visible = true;
            reciveAddControl.Visible = false;
            reciveControl.Visible = false;
            orderList2.Visible = false;
            reciveListDetails.Visible = false;
            pigeonDetails.Visible = false;
            pigeonAddControl.Visible = false;
        }
        private void UnDispatched_Click(object sender, EventArgs e)
        {
            headerLists.Visible = true;
            orderList2.Visible = true;
            pigeonList.Visible = false;
            reciveAddControl.Visible = false;
            reciveControl.Visible = false;
            orderAddControl.Visible = false;
        }
        private void OnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
        

        private void LoginButtonClick(object sender, EventArgs e)
        {
            Login();
        }
        
        private void Login()
        {
            Login login = new Login();
            if (login.AuthUser(loginControl.idTextBox.Text, loginControl.passTextBox.Text, out employee))
            {
                headerControl.userLabel.Text += $" {employee.EmployeeName}";
                logined = true;
                headerControl.Visible = true;
                switch (employee.AffiliationId)
                {
                    case "A01":
                        salesMenuBar.Visible = false;
                        loginControl.Visible = false;
                        warehouseMenuBar.Visible = true;
                        mainOfficeManuBar.Visible = false;
                        reciveControl.Visible = true;
                        headerLists.Visible = true;
                        DataSource.SetDataSource<ReciveOrderDetail>(reciveControl.reciveGridView, DatabaseInstance.ReciveOrderDetailTable);
                        DataSource.SetDataSource<Stock>(stockList.stockGridView, DatabaseInstance.StockTable);
                        DataSource.SetDataSource<Order>(orderList2.orderGridView, DatabaseInstance.OrderTable);
                        break;
                    case "A02":
                        salesMenuBar.Visible = true;
                        loginControl.Visible = false;
                        warehouseMenuBar.Visible = false;
                        mainOfficeManuBar.Visible = false;
                        reciveControl.Visible = true;
                        headerLists.Visible = true;
                        DataSource.SetDataSource<ReciveOrderDetail>(reciveControl.reciveGridView, DatabaseInstance.ReciveOrderDetailTable);
                        DataSource.SetDataSource<Pigeon>(pigeonList.pigeonGridView, DatabaseInstance.PigeonTable);
                        break;
                    case "A03":
                        mainOfficeManuBar.Visible = true;
                        salesMenuBar.Visible = false;
                        loginControl.Visible = false;
                        warehouseMenuBar.Visible = false;
                        reciveControl.Visible = false;
                        headerLists.Visible = true;
                        productList.Visible = true;
                        DataSource.SetDataSource<Product>(productList.productGridView, DatabaseInstance.ProductTable);
                        DataSource.SetDataSource<Employee>(empList.empGridView, DatabaseInstance.EmployeeTable);
                        DataSource.SetDataSource<Maker>(manufactureList.manufGridView, DatabaseInstance.MakerTable);
                        DataSource.SetDataSource<Shop>(shopList.shopGridView, DatabaseInstance.ShopTable);
                        DataSource.SetDataSource<SalesOffice>(salesOfficeList.salesOfficeGridView, DatabaseInstance.SalesOfficeTable);
                        break;
                }
            }
        }

        private void LogoutButtonClick(object sender, EventArgs e)
        {
            logined = false;

            Control[] all = Controller.GetAllControls(this);
            foreach (Control c in all)
            {
                foreach (Control con in c.Controls)
                {
                    if (con.GetType().ToString().Contains("TextBox") ||
                       con.GetType().ToString().Contains("ComboBox"))
                        con.Text = "";
                }
                c.Visible = false;
            }
            headerControl.userLabel.Text = "ログイン中：";
            loginControl.Visible = true;
        }

        private void mainOfficeManuBar_Load(object sender, EventArgs e)
        {

        }
    }
}
