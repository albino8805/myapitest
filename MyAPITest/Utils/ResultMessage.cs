using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAPITest.Utils
{
    /// <summary>
    /// ResultMessage
    /// </summary>
    public class ResultMessage
    {
        /// <summary>
        /// Gets or sets the success.
        /// </summary>
        /// <value>
        /// The success.
        /// </value>
        public bool Success { get; set; }
        /// <summary>
        /// Gets or sets the failure.
        /// </summary>
        /// <value>
        /// The failure.
        /// </value>
        public bool Failure { get; set; }
        /// <summary>
        /// Gets or sets the nologin.
        /// </summary>
        /// <value>
        /// The nologin.
        /// </value>
        public bool Nologin { get; set; }
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }
        /// <summary>
        /// Gets or sets the o data.
        /// </summary>
        /// <value>
        /// The o data.
        /// </value>
        public object oData { get; set; }
    }
}
