using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection;


namespace Com.H.Data
{

    public static class MappingExtensions
    {
        private static readonly DataMapper _mapper = new DataMapper();

        public static (string Name, PropertyInfo Info)[] GetCachedProperties(this Type type)
        {
            return _mapper.GetCachedProperties(type);
        }


        public static T Map<T>(this object source)
        {
            return _mapper.Map<T>(source);
        }

        public static T Clone<T>(this T source)
        {
            return _mapper.Clone<T>(source);
        }

        public static IEnumerable<T> Map<T>(this IEnumerable<object> source)
        {
            if (source == null) return null;
            return _mapper.Map<T>(source);
        }

        public static void FillWith(
            this object destination,
            object source,
            bool skipNull = false
            )
        {
            _mapper.FillWith(destination, source, skipNull);
        }
    }
}