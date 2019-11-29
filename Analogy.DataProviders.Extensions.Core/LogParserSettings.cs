﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Analogy.Interfaces;
using Newtonsoft.Json;

namespace Analogy.DataProviders.Extensions
{
    public interface ILogParserSettings
    {
        /// <summary>
        /// The initial location of the log files.
        /// </summary>
        string Directory { get; set; }
        List<string> SupportedFilesExtensions { get; set; }
        bool IsConfigured { get; set; }
        string Splitter { get; set; }
        string Layout { get; set; }
        Dictionary<int, AnalogyLogMessagePropertyName> Maps { get; set; }
        int ValidItemsCount { get; set; }
        string AsJson();
        void Configure(string layout, string splitter, List<string> supportedFilesExtension, Dictionary<int, AnalogyLogMessagePropertyName> maps);
        void AddMap(int index, AnalogyLogMessagePropertyName name);
        bool CanOpenFile(string fileName);
        bool CanOpenFiles(IEnumerable<string> fileNames);
    }

    [Serializable]
    public class LogParserSettings : ILogParserSettings
    {
        public string Directory { get; set; }
        public List<string> SupportedFilesExtensions { get; set; }
        public bool IsConfigured { get; set; }
        public string Splitter { get; set; }
        public string Layout { get; set; }
        public Dictionary<int, AnalogyLogMessagePropertyName> Maps { get; set; }
        public int ValidItemsCount { get; set; }

        public string AsJson() => JsonConvert.SerializeObject(this);
        public static LogParserSettings FromJson(string json) => JsonConvert.DeserializeObject<LogParserSettings>(json);
        public LogParserSettings()
        {
            IsConfigured = false;
            Layout = string.Empty;
            Splitter = string.Empty;
            Maps = new Dictionary<int, AnalogyLogMessagePropertyName>();
            SupportedFilesExtensions = new List<string>();
        }

        public void Configure(string layout, string splitter, List<string> supportedFilesExtension, Dictionary<int, AnalogyLogMessagePropertyName> maps)
        {
            Layout = layout;
            Splitter = splitter;
            SupportedFilesExtensions = supportedFilesExtension;
            Maps = maps ?? new Dictionary<int, AnalogyLogMessagePropertyName>();
            IsConfigured = true;
            ValidItemsCount = Layout.Split(splitter.Split(), StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public void AddMap(int index, AnalogyLogMessagePropertyName name) => Maps.Add(index, name);

        public bool CanOpenFile(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return false;
            return SupportedFilesExtensions.Any(s => s.EndsWith(Path.GetExtension(fileName), StringComparison.InvariantCultureIgnoreCase));
        }

        public bool CanOpenFiles(IEnumerable<string> fileNames) => fileNames.All(CanOpenFile);

    }
}