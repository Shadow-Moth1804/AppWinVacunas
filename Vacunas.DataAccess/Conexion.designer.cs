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

namespace Vacunas.DataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="VacunasDB")]
	public partial class ConexionDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public ConexionDataContext() : 
				base(global::Vacunas.DataAccess.Properties.Settings.Default.VacunasDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ListEmpl")]
		public ISingleResult<sp_ListEmplResult> sp_ListEmpl()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_ListEmplResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_DelOwner")]
		public int sp_DelOwner([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_DelPet")]
		public int sp_DelPet([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_DelVac")]
		public int sp_DelVac([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ListEmpl")]
		public ISingleResult<sp_ListEmplResult1> sp_ListEmpl1()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_ListEmplResult1>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ListHis")]
		public ISingleResult<sp_ListHisResult> sp_ListHis()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_ListHisResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ListOwner")]
		public ISingleResult<sp_ListOwnerResult> sp_ListOwner()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_ListOwnerResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ListPet")]
		public ISingleResult<sp_ListPetResult> sp_ListPet()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_ListPetResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ListUser")]
		public ISingleResult<sp_ListUserResult> sp_ListUser()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_ListUserResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ListVac")]
		public ISingleResult<sp_ListVacResult> sp_ListVac()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_ListVacResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_Login")]
		public int sp_Login([global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="VarChar(100)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="VarChar(100)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userName, password);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ModOwner")]
		public int sp_ModOwner([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AdData", DbType="VarChar(400)")] string adData)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, adData);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_NewEmployee")]
		public int sp_NewEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="VarChar(150)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EmpRange", DbType="VarChar(50)")] string empRange, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(150)")] string email)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, empRange, email);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_NewOwner")]
		public int sp_NewOwner([global::System.Data.Linq.Mapping.ParameterAttribute(Name="OwnerName", DbType="VarChar(150)")] string ownerName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PhoneNumber", DbType="Char(16)")] string phoneNumber, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Email", DbType="VarChar(150)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="AdData", DbType="VarChar(400)")] string adData)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), ownerName, phoneNumber, email, adData);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_NewPet")]
		public int sp_NewPet([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PetName", DbType="VarChar(100)")] string petName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Breed", DbType="VarChar(50)")] string breed, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Gender", DbType="VarChar(8)")] string gender, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DateB", DbType="Date")] System.Nullable<System.DateTime> dateB, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Comments", DbType="VarChar(400)")] string comments, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="OwnerName", DbType="VarChar(150)")] string ownerName)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), petName, breed, gender, dateB, comments, ownerName);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_NewUser")]
		public int sp_NewUser([global::System.Data.Linq.Mapping.ParameterAttribute(Name="EmpName", DbType="VarChar(100)")] string empName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="UserName", DbType="VarChar(100)")] string userName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Password", DbType="VarChar(100)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), empName, userName, password);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_NewVaccine")]
		public int sp_NewVaccine([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Name", DbType="VarChar(50)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Pathogen", DbType="VarChar(50)")] string pathogen)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, pathogen);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_DelEmployee")]
		public int sp_DelEmployee([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id", DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_NewHist")]
		public int sp_NewHist([global::System.Data.Linq.Mapping.ParameterAttribute(Name="PetName", DbType="VarChar(100)")] string petName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PetWeight", DbType="Float")] System.Nullable<double> petWeight, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Stage", DbType="VarChar(8)")] string stage, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="VacName", DbType="VarChar(100)")] string vacName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="VacDate", DbType="Date")] System.Nullable<System.DateTime> vacDate, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="EmpName", DbType="VarChar(150)")] string empName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Observations", DbType="VarChar(400)")] string observations)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), petName, petWeight, stage, vacName, vacDate, empName, observations);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class sp_ListEmplResult
	{
		
		private int _Id;
		
		private string _EmpName;
		
		private string _EmpRange;
		
		private string _Email;
		
		private System.Nullable<bool> _Condition;
		
		public sp_ListEmplResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpName", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string EmpName
		{
			get
			{
				return this._EmpName;
			}
			set
			{
				if ((this._EmpName != value))
				{
					this._EmpName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpRange", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EmpRange
		{
			get
			{
				return this._EmpRange;
			}
			set
			{
				if ((this._EmpRange != value))
				{
					this._EmpRange = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Condition", DbType="Bit")]
		public System.Nullable<bool> Condition
		{
			get
			{
				return this._Condition;
			}
			set
			{
				if ((this._Condition != value))
				{
					this._Condition = value;
				}
			}
		}
	}
	
	public partial class sp_ListEmplResult1
	{
		
		private int _Id;
		
		private string _EmpName;
		
		private string _EmpRange;
		
		private string _Email;
		
		private System.Nullable<bool> _Condition;
		
		public sp_ListEmplResult1()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpName", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string EmpName
		{
			get
			{
				return this._EmpName;
			}
			set
			{
				if ((this._EmpName != value))
				{
					this._EmpName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpRange", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string EmpRange
		{
			get
			{
				return this._EmpRange;
			}
			set
			{
				if ((this._EmpRange != value))
				{
					this._EmpRange = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Condition", DbType="Bit")]
		public System.Nullable<bool> Condition
		{
			get
			{
				return this._Condition;
			}
			set
			{
				if ((this._Condition != value))
				{
					this._Condition = value;
				}
			}
		}
	}
	
	public partial class sp_ListHisResult
	{
		
		private int _Id;
		
		private string _PetName;
		
		private double _PetWeight;
		
		private string _PetStage;
		
		private string _VacName;
		
		private System.DateTime _VacDate;
		
		private string _EmpName;
		
		private string _Observations;
		
		public sp_ListHisResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PetName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string PetName
		{
			get
			{
				return this._PetName;
			}
			set
			{
				if ((this._PetName != value))
				{
					this._PetName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PetWeight", DbType="Float NOT NULL")]
		public double PetWeight
		{
			get
			{
				return this._PetWeight;
			}
			set
			{
				if ((this._PetWeight != value))
				{
					this._PetWeight = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PetStage", DbType="VarChar(8)")]
		public string PetStage
		{
			get
			{
				return this._PetStage;
			}
			set
			{
				if ((this._PetStage != value))
				{
					this._PetStage = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VacName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string VacName
		{
			get
			{
				return this._VacName;
			}
			set
			{
				if ((this._VacName != value))
				{
					this._VacName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VacDate", DbType="Date NOT NULL")]
		public System.DateTime VacDate
		{
			get
			{
				return this._VacDate;
			}
			set
			{
				if ((this._VacDate != value))
				{
					this._VacDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpName", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string EmpName
		{
			get
			{
				return this._EmpName;
			}
			set
			{
				if ((this._EmpName != value))
				{
					this._EmpName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Observations", DbType="VarChar(400)")]
		public string Observations
		{
			get
			{
				return this._Observations;
			}
			set
			{
				if ((this._Observations != value))
				{
					this._Observations = value;
				}
			}
		}
	}
	
	public partial class sp_ListOwnerResult
	{
		
		private int _Id;
		
		private string _OwnerName;
		
		private string _PhoneNumber;
		
		private string _Email;
		
		private string _AdData;
		
		private System.Nullable<bool> _Condition;
		
		public sp_ListOwnerResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerName", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string OwnerName
		{
			get
			{
				return this._OwnerName;
			}
			set
			{
				if ((this._OwnerName != value))
				{
					this._OwnerName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="Char(16) NOT NULL", CanBeNull=false)]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this._PhoneNumber = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this._Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdData", DbType="VarChar(400)")]
		public string AdData
		{
			get
			{
				return this._AdData;
			}
			set
			{
				if ((this._AdData != value))
				{
					this._AdData = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Condition", DbType="Bit")]
		public System.Nullable<bool> Condition
		{
			get
			{
				return this._Condition;
			}
			set
			{
				if ((this._Condition != value))
				{
					this._Condition = value;
				}
			}
		}
	}
	
	public partial class sp_ListPetResult
	{
		
		private int _Id;
		
		private string _PetName;
		
		private string _Breed;
		
		private string _Gender;
		
		private System.DateTime _DateBirth;
		
		private string _AdData;
		
		private string _OwnerName;
		
		private System.Nullable<bool> _Condition;
		
		public sp_ListPetResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PetName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string PetName
		{
			get
			{
				return this._PetName;
			}
			set
			{
				if ((this._PetName != value))
				{
					this._PetName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Breed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Breed
		{
			get
			{
				return this._Breed;
			}
			set
			{
				if ((this._Breed != value))
				{
					this._Breed = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(8) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this._Gender = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateBirth", DbType="Date NOT NULL")]
		public System.DateTime DateBirth
		{
			get
			{
				return this._DateBirth;
			}
			set
			{
				if ((this._DateBirth != value))
				{
					this._DateBirth = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdData", DbType="VarChar(400)")]
		public string AdData
		{
			get
			{
				return this._AdData;
			}
			set
			{
				if ((this._AdData != value))
				{
					this._AdData = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerName", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string OwnerName
		{
			get
			{
				return this._OwnerName;
			}
			set
			{
				if ((this._OwnerName != value))
				{
					this._OwnerName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Condition", DbType="Bit")]
		public System.Nullable<bool> Condition
		{
			get
			{
				return this._Condition;
			}
			set
			{
				if ((this._Condition != value))
				{
					this._Condition = value;
				}
			}
		}
	}
	
	public partial class sp_ListUserResult
	{
		
		private int _Id;
		
		private string _UserName;
		
		private System.Data.Linq.Binary _UsPassword;
		
		private string _EmpName;
		
		private System.Nullable<bool> _Condition;
		
		public sp_ListUserResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this._UserName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UsPassword", DbType="VarBinary(500) NOT NULL", CanBeNull=false)]
		public System.Data.Linq.Binary UsPassword
		{
			get
			{
				return this._UsPassword;
			}
			set
			{
				if ((this._UsPassword != value))
				{
					this._UsPassword = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpName", DbType="VarChar(150) NOT NULL", CanBeNull=false)]
		public string EmpName
		{
			get
			{
				return this._EmpName;
			}
			set
			{
				if ((this._EmpName != value))
				{
					this._EmpName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Condition", DbType="Bit")]
		public System.Nullable<bool> Condition
		{
			get
			{
				return this._Condition;
			}
			set
			{
				if ((this._Condition != value))
				{
					this._Condition = value;
				}
			}
		}
	}
	
	public partial class sp_ListVacResult
	{
		
		private int _Id;
		
		private string _VacName;
		
		private string _Pathogen;
		
		private System.Nullable<bool> _Condition;
		
		public sp_ListVacResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VacName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string VacName
		{
			get
			{
				return this._VacName;
			}
			set
			{
				if ((this._VacName != value))
				{
					this._VacName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pathogen", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Pathogen
		{
			get
			{
				return this._Pathogen;
			}
			set
			{
				if ((this._Pathogen != value))
				{
					this._Pathogen = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Condition", DbType="Bit")]
		public System.Nullable<bool> Condition
		{
			get
			{
				return this._Condition;
			}
			set
			{
				if ((this._Condition != value))
				{
					this._Condition = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
