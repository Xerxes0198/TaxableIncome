// <copyright file="LevyCalculator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces;

using Constants.TaxConstants;

/// <summary>
/// This class holds some basic levy functions.
/// </summary>
public class LevyCalculator
{
    /// <summary>
    /// Get the calulated medicare levy payments from an income for the financial year 2018.
    /// </summary>
    /// <param name="income">The income.</param>
    /// <returns>The calculated return</returns>
    public decimal Get2018Levy(decimal income)
    {
        if (income < FinancialYear2018Constants.MedicareLevyLowExcess)
        {
            return 0.00M;
        }

        if (income >= FinancialYear2018Constants.MedicareLevyHighExcess)
        {
            return decimal.Ceiling(income * FinancialYear2018Constants.MedicareLevyUpperCappedPercentage);
        }

        // Everything else is 10% of the excess over $21,335
        return decimal.Ceiling(income - FinancialYear2018Constants.MedicareLevyExcessReduction) * FinancialYear2018Constants.MedicareLevyMidCappedPercentage;
    }
}