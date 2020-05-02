using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.DataProviders.Extensions
{
    public interface IAnalogyComponentImages
    {
        Image GetLargeImage(Guid analogyComponentId);
        Image GetSmallImage(Guid analogyComponentId);
        Image GetOnlineConnectedLargeImage(Guid analogyComponentId);
        Image GetOnlineConnectedSmallImage(Guid analogyComponentId);
        Image GetOnlineDisconnectedLargeImage(Guid analogyComponentId);
        Image GetOnlineDisconnectedSmallImage(Guid analogyComponentId);
    }
}
