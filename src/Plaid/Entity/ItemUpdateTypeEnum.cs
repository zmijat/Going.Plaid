namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicates whether an Item requires user interaction to be updated, which can be the case for Items with some forms of two-factor authentication.</para>
/// </summary>
public enum ItemUpdateTypeEnum
{
	/// <summary>
	/// <para>Item can be updated in the background</para>
	/// </summary>
	[EnumMember(Value = "background")]
	Background,

	/// <summary>
	/// <para>Item requires user interaction to be updated</para>
	/// </summary>
	[EnumMember(Value = "user_present_required")]
	UserPresentRequired,
}