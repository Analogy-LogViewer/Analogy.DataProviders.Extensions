using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.DataProviders.Extensions
{
    public interface IAnalogyDataProviderSetting
    {
        string Title { get; }
        UserControl DataProviderSettings { get; }
        System.Drawing.Image Icon { get; } 
    }


}
