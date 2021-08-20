namespace Going.Plaid.Link;

/// <summary>
/// <para>LinkTokenCreateRequest defines the request schema for <c>/link/token/create</c></para>
/// </summary>
public class LinkTokenCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The name of your application, as it should be displayed in Link. Maximum length of 30 characters.</para>
	/// </summary>
	[JsonPropertyName("client_name")]
	public string ClientName { get; set; } = default!;

	/// <summary>
	/// <para>The language that Link should be displayed in.</para>
	/// <para>When using a Link customization, the language configured here must match the setting in the customization, or the customization will not be applied.</para>
	/// </summary>
	[JsonPropertyName("language")]
	public Entity.Language Language { get; set; } = default!;

	/// <summary>
	/// <para>Specify an array of Plaid-supported country codes using the ISO-3166-1 alpha-2 country code standard. Institutions from all listed countries will be shown.  Supported country codes are: <c>US</c>, <c>CA</c>, <c>ES</c>, <c>FR</c>, <c>GB</c>, <c>IE</c>, <c>NL</c>. Example value: <c>['US', 'CA']</c>.</para>
	/// <para>If Link is launched with multiple country codes, only products that you are enabled for in all countries will be used by Link. Note that while all countries are enabled by default in Sandbox and Development, in Production only US and Canada are enabled by default. To gain access to European institutions in the Production environment, <a href="https://dashboard.plaid.com/support/new/product-and-development/product-troubleshooting/request-product-access">file a product access Support ticket</a> via the Plaid dashboard. If you initialize with a European country code, your users will see the European consent panel during the Link flow.</para>
	/// <para>If using a Link customization, make sure the country codes in the customization match those specified in <c>country_codes</c>. If both <c>country_codes</c> and a Link customization are used, the value in <c>country_codes</c> may override the value in the customization.</para>
	/// <para>If using the Auth features Instant Match, Same-day Micro-deposits, or Automated Micro-deposits, <c>country_codes</c> must be set to <c>['US']</c>.</para>
	/// </summary>
	[JsonPropertyName("country_codes")]
	public IReadOnlyList<Entity.CountryCode> CountryCodes { get; set; } = default!;

	/// <summary>
	/// <para>An object specifying information about the end user who will be linking their account.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.LinkTokenCreateRequestUser User { get; set; } = default!;

	/// <summary>
	/// <para>List of Plaid product(s) you wish to use. If launching Link in update mode, should be omitted; required otherwise. Valid products are:</para>
	/// <para><c>transactions</c>, <c>auth</c>, <c>identity</c>, <c>assets</c>, <c>investments</c>, <c>liabilities</c>, <c>payment_initiation</c>, <c>deposit_switch</c>, <c>income_verification</c></para>
	/// <para>Example: <c>['auth', 'transactions']</c></para>
	/// <para><c>balance</c> is *not* a valid value, the Balance product does not require explicit initalization and will automatically be initialized when any other product is initialized.</para>
	/// <para>Only institutions that support *all* requested products will be shown in Link; to maximize the number of institutions listed, it is recommended to initialize Link with the minimal product set required for your use case. Additional products can be added after Link initialization by calling the relevant endpoints. For details and exceptions, see <a href="https://plaid.com/docs/link/best-practices/#choosing-when-to-initialize-products">Choosing when to initialize products</a>.</para>
	/// <para>Note that, unless you have opted to disable Instant Match support, institutions that support Instant Match will also be shown in Link if <c>auth</c> is specified as a product, even though these institutions do not contain <c>auth</c> in their product array.</para>
	/// <para>In Production, you will be billed for each product that you specify when initializing Link. Note that a product cannot be removed from an Item once the Item has been initialized with that product. To stop billing on an Item for subscription-based products, such as Liabilities, Investments, and Transactions, remove the Item via <c>/item/remove</c>.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products> Products { get; set; } = default!;

	/// <summary>
	/// <para>The destination URL to which any webhooks should be sent.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

	/// <summary>
	/// <para>The name of the Link customization from the Plaid Dashboard to be applied to Link. If not specified, the <c>default</c> customization will be used. When using a Link customization, the language in the customization must match the language selected via the <c>language</c> parameter, and the countries in the customization should match the country codes selected via <c>country_codes</c>.</para>
	/// </summary>
	[JsonPropertyName("link_customization_name")]
	public string LinkCustomizationName { get; set; } = default!;

	/// <summary>
	/// <para>A URI indicating the destination where a user should be forwarded after completing the Link flow; used to support OAuth authentication flows when launching Link in the browser or via a webview. The <c>redirect_uri</c> should not contain any query parameters. When used in Production or Development, must be an https URI. To specify any subdomain, use <c>*</c> as a wildcard character, e.g. <c>https://*.example.com/oauth.html</c>. If <c>android_package_name</c> is specified, this field should be left blank.  Note that any redirect URI must also be added to the Allowed redirect URIs list in the <a href="https://dashboard.plaid.com/team/api">developer dashboard</a>.</para>
	/// </summary>
	[JsonPropertyName("redirect_uri")]
	public string RedirectUri { get; set; } = default!;

	/// <summary>
	/// <para>The name of your app's Android package. Required if using the <c>link_token</c> to initialize Link on Android. When creating a <c>link_token</c> for initializing Link on other platforms, this field must be left blank. Any package name specified here must also be added to the Allowed Android package names setting on the <a href="https://dashboard.plaid.com/team/api">developer dashboard</a>.</para>
	/// </summary>
	[JsonPropertyName("android_package_name")]
	public string AndroidPackageName { get; set; } = default!;

	/// <summary>
	/// <para>By default, Link will provide limited account filtering: it will only display Institutions that are compatible with all products supplied in the <c>products</c> parameter of <c>/link/token/create</c>, and, if <c>auth</c> is specified in the <c>products</c> array, will also filter out accounts other than <c>checking</c> and <c>savings</c> accounts on the Account Select pane. You can further limit the accounts shown in Link by using <c>account_filters</c> to specify the account subtypes to be shown in Link. Only the specified subtypes will be shown. This filtering applies to both the Account Select view (if enabled) and the Institution Select view. Institutions that do not support the selected subtypes will be omitted from Link. To indicate that all subtypes should be shown, use the value <c>"all"</c>. If the <c>account_filters</c> filter is used, any account type for which a filter is not specified will be entirely omitted from Link. For a full list of valid types and subtypes, see the <a href="https://plaid.com/docs/api/accounts#accounts-schema">Account schema</a>.</para>
	/// <para>For institutions using OAuth, the filter will not affect the list of accounts shown by the bank in the OAuth window.</para>
	/// </summary>
	[JsonPropertyName("account_filters")]
	public Entity.LinkTokenAccountFilters AccountFilters { get; set; } = default!;

	/// <summary>
	/// <para>Configuration parameters for EU flows</para>
	/// </summary>
	[JsonPropertyName("eu_config")]
	public Entity.LinkTokenEUConfig EuConfig { get; set; } = default!;

	/// <summary>
	/// <para>Used for certain Europe-only configurations, as well as certain legacy use cases in other regions.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Payment Initiation (Europe) product. This field is required if <c>payment_initiation</c> is included in the <c>products</c> array.</para>
	/// </summary>
	[JsonPropertyName("payment_initiation")]
	public Entity.LinkTokenCreateRequestPaymentInitiation PaymentInitiation { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Deposit Switch (beta) product. This field is required if <c>deposit_switch</c> is included in the <c>products</c> array.</para>
	/// </summary>
	[JsonPropertyName("deposit_switch")]
	public Entity.LinkTokenCreateRequestDepositSwitch DepositSwitch { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Income (beta) product. This field is required if <c>income_verification</c> is included in the <c>products</c> array.</para>
	/// </summary>
	[JsonPropertyName("income_verification")]
	public Entity.LinkTokenCreateRequestIncomeVerification IncomeVerification { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Auth product. This field is currently only required if using the Flexible Auth product (currently in closed beta).</para>
	/// </summary>
	[JsonPropertyName("auth")]
	public Entity.LinkTokenCreateRequestAuth Auth { get; set; } = default!;
}