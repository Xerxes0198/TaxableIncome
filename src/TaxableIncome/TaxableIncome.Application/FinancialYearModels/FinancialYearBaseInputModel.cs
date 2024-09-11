// <copyright file="FinancialYearBaseInputModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.FinancialYearModels;

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
    /// Gets or sets the user provided string for pay frequency.
    /// </summary>
    public string PayFrequencyString { get; set; } = string.Empty;
}