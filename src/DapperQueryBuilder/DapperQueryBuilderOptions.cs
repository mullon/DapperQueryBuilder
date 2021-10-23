﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DapperQueryBuilder
{
    /// <summary>
    /// Global options for DapperQueryBuilder
    /// </summary>
    public class DapperQueryBuilderOptions
    {
        /// <summary>
        /// In the rendered SQL statement the parameters by default are named like @p0, @p1, etc. <br />
        /// You can change the name p0/p1/etc to any other prfix. <br />
        /// Example: if you set to "arg" you'll get @arg0, @arg1, etc. <br />
        /// </summary>
        public static string AutoGeneratedParameterName { get; set; } = "p";

        /// <summary>
        /// In the rendered SQL statement the parameters by default are named like @p0, @p1, etc. <br />
        /// If your database does not accept @ symbol you can change for any other symbol. <br />
        /// For Oracle you should use ":" <br />
        /// </summary>
        public static string DatabaseParameterSymbol { get; set; } = "@";


        /// <summary>
        /// If enabled (default is disabled) each added parameter will check if identical parameter (same type and value)
        /// was already added, and if so will reuse the existing parameter.
        /// </summary>
        public static bool ReuseIdenticalParameters { get; set; } = false;

    }
}
