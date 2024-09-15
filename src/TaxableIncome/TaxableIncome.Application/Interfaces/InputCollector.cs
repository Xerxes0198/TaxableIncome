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
    /// Collect the inputs for the financial year 2018.
    /// </summary>
    /// <returns>Returns a <see cref="FinancialYearBaseInputModel"/> for the year 2018.</returns>
    public FinancialYear2018InputModel Get2018Inputs()
    {
        var financialYear2018InputModel = new FinancialYear2018InputModel();

        Console.Write(InputConstants.IncomeInputMessage);
        financialYear2018InputModel.ProvidedIncomeString = Console.ReadLine() ?? string.Empty;

        Console.Write(InputConstants.PayCycleInputMessage);
        financialYear2018InputModel.ProvidedPayFrequencyString = Console.ReadLine() ?? string.Empty;

        return financialYear2018InputModel;
    }
}