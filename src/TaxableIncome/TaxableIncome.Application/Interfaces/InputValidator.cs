// <copyright file="InputValidator.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces;

using FinancialYearModels;
using Classes;
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

        try
        {
            return decimal.Parse(filteredString, CultureInfo.CurrentCulture);
        }
        catch
        {
            // Todo: Do something meaningful with the exception, instead of swallowing.
            throw new ArgumentException("Income was not an expected format.");
        }
    }

    /// <summary>
    /// Attempts to take an inpput string and return a valid pay frequency.
    /// </summary>
    /// <param name="userInput">The provided input.</param>
    /// <returns>A valid pay frequency.</returns>
    public PayFrequency ValidatePayFrequency(string userInput)
    {
        var firstCharacter = userInput.ToLower().First();
        return PayFrequencyExtensions.CharacterToPayCycle(firstCharacter);
    }

    /// <summary>
    /// Takes in a <see cref="FinancialYearBaseInputModel"/> and validates all given user inputs against its defined type.
    /// </summary>
    /// <param name="model">The input model to validate.</param>
    /// <returns>Whether the model is valid.</returns>
    public bool ValidateInputModel(FinancialYearBaseInputModel model)
    {
        try
        {
            model.ValidatedIncome = this.StrippedCurrencyString(model.ProvidedIncomeString);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }

        try
        {
            model.ValidatedPayFrequency = this.ValidatePayFrequency(model.ProvidedPayFrequencyString);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return false;
        }

        return true;
    }
}