using System;
using System.Collections.Generic;
using System.Linq;

namespace Serilog
{
    public static class SerilogExtensions
    {
        private static readonly object _defaultValue = 1;

        #region Debug

        public static void DebugExplicit(this ILogger logger, Exception exception, string message, object propertyValue)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue });
            DebugWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void DebugExplicit(this ILogger logger, Exception exception, string message, object propertyValue0, object propertyValue1)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1 });
            DebugWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void DebugExplicit(this ILogger logger, Exception exception, string message, object propertyValue0, object propertyValue1, object propertyValue2)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1, propertyValue2 });
            DebugWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void DebugExplicit(this ILogger logger, Exception exception, string message, params object[] propertyValues)
        {
            DebugWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void DebugExplicit(this ILogger logger, string message, object propertyValue)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue });
            DebugWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void DebugExplicit(this ILogger logger, string message, object propertyValue0, object propertyValue1)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1 });
            DebugWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void DebugExplicit(this ILogger logger, string message, object propertyValue0, object propertyValue1, object propertyValue2)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1, propertyValue2 });
            DebugWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void DebugExplicit(this ILogger logger, string message, params object[] propertyValues)
        {
            DebugWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void DebugExplicit(this ILogger logger, Exception exception, string message)
        {
            logger.Debug(exception, GetMessageTemplate(message), _defaultValue);
        }

        public static void DebugExplicit(this ILogger logger, string message)
        {
            logger.Debug(GetMessageTemplate(message), _defaultValue);
        }

        private static void DebugWithProperties(ILogger logger, Exception exception, string message, params object[] propertyValues)
        {
            logger.Debug(exception, message, propertyValues);
        }

        private static void DebugWithProperties(ILogger logger, string message, params object[] propertyValues)
        {
            logger.Debug(message, propertyValues);
        }

        #endregion Debug

        #region Error

        public static void ErrorExplicit(this ILogger logger, Exception exception, string message, object propertyValue)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue });
            ErrorWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void ErrorExplicit(this ILogger logger, Exception exception, string message, object propertyValue0, object propertyValue1)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1 });
            ErrorWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void ErrorExplicit(this ILogger logger, Exception exception, string message, object propertyValue0, object propertyValue1, object propertyValue2)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1, propertyValue2 });
            ErrorWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void ErrorExplicit(this ILogger logger, Exception exception, string message, params object[] propertyValues)
        {
            ErrorWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void ErrorExplicit(this ILogger logger, string message, object propertyValue)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue });
            ErrorWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void ErrorExplicit(this ILogger logger, string message, object propertyValue0, object propertyValue1)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1 });
            ErrorWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void ErrorExplicit(this ILogger logger, string message, object propertyValue0, object propertyValue1, object propertyValue2)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1, propertyValue2 });
            ErrorWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void ErrorExplicit(this ILogger logger, string message, params object[] propertyValues)
        {
            ErrorWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void ErrorExplicit(this ILogger logger, Exception exception, string message)
        {
            logger.Error(exception, GetMessageTemplate(message), _defaultValue);
        }

        public static void ErrorExplicit(this ILogger logger, string message)
        {
            logger.Error(GetMessageTemplate(message), _defaultValue);
        }

        private static void ErrorWithProperties(ILogger logger, Exception exception, string message, params object[] propertyValues)
        {
            logger.Error(exception, message, propertyValues);
        }

        private static void ErrorWithProperties(ILogger logger, string message, params object[] propertyValues)
        {
            logger.Error(message, propertyValues);
        }

        #endregion Error

        #region Fatal

        public static void FatalExplicit(this ILogger logger, Exception exception, string message, object propertyValue)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue });
            FatalWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void FatalExplicit(this ILogger logger, Exception exception, string message, object propertyValue0, object propertyValue1)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1 });
            FatalWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void FatalExplicit(this ILogger logger, Exception exception, string message, object propertyValue0, object propertyValue1, object propertyValue2)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1, propertyValue2 });
            FatalWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void FatalExplicit(this ILogger logger, Exception exception, string message, params object[] propertyValues)
        {
            FatalWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void FatalExplicit(this ILogger logger, string message, object propertyValue)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue });
            FatalWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void FatalExplicit(this ILogger logger, string message, object propertyValue0, object propertyValue1)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1 });
            FatalWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void FatalExplicit(this ILogger logger, string message, object propertyValue0, object propertyValue1, object propertyValue2)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1, propertyValue2 });
            FatalWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void FatalExplicit(this ILogger logger, string message, params object[] propertyValues)
        {
            FatalWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void FatalExplicit(this ILogger logger, Exception exception, string message)
        {
            logger.Fatal(exception, GetMessageTemplate(message), _defaultValue);
        }

        public static void FatalExplicit(this ILogger logger, string message)
        {
            logger.Fatal(GetMessageTemplate(message), _defaultValue);
        }

        private static void FatalWithProperties(ILogger logger, Exception exception, string message, params object[] propertyValues)
        {
            logger.Fatal(exception, message, propertyValues);
        }

        private static void FatalWithProperties(ILogger logger, string message, params object[] propertyValues)
        {
            logger.Fatal(message, propertyValues);
        }

        #endregion Fatal

        #region Information

        public static void InformationExplicit(this ILogger logger, Exception exception, string message, object propertyValue)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue });
            InformationWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void InformationExplicit(this ILogger logger, Exception exception, string message, object propertyValue0, object propertyValue1)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1 });
            InformationWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void InformationExplicit(this ILogger logger, Exception exception, string message, object propertyValue0, object propertyValue1, object propertyValue2)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1, propertyValue2 });
            InformationWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void InformationExplicit(this ILogger logger, Exception exception, string message, params object[] propertyValues)
        {
            InformationWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void InformationExplicit(this ILogger logger, string message, object propertyValue)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue });
            InformationWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void InformationExplicit(this ILogger logger, string message, object propertyValue0, object propertyValue1)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1 });
            InformationWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void InformationExplicit(this ILogger logger, string message, object propertyValue0, object propertyValue1, object propertyValue2)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1, propertyValue2 });
            InformationWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void InformationExplicit(this ILogger logger, string message, params object[] propertyValues)
        {
            InformationWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void InformationExplicit(this ILogger logger, Exception exception, string message)
        {
            logger.Information(exception, GetMessageTemplate(message), _defaultValue);
        }

        public static void InformationExplicit(this ILogger logger, string message)
        {
            logger.Information(GetMessageTemplate(message), _defaultValue);
        }

        private static void InformationWithProperties(ILogger logger, Exception exception, string message, params object[] propertyValues)
        {
            logger.Information(exception, message, propertyValues);
        }

        private static void InformationWithProperties(ILogger logger, string message, params object[] propertyValues)
        {
            logger.Information(message, propertyValues);
        }

        #endregion Information

        #region Verbose

        public static void VerboseExplicit(this ILogger logger, Exception exception, string message, object propertyValue)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue });
            VerboseWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void VerboseExplicit(this ILogger logger, Exception exception, string message, object propertyValue0, object propertyValue1)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1 });
            VerboseWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void VerboseExplicit(this ILogger logger, Exception exception, string message, object propertyValue0, object propertyValue1, object propertyValue2)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1, propertyValue2 });
            VerboseWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void VerboseExplicit(this ILogger logger, Exception exception, string message, params object[] propertyValues)
        {
            VerboseWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void VerboseExplicit(this ILogger logger, string message, object propertyValue)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue });
            VerboseWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void VerboseExplicit(this ILogger logger, string message, object propertyValue0, object propertyValue1)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1 });
            VerboseWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void VerboseExplicit(this ILogger logger, string message, object propertyValue0, object propertyValue1, object propertyValue2)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1, propertyValue2 });
            VerboseWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void VerboseExplicit(this ILogger logger, string message, params object[] propertyValues)
        {
            VerboseWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void VerboseExplicit(this ILogger logger, Exception exception, string message)
        {
            logger.Verbose(exception, GetMessageTemplate(message), _defaultValue);
        }

        public static void VerboseExplicit(this ILogger logger, string message)
        {
            logger.Verbose(GetMessageTemplate(message), _defaultValue);
        }

        private static void VerboseWithProperties(ILogger logger, Exception exception, string message, params object[] propertyValues)
        {
            logger.Verbose(exception, message, propertyValues);
        }

        private static void VerboseWithProperties(ILogger logger, string message, params object[] propertyValues)
        {
            logger.Verbose(message, propertyValues);
        }

        #endregion Verbose

        #region Warning

        public static void WarningExplicit(this ILogger logger, Exception exception, string message, object propertyValue)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue });
            WarningWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void WarningExplicit(this ILogger logger, Exception exception, string message, object propertyValue0, object propertyValue1)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1 });
            WarningWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void WarningExplicit(this ILogger logger, Exception exception, string message, object propertyValue0, object propertyValue1, object propertyValue2)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1, propertyValue2 });
            WarningWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void WarningExplicit(this ILogger logger, Exception exception, string message, params object[] propertyValues)
        {
            WarningWithProperties(logger, exception, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void WarningExplicit(this ILogger logger, string message, object propertyValue)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue });
            WarningWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void WarningExplicit(this ILogger logger, string message, object propertyValue0, object propertyValue1)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1 });
            WarningWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void WarningExplicit(this ILogger logger, string message, object propertyValue0, object propertyValue1, object propertyValue2)
        {
            object[] propertyValues = GetPropertyValues(new object[] { propertyValue0, propertyValue1, propertyValue2 });
            WarningWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void WarningExplicit(this ILogger logger, string message, params object[] propertyValues)
        {
            WarningWithProperties(logger, GetMessageTemplate(message), GetPropertyValues(propertyValues));
        }

        public static void WarningExplicit(this ILogger logger, Exception exception, string message)
        {
            logger.Warning(exception, GetMessageTemplate(message), _defaultValue);
        }

        public static void WarningExplicit(this ILogger logger, string message)
        {
            logger.Warning(GetMessageTemplate(message), _defaultValue);
        }

        private static void WarningWithProperties(ILogger logger, Exception exception, string message, params object[] propertyValues)
        {
            logger.Warning(exception, message, propertyValues);
        }

        private static void WarningWithProperties(ILogger logger, string message, params object[] propertyValues)
        {
            logger.Warning(message, propertyValues);
        }

        #endregion Warning

        #region Shared

        private static string GetMessageTemplate(string message)
        {
            return message + "{ExplicitLog}";
        }

        private static object[] GetPropertyValues(object[] propertyValues)
        {
            List<object> tempList = propertyValues.ToList();
            tempList.Add(_defaultValue);
            object[] tempArray = tempList.ToArray();
            return tempArray;
        }

        #endregion Shared
    }
}