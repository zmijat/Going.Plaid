namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an error is encountered with an Item. The error can be resolved by having the user go through Link’s update mode.</para>
/// </summary>
public record ItemErrorWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Item;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.Error;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;
}