namespace Going.Plaid.Entity;

/// <summary>
/// <para>A list of add-ons that should be included in the Asset Report.</para>
/// </summary>
public enum AssetReportAddOns
{
	/// <summary>
	/// <para>Request an Asset Report with Investments. This add-on is in closed beta and not generally available.</para>
	/// </summary>
	[EnumMember(Value = "investments")]
	Investments,

	/// <summary>
	/// <para>When Fast Assets is requested, Plaid will create two versions of the Asset Report: the Fast Asset Report, which will contain only Identity and Balance information, and the Full Asset Report, which will also contain Transactions information. A <c>PRODUCT_READY</c> webhook will be fired for each Asset Report when it is ready, and the <c>report_type</c> field will indicate whether the webhook is firing for the <c>full</c> or <c>fast</c> Asset Report. To retrieve the Fast Asset Report, call <c>/asset_report/get</c> with <c>fast_report</c> set to <c>true</c>. There is no additional charge for using Fast Assets.</para>
	/// </summary>
	[EnumMember(Value = "fast_assets")]
	FastAssets,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}