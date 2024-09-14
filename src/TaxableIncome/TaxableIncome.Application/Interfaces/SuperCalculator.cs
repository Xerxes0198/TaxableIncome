// <copyright file="IncomeTaxCalculator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces;

using System.Data;

/// <summary>
/// This class is the super calculator, not to be confused with a super calculator.
/// </summary>
public class SuperCalculator
{
    /// <summary>
    /// Get the calculated super contribution for the financial year 2018.
    /// </summary>
    /// <param name="income">The income.</param>
    public decimal Get2018SuperContribution(decimal income)
    {
        return Math.Round(taxableSalary * FinancialYear2018Constants.SuperPercentage, 2);
    }
}
