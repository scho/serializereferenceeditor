﻿using System;
using SerializeReferenceEditor.Scripts;

namespace SerializeReferenceEditor.Demo
{
	public class SRDemoAttribute : SRAttribute
	{
		public SRDemoAttribute() : base()
		{
		}

		public SRDemoAttribute(Type baseType) : base(baseType)
		{
		}

		public SRDemoAttribute(params Type[] types) : base(types)
		{
		}

		public override void OnCreate(object instance)
		{
			if(instance is AbstractData)
			{
				((AbstractData)instance).DataName = instance.GetType().Name;
			}
		}
	}
}
