// <copyright file="FinancialYearBaseInputModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace TaxableIncome.Application.FinancialYearModels;

/// <summary>
/// This is the abstract input model for all financial years.
/// </summary>
public abstract class FinancialYearBaseInputModel
{
    private List<(Type inputType, string inputValue, string inputDesscription, bool validValue)> userInputs = new List<(Type inputType, string inputValue, string inputName, bool validValue)>();

    /// <summary>
    /// Initializes a new instance of the <see cref="FinancialYearBaseInputModel"/> class.
    /// </summary>
    protected FinancialYearBaseInputModel()
    {
        this.userInputs.Add((typeof(decimal), this.ProvidedIncomeString, "Gross Income", false));
        this.userInputs.Add((typeof(decimal), this.PayFrequencyString, "Payment Cycle (Day, Week, Month, Year)", false));
    }

    /// <summary>
    /// Gets the user inputs defined for this financial year input.
    /// </summary>
    public List<(Type inputType, string inputValue, string inputDescription, bool validValue)> GetUserInputs => this.userInputs;

    /// <summary>
    /// Gets or sets the user provided string for income.
    /// </summary>
    public string ProvidedIncomeString { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the user provided string for pay frequency.
    /// </summary>
    public string PayFrequencyString { get; set; } = string.Empty;
}