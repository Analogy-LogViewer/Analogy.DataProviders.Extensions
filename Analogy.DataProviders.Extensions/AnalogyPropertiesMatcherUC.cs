using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Analogy.DataProviders.Extensions;
using Analogy.Interfaces;

namespace Analogy.DataProviders.Extensions
{
    public partial class AnalogyPropertiesMatcherUC : UserControl
    {
        private AnalogyLogMessagePropertyName Selection { get; set; }
        private ILogParserSettings ParserSettings { get; set; }
        public AnalogyPropertiesMatcherUC()
        {
            InitializeComponent();
        }

        public AnalogyPropertiesMatcherUC(ILogParserSettings parserSettings):this()
        {
            ParserSettings = parserSettings;
        }
        private void AnalogyPropertiesMatcherUC_Load(object sender, EventArgs e)
        {
            cbLogProperties.DataSource = AnalogyLogMessage.AnalogyLogMessagePropertyNames.Values;
            cbLogProperties.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbLogProperties_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selection = (AnalogyLogMessagePropertyName) cbLogProperties.SelectedItem;
            lblInfo.Text = $"Log files keys/properties to map to {Selection}:";
            UpdateMappings();

        }

        private void UpdateMappings()
        {
            if (ParserSettings.Maps.ContainsKey(Selection))
            {
                lstbMappedKeys.Items.Clear();
                lstbMappedKeys.Items.AddRange(ParserSettings.Maps[Selection].ToArray());
            }
        }
        
        private void btnAddKey_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKey.Text))
            {
                ParserSettings.AddMap(Selection,txtKey.Text);
                UpdateMappings();
            }
        }

        private void lstbMappedKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelection.Text = "Selection:" + lstbMappedKeys.SelectedItem;
        }

        private void btnDeleteSelection_Click(object sender, EventArgs e)
        {
            if (lstbMappedKeys.SelectedItem != null)
            {
                ParserSettings.DeleteMap(Selection, lstbMappedKeys.SelectedItem as string);
            }
        }
    }
}
