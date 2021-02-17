namespace fw_poc.Abstractions.Sender
{
	interface IUser
	{
		string UserIdentifier { get; }
		string Name { get; }
	}

	interface IRocketDefinition
	{
	}
	
	


	interface IRocket
	{
		IUser Sender { get; }

		string RocketIdentifier { get; }

	}
}
