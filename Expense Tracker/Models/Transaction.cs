using System;

public class Transaction
{
	[key]
	public int TransactionId { get; set; }

	public int CategoryId { get; set; }
    
	public int Amount { get; set; }
	
	public string? Note { get; set; }
	
	public int MyProperty { get; set; }

}
