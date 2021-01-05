﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CarritoCompras")]
	public partial class ConexionBaseDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Inserttbl_categoria(tbl_categoria instance);
    partial void Updatetbl_categoria(tbl_categoria instance);
    partial void Deletetbl_categoria(tbl_categoria instance);
    partial void Inserttbl_producto(tbl_producto instance);
    partial void Updatetbl_producto(tbl_producto instance);
    partial void Deletetbl_producto(tbl_producto instance);
    partial void Inserttbl_tipoUsuario(tbl_tipoUsuario instance);
    partial void Updatetbl_tipoUsuario(tbl_tipoUsuario instance);
    partial void Deletetbl_tipoUsuario(tbl_tipoUsuario instance);
    partial void Inserttbl_usuario(tbl_usuario instance);
    partial void Updatetbl_usuario(tbl_usuario instance);
    partial void Deletetbl_usuario(tbl_usuario instance);
    #endregion
		
		public ConexionBaseDataDataContext() : 
				base(global::CapaDatos.Properties.Settings.Default.CarritoComprasConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionBaseDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionBaseDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionBaseDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionBaseDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_categoria> tbl_categoria
		{
			get
			{
				return this.GetTable<tbl_categoria>();
			}
		}
		
		public System.Data.Linq.Table<tbl_producto> tbl_producto
		{
			get
			{
				return this.GetTable<tbl_producto>();
			}
		}
		
		public System.Data.Linq.Table<tbl_tipoUsuario> tbl_tipoUsuario
		{
			get
			{
				return this.GetTable<tbl_tipoUsuario>();
			}
		}
		
		public System.Data.Linq.Table<tbl_usuario> tbl_usuario
		{
			get
			{
				return this.GetTable<tbl_usuario>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_categoria")]
	public partial class tbl_categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cat_id;
		
		private string _cat_nombre;
		
		private System.Nullable<char> _cat_estado;
		
		private EntitySet<tbl_producto> _tbl_producto;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncat_idChanging(int value);
    partial void Oncat_idChanged();
    partial void Oncat_nombreChanging(string value);
    partial void Oncat_nombreChanged();
    partial void Oncat_estadoChanging(System.Nullable<char> value);
    partial void Oncat_estadoChanged();
    #endregion
		
		public tbl_categoria()
		{
			this._tbl_producto = new EntitySet<tbl_producto>(new Action<tbl_producto>(this.attach_tbl_producto), new Action<tbl_producto>(this.detach_tbl_producto));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cat_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int cat_id
		{
			get
			{
				return this._cat_id;
			}
			set
			{
				if ((this._cat_id != value))
				{
					this.Oncat_idChanging(value);
					this.SendPropertyChanging();
					this._cat_id = value;
					this.SendPropertyChanged("cat_id");
					this.Oncat_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cat_nombre", DbType="VarChar(100)")]
		public string cat_nombre
		{
			get
			{
				return this._cat_nombre;
			}
			set
			{
				if ((this._cat_nombre != value))
				{
					this.Oncat_nombreChanging(value);
					this.SendPropertyChanging();
					this._cat_nombre = value;
					this.SendPropertyChanged("cat_nombre");
					this.Oncat_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cat_estado", DbType="Char(1)")]
		public System.Nullable<char> cat_estado
		{
			get
			{
				return this._cat_estado;
			}
			set
			{
				if ((this._cat_estado != value))
				{
					this.Oncat_estadoChanging(value);
					this.SendPropertyChanging();
					this._cat_estado = value;
					this.SendPropertyChanged("cat_estado");
					this.Oncat_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_categoria_tbl_producto", Storage="_tbl_producto", ThisKey="cat_id", OtherKey="cat_id")]
		public EntitySet<tbl_producto> tbl_producto
		{
			get
			{
				return this._tbl_producto;
			}
			set
			{
				this._tbl_producto.Assign(value);
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
		
		private void attach_tbl_producto(tbl_producto entity)
		{
			this.SendPropertyChanging();
			entity.tbl_categoria = this;
		}
		
		private void detach_tbl_producto(tbl_producto entity)
		{
			this.SendPropertyChanging();
			entity.tbl_categoria = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_producto")]
	public partial class tbl_producto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _pro_id;
		
		private string _pro_nombre;
		
		private System.Nullable<int> _pro_cantidad;
		
		private System.Nullable<decimal> _pro_precio;
		
		private System.Nullable<char> _pro_estado;
		
		private int _cat_id;
		
		private EntityRef<tbl_categoria> _tbl_categoria;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onpro_idChanging(int value);
    partial void Onpro_idChanged();
    partial void Onpro_nombreChanging(string value);
    partial void Onpro_nombreChanged();
    partial void Onpro_cantidadChanging(System.Nullable<int> value);
    partial void Onpro_cantidadChanged();
    partial void Onpro_precioChanging(System.Nullable<decimal> value);
    partial void Onpro_precioChanged();
    partial void Onpro_estadoChanging(System.Nullable<char> value);
    partial void Onpro_estadoChanged();
    partial void Oncat_idChanging(int value);
    partial void Oncat_idChanged();
    #endregion
		
		public tbl_producto()
		{
			this._tbl_categoria = default(EntityRef<tbl_categoria>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int pro_id
		{
			get
			{
				return this._pro_id;
			}
			set
			{
				if ((this._pro_id != value))
				{
					this.Onpro_idChanging(value);
					this.SendPropertyChanging();
					this._pro_id = value;
					this.SendPropertyChanged("pro_id");
					this.Onpro_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string pro_nombre
		{
			get
			{
				return this._pro_nombre;
			}
			set
			{
				if ((this._pro_nombre != value))
				{
					this.Onpro_nombreChanging(value);
					this.SendPropertyChanging();
					this._pro_nombre = value;
					this.SendPropertyChanged("pro_nombre");
					this.Onpro_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_cantidad", DbType="Int")]
		public System.Nullable<int> pro_cantidad
		{
			get
			{
				return this._pro_cantidad;
			}
			set
			{
				if ((this._pro_cantidad != value))
				{
					this.Onpro_cantidadChanging(value);
					this.SendPropertyChanging();
					this._pro_cantidad = value;
					this.SendPropertyChanged("pro_cantidad");
					this.Onpro_cantidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_precio", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> pro_precio
		{
			get
			{
				return this._pro_precio;
			}
			set
			{
				if ((this._pro_precio != value))
				{
					this.Onpro_precioChanging(value);
					this.SendPropertyChanging();
					this._pro_precio = value;
					this.SendPropertyChanged("pro_precio");
					this.Onpro_precioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pro_estado", DbType="Char(1)")]
		public System.Nullable<char> pro_estado
		{
			get
			{
				return this._pro_estado;
			}
			set
			{
				if ((this._pro_estado != value))
				{
					this.Onpro_estadoChanging(value);
					this.SendPropertyChanging();
					this._pro_estado = value;
					this.SendPropertyChanged("pro_estado");
					this.Onpro_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cat_id", DbType="Int NOT NULL")]
		public int cat_id
		{
			get
			{
				return this._cat_id;
			}
			set
			{
				if ((this._cat_id != value))
				{
					if (this._tbl_categoria.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncat_idChanging(value);
					this.SendPropertyChanging();
					this._cat_id = value;
					this.SendPropertyChanged("cat_id");
					this.Oncat_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_categoria_tbl_producto", Storage="_tbl_categoria", ThisKey="cat_id", OtherKey="cat_id", IsForeignKey=true)]
		public tbl_categoria tbl_categoria
		{
			get
			{
				return this._tbl_categoria.Entity;
			}
			set
			{
				tbl_categoria previousValue = this._tbl_categoria.Entity;
				if (((previousValue != value) 
							|| (this._tbl_categoria.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_categoria.Entity = null;
						previousValue.tbl_producto.Remove(this);
					}
					this._tbl_categoria.Entity = value;
					if ((value != null))
					{
						value.tbl_producto.Add(this);
						this._cat_id = value.cat_id;
					}
					else
					{
						this._cat_id = default(int);
					}
					this.SendPropertyChanged("tbl_categoria");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_tipoUsuario")]
	public partial class tbl_tipoUsuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _tusu_id;
		
		private string _tusu_nombre;
		
		private System.Nullable<char> _tusu_estado;
		
		private EntitySet<tbl_usuario> _tbl_usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ontusu_idChanging(int value);
    partial void Ontusu_idChanged();
    partial void Ontusu_nombreChanging(string value);
    partial void Ontusu_nombreChanged();
    partial void Ontusu_estadoChanging(System.Nullable<char> value);
    partial void Ontusu_estadoChanged();
    #endregion
		
		public tbl_tipoUsuario()
		{
			this._tbl_usuario = new EntitySet<tbl_usuario>(new Action<tbl_usuario>(this.attach_tbl_usuario), new Action<tbl_usuario>(this.detach_tbl_usuario));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int tusu_id
		{
			get
			{
				return this._tusu_id;
			}
			set
			{
				if ((this._tusu_id != value))
				{
					this.Ontusu_idChanging(value);
					this.SendPropertyChanging();
					this._tusu_id = value;
					this.SendPropertyChanged("tusu_id");
					this.Ontusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string tusu_nombre
		{
			get
			{
				return this._tusu_nombre;
			}
			set
			{
				if ((this._tusu_nombre != value))
				{
					this.Ontusu_nombreChanging(value);
					this.SendPropertyChanging();
					this._tusu_nombre = value;
					this.SendPropertyChanged("tusu_nombre");
					this.Ontusu_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_estado", DbType="Char(1)")]
		public System.Nullable<char> tusu_estado
		{
			get
			{
				return this._tusu_estado;
			}
			set
			{
				if ((this._tusu_estado != value))
				{
					this.Ontusu_estadoChanging(value);
					this.SendPropertyChanging();
					this._tusu_estado = value;
					this.SendPropertyChanged("tusu_estado");
					this.Ontusu_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_tipoUsuario_tbl_usuario", Storage="_tbl_usuario", ThisKey="tusu_id", OtherKey="tusu_id")]
		public EntitySet<tbl_usuario> tbl_usuario
		{
			get
			{
				return this._tbl_usuario;
			}
			set
			{
				this._tbl_usuario.Assign(value);
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
		
		private void attach_tbl_usuario(tbl_usuario entity)
		{
			this.SendPropertyChanging();
			entity.tbl_tipoUsuario = this;
		}
		
		private void detach_tbl_usuario(tbl_usuario entity)
		{
			this.SendPropertyChanging();
			entity.tbl_tipoUsuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_usuario")]
	public partial class tbl_usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _usu_id;
		
		private string _usu_cedula;
		
		private string _usu_nombre;
		
		private string _usu_apellido;
		
		private string _usu_direccion;
		
		private string _usu_telefono;
		
		private System.Nullable<System.DateTime> _usu_fechacreacion;
		
		private string _usu_contraseña;
		
		private string _usu_nomlogin;
		
		private string _usu_correo;
		
		private System.Nullable<char> _usu_estado;
		
		private int _tusu_id;
		
		private EntityRef<tbl_tipoUsuario> _tbl_tipoUsuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onusu_idChanging(int value);
    partial void Onusu_idChanged();
    partial void Onusu_cedulaChanging(string value);
    partial void Onusu_cedulaChanged();
    partial void Onusu_nombreChanging(string value);
    partial void Onusu_nombreChanged();
    partial void Onusu_apellidoChanging(string value);
    partial void Onusu_apellidoChanged();
    partial void Onusu_direccionChanging(string value);
    partial void Onusu_direccionChanged();
    partial void Onusu_telefonoChanging(string value);
    partial void Onusu_telefonoChanged();
    partial void Onusu_fechacreacionChanging(System.Nullable<System.DateTime> value);
    partial void Onusu_fechacreacionChanged();
    partial void Onusu_contraseñaChanging(string value);
    partial void Onusu_contraseñaChanged();
    partial void Onusu_nomloginChanging(string value);
    partial void Onusu_nomloginChanged();
    partial void Onusu_correoChanging(string value);
    partial void Onusu_correoChanged();
    partial void Onusu_estadoChanging(System.Nullable<char> value);
    partial void Onusu_estadoChanged();
    partial void Ontusu_idChanging(int value);
    partial void Ontusu_idChanged();
    #endregion
		
		public tbl_usuario()
		{
			this._tbl_tipoUsuario = default(EntityRef<tbl_tipoUsuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int usu_id
		{
			get
			{
				return this._usu_id;
			}
			set
			{
				if ((this._usu_id != value))
				{
					this.Onusu_idChanging(value);
					this.SendPropertyChanging();
					this._usu_id = value;
					this.SendPropertyChanged("usu_id");
					this.Onusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_cedula", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string usu_cedula
		{
			get
			{
				return this._usu_cedula;
			}
			set
			{
				if ((this._usu_cedula != value))
				{
					this.Onusu_cedulaChanging(value);
					this.SendPropertyChanging();
					this._usu_cedula = value;
					this.SendPropertyChanged("usu_cedula");
					this.Onusu_cedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string usu_nombre
		{
			get
			{
				return this._usu_nombre;
			}
			set
			{
				if ((this._usu_nombre != value))
				{
					this.Onusu_nombreChanging(value);
					this.SendPropertyChanging();
					this._usu_nombre = value;
					this.SendPropertyChanged("usu_nombre");
					this.Onusu_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_apellido", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string usu_apellido
		{
			get
			{
				return this._usu_apellido;
			}
			set
			{
				if ((this._usu_apellido != value))
				{
					this.Onusu_apellidoChanging(value);
					this.SendPropertyChanging();
					this._usu_apellido = value;
					this.SendPropertyChanged("usu_apellido");
					this.Onusu_apellidoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_direccion", DbType="VarChar(200)")]
		public string usu_direccion
		{
			get
			{
				return this._usu_direccion;
			}
			set
			{
				if ((this._usu_direccion != value))
				{
					this.Onusu_direccionChanging(value);
					this.SendPropertyChanging();
					this._usu_direccion = value;
					this.SendPropertyChanged("usu_direccion");
					this.Onusu_direccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_telefono", DbType="VarChar(20)")]
		public string usu_telefono
		{
			get
			{
				return this._usu_telefono;
			}
			set
			{
				if ((this._usu_telefono != value))
				{
					this.Onusu_telefonoChanging(value);
					this.SendPropertyChanging();
					this._usu_telefono = value;
					this.SendPropertyChanged("usu_telefono");
					this.Onusu_telefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_fechacreacion", DbType="DateTime")]
		public System.Nullable<System.DateTime> usu_fechacreacion
		{
			get
			{
				return this._usu_fechacreacion;
			}
			set
			{
				if ((this._usu_fechacreacion != value))
				{
					this.Onusu_fechacreacionChanging(value);
					this.SendPropertyChanging();
					this._usu_fechacreacion = value;
					this.SendPropertyChanged("usu_fechacreacion");
					this.Onusu_fechacreacionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_contraseña", DbType="VarChar(50)")]
		public string usu_contraseña
		{
			get
			{
				return this._usu_contraseña;
			}
			set
			{
				if ((this._usu_contraseña != value))
				{
					this.Onusu_contraseñaChanging(value);
					this.SendPropertyChanging();
					this._usu_contraseña = value;
					this.SendPropertyChanged("usu_contraseña");
					this.Onusu_contraseñaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_nomlogin", DbType="VarChar(50)")]
		public string usu_nomlogin
		{
			get
			{
				return this._usu_nomlogin;
			}
			set
			{
				if ((this._usu_nomlogin != value))
				{
					this.Onusu_nomloginChanging(value);
					this.SendPropertyChanging();
					this._usu_nomlogin = value;
					this.SendPropertyChanged("usu_nomlogin");
					this.Onusu_nomloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_correo", DbType="VarChar(50)")]
		public string usu_correo
		{
			get
			{
				return this._usu_correo;
			}
			set
			{
				if ((this._usu_correo != value))
				{
					this.Onusu_correoChanging(value);
					this.SendPropertyChanging();
					this._usu_correo = value;
					this.SendPropertyChanged("usu_correo");
					this.Onusu_correoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_estado", DbType="Char(1)")]
		public System.Nullable<char> usu_estado
		{
			get
			{
				return this._usu_estado;
			}
			set
			{
				if ((this._usu_estado != value))
				{
					this.Onusu_estadoChanging(value);
					this.SendPropertyChanging();
					this._usu_estado = value;
					this.SendPropertyChanged("usu_estado");
					this.Onusu_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_id", DbType="Int NOT NULL")]
		public int tusu_id
		{
			get
			{
				return this._tusu_id;
			}
			set
			{
				if ((this._tusu_id != value))
				{
					if (this._tbl_tipoUsuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ontusu_idChanging(value);
					this.SendPropertyChanging();
					this._tusu_id = value;
					this.SendPropertyChanged("tusu_id");
					this.Ontusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tbl_tipoUsuario_tbl_usuario", Storage="_tbl_tipoUsuario", ThisKey="tusu_id", OtherKey="tusu_id", IsForeignKey=true)]
		public tbl_tipoUsuario tbl_tipoUsuario
		{
			get
			{
				return this._tbl_tipoUsuario.Entity;
			}
			set
			{
				tbl_tipoUsuario previousValue = this._tbl_tipoUsuario.Entity;
				if (((previousValue != value) 
							|| (this._tbl_tipoUsuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tbl_tipoUsuario.Entity = null;
						previousValue.tbl_usuario.Remove(this);
					}
					this._tbl_tipoUsuario.Entity = value;
					if ((value != null))
					{
						value.tbl_usuario.Add(this);
						this._tusu_id = value.tusu_id;
					}
					else
					{
						this._tusu_id = default(int);
					}
					this.SendPropertyChanged("tbl_tipoUsuario");
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