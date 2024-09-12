// <copyright file="FinancialYearBaseInputModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.FinancialYearModels;

using Constants;

/// <summary>
/// This is the abstract input model for all financial years.
/// </summary>
public abstract class FinancialYearBaseInputModel
{
    /// <summary>
    /// Gets or sets the user provided string for income.
    /// </summary>
    public string ProvidedIncomeString { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the validated value used later in the program.
    /// </summary>
    public decimal? ValidatedIncome { get; set; }

    /// <summary>
    /// Gets or sets the user provided string for pay frequency.
    /// </summary>
    public string ProvidedPayFrequencyString { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the validated pay cycle.
    /// </summary>
    public PayCycleEnum.PayCycle? ValidatedPayFrequency { get; set; }
}