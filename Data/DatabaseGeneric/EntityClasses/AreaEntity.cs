﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.4.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AqarPress.Data.HelperClasses;
using AqarPress.Data.FactoryClasses;
using AqarPress.Data.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AqarPress.Data.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'Area'.<br/><br/></summary>
	[Serializable]
	public partial class AreaEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static AreaEntityStaticMetaData _staticMetaData = new AreaEntityStaticMetaData();
		private static AreaRelations _relationsFactory = new AreaRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class AreaEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public AreaEntityStaticMetaData()
			{
				SetEntityCoreInfo("AreaEntity", InheritanceHierarchyType.None, false, (int)AqarPress.Data.EntityType.AreaEntity, typeof(AreaEntity), typeof(AreaEntityFactory), false);
			}
		}

		/// <summary>Static ctor</summary>
		static AreaEntity()
		{
		}

		/// <summary> CTor</summary>
		public AreaEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public AreaEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this AreaEntity</param>
		public AreaEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Area which data should be fetched into this Area object</param>
		public AreaEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Area which data should be fetched into this Area object</param>
		/// <param name="validator">The custom validator object for this AreaEntity</param>
		public AreaEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected AreaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this AreaEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static AreaRelations Relations { get { return _relationsFactory; } }

		/// <summary>The ArabicName property of the Entity Area<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Area"."arabic_name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String ArabicName
		{
			get { return (System.String)GetValue((int)AreaFieldIndex.ArabicName, true); }
			set	{ SetValue((int)AreaFieldIndex.ArabicName, value); }
		}

		/// <summary>The Id property of the Entity Area<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Area"."id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)AreaFieldIndex.Id, true); }
			set { SetValue((int)AreaFieldIndex.Id, value); }		}

		/// <summary>The Name property of the Entity Area<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Area"."name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 500.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)AreaFieldIndex.Name, true); }
			set	{ SetValue((int)AreaFieldIndex.Name, value); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
	}
}

namespace AqarPress.Data
{
	public enum AreaFieldIndex
	{
		///<summary>ArabicName. </summary>
		ArabicName,
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AqarPress.Data.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Area. </summary>
	public partial class AreaRelations: RelationFactory
	{

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticAreaRelations
	{

		/// <summary>CTor</summary>
		static StaticAreaRelations() { }
	}
}
