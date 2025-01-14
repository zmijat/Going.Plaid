namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an end user has completed a step of the Identity Verification process.</para>
/// </summary>
public record IdentityVerificationStepUpdatedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.IdentityVerification;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.StepUpdated;

	/// <summary>
	/// <para>The ID of the associated Identity Verification attempt.</para>
	/// </summary>
	[JsonPropertyName("identity_verification_id")]
	public string IdentityVerificationId { get; init; } = default!;
}