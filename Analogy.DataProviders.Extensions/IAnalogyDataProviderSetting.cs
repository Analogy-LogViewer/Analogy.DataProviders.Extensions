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
        Image Icon { get; }
        /// <summary>
        /// to which Analogy Factory this user setting belong t0
        /// </summary>
        Guid FactoryId { get; set; }

        Task SaveSettingsAsync();
    }


}
