using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.DataProviders.Extensions
{
    public interface IAnalogyComponentImages
    {
        IEnumerable<DataProviderImages> GetDataProviderImages();
    }
}
