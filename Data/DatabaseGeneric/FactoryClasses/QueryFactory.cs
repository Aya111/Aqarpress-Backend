﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
////////////////////////////////////////////////////////////// 
using System;
using System.Linq;
using DB_A4D6F8_AqarPress.Data.EntityClasses;
using DB_A4D6F8_AqarPress.Data.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec.AdapterSpecific;
using SD.LLBLGen.Pro.QuerySpec;

namespace DB_A4D6F8_AqarPress.Data.FactoryClasses
{
	/// <summary>Factory class to produce DynamicQuery instances and EntityQuery instances</summary>
	public partial class QueryFactory : QueryFactoryBase2
	{
		/// <summary>Creates and returns a new EntityQuery for the Ad entity</summary>
		public EntityQuery<AdEntity> Ad { get { return Create<AdEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Area entity</summary>
		public EntityQuery<AreaEntity> Area { get { return Create<AreaEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Attachment entity</summary>
		public EntityQuery<AttachmentEntity> Attachment { get { return Create<AttachmentEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Category entity</summary>
		public EntityQuery<CategoryEntity> Category { get { return Create<CategoryEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Developer entity</summary>
		public EntityQuery<DeveloperEntity> Developer { get { return Create<DeveloperEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Project entity</summary>
		public EntityQuery<ProjectEntity> Project { get { return Create<ProjectEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the ProjectDiscussion entity</summary>
		public EntityQuery<ProjectDiscussionEntity> ProjectDiscussion { get { return Create<ProjectDiscussionEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the ProjectSubCategoryTable entity</summary>
		public EntityQuery<ProjectSubCategoryTableEntity> ProjectSubCategoryTable { get { return Create<ProjectSubCategoryTableEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the Role entity</summary>
		public EntityQuery<RoleEntity> Role { get { return Create<RoleEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the SubCategory entity</summary>
		public EntityQuery<SubCategoryEntity> SubCategory { get { return Create<SubCategoryEntity>(); } }

		/// <summary>Creates and returns a new EntityQuery for the User entity</summary>
		public EntityQuery<UserEntity> User { get { return Create<UserEntity>(); } }

		/// <inheritdoc/>
		protected override IElementCreatorCore CreateElementCreator() { return new ElementCreator(); }
 
	}
}