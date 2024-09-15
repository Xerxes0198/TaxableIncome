[![Build and Test](https://github.com/Xerxes0198/TaxableIncome/actions/workflows/CI_BuildandTest.yml/badge.svg)](https://github.com/Xerxes0198/TaxableIncome/actions/workflows/CI_BuildandTest.yml)
# Taxable Income
Taxable Income Calculator Solution.

# Assumptions
- Examples provided seemed to be for FY 2018. Current application works for 2018. There are plans to make this generic for different years.
- Current pay frequencies are for exactly 52 weeks, 26 fortnights and 12 months, no consideration for leap years or custom pay frequencies.

# Proposed High-Level Sequence Diagram
- Orchestrator: Takes in the request and orchestrates calling different services in the solution.
- Input Collection: Responsible for handling all input collection from the user, which can be specific to the orchestrator's mode.
- Input Validation: Responsible for handling all input validation, separated from input collection as this validator could expand to handle different data in different scenarios.
- Calculations Query: Responsible for processing a request from the calling orchestrator, which can be specific to the orchestrator's mode. 
![image](https://github.com/user-attachments/assets/9c690217-7079-4351-8fcf-0ba2f5c369ee)

# Component Design Considerations and Reasons

All of the components in the Taxable Income solution have been designed with expansion in mind. The separation of responsibilities ensures we can maintain and expand each component separately, which creates:
- Cleaner and smaller PRs.
- Code changes impact a smaller area, creating more meaningful reviews.
- Code which is Unit Test friendly.
- Validation and Query execution can be easily decoupled from a console application and used in an API, or other use-case.
- Calculators can be made generic and registered with a service container, for DI when generics are introduced.

# Proposed Future Enhancements

- Add additional financial years
The orchestrator can be expanded to perform calculations from any financial year with known values, for instance: retrospectively calculating taxable incomes for previous years. It can also lean on the input validator and calculations command to validate and calculate specific rules depending on the desired year.

- Make the query calculator generic for selected financial year.

- Custom input types for the pay frequency and income fields. (Make them more tolerant to strange inputs.)

- Input Collection Expansion
Depending on the specific needs per year, the orchestrator can request additional - or fewer - inputs from the input collection.

- Inpupt Validation Expansion
The input validator can be expanded to dynamically handle differing inputs, like custom strings for currency formats. It can also be made to be generic with the calculators to ensure it only validates values it is given against values required for the current financial year selected.
