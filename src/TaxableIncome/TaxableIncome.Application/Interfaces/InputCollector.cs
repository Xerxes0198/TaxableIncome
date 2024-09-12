// <copyright file="InputCollector.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.Interfaces;

using Constants;
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
        var financialYear2024InputModel = new FinancialYear2024InputModel();

        Console.Write(InputConstants.IncomeInputMessage);
        financialYear2024InputModel.ProvidedIncomeString = Console.ReadLine() ?? string.Empty;

        Console.Write(InputConstants.PayCycleInputMessage);
        financialYear2024InputModel.ProvidedPayFrequencyString = Console.ReadLine() ?? string.Empty;

        return financialYear2024InputModel;
    }
}