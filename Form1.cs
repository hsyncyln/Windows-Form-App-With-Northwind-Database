using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthWind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbbxTables.Items.Add("Categories");
            cmbbxTables.Items.Add("CustomerCustomerDemo");
            cmbbxTables.Items.Add("CustomerDemographics");
            cmbbxTables.Items.Add("Customers");
            cmbbxTables.Items.Add("Employees");
            cmbbxTables.Items.Add("EmployeeTerritories");
            cmbbxTables.Items.Add("OrderDetails");
            cmbbxTables.Items.Add("Orders");
            cmbbxTables.Items.Add("Products");
            cmbbxTables.Items.Add("Region");
            cmbbxTables.Items.Add("Shippers");
            cmbbxTables.Items.Add("Suppliers");
            cmbbxTables.Items.Add("Territories");

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstbxRows.Items.Clear();
            lblDetail1.Visible = false;
            lblDetail2.Visible = false;
            lblDetail3.Visible = false;
            lblDetail4.Visible = false;
            rchbxDetail1.Visible = false;
            rchbxDetail2.Visible = false;
            rchbxDetail3.Visible = false;
            rchbxDetail4.Visible = false;

            SqlConnection cnn = new SqlConnection(@"server=.\MSSQLSERVER01;database=Northwnd;trusted_connection=true");

            cnn.Open();

            if (cmbbxTables.SelectedItem.ToString() == "Suppliers")
            {
                SqlCommand cmd = new SqlCommand("select SupplierID,CompanyName,ContactName,Phone from Suppliers", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Suppliers supp = new Suppliers(rdr.GetInt32(0), rdr.IsDBNull(1) ? "" : rdr.GetString(1),
                        rdr.IsDBNull(2) ? "" : rdr.GetString(2), rdr.IsDBNull(3) ? "" : rdr.GetString(3));

                    lstbxRows.Items.Add(supp);
                }
                rdr.Close();
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Orders")
            {
                SqlCommand cmd = new SqlCommand("select OrderID,CustomerID,EmployeeID,ShipName from Orders", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Orders order = new Orders(rdr.GetInt32(0), rdr.IsDBNull(1) ? "" : rdr.GetString(1), rdr.GetInt32(2), rdr.IsDBNull(3) ? "" : rdr.GetString(3));

                    lstbxRows.Items.Add(order);
                }
                rdr.Close();
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Categories")
            {
                SqlCommand cmd = new SqlCommand("select CategoryID,CategoryName from Categories", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Categories category = new Categories(rdr.GetInt32(0), rdr.IsDBNull(1) ? "" : rdr.GetString(1));

                    lstbxRows.Items.Add(category);
                }
                rdr.Close();
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Customers")
            {
                SqlCommand cmd = new SqlCommand("select CustomerID,CompanyName,Phone from Customers", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Customers customer = new Customers(rdr.IsDBNull(0) ? "" : rdr.GetString(0), rdr.IsDBNull(1) ? "" : rdr.GetString(1), rdr.IsDBNull(2) ? "" : rdr.GetString(2));

                    lstbxRows.Items.Add(customer);
                }
                rdr.Close();
            }
            else if (cmbbxTables.SelectedItem.ToString() == "CustomerCustomerDemo")
            {
                SqlCommand cmd = new SqlCommand("select CustomerID,CustomerTypeID from CustomerCustomerDemo", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CustomerCustomerDemo cust = new CustomerCustomerDemo(rdr.IsDBNull(0) ? "" : rdr.GetString(0), rdr.IsDBNull(1) ? "" : rdr.GetString(1));

                    lstbxRows.Items.Add(cust);
                }
                rdr.Close();
            }
            else if (cmbbxTables.SelectedItem.ToString() == "CustomerDemographics")
            {
                SqlCommand cmd = new SqlCommand("select CustomerTypeID,CustomerDesc from CustomerDemographics", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    CustomerDemographics cd = new CustomerDemographics(rdr.IsDBNull(0) ? "" : rdr.GetString(0), rdr.IsDBNull(1) ? "" : rdr.GetString(1));

                    lstbxRows.Items.Add(cd);
                }
                rdr.Close();
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Employees")
            {
                SqlCommand cmd = new SqlCommand("select EmployeeID,FirstName,LastName,BirthDate from Employees", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Employees emp=new Employees(rdr.GetInt32(0),rdr.IsDBNull(1) ? "" : rdr.GetString(1), rdr.IsDBNull(2) ? "" : rdr.GetString(2),rdr.GetDateTime(3));
                    
                    lstbxRows.Items.Add(emp);
                }
                rdr.Close();
            }
            else if (cmbbxTables.SelectedItem.ToString() == "EmployeeTerritories")
            {
                SqlCommand cmd = new SqlCommand("select EmployeeID,TerritoryID from EmployeeTerritories", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    EmployeeTerritories empt = new EmployeeTerritories(rdr.GetInt32(0), rdr.IsDBNull(1) ? "" : rdr.GetString(1));

                    lstbxRows.Items.Add(empt);
                }
                rdr.Close();
            }
            else if (cmbbxTables.SelectedItem.ToString() == "OrderDetails")
            {
                SqlCommand cmd = new SqlCommand("select OrderID,ProductID from [Order Details]", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    OrderDetails orderd = new OrderDetails(rdr.GetInt32(0), rdr.GetInt32(1));

                    lstbxRows.Items.Add(orderd);
                }
                rdr.Close();
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Products")
            {
                SqlCommand cmd = new SqlCommand("select ProductID,ProductName from Products", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Products product = new Products(rdr.GetInt32(0), rdr.IsDBNull(1) ? "" : rdr.GetString(1));

                    lstbxRows.Items.Add(product);
                }
                rdr.Close();
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Region")
            {
                SqlCommand cmd = new SqlCommand("select RegionID from Region", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Region region=new Region(rdr.GetInt32(0));

                    lstbxRows.Items.Add(region);
                }
                rdr.Close();
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Shippers")
            {
                SqlCommand cmd = new SqlCommand("select ShipperID,CompanyName from Shippers", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Shippers ship=new Shippers (rdr.GetInt32(0), rdr.IsDBNull(1) ? "" : rdr.GetString(1));

                    lstbxRows.Items.Add(ship);
                }
                rdr.Close();
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Territories")
            {
                SqlCommand cmd = new SqlCommand("select TerritoryID,RegionID from Territories", cnn);

                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Territories terr=new Territories( rdr.IsDBNull(0) ? "" : rdr.GetString(0),rdr.GetInt32(1));

                    lstbxRows.Items.Add(terr);
                }
                rdr.Close();
            }
            cnn.Close();
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDetail1.Visible = false;
            lblDetail2.Visible = false;
            lblDetail3.Visible = false;
            lblDetail4.Visible = false;
            rchbxDetail1.Visible = false;
            rchbxDetail2.Visible = false;
            rchbxDetail3.Visible = false;
            rchbxDetail4.Visible = false;

            if (cmbbxTables.SelectedItem.ToString() == "Suppliers")
            {
                lblDetail1.Text = "SupplierID";
                lblDetail2.Text = "Company Name";
                lblDetail3.Text = "Contact Name";
                lblDetail4.Text = "Phone";
                lblDetail1.Visible = true;
                lblDetail2.Visible = true;
                lblDetail3.Visible = true;
                lblDetail4.Visible = true;
                Suppliers supp = (Suppliers)lstbxRows.SelectedItem;
                rchbxDetail1.Text = supp.SupplierID.ToString();
                rchbxDetail2.Text = supp.CompanyName;
                rchbxDetail3.Text = supp.ContactName;
                rchbxDetail4.Text = supp.Phone;
                rchbxDetail1.Visible = true;
                rchbxDetail2.Visible = true;
                rchbxDetail3.Visible = true;
                rchbxDetail4.Visible = true;
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Orders")
            {
                lblDetail1.Text = "OrderID";
                lblDetail2.Text = "CustomerID";
                lblDetail3.Text = "EmployeeID";
                lblDetail4.Text = "ShipName";
                lblDetail1.Visible = true;
                lblDetail2.Visible = true;
                lblDetail3.Visible = true;
                lblDetail4.Visible = true;
                Orders ord=(Orders)lstbxRows.SelectedItem;
                rchbxDetail1.Text = ord.OrderID.ToString();
                rchbxDetail2.Text = ord.CustomerID;
                rchbxDetail3.Text = ord.EmployeeID.ToString();
                rchbxDetail4.Text = ord.ShipName;
                rchbxDetail1.Visible = true;
                rchbxDetail2.Visible = true;
                rchbxDetail3.Visible = true;
                rchbxDetail4.Visible = true;
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Categories")
            {
                lblDetail1.Text = "CategoryID";
                lblDetail2.Text = "Category Name";
                lblDetail1.Visible = true;
                lblDetail2.Visible = true;
                Categories cat = (Categories)lstbxRows.SelectedItem;
                rchbxDetail1.Text = cat.CategoryID.ToString();
                rchbxDetail2.Text = cat.CategoryName;
                rchbxDetail1.Visible = true;
                rchbxDetail2.Visible = true;
            
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Customers")
            {
                lblDetail1.Text = "CustomerID";
                lblDetail2.Text = "Company Name";
                lblDetail3.Text = "Phone";
                lblDetail1.Visible = true;
                lblDetail2.Visible = true;
                lblDetail3.Visible = true;
                Customers cust=(Customers) lstbxRows.SelectedItem;
                rchbxDetail1.Text = cust.CustomerID;
                rchbxDetail2.Text = cust.CompanyName;
                rchbxDetail3.Text = cust.Phone;
                rchbxDetail1.Visible = true;
                rchbxDetail2.Visible = true;
                rchbxDetail3.Visible = true;
            }
            else if (cmbbxTables.SelectedItem.ToString() == "CustomerCustomerDemo")
            {
                lblDetail1.Text = "CustomerID";
                lblDetail2.Text = "CustomerTypeID";
                lblDetail1.Visible = true;
                lblDetail2.Visible = true;
                CustomerCustomerDemo ccd=(CustomerCustomerDemo) lstbxRows.SelectedItem;
                rchbxDetail1.Text = ccd.CustomerID;
                rchbxDetail2.Text = ccd.CustomerTypeID;
                rchbxDetail1.Visible = true;
                rchbxDetail2.Visible = true;

            }
            else if (cmbbxTables.SelectedItem.ToString() == "CustomerDemographics")
            {
                lblDetail1.Text = "CustomerTypeID";
                lblDetail2.Text = "Customer Desc";
                lblDetail1.Visible = true;
                lblDetail2.Visible = true;
                CustomerDemographics cd=(CustomerDemographics) lstbxRows.SelectedItem;
                rchbxDetail1.Text = cd.CustomerTypeID;
                rchbxDetail2.Text = cd.CustomerDesc;
                rchbxDetail1.Visible = true;
                rchbxDetail2.Visible = true;
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Employees")
            {
                lblDetail1.Text = "EmployeeID";
                lblDetail2.Text = "First Name";
                lblDetail3.Text = "Last Name";
                lblDetail4.Text = "BirthDate";
                lblDetail1.Visible = true;
                lblDetail2.Visible = true;
                lblDetail3.Visible = true;
                lblDetail4.Visible = true;
                Employees emp=(Employees) lstbxRows.SelectedItem;
                rchbxDetail1.Text = emp.EmployeeID.ToString();
                rchbxDetail2.Text = emp.FirstName;
                rchbxDetail3.Text = emp.LastName;
                rchbxDetail4.Text = emp.BirthDate.ToString();
                rchbxDetail1.Visible = true;
                rchbxDetail2.Visible = true;
                rchbxDetail3.Visible = true;
                rchbxDetail4.Visible = true;

            }
            else if (cmbbxTables.SelectedItem.ToString() == "EmployeeTerritories")
            {
                lblDetail1.Text = "EmployeeID";
                lblDetail2.Text = "TerritoryID";                
                lblDetail1.Visible = true;
                lblDetail2.Visible = true;               
                EmployeeTerritories empt=(EmployeeTerritories) lstbxRows.SelectedItem;
                rchbxDetail1.Text = empt.EmployeeID.ToString();
                rchbxDetail2.Text = empt.TerritoryID;
                rchbxDetail1.Visible = true;
                rchbxDetail2.Visible = true;
            }
            else if (cmbbxTables.SelectedItem.ToString() == "OrderDetails")
            {
                lblDetail1.Text = "OrderID";
                lblDetail2.Text = "ProductID";
                lblDetail1.Visible = true;
                lblDetail2.Visible = true;
                OrderDetails od=(OrderDetails) lstbxRows.SelectedItem;
                rchbxDetail1.Text = od.OrderID.ToString();
                rchbxDetail2.Text = od.ProductID.ToString();
                rchbxDetail1.Visible = true;
                rchbxDetail2.Visible = true;
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Products")
            {
                lblDetail1.Text = "ProductID";
                lblDetail2.Text = "Product Name";
                lblDetail1.Visible = true;
                lblDetail2.Visible = true;
                Products pro=(Products) lstbxRows.SelectedItem;
                rchbxDetail1.Text = pro.ProductID.ToString();
                rchbxDetail2.Text = pro.ProductName;
                rchbxDetail1.Visible = true;
                rchbxDetail2.Visible = true;
            }            
            else if (cmbbxTables.SelectedItem.ToString() == "Shippers")
            {
                lblDetail1.Text = "ShipperID";
                lblDetail2.Text = "Company Name";
                lblDetail1.Visible = true;
                lblDetail2.Visible = true;
                Shippers ship=(Shippers) lstbxRows.SelectedItem;
                rchbxDetail1.Text = ship.ShipperID.ToString();
                rchbxDetail2.Text = ship.CompanyName;
                rchbxDetail1.Visible = true;
                rchbxDetail2.Visible = true;
            }
            else if (cmbbxTables.SelectedItem.ToString() == "Territories")
            {
                lblDetail1.Text = "TerritoryID";
                lblDetail2.Text = "RegionID";
                lblDetail1.Visible = true;
                lblDetail2.Visible = true;
                Territories terr=(Territories) lstbxRows.SelectedItem;
                rchbxDetail1.Text = terr.TerritoryID;
                rchbxDetail2.Text = terr.RegionID.ToString();
                rchbxDetail1.Visible = true;
                rchbxDetail2.Visible = true;
            }
        }
    }
}
