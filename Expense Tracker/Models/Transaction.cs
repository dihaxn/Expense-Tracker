using System;

public class Transaction
{
	[key]
	public int TransactionId { get; set; }

	//CategoryId

	public int Amount { get; set; }
	public string? Note { get; set; }
	public int MyProperty { get; set; }

}
