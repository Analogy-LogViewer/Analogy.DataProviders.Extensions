using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.DataProviders.Extensions
{
    public interface IAnalogyDataProviderSettings
    {
        string Title { get; }
        UserControl DataProviderSettings { get; }
        /// <summary>
        /// 16x16 icon to show in the Analogy UI
        /// </summary>
        Image SmallImage { get; }
        /// <summary>
        /// 32x32 icon to show in the Analogy UI
        /// </summary>
        Image LargeImage { get; }
        /// <summary>
        /// to which Analogy Factory this user setting belong t0
        /// </summary>
        Guid FactoryId { get; set; }

        Task SaveSettingsAsync();
    }


}
