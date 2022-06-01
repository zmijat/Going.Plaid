namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Plaid can provide an Audit Copy token of an Asset Report and/or Income Report directly to a participating third party on your behalf. For example, Plaid can supply an Audit Copy token directly to Fannie Mae on your behalf if you participate in the Day 1 Certainty™ program. An Audit Copy token contains the same underlying data as the Asset Report and/or Income Report (result of /credit/payroll_income/get).</para>
	/// <para>To grant access to an Audit Copy token, use the <c>/credit/audit_copy_token/create</c> endpoint to create an <c>audit_copy_token</c> and then pass that token to the third party who needs access. Each third party has its own <c>auditor_id</c>, for example <c>fannie_mae</c>. You’ll need to create a separate Audit Copy for each third party to whom you want to grant access to the Report.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditaudit_copy_tokencreate" /></remarks>
	public Task<Credit.CreditAuditCopyTokenCreateResponse> CreditAuditCopyTokenCreateAsync(Credit.CreditAuditCopyTokenCreateRequest request) =>
		PostAsync("/credit/audit_copy_token/create", request)
			.ParseResponseAsync<Credit.CreditAuditCopyTokenCreateResponse>();

	/// <summary>
	/// <para><c>/credit/bank_income/get</c> returns the bank income report(s) for a specified user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditbank_incomeget" /></remarks>
	public Task<Credit.CreditBankIncomeGetResponse> CreditBankIncomeGetAsync(Credit.CreditBankIncomeGetRequest request) =>
		PostAsync("/credit/bank_income/get", request)
			.ParseResponseAsync<Credit.CreditBankIncomeGetResponse>();

	/// <summary>
	/// <para><c>/credit/bank_income/refresh</c> refreshes the bank income report data for a specific user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditbank_incomerefresh" /></remarks>
	public Task<Credit.CreditBankIncomeRefreshResponse> CreditBankIncomeRefreshAsync(Credit.CreditBankIncomeRefreshRequest request) =>
		PostAsync("/credit/bank_income/refresh", request)
			.ParseResponseAsync<Credit.CreditBankIncomeRefreshResponse>();

	/// <summary>
	/// <para>This endpoint gets payroll income information for a specific user, either as a result of the user connecting to their payroll provider or uploading a pay related document.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditpayroll_incomeget" /></remarks>
	public Task<Credit.CreditPayrollIncomeGetResponse> CreditPayrollIncomeGetAsync(Credit.CreditPayrollIncomeGetRequest request) =>
		PostAsync("/credit/payroll_income/get", request)
			.ParseResponseAsync<Credit.CreditPayrollIncomeGetResponse>();

	/// <summary>
	/// <para><c>/credit/payroll_income/precheck</c> is an optional endpoint that can be called before initializing a Link session for income verification. It evaluates whether a given user is supportable by digital income verification. If the user is eligible for digital verification, that information will be associated with the user token, and in this way will generate a Link UI optimized for the end user and their specific employer. If the user cannot be confirmed as eligible, the user can still use the income verification flow, but they may be required to manually upload a paystub to verify their income.</para>
	/// <para>While all request fields are optional, providing <c>employer</c> data will increase the chance of receiving a useful result.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditpayroll_incomeprecheck" /></remarks>
	public Task<Credit.CreditPayrollIncomePrecheckResponse> CreditPayrollIncomePrecheckAsync(Credit.CreditPayrollIncomePrecheckRequest request) =>
		PostAsync("/credit/payroll_income/precheck", request)
			.ParseResponseAsync<Credit.CreditPayrollIncomePrecheckResponse>();

	/// <summary>
	/// <para><c>/credit/employment/get</c> returns a list of items with employment information from a user's payroll provider that was verified by an end user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditemploymentget" /></remarks>
	public Task<Credit.CreditEmploymentGetResponse> CreditEmploymentGetAsync(Credit.CreditEmploymentGetRequest request) =>
		PostAsync("/credit/employment/get", request)
			.ParseResponseAsync<Credit.CreditEmploymentGetResponse>();

	/// <summary>
	/// <para><c>/credit/payroll_income/refresh</c> refreshes a given digital payroll income verification.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditpayroll_incomerefresh" /></remarks>
	public Task<Credit.CreditPayrollIncomeRefreshResponse> CreditPayrollIncomeRefreshAsync(Credit.CreditPayrollIncomeRefreshRequest request) =>
		PostAsync("/credit/payroll_income/refresh", request)
			.ParseResponseAsync<Credit.CreditPayrollIncomeRefreshResponse>();
}