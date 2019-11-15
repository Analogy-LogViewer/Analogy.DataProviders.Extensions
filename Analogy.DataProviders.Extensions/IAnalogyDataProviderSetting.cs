using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.DataProviders.Extensions
{
    public interface IAnalogyDataProviderSettings
    {
        string Title { get; }
        UserControl DataProviderSettings { get; }
        Image Icon { get; } 

        Task SaveSettingsAsync { get; set; }
    }


}
