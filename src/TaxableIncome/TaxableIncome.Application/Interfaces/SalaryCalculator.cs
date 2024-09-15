// <copyright file="SalaryCalculator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces;

using Helpers;
using Constants.TaxConstants;

/// <summary>
/// This class is the super calculator, not to be confused with a super calculator.
/// </summary>
public class SalaryCalculator
{
    /// <summary>
    /// Get the salary minus the super contribution for financial year 2018. Rounded to the second decimal place.
    /// </summary>
    /// <param name="totalPackage">The total package.</param>
    /// <returns>The calculated salary exclusive of suer contributions, from a total package.</returns>
    public decimal GetSalaryFromPackage(decimal totalPackage)
    {
        // Salary is always 1 + super percentage for that year.
        return (totalPackage / (1 + FinancialYear2018Constants.SuperPercentage)).RoundToCent();
    }
}
