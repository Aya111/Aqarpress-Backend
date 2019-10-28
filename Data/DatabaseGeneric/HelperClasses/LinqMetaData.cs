﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.Linq;
using System.Collections.Generic;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using DB_A4D6F8_AqarPress.Data.EntityClasses;
using DB_A4D6F8_AqarPress.Data.FactoryClasses;

namespace DB_A4D6F8_AqarPress.Data.Linq
{
	/// <summary>Meta-data class for the construction of Linq queries which are to be executed using LLBLGen Pro code.</summary>
	public partial class LinqMetaData: ILinqMetaData
	{
		/// <summary>CTor. Using this ctor will leave the IDataAccessAdapter object to use empty. To be able to execute the query, an IDataAccessAdapter instance
		/// is required, and has to be set on the LLBLGenProProvider2 object in the query to execute. </summary>
		public LinqMetaData() : this(null, null) { }
		
		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse) : this (adapterToUse, null) { }

		/// <summary>CTor which accepts an IDataAccessAdapter implementing object, which will be used to execute queries created with this metadata class.</summary>
		/// <param name="adapterToUse">the IDataAccessAdapter to use in queries created with this meta data</param>
		/// <param name="customFunctionMappings">The custom function mappings to use. These take higher precedence than the ones in the DQE to use.</param>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data till they go out of scope.</remarks>
		public LinqMetaData(IDataAccessAdapter adapterToUse, FunctionMappingStore customFunctionMappings)
		{
			this.AdapterToUse = adapterToUse;
			this.CustomFunctionMappings = customFunctionMappings;
		}
	
		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <param name="typeOfEntity">the type of the entity to get the datasource for</param>
		/// <returns>the requested datasource</returns>
		public IDataSource GetQueryableForEntity(int typeOfEntity)
		{
			switch((DB_A4D6F8_AqarPress.Data.EntityType)typeOfEntity)
			{
				case DB_A4D6F8_AqarPress.Data.EntityType.AreaEntity:
					return this.Area;
				case DB_A4D6F8_AqarPress.Data.EntityType.CategoryEntity:
					return this.Category;
				case DB_A4D6F8_AqarPress.Data.EntityType.DeveloperEntity:
					return this.Developer;
				case DB_A4D6F8_AqarPress.Data.EntityType.ProjectEntity:
					return this.Project;
				case DB_A4D6F8_AqarPress.Data.EntityType.ProjectDiscussionEntity:
					return this.ProjectDiscussion;
				case DB_A4D6F8_AqarPress.Data.EntityType.ProjectSubCategoryTableEntity:
					return this.ProjectSubCategoryTable;
				case DB_A4D6F8_AqarPress.Data.EntityType.RoleEntity:
					return this.Role;
				case DB_A4D6F8_AqarPress.Data.EntityType.SubCategoryEntity:
					return this.SubCategory;
				case DB_A4D6F8_AqarPress.Data.EntityType.UserEntity:
					return this.User;
				default:
					return null;
			}
		}

		/// <summary>returns the datasource to use in a Linq query for the entity type specified</summary>
		/// <typeparam name="TEntity">the type of the entity to get the datasource for</typeparam>
		/// <returns>the requested datasource</returns>
		public DataSource2<TEntity> GetQueryableForEntity<TEntity>()
				where TEntity : class
		{
			return new DataSource2<TEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse);
		}

		/// <summary>returns the datasource to use in a Linq query when targeting AreaEntity instances in the database.</summary>
		public DataSource2<AreaEntity> Area {	get { return new DataSource2<AreaEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting CategoryEntity instances in the database.</summary>
		public DataSource2<CategoryEntity> Category {	get { return new DataSource2<CategoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting DeveloperEntity instances in the database.</summary>
		public DataSource2<DeveloperEntity> Developer {	get { return new DataSource2<DeveloperEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProjectEntity instances in the database.</summary>
		public DataSource2<ProjectEntity> Project {	get { return new DataSource2<ProjectEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProjectDiscussionEntity instances in the database.</summary>
		public DataSource2<ProjectDiscussionEntity> ProjectDiscussion {	get { return new DataSource2<ProjectDiscussionEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting ProjectSubCategoryTableEntity instances in the database.</summary>
		public DataSource2<ProjectSubCategoryTableEntity> ProjectSubCategoryTable {	get { return new DataSource2<ProjectSubCategoryTableEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting RoleEntity instances in the database.</summary>
		public DataSource2<RoleEntity> Role {	get { return new DataSource2<RoleEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting SubCategoryEntity instances in the database.</summary>
		public DataSource2<SubCategoryEntity> SubCategory {	get { return new DataSource2<SubCategoryEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		
		/// <summary>returns the datasource to use in a Linq query when targeting UserEntity instances in the database.</summary>
		public DataSource2<UserEntity> User {	get { return new DataSource2<UserEntity>(this.AdapterToUse, new ElementCreator(), this.CustomFunctionMappings, this.ContextToUse); } }
		


		/// <summary> Gets / sets the IDataAccessAdapter to use for the queries created with this meta data object.</summary>
		/// <remarks> Be aware that the IDataAccessAdapter object set via this property is kept alive by the LLBLGenProQuery objects created with this meta data
		/// till they go out of scope.</remarks>
		public IDataAccessAdapter AdapterToUse { get; set; }
		
		/// <summary>Gets or sets the custom function mappings to use. These take higher precedence than the ones in the DQE to use</summary>
		public FunctionMappingStore CustomFunctionMappings { get; set; }
		
		/// <summary>Gets or sets the Context instance to use for entity fetches.</summary>
		public Context ContextToUse { get; set; }
	}
}