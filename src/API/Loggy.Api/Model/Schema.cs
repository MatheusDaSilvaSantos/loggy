﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using Loggy.Api.Schema.Queries;

namespace Loggy.Api.Schema
{
	public class Schema: GraphQL.Types.Schema
	{
		public Schema(IDependencyResolver resolver): base(resolver)
		{
			Query = resolver.Resolve<RootQuery>();	
			Mutation = null;
		}
	}
}
