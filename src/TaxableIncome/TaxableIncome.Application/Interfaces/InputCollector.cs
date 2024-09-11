// <copyright file="InputCollector.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces;

using FinancialYearModels;

/// <summary>
/// This class is used to handle all input collection.
/// </summary>
public class InputCollector
{
    /// <summary>
    /// Collect the inputs for the financial year 2024.
    /// </summary>
    /// <returns>Returns a <see cref="FinancialYearBaseInputModel"/> for the year 2024.</returns>
    public FinancialYear2024InputModel Get2024Inputs()
    {
        var response = new FinancialYear2024InputModel();

        foreach (var input in response.GetUserInputs)
        {
            Console.Write($"Please enter a value for {input.inputDescription}:");
        }

        return response;
    }
}