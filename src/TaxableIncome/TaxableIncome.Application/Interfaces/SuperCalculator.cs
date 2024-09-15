// <copyright file="SuperCalculator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces;

using TaxableIncome.Application.Constants.TaxConstants;

/// <summary>
/// This class is the super calculator, not to be confused with a super calculator.
/// </summary>
public class SuperCalculator
{
    /// <summary>
    /// Get the calculated super contribution for the financial year 2018.
    /// </summary>
    /// <param name="income">The income.</param>
    /// <returns>The calculated super contribution for this year, rounded to nearest cent.</returns>
    public decimal Get2018SuperContribution(decimal income)
    {
        return Math.Round(income * FinancialYear2018Constants.SuperPercentage, 2);
    }
}
