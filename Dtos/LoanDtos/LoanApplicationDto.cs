﻿namespace EmployeeLoans.Api.Dtos.LoanDtos;

public record LoanApplicationDto
(
    Guid Id,
    decimal LoanAmount,
    string LoanPurpose,
    DateTime ApplicationDate,
    decimal MonthlyDeductionAmount
);