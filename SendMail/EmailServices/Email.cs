using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOSUDAPAYAPI.EmailServices
{
    /// <summary>
    /// Email Model
    /// </summary>
    public class Email
    {
        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        /// <value>
        /// The domain.
        /// </value>
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        /// <value>
        /// The port.
        /// </value>
        public string Port { get; set; }

        /// <summary>
        /// Gets or sets from email.
        /// </summary>
        /// <value>
        /// From email.
        /// </value>
        public string FromEmail { get; set; }

        /// <summary>
        /// Gets or sets from name.
        /// </summary>
        /// <value>
        /// From name.
        /// </value>
        public string FromName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the cc email.
        /// </summary>
        /// <value>
        /// The cc email.
        /// </value>
        public string CCEmail { get; set; }

        /// <summary>
        /// Gets or sets the name of the cc.
        /// </summary>
        /// <value>
        /// The name of the cc.
        /// </value>
        public string CCName { get; set; }

        /// <summary>
        /// Gets or sets the host.
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        public string Host { get; set; }


    }
}
