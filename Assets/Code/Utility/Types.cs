﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

public class Types
{
	public static List<Type> FindAllDerivedTypes<T>()
    {
        return FindAllDerivedTypes<T>(Assembly.GetAssembly(typeof(T)));
    }

    public static List<Type> FindAllDerivedTypes<T>(Assembly assembly)
    {
        var derivedType = typeof(T);
        return assembly
            .GetTypes()
            .Where(t =>
                t != derivedType &&
                derivedType.IsAssignableFrom(t)
                ).ToList();

    } 
}
