namespace Going.Plaid.Webhook;

/// <summary>
/// <para>The webhook of type <c>LIABILITIES</c> and code <c>DEFAULT_UPDATE</c> will be fired when new or updated liabilities have been detected on a liabilities item.</para>
/// </summary>
public record LiabilitiesDefaultUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Liabilities;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.DefaultUpdate;

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

	/// <summary>
	/// <para>An array of <c>account_id</c>'s for accounts that contain new liabilities.'</para>
	/// </summary>
	[JsonPropertyName("account_ids_with_new_liabilities")]
	public IReadOnlyList<string> AccountIdsWithNewLiabilities { get; init; } = default!;

	/// <summary>
	/// <para>An object with keys of <c>account_id</c>'s that are mapped to their respective liabilities fields that changed.</para>
	/// <para>Example: <c>{ "XMBvvyMGQ1UoLbKByoMqH3nXMj84ALSdE5B58": ["past_amount_due"] }</c></para>
	/// </summary>
	[JsonPropertyName("account_ids_with_updated_liabilities")]
	public IReadOnlyDictionary<string, IReadOnlyList<string>> AccountIdsWithUpdatedLiabilities { get; init; } = default!;
}