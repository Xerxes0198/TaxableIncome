// <copyright file="InputValidator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces;

using FinancialYearModels;
using System.Text.RegularExpressions;
using Constants;
using System.Globalization;

/// <summary>
/// This class is used to handle all input validation.
/// </summary>
public class InputValidator
{
    /// <summary>
    /// Take in a string and return the float value without any formatting.
    /// Attempts to strip any of the formatting a user may put on a number, like dollar signs, commas, so on.
    /// </summary>
    /// <param name="inputString">A string which may contain a value we wish to convert to a math-friendly value.</param>
    /// <returns>A float value from the input string.</returns>
    public decimal StrippedCurrencyString(string inputString)
    {
        // All decimals \D
        // Greedy *
        // Not . with a negative look behind.
        var filteredString = Regex.Replace(inputString, @"\D*(?<!\.)", string.Empty);

        // If there is more than 1 decimal place, we want to ignore everything past the second one.
        var numberOfDecimals = filteredString.Count(x => x == '.');

        if (numberOfDecimals > InputConstants.AllowedDecimalPoints)
        {
            var indexOfFirstDecimal = filteredString.IndexOf(".", StringComparison.CurrentCultureIgnoreCase);
            var indexOfSecondDecimal = filteredString.IndexOf(".", indexOfFirstDecimal + 1, StringComparison.CurrentCultureIgnoreCase);
            filteredString = filteredString.Substring(0, indexOfSecondDecimal);
        }

        return decimal.Parse(filteredString, CultureInfo.CurrentCulture);
    }

    /// <summary>
    /// Takes in a <see cref="FinancialYearBaseInputModel"/> and validates all given user inputs against its defined type.
    /// </summary>
    /// <param name="model">The input model to validate.</param>
    /// <returns>Whether the model is valid.</returns>
    public bool ValidateInputModel(FinancialYearBaseInputModel model)
    {
        return false;
    }
}