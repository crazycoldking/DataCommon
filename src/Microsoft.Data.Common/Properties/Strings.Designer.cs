// <auto-generated />
namespace Microsoft.Data.Common
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.Data.Common.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>
        /// The argument '{argumentName}' cannot be null, empty or contain only white space.
        /// </summary>
        internal static string ArgumentIsNullOrWhitespace
        {
            get { return GetString("ArgumentIsNullOrWhitespace"); }
        }

        /// <summary>
        /// The argument '{argumentName}' cannot be null, empty or contain only white space.
        /// </summary>
        internal static string FormatArgumentIsNullOrWhitespace(object argumentName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentIsNullOrWhitespace", "argumentName"), argumentName);
        }

        /// <summary>
        /// Format of the initialization string does not conform to specification starting at index {index}.
        /// </summary>
        internal static string ConnectionStringInvalidSyntax
        {
            get { return GetString("ConnectionStringInvalidSyntax"); }
        }

        /// <summary>
        /// Format of the initialization string does not conform to specification starting at index {index}.
        /// </summary>
        internal static string FormatConnectionStringInvalidSyntax(object index)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ConnectionStringInvalidSyntax", "index"), index);
        }

        /// <summary>
        /// Constraint Exception.
        /// </summary>
        internal static string DefaultConstraintException
        {
            get { return GetString("DefaultConstraintException"); }
        }

        /// <summary>
        /// Constraint Exception.
        /// </summary>
        internal static string FormatDefaultConstraintException()
        {
            return GetString("DefaultConstraintException");
        }

        /// <summary>
        /// Data Exception.
        /// </summary>
        internal static string DefaultDataException
        {
            get { return GetString("DefaultDataException"); }
        }

        /// <summary>
        /// Data Exception.
        /// </summary>
        internal static string FormatDefaultDataException()
        {
            return GetString("DefaultDataException");
        }

        /// <summary>
        /// External component has thrown an exception.
        /// </summary>
        internal static string ExternalException
        {
            get { return GetString("ExternalException"); }
        }

        /// <summary>
        /// External component has thrown an exception.
        /// </summary>
        internal static string FormatExternalException()
        {
            return GetString("ExternalException");
        }

        /// <summary>
        /// Internal error.
        /// </summary>
        internal static string InternalError
        {
            get { return GetString("InternalError"); }
        }

        /// <summary>
        /// Internal error.
        /// </summary>
        internal static string FormatInternalError()
        {
            return GetString("InternalError");
        }

        /// <summary>
        /// Invalid keyword, contain one or more of 'no characters', 'control characters', 'leading or trailing whitespace' or 'leading semicolons'.
        /// </summary>
        internal static string InvalidKey
        {
            get { return GetString("InvalidKey"); }
        }

        /// <summary>
        /// Invalid keyword, contain one or more of 'no characters', 'control characters', 'leading or trailing whitespace' or 'leading semicolons'.
        /// </summary>
        internal static string FormatInvalidKey()
        {
            return GetString("InvalidKey");
        }

        /// <summary>
        /// The value contains embedded nulls (\u0000).
        /// </summary>
        internal static string InvalidValue
        {
            get { return GetString("InvalidValue"); }
        }

        /// <summary>
        /// The value contains embedded nulls (\u0000).
        /// </summary>
        internal static string FormatInvalidValue()
        {
            return GetString("InvalidValue");
        }

        /// <summary>
        /// Keyword not supported: '{keyword}'.
        /// </summary>
        internal static string KeywordNotSupported
        {
            get { return GetString("KeywordNotSupported"); }
        }

        /// <summary>
        /// Keyword not supported: '{keyword}'.
        /// </summary>
        internal static string FormatKeywordNotSupported(object keyword)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("KeywordNotSupported", "keyword"), keyword);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);
    
            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
