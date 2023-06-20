﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingSeb.Localization
{
    /// <summary>
    /// To specify the name of a field defined in the class that has this attribute that return a custom <see cref="Loc"/> instance
    /// for multi-users mode
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class LocFieldAttribute : Attribute
    {
        /// <summary>
        /// To specify the name of a field defined in the class that has this attribute that return a custom <see cref="Loc"/> instance
        /// for multi-users mode
        /// </summary>
        /// <param name="fieldName">the name of the field that get the custom <see cref="Loc"/> instance</param>
        public LocFieldAttribute(string fieldName)
        {}
    }
}
