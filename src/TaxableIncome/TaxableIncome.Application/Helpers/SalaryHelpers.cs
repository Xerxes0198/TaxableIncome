// <copyright file="SalaryHelpers.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Helpers;

using Constants;

/// <summary>
/// A helper class for salary functions.
/// </summary>
public static class SalaryHelpers
{
    /// <summary>
    /// Round a value to the nearest cent.
    /// </summary>
    /// <param name="decimalValue">The value to round.</param>
    /// <returns>The rounded decimal figure.</returns>
    public static decimal RoundToCent(this decimal decimalValue)
    {
        return Math.Round(decimalValue, CurrencyConstants.NearestCentDecimalPlace);
    }
}