using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.DataProviders.Extensions
{
    interface IAnalogyExtensionUI
    {
        /// <summary>
        /// ID of the ExtensionUI
        /// </summary>
        Guid ID { get; }
        /// <summary>
        /// ID of the Extension
        /// </summary>
        Guid ExtensionID { get; }
        /// <summary>
        /// //Optional title to display in the ribbon bar
        /// </summary>
        string OptionalTitle { get; }
        /// <summary>
        /// The user control to show
        /// </summary>
        UserControl UserControl { get; }
    }
    }

