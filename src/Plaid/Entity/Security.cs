namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains details about a security</para>
/// </summary>
public record Security
{
	/// <summary>
	/// <para>A unique, Plaid-specific identifier for the security, used to associate securities with holdings. Like all Plaid identifiers, the <c>security_id</c> is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("security_id")]
	public string SecurityId { get; init; } = default!;

	/// <summary>
	/// <para>12-character ISIN, a globally unique securities identifier.</para>
	/// </summary>
	[JsonPropertyName("isin")]
	public string? Isin { get; init; } = default!;

	/// <summary>
	/// <para>9-character CUSIP, an identifier assigned to North American securities.</para>
	/// </summary>
	[JsonPropertyName("cusip")]
	public string? Cusip { get; init; } = default!;

	/// <summary>
	/// <para>7-character SEDOL, an identifier assigned to securities in the UK.</para>
	/// </summary>
	[JsonPropertyName("sedol")]
	public string? Sedol { get; init; } = default!;

	/// <summary>
	/// <para>An identifier given to the security by the institution</para>
	/// </summary>
	[JsonPropertyName("institution_security_id")]
	public string? InstitutionSecurityId { get; init; } = default!;

	/// <summary>
	/// <para>If <c>institution_security_id</c> is present, this field indicates the Plaid <c>institution_id</c> of the institution to whom the identifier belongs.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string? InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>In certain cases, Plaid will provide the ID of another security whose performance resembles this security, typically when the original security has low volume, or when a private security can be modeled with a publicly traded security.</para>
	/// </summary>
	[JsonPropertyName("proxy_security_id")]
	public string? ProxySecurityId { get; init; } = default!;

	/// <summary>
	/// <para>A descriptive name for the security, suitable for display.</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string? Name { get; init; } = default!;

	/// <summary>
	/// <para>The security’s trading symbol for publicly traded securities, and otherwise a short identifier if available.</para>
	/// </summary>
	[JsonPropertyName("ticker_symbol")]
	public string? TickerSymbol { get; init; } = default!;

	/// <summary>
	/// <para>Indicates that a security is a highly liquid asset and can be treated like cash.</para>
	/// </summary>
	[JsonPropertyName("is_cash_equivalent")]
	public bool? IsCashEquivalent { get; init; } = default!;

	/// <summary>
	/// <para>The security type of the holding. Valid security types are:</para>
	/// <para><c>cash</c>: Cash, currency, and money market funds</para>
	/// <para><c>derivative</c>: Options, warrants, and other derivative instruments</para>
	/// <para><c>equity</c>: Domestic and foreign equities</para>
	/// <para><c>etf</c>: Multi-asset exchange-traded investment funds</para>
	/// <para><c>fixed income</c>: Bonds and certificates of deposit (CDs)</para>
	/// <para><c>loan</c>: Loans and loan receivables.</para>
	/// <para><c>mutual fund</c>: Open- and closed-end vehicles pooling funds of multiple investors.</para>
	/// <para><c>other</c>: Unknown or other investment types</para>
	/// </summary>
	[JsonPropertyName("type")]
	public string? Type { get; init; } = default!;

	/// <summary>
	/// <para>Price of the security at the close of the previous trading session. <c>null</c> for non-public securities. If the security is a foreign currency or a cryptocurrency this field will be updated daily and will be priced in USD.</para>
	/// </summary>
	[JsonPropertyName("close_price")]
	public decimal? ClosePrice { get; init; } = default!;

	/// <summary>
	/// <para>Date for which <c>close_price</c> is accurate. Always <c>null</c> if <c>close_price</c> is <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("close_price_as_of")]
	public DateOnly? ClosePriceAsOf { get; init; } = default!;

	/// <summary>
	/// <para>The ISO-4217 currency code of the price given. Always <c>null</c> if <c>unofficial_currency_code</c> is non-<c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public string? IsoCurrencyCode { get; init; } = default!;

	/// <summary>
	/// <para>The unofficial currency code associated with the security. Always <c>null</c> if <c>iso_currency_code</c> is non-<c>null</c>. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</para>
	/// <para>See the <a href="https://plaid.com/docs/api/accounts#currency-code-schema">currency code schema</a> for a full listing of supported <c>iso_currency_code</c>s.</para>
	/// </summary>
	[JsonPropertyName("unofficial_currency_code")]
	public string? UnofficialCurrencyCode { get; init; } = default!;
}