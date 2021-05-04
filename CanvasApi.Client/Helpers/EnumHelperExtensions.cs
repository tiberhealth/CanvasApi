using System;
using System.Reflection;
using TiberHealth.Serializer;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Helpers
{
    public static class EnumHelperExtensions
    {
        public static Nullable<TEnum> ToEnum<TEnum>(this string value) where TEnum: struct, Enum
        {
            if (Enum.TryParse<TEnum>(value, out var enumResult)) return enumResult;
            if (Enum.TryParse<TEnum>(value.ToPascal(), out enumResult)) return enumResult;

            var enumValues = Enum.GetValues(typeof(TEnum));

            foreach (var enumValue in enumValues)
            {
                var field = enumValue.GetType().GetField(enumValue.ToString());
                var customProperty = field.GetCustomAttribute<EnumSerializedValueAttribute>();
                if (customProperty == null) continue;

                if (customProperty.Value.ToString().Equals(value, StringComparison.OrdinalIgnoreCase)) return (TEnum)enumValue;
            }

            return null;
        }

        /// <summary>
        /// Converts an enum to snake_casing
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string ToSnake<TEnum> (this TEnum enumValue)
        {
            if (enumValue == null) return null;
            return new PascalToSnakeResolver().ConvertName(enumValue?.ToString());
        }
    }
}
