using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOSUDAPAYAPI.Models
{
    public class Email
    {
        /// <summary>
        /// Gets or sets to.
        /// </summary>
        /// <value>
        /// Email To value
        /// </value>
        public string To { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        public string Body { get; set; }       

    }
}
