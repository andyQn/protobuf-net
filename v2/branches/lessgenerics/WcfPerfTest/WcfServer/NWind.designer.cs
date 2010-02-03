﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3031
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServer
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
	using System.ComponentModel;
	using System;
	
	
	[System.Data.Linq.Mapping.DatabaseAttribute(Name="Northwind")]
	public partial class NWindDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertOrder_Detail(Order_Detail instance);
    partial void UpdateOrder_Detail(Order_Detail instance);
    partial void DeleteOrder_Detail(Order_Detail instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    #endregion
		
		public NWindDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["NorthwindConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NWindDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NWindDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NWindDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NWindDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Order_Detail> Order_Details
		{
			get
			{
				return this.GetTable<Order_Detail>();
			}
		}
		
		public System.Data.Linq.Table<Order> Orders
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
	}
	
	[Table(Name="dbo.[Order Details]")]
	[DataContract()]
	public partial class Order_Detail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderID;
		
		private int _ProductID;
		
		private decimal _UnitPrice;
		
		private short _Quantity;
		
		private float _Discount;
		
		private EntityRef<Order> _Order;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(int value);
    partial void OnOrderIDChanged();
    partial void OnProductIDChanging(int value);
    partial void OnProductIDChanged();
    partial void OnUnitPriceChanging(decimal value);
    partial void OnUnitPriceChanged();
    partial void OnQuantityChanging(short value);
    partial void OnQuantityChanged();
    partial void OnDiscountChanging(float value);
    partial void OnDiscountChanged();
    #endregion
		
		public Order_Detail()
		{
			this.Initialize();
		}
		
		[Column(Storage="_OrderID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		[DataMember(Order=1)]
		public int OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					if (this._Order.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[Column(Storage="_ProductID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		[DataMember(Order=2)]
		public int ProductID
		{
			get
			{
				return this._ProductID;
			}
			set
			{
				if ((this._ProductID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._ProductID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[Column(Storage="_UnitPrice", DbType="Money NOT NULL")]
		[DataMember(Order=3)]
		public decimal UnitPrice
		{
			get
			{
				return this._UnitPrice;
			}
			set
			{
				if ((this._UnitPrice != value))
				{
					this.OnUnitPriceChanging(value);
					this.SendPropertyChanging();
					this._UnitPrice = value;
					this.SendPropertyChanged("UnitPrice");
					this.OnUnitPriceChanged();
				}
			}
		}
		
		[Column(Storage="_Quantity", DbType="SmallInt NOT NULL")]
		[DataMember(Order=4)]
		public short Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[Column(Storage="_Discount", DbType="Real NOT NULL")]
		[DataMember(Order=5)]
		public float Discount
		{
			get
			{
				return this._Discount;
			}
			set
			{
				if ((this._Discount != value))
				{
					this.OnDiscountChanging(value);
					this.SendPropertyChanging();
					this._Discount = value;
					this.SendPropertyChanged("Discount");
					this.OnDiscountChanged();
				}
			}
		}
		
		[Association(Name="Order_Order_Detail", Storage="_Order", ThisKey="OrderID", IsForeignKey=true)]
		public Order Order
		{
			get
			{
				return this._Order.Entity;
			}
			set
			{
				Order previousValue = this._Order.Entity;
				if (((previousValue != value) 
							|| (this._Order.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Order.Entity = null;
						previousValue.Order_Details.Remove(this);
					}
					this._Order.Entity = value;
					if ((value != null))
					{
						value.Order_Details.Add(this);
						this._OrderID = value.OrderID;
					}
					else
					{
						this._OrderID = default(int);
					}
					this.SendPropertyChanged("Order");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void Initialize()
		{
			this._Order = default(EntityRef<Order>);
			OnCreated();
		}
		
		[OnDeserializing()]
		[System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
	
	[Table(Name="dbo.Orders")]
	[DataContract()]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _OrderID;
		
		private string _CustomerID;
		
		private System.Nullable<int> _EmployeeID;
		
		private System.Nullable<System.DateTime> _OrderDate;
		
		private System.Nullable<System.DateTime> _RequiredDate;
		
		private System.Nullable<System.DateTime> _ShippedDate;
		
		private System.Nullable<int> _ShipVia;
		
		private System.Nullable<decimal> _Freight;
		
		private string _ShipName;
		
		private string _ShipAddress;
		
		private string _ShipCity;
		
		private string _ShipRegion;
		
		private string _ShipPostalCode;
		
		private string _ShipCountry;
		
		private EntitySet<Order_Detail> _Order_Details;
		
		private bool serializing;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnOrderIDChanging(int value);
    partial void OnOrderIDChanged();
    partial void OnCustomerIDChanging(string value);
    partial void OnCustomerIDChanged();
    partial void OnEmployeeIDChanging(System.Nullable<int> value);
    partial void OnEmployeeIDChanged();
    partial void OnOrderDateChanging(System.Nullable<System.DateTime> value);
    partial void OnOrderDateChanged();
    partial void OnRequiredDateChanging(System.Nullable<System.DateTime> value);
    partial void OnRequiredDateChanged();
    partial void OnShippedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnShippedDateChanged();
    partial void OnShipViaChanging(System.Nullable<int> value);
    partial void OnShipViaChanged();
    partial void OnFreightChanging(System.Nullable<decimal> value);
    partial void OnFreightChanged();
    partial void OnShipNameChanging(string value);
    partial void OnShipNameChanged();
    partial void OnShipAddressChanging(string value);
    partial void OnShipAddressChanged();
    partial void OnShipCityChanging(string value);
    partial void OnShipCityChanged();
    partial void OnShipRegionChanging(string value);
    partial void OnShipRegionChanged();
    partial void OnShipPostalCodeChanging(string value);
    partial void OnShipPostalCodeChanged();
    partial void OnShipCountryChanging(string value);
    partial void OnShipCountryChanged();
    #endregion
		
		public Order()
		{
			this.Initialize();
		}
		
		[Column(Storage="_OrderID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		[DataMember(Order=1)]
		public int OrderID
		{
			get
			{
				return this._OrderID;
			}
			set
			{
				if ((this._OrderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._OrderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[Column(Storage="_CustomerID", DbType="NChar(5)")]
		[DataMember(Order=2)]
		public string CustomerID
		{
			get
			{
				return this._CustomerID;
			}
			set
			{
				if ((this._CustomerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[Column(Storage="_EmployeeID", DbType="Int")]
		[DataMember(Order=3)]
		public System.Nullable<int> EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[Column(Storage="_OrderDate", DbType="DateTime")]
		[DataMember(Order=4)]
		public System.Nullable<System.DateTime> OrderDate
		{
			get
			{
				return this._OrderDate;
			}
			set
			{
				if ((this._OrderDate != value))
				{
					this.OnOrderDateChanging(value);
					this.SendPropertyChanging();
					this._OrderDate = value;
					this.SendPropertyChanged("OrderDate");
					this.OnOrderDateChanged();
				}
			}
		}
		
		[Column(Storage="_RequiredDate", DbType="DateTime")]
		[DataMember(Order=5)]
		public System.Nullable<System.DateTime> RequiredDate
		{
			get
			{
				return this._RequiredDate;
			}
			set
			{
				if ((this._RequiredDate != value))
				{
					this.OnRequiredDateChanging(value);
					this.SendPropertyChanging();
					this._RequiredDate = value;
					this.SendPropertyChanged("RequiredDate");
					this.OnRequiredDateChanged();
				}
			}
		}
		
		[Column(Storage="_ShippedDate", DbType="DateTime")]
		[DataMember(Order=6)]
		public System.Nullable<System.DateTime> ShippedDate
		{
			get
			{
				return this._ShippedDate;
			}
			set
			{
				if ((this._ShippedDate != value))
				{
					this.OnShippedDateChanging(value);
					this.SendPropertyChanging();
					this._ShippedDate = value;
					this.SendPropertyChanged("ShippedDate");
					this.OnShippedDateChanged();
				}
			}
		}
		
		[Column(Storage="_ShipVia", DbType="Int")]
		[DataMember(Order=7)]
		public System.Nullable<int> ShipVia
		{
			get
			{
				return this._ShipVia;
			}
			set
			{
				if ((this._ShipVia != value))
				{
					this.OnShipViaChanging(value);
					this.SendPropertyChanging();
					this._ShipVia = value;
					this.SendPropertyChanged("ShipVia");
					this.OnShipViaChanged();
				}
			}
		}
		
		[Column(Storage="_Freight", DbType="Money")]
		[DataMember(Order=8)]
		public System.Nullable<decimal> Freight
		{
			get
			{
				return this._Freight;
			}
			set
			{
				if ((this._Freight != value))
				{
					this.OnFreightChanging(value);
					this.SendPropertyChanging();
					this._Freight = value;
					this.SendPropertyChanged("Freight");
					this.OnFreightChanged();
				}
			}
		}
		
		[Column(Storage="_ShipName", DbType="NVarChar(40)")]
		[DataMember(Order=9)]
		public string ShipName
		{
			get
			{
				return this._ShipName;
			}
			set
			{
				if ((this._ShipName != value))
				{
					this.OnShipNameChanging(value);
					this.SendPropertyChanging();
					this._ShipName = value;
					this.SendPropertyChanged("ShipName");
					this.OnShipNameChanged();
				}
			}
		}
		
		[Column(Storage="_ShipAddress", DbType="NVarChar(60)")]
		[DataMember(Order=10)]
		public string ShipAddress
		{
			get
			{
				return this._ShipAddress;
			}
			set
			{
				if ((this._ShipAddress != value))
				{
					this.OnShipAddressChanging(value);
					this.SendPropertyChanging();
					this._ShipAddress = value;
					this.SendPropertyChanged("ShipAddress");
					this.OnShipAddressChanged();
				}
			}
		}
		
		[Column(Storage="_ShipCity", DbType="NVarChar(15)")]
		[DataMember(Order=11)]
		public string ShipCity
		{
			get
			{
				return this._ShipCity;
			}
			set
			{
				if ((this._ShipCity != value))
				{
					this.OnShipCityChanging(value);
					this.SendPropertyChanging();
					this._ShipCity = value;
					this.SendPropertyChanged("ShipCity");
					this.OnShipCityChanged();
				}
			}
		}
		
		[Column(Storage="_ShipRegion", DbType="NVarChar(15)")]
		[DataMember(Order=12)]
		public string ShipRegion
		{
			get
			{
				return this._ShipRegion;
			}
			set
			{
				if ((this._ShipRegion != value))
				{
					this.OnShipRegionChanging(value);
					this.SendPropertyChanging();
					this._ShipRegion = value;
					this.SendPropertyChanged("ShipRegion");
					this.OnShipRegionChanged();
				}
			}
		}
		
		[Column(Storage="_ShipPostalCode", DbType="NVarChar(10)")]
		[DataMember(Order=13)]
		public string ShipPostalCode
		{
			get
			{
				return this._ShipPostalCode;
			}
			set
			{
				if ((this._ShipPostalCode != value))
				{
					this.OnShipPostalCodeChanging(value);
					this.SendPropertyChanging();
					this._ShipPostalCode = value;
					this.SendPropertyChanged("ShipPostalCode");
					this.OnShipPostalCodeChanged();
				}
			}
		}
		
		[Column(Storage="_ShipCountry", DbType="NVarChar(15)")]
		[DataMember(Order=14)]
		public string ShipCountry
		{
			get
			{
				return this._ShipCountry;
			}
			set
			{
				if ((this._ShipCountry != value))
				{
					this.OnShipCountryChanging(value);
					this.SendPropertyChanging();
					this._ShipCountry = value;
					this.SendPropertyChanged("ShipCountry");
					this.OnShipCountryChanged();
				}
			}
		}
		
		[Association(Name="Order_Order_Detail", Storage="_Order_Details", OtherKey="OrderID")]
		[DataMember(Order=15, EmitDefaultValue=false)]
		public EntitySet<Order_Detail> Order_Details
		{
			get
			{
				if ((this.serializing 
							&& (this._Order_Details.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
				return this._Order_Details;
			}
			set
			{
				this._Order_Details.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Order_Details(Order_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Order = this;
		}
		
		private void detach_Order_Details(Order_Detail entity)
		{
			this.SendPropertyChanging();
			entity.Order = null;
		}
		
		private void Initialize()
		{
			this._Order_Details = new EntitySet<Order_Detail>(new Action<Order_Detail>(this.attach_Order_Details), new Action<Order_Detail>(this.detach_Order_Details));
			OnCreated();
		}
		
		[OnDeserializing()]
		[System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[OnSerializing()]
		[System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[OnSerialized()]
		[System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
}
#pragma warning restore 1591
