﻿using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.CodeAnalysis;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using Palmmedia.ReportGenerator.Core.Reporting;

namespace Palmmedia.ReportGenerator.Core
{
    /// <summary>
    /// The context containing configuration and runtime information of the current execution.
    /// </summary>
    internal class ReportContext : IReportContext
    {
        /// <summary>
        /// The historic coverage elements.
        /// </summary>
        private IReadOnlyCollection<HistoricCoverage> overallHistoricCoverages = new List<HistoricCoverage>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportContext"/> class.
        /// </summary>
        /// <param name="reportConfiguration">The configuration options.</param>
        internal ReportContext(IReportConfiguration reportConfiguration)
        {
            this.ReportConfiguration = reportConfiguration;
        }

        /// <summary>
        /// Gets the configuration options.
        /// </summary>
        public IReportConfiguration ReportConfiguration { get; }

        /// <summary>
        /// Gets the settings.
        /// </summary>
        public Settings Settings { get; } = new Settings();

        /// <summary>
        /// Gets or sets the risk hotspot analysis result.
        /// </summary>
        public RiskHotspotAnalysisResult RiskHotspotAnalysisResult { get; set; }

        /// <summary>
        /// Gets or sets the historic coverage elements.
        /// </summary>
        public IReadOnlyCollection<HistoricCoverage> OverallHistoricCoverages
        {
            get
            {
                return this.overallHistoricCoverages;
            }

            set
            {
                this.overallHistoricCoverages = value ?? this.overallHistoricCoverages;
            }
        }
    }
}