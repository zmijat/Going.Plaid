namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Create a new Identity Verification for the user specified by the <c>client_user_id</c> field. The requirements and behavior of the verification are determined by the <c>template_id</c> provided.</para>
	/// <para>If you don't know whether the associated user already has an active Identity Verification, you can specify <c>"is_idempotent": true</c> in the request body. With idempotency enabled, a new Identity Verification will only be created if one does not already exist for the associated <c>client_user_id</c> and <c>template_id</c>. If an Identity Verification is found, it will be returned unmodified with an <c>200 OK</c> HTTP status code.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/identity-verification/identity_verificationcreate" /></remarks>
	public Task<Entity.IdentityVerification> IdentityVerificationCreateAsync(IdentityVerification.IdentityVerificationCreateRequest request) =>
		PostAsync("/identity_verification/create", request)
			.ParseResponseAsync<Entity.IdentityVerification>();

	/// <summary>
	/// <para>Retrieve a previously created identity verification</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/identity-verification/identity_verificationget" /></remarks>
	public Task<Entity.IdentityVerification> IdentityVerificationGetAsync(IdentityVerification.GetIdentityVerificationRequest request) =>
		PostAsync("/identity_verification/get", request)
			.ParseResponseAsync<Entity.IdentityVerification>();

	/// <summary>
	/// <para>Filter and list Identity Verifications created by your account</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/monitor/dashboard_userget" /></remarks>
	public Task<Entity.PaginatedIdentityVerificationPaginatedList> IdentityVerificationListAsync(IdentityVerification.ListIdentityVerificationRequest request) =>
		PostAsync("/identity_verification/list", request)
			.ParseResponseAsync<Entity.PaginatedIdentityVerificationPaginatedList>();

	/// <summary>
	/// <para>Allow a customer to retry their identity verification</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/identity-verification/identity_verificationretry" /></remarks>
	public Task<Entity.IdentityVerification> IdentityVerificationRetryAsync(IdentityVerification.IdentityVerificationRetryRequest request) =>
		PostAsync("/identity_verification/retry", request)
			.ParseResponseAsync<Entity.IdentityVerification>();
}