// <copyright file="IncomeQueryTests.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using TaxableIncome.Application.Enums;

namespace TaxableIncome.Application.UnitTests.Interfaces.IncomeTaxQuery;

using TaxableIncome.Application.Interfaces.IncomeTaxQuery;

/// <summary>
/// Tests for <see cref="IncomeQuery"/>.
/// </summary>
public class IncomeQueryTests : BaseUnitTests
{
    /// <summary>
    /// Assembles a request and checks that the expected response is returned.
    /// Example data pulled from supplied assignment sheet.
    /// </summary>
    [Fact]
    public void IncomeQuery_Execute_ReturnsExpectedResponse()
    {
        var request = new IncomeQueryRequest(65000M, PayFrequency.Monthly);

        var response = this.IncomeQuery.Execute(request);

        Assert.Equal(5639.27M, response.SuperContribution);

        Assert.Equal(true, response.MedicareLevyChargeRequired);
        Assert.Equal(1188.00M, response.MedicareLevy);
    }
}