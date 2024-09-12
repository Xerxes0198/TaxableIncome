// <copyright file="BudgetRepairCalculator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces;

using Constants.TaxConstants;

/// <summary>
/// This class holds budget repair levy functions.
/// </summary>
public static class BudgetRepairCalculator
{
    /// <summary>
    /// Get the calulated bedugte repair levy payments from an income for the financial year 2018.
    /// </summary>
    /// <param name="income">The income.</param>
    /// <returns>The calculated return.</returns>
    public static decimal Get2018BudgetRepairLevy(decimal income)
    {
        if (income < FinancialYear2018Constants.BudgetRepairLevyCutoff)
        {
            return 0.00M;
        }

        // Everything else is 2% of the excess over Budget Repair Levy Cutoff
        return decimal.Ceiling(income - FinancialYear2018Constants.BudgetRepairLevyCutoff) * FinancialYear2018Constants.BudgetRepairLevyPercntage;
    }
}