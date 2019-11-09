﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortfolioManagement
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertStock(Stock instance);
    partial void UpdateStock(Stock instance);
    partial void DeleteStock(Stock instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::PortfolioManagement.Properties.Settings.Default.DatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Stock> Stocks
		{
			get
			{
				return this.GetTable<Stock>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _password;
		
		private decimal _money;
		
		private string _email;
		
		private EntitySet<Stock> _Stocks;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnmoneyChanging(decimal value);
    partial void OnmoneyChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
		
		public User()
		{
			this._Stocks = new EntitySet<Stock>(new Action<Stock>(this.attach_Stocks), new Action<Stock>(this.detach_Stocks));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_money", DbType="Money NOT NULL")]
		public decimal money
		{
			get
			{
				return this._money;
			}
			set
			{
				if ((this._money != value))
				{
					this.OnmoneyChanging(value);
					this.SendPropertyChanging();
					this._money = value;
					this.SendPropertyChanged("money");
					this.OnmoneyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Stock", Storage="_Stocks", ThisKey="id", OtherKey="User_id")]
		public EntitySet<Stock> Stocks
		{
			get
			{
				return this._Stocks;
			}
			set
			{
				this._Stocks.Assign(value);
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
		
		private void attach_Stocks(Stock entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Stocks(Stock entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Stocks")]
	public partial class Stock : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Transaction_id;
		
		private int _User_id;
		
		private string _stock_symbol;
		
		private int _count;
		
		private System.Nullable<double> _purchasePrice;
		
		private EntityRef<User> _User;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransaction_idChanging(int value);
    partial void OnTransaction_idChanged();
    partial void OnUser_idChanging(int value);
    partial void OnUser_idChanged();
    partial void Onstock_symbolChanging(string value);
    partial void Onstock_symbolChanged();
    partial void OncountChanging(int value);
    partial void OncountChanged();
    partial void OnpurchasePriceChanging(System.Nullable<double> value);
    partial void OnpurchasePriceChanged();
    #endregion
		
		public Stock()
		{
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Transaction_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Transaction_id
		{
			get
			{
				return this._Transaction_id;
			}
			set
			{
				if ((this._Transaction_id != value))
				{
					this.OnTransaction_idChanging(value);
					this.SendPropertyChanging();
					this._Transaction_id = value;
					this.SendPropertyChanged("Transaction_id");
					this.OnTransaction_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_id", DbType="Int NOT NULL")]
		public int User_id
		{
			get
			{
				return this._User_id;
			}
			set
			{
				if ((this._User_id != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUser_idChanging(value);
					this.SendPropertyChanging();
					this._User_id = value;
					this.SendPropertyChanged("User_id");
					this.OnUser_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stock_symbol", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string stock_symbol
		{
			get
			{
				return this._stock_symbol;
			}
			set
			{
				if ((this._stock_symbol != value))
				{
					this.Onstock_symbolChanging(value);
					this.SendPropertyChanging();
					this._stock_symbol = value;
					this.SendPropertyChanged("stock_symbol");
					this.Onstock_symbolChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_count", DbType="Int NOT NULL")]
		public int count
		{
			get
			{
				return this._count;
			}
			set
			{
				if ((this._count != value))
				{
					this.OncountChanging(value);
					this.SendPropertyChanging();
					this._count = value;
					this.SendPropertyChanged("count");
					this.OncountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_purchasePrice", DbType="Float")]
		public System.Nullable<double> purchasePrice
		{
			get
			{
				return this._purchasePrice;
			}
			set
			{
				if ((this._purchasePrice != value))
				{
					this.OnpurchasePriceChanging(value);
					this.SendPropertyChanging();
					this._purchasePrice = value;
					this.SendPropertyChanged("purchasePrice");
					this.OnpurchasePriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Stock", Storage="_User", ThisKey="User_id", OtherKey="id", IsForeignKey=true)]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Stocks.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Stocks.Add(this);
						this._User_id = value.id;
					}
					else
					{
						this._User_id = default(int);
					}
					this.SendPropertyChanged("User");
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
	}
}
#pragma warning restore 1591