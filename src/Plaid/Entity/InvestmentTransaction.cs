namespace Going.Plaid.Entity;

/// <summary>
/// <para>A transaction within an investment account.</para>
/// </summary>
public record InvestmentTransaction
{
	/// <summary>
	/// <para>The ID of the Investment transaction, unique across all Plaid transactions. Like all Plaid identifiers, the <c>investment_transaction_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("investment_transaction_id")]
	public string InvestmentTransactionId { get; init; } = default!;

	/// <summary>
	/// <para>A legacy field formerly used internally by Plaid to identify certain canceled transactions.</para>
	/// </summary>
	[JsonPropertyName("cancel_transaction_id")]
	public string? CancelTransactionId { get; init; } = default!;

	/// <summary>
	/// <para>The <c>account_id</c> of the account against which this transaction posted.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The <c>security_id</c> to which this transaction is related.</para>
	/// </summary>
	[JsonPropertyName("security_id")]
	public string? SecurityId { get; init; } = default!;

	/// <summary>
	/// <para>The <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> posting date for the transaction.</para>
	/// </summary>
	[JsonPropertyName("date")]
	public DateOnly Date { get; init; } = default!;

	/// <summary>
	/// <para>The institution’s description of the transaction.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; init; } = default!;

	/// <summary>
	/// <para>The number of units of the security involved in this transaction.</para>
	/// </summary>
	[JsonPropertyName("quantity")]
	public decimal Quantity { get; init; } = default!;

	/// <summary>
	/// <para>The complete value of the transaction. Positive values when cash is debited, e.g. purchases of stock; negative values when cash is credited, e.g. sales of stock. Treatment remains the same for cash-only movements unassociated with securities.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public decimal Amount { get; init; } = default!;

	/// <summary>
	/// <para>The price of the security at which this transaction occurred.</para>
	/// </summary>
	[JsonPropertyName("price")]
	public decimal Price { get; init; } = default!;

	/// <summary>
	/// <para>The combined value of all fees applied to this transaction</para>
	/// </summary>
	[JsonPropertyName("fees")]
	public decimal? Fees { get; init; } = default!;

	/// <summary>
	/// <para>Value is one of the following:</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.InvestmentTransactionTypeEnum Type { get; init; } = default!;

	/// <summary>
	/// <para>For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema).</para>
	/// </summary>
	[JsonPropertyName("subtype")]
	public Entity.InvestmentTransactionSubtypeEnum Subtype { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the transaction. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the holding. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>iso_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;
}