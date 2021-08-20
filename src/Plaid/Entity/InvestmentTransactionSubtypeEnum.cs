namespace Going.Plaid.Entity;

/// <summary>
/// <para>For descriptions of possible transaction subtypes, see [Investment transaction subtypes schema](https://plaid.com/docs/api/accounts/#investment-transaction-subtypes-schema).</para>
/// </summary>
public enum InvestmentTransactionSubtypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "account fee")]
	AccountFee,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "assignment")]
	Assignment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "buy")]
	Buy,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "buy to cover")]
	BuyToCover,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "contribution")]
	Contribution,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "deposit")]
	Deposit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "distribution")]
	Distribution,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "dividend")]
	Dividend,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "dividend reinvestment")]
	DividendReinvestment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "exercise")]
	Exercise,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "expire")]
	Expire,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "fund fee")]
	FundFee,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "interest")]
	Interest,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "interest receivable")]
	InterestReceivable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "interest reinvestment")]
	InterestReinvestment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "legal fee")]
	LegalFee,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "loan payment")]
	LoanPayment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "long-term capital gain")]
	LongTermCapitalGain,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "long-term capital gain reinvestment")]
	LongTermCapitalGainReinvestment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "management fee")]
	ManagementFee,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "margin expense")]
	MarginExpense,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "merger")]
	Merger,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "miscellaneous fee")]
	MiscellaneousFee,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "non-qualified dividend")]
	NonQualifiedDividend,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "non-resident tax")]
	NonResidentTax,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pending credit")]
	PendingCredit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pending debit")]
	PendingDebit,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "qualified dividend")]
	QualifiedDividend,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "rebalance")]
	Rebalance,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "return of principal")]
	ReturnOfPrincipal,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sell")]
	Sell,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "sell short")]
	SellShort,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "short-term capital gain")]
	ShortTermCapitalGain,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "short-term capital gain reinvestment")]
	ShortTermCapitalGainReinvestment,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "spin off")]
	SpinOff,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "split")]
	Split,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "stock distribution")]
	StockDistribution,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "tax")]
	Tax,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "tax withheld")]
	TaxWithheld,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "transfer")]
	Transfer,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "transfer fee")]
	TransferFee,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "trust fee")]
	TrustFee,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "unqualified gain")]
	UnqualifiedGain,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "withdrawal")]
	Withdrawal,
}