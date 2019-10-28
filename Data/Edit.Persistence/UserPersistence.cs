﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.5.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Edit.Persistence
{
	/// <summary>Static class for (extension) methods for fetching and projecting instances of Edit.DtoClasses.User from the entity model.</summary>
	public static partial class UserPersistence
	{
		private static readonly System.Linq.Expressions.Expression<Func<DB_A4D6F8_AqarPress.Data.EntityClasses.UserEntity, Edit.DtoClasses.User>> _projectorExpression = CreateProjectionFunc();
		private static readonly Func<DB_A4D6F8_AqarPress.Data.EntityClasses.UserEntity, Edit.DtoClasses.User> _compiledProjector = CreateProjectionFunc().Compile();
	
		/// <summary>Empty static ctor for triggering initialization of static members in a thread-safe manner</summary>
		static UserPersistence() { }
	
		/// <summary>Extension method which produces a projection to Edit.DtoClasses.User which instances are projected from the 
		/// results of the specified baseQuery, which returns DB_A4D6F8_AqarPress.Data.EntityClasses.UserEntity instances, the root entity of the derived element returned by this query.</summary>
		/// <param name="baseQuery">The base query to project the derived element instances from.</param>
		/// <returns>IQueryable to retrieve Edit.DtoClasses.User instances</returns>
		public static IQueryable<Edit.DtoClasses.User> ProjectToUser(this IQueryable<DB_A4D6F8_AqarPress.Data.EntityClasses.UserEntity> baseQuery)
		{
			return baseQuery.Select(_projectorExpression);
		}
		
		/// <summary>Extension method which produces a projection to Edit.DtoClasses.User which instances are projected from the
		/// DB_A4D6F8_AqarPress.Data.EntityClasses.UserEntity entity instance specified, the root entity of the derived element returned by this method.</summary>
		/// <param name="entity">The entity to project from.</param>
		/// <returns>DB_A4D6F8_AqarPress.Data.EntityClasses.UserEntity instance created from the specified entity instance</returns>
		public static Edit.DtoClasses.User ProjectToUser(this DB_A4D6F8_AqarPress.Data.EntityClasses.UserEntity entity)
		{
			return _compiledProjector(entity);
		}
		
		private static System.Linq.Expressions.Expression<Func<DB_A4D6F8_AqarPress.Data.EntityClasses.UserEntity, Edit.DtoClasses.User>> CreateProjectionFunc()
		{
			return p__0 => new Edit.DtoClasses.User()
			{
				DateCreated = p__0.DateCreated,
				DeviceToken = p__0.DeviceToken,
				Id = p__0.Id,
				LastLoginDate = p__0.LastLoginDate,
				MobilePhone = p__0.MobilePhone,
				Name = p__0.Name,
				Password = p__0.Password,
				RoleId = p__0.RoleId,
	// __LLBLGENPRO_USER_CODE_REGION_START ProjectionRegion_User 
	// __LLBLGENPRO_USER_CODE_REGION_END 
			};
		}
	}
}

