﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Architects.Persistencia
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CondominiosDB")]
	public partial class DBMLPagosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DBMLPagosDataContext() : 
				base(global::Architects.Persistencia.Properties.Settings.Default.CondominiosDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBMLPagosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBMLPagosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBMLPagosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBMLPagosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Maestros.dsd_mnt_S_TipoPago")]
		public ISingleResult<dsd_mnt_S_TipoPagoResult> dsd_mnt_S_TipoPago()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<dsd_mnt_S_TipoPagoResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Maestros.dsd_mnt_I_TipoPago")]
		public int dsd_mnt_I_TipoPago([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> prmN_IdTipoPago, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(45)")] string prm_C_Descripcion, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Bit")] System.Nullable<bool> prm_B_Estado)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), prmN_IdTipoPago, prm_C_Descripcion, prm_B_Estado);
			prmN_IdTipoPago = ((System.Nullable<int>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Maestros.dsd_mnt_S_TipoPagoId")]
		public ISingleResult<dsd_mnt_S_TipoPagoIdResult> dsd_mnt_S_TipoPagoId([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> prm_N_IdTipoPago)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), prm_N_IdTipoPago);
			return ((ISingleResult<dsd_mnt_S_TipoPagoIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Gestion.dsd_mnt_D_Cuota")]
		public int dsd_mnt_D_Cuota([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> prm_N_IdCuota)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), prm_N_IdCuota);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Gestion.dsd_mnt_S_CuotaId")]
		public ISingleResult<dsd_mnt_S_CuotaIdResult> dsd_mnt_S_CuotaId([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> prm_N_IdCuota)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), prm_N_IdCuota);
			return ((ISingleResult<dsd_mnt_S_CuotaIdResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Gestion.dsd_mnt_U_CuotaPago")]
		public int dsd_mnt_U_CuotaPago([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> prm_N_IdCuota, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1)")] string prm_D_FecPago)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), prm_N_IdCuota, prm_D_FecPago);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Gestion.dsd_mnt_S_Cuota")]
		public ISingleResult<dsd_mnt_S_CuotaResult> dsd_mnt_S_Cuota([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(1)")] string prm_C_Periodo)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), prm_C_Periodo);
			return ((ISingleResult<dsd_mnt_S_CuotaResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Gestion.dsd_mnt_I_Cuota")]
		public int dsd_mnt_I_Cuota([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> prm_N_IdCuota, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(6)")] string prm_C_Periodo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> prm_N_IdVivienda, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> prm_N_IdTipoPago, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,0)")] System.Nullable<decimal> prm_N_Importe, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> prm_D_FecVncto)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), prm_N_IdCuota, prm_C_Periodo, prm_N_IdVivienda, prm_N_IdTipoPago, prm_N_Importe, prm_D_FecVncto);
			prm_N_IdCuota = ((System.Nullable<int>)(result.GetParameterValue(0)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Gestion.dsd_mnt_U_Cuota")]
		public int dsd_mnt_U_Cuota([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> prm_N_IdCuota, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(6)")] string prm_C_Periodo, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> prm_N_IdVivienda, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> prm_N_IdTipoPago, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,0)")] System.Nullable<decimal> prm_N_Importe, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> prm_D_FecVncto)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), prm_N_IdCuota, prm_C_Periodo, prm_N_IdVivienda, prm_N_IdTipoPago, prm_N_Importe, prm_D_FecVncto);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class dsd_mnt_S_TipoPagoResult
	{
		
		private int _N_IdTipoPago;
		
		private string _C_Descripcion;
		
		private bool _B_Estado;
		
		public dsd_mnt_S_TipoPagoResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_IdTipoPago", DbType="Int NOT NULL")]
		public int N_IdTipoPago
		{
			get
			{
				return this._N_IdTipoPago;
			}
			set
			{
				if ((this._N_IdTipoPago != value))
				{
					this._N_IdTipoPago = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Descripcion", DbType="VarChar(45)")]
		public string C_Descripcion
		{
			get
			{
				return this._C_Descripcion;
			}
			set
			{
				if ((this._C_Descripcion != value))
				{
					this._C_Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_B_Estado", DbType="Bit NOT NULL")]
		public bool B_Estado
		{
			get
			{
				return this._B_Estado;
			}
			set
			{
				if ((this._B_Estado != value))
				{
					this._B_Estado = value;
				}
			}
		}
	}
	
	public partial class dsd_mnt_S_TipoPagoIdResult
	{
		
		private int _N_IdTipoPago;
		
		private string _C_Descripcion;
		
		private bool _B_Estado;
		
		public dsd_mnt_S_TipoPagoIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_IdTipoPago", DbType="Int NOT NULL")]
		public int N_IdTipoPago
		{
			get
			{
				return this._N_IdTipoPago;
			}
			set
			{
				if ((this._N_IdTipoPago != value))
				{
					this._N_IdTipoPago = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Descripcion", DbType="VarChar(45)")]
		public string C_Descripcion
		{
			get
			{
				return this._C_Descripcion;
			}
			set
			{
				if ((this._C_Descripcion != value))
				{
					this._C_Descripcion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_B_Estado", DbType="Bit NOT NULL")]
		public bool B_Estado
		{
			get
			{
				return this._B_Estado;
			}
			set
			{
				if ((this._B_Estado != value))
				{
					this._B_Estado = value;
				}
			}
		}
	}
	
	public partial class dsd_mnt_S_CuotaIdResult
	{
		
		private int _N_IdCuota;
		
		private string _C_Periodo;
		
		private int _N_IdVivienda;
		
		private int _N_IdTipoPago;
		
		private System.Nullable<decimal> _N_Importe;
		
		private System.Nullable<System.DateTime> _D_FecVncto;
		
		private System.Nullable<System.DateTime> _D_FecPago;
		
		public dsd_mnt_S_CuotaIdResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_IdCuota", DbType="Int NOT NULL")]
		public int N_IdCuota
		{
			get
			{
				return this._N_IdCuota;
			}
			set
			{
				if ((this._N_IdCuota != value))
				{
					this._N_IdCuota = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Periodo", DbType="VarChar(6)")]
		public string C_Periodo
		{
			get
			{
				return this._C_Periodo;
			}
			set
			{
				if ((this._C_Periodo != value))
				{
					this._C_Periodo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_IdVivienda", DbType="Int NOT NULL")]
		public int N_IdVivienda
		{
			get
			{
				return this._N_IdVivienda;
			}
			set
			{
				if ((this._N_IdVivienda != value))
				{
					this._N_IdVivienda = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_IdTipoPago", DbType="Int NOT NULL")]
		public int N_IdTipoPago
		{
			get
			{
				return this._N_IdTipoPago;
			}
			set
			{
				if ((this._N_IdTipoPago != value))
				{
					this._N_IdTipoPago = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_Importe", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> N_Importe
		{
			get
			{
				return this._N_Importe;
			}
			set
			{
				if ((this._N_Importe != value))
				{
					this._N_Importe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D_FecVncto", DbType="Date")]
		public System.Nullable<System.DateTime> D_FecVncto
		{
			get
			{
				return this._D_FecVncto;
			}
			set
			{
				if ((this._D_FecVncto != value))
				{
					this._D_FecVncto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D_FecPago", DbType="Date")]
		public System.Nullable<System.DateTime> D_FecPago
		{
			get
			{
				return this._D_FecPago;
			}
			set
			{
				if ((this._D_FecPago != value))
				{
					this._D_FecPago = value;
				}
			}
		}
	}
	
	public partial class dsd_mnt_S_CuotaResult
	{
		
		private int _N_IdCuota;
		
		private string _C_Periodo;
		
		private int _N_IdVivienda;
		
		private string _C_NumEdificio;
		
		private string _C_NumDpto;
		
		private string _C_Propietario;
		
		private int _N_IdTipoPago;
		
		private string _V_IdTipoPago;
		
		private System.Nullable<decimal> _N_Importe;
		
		private System.Nullable<System.DateTime> _D_FecVncto;
		
		private System.Nullable<System.DateTime> _D_FecPago;
		
		public dsd_mnt_S_CuotaResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_IdCuota", DbType="Int NOT NULL")]
		public int N_IdCuota
		{
			get
			{
				return this._N_IdCuota;
			}
			set
			{
				if ((this._N_IdCuota != value))
				{
					this._N_IdCuota = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Periodo", DbType="VarChar(6)")]
		public string C_Periodo
		{
			get
			{
				return this._C_Periodo;
			}
			set
			{
				if ((this._C_Periodo != value))
				{
					this._C_Periodo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_IdVivienda", DbType="Int NOT NULL")]
		public int N_IdVivienda
		{
			get
			{
				return this._N_IdVivienda;
			}
			set
			{
				if ((this._N_IdVivienda != value))
				{
					this._N_IdVivienda = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_NumEdificio", DbType="VarChar(10)")]
		public string C_NumEdificio
		{
			get
			{
				return this._C_NumEdificio;
			}
			set
			{
				if ((this._C_NumEdificio != value))
				{
					this._C_NumEdificio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_NumDpto", DbType="VarChar(10)")]
		public string C_NumDpto
		{
			get
			{
				return this._C_NumDpto;
			}
			set
			{
				if ((this._C_NumDpto != value))
				{
					this._C_NumDpto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_C_Propietario", DbType="VarChar(181)")]
		public string C_Propietario
		{
			get
			{
				return this._C_Propietario;
			}
			set
			{
				if ((this._C_Propietario != value))
				{
					this._C_Propietario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_IdTipoPago", DbType="Int NOT NULL")]
		public int N_IdTipoPago
		{
			get
			{
				return this._N_IdTipoPago;
			}
			set
			{
				if ((this._N_IdTipoPago != value))
				{
					this._N_IdTipoPago = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_V_IdTipoPago", DbType="VarChar(45)")]
		public string V_IdTipoPago
		{
			get
			{
				return this._V_IdTipoPago;
			}
			set
			{
				if ((this._V_IdTipoPago != value))
				{
					this._V_IdTipoPago = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_Importe", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> N_Importe
		{
			get
			{
				return this._N_Importe;
			}
			set
			{
				if ((this._N_Importe != value))
				{
					this._N_Importe = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D_FecVncto", DbType="Date")]
		public System.Nullable<System.DateTime> D_FecVncto
		{
			get
			{
				return this._D_FecVncto;
			}
			set
			{
				if ((this._D_FecVncto != value))
				{
					this._D_FecVncto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_D_FecPago", DbType="Date")]
		public System.Nullable<System.DateTime> D_FecPago
		{
			get
			{
				return this._D_FecPago;
			}
			set
			{
				if ((this._D_FecPago != value))
				{
					this._D_FecPago = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
