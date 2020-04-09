using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.DataProviders.Extensions
{
   public class DataProviderImages
    {
        /// <summary>
        /// the component (Data provider/custom Action/ etc) Id
        /// </summary>
        public Guid ItemId { get; set; }
        /// <summary>
        /// 16x16 icon to show in the Analogy UI
        /// </summary>
        public Image SmallImage { get; }
        /// <summary>
        /// 32x32 icon to show in the Analogy UI
        /// </summary>
        public Image LargeImage { get; }

        public DataProviderImages(Guid itemId, Image smallImage, Image largeImage)
        {
            ItemId = itemId;
            SmallImage = smallImage;
            LargeImage = largeImage;
        }
    }
}
