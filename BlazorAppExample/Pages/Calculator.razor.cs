@using System.Data
[CascadingParameter] UserStateMemory State { get; set; }

	string zero = "0";

	public void ConsolidateDisplay(char btnpress)
	{	
		string UpdatedContents = string.Concat(State.CalculatorScreen.ToString(), btnpress); ;
		State.CalculatorScreen = double.Parse(UpdatedContents);
	}
	public void ConsolidateDisplay(int x)
	{
		switch(x)
		{
			case 0: //Clear
				State.CalculatorScreen = 0D;
				break;
			case 1: //Add
				State.CalculatorIntermediateVar = State.CalculatorScreen;
				State.CalculatorScreenMini = State.CalculatorScreenMini + State.CalculatorScreen.ToString() + " + ";
				break;
			case 2: //Sub
				State.CalculatorIntermediateVar = State.CalculatorScreen;
				State.CalculatorScreenMini = State.CalculatorScreenMini + State.CalculatorScreen.ToString() + " - ";
				break;
			case 9: //Equals
			State.CalculatorScreen = Convert.ToDouble(new DataTable().Compute(State.CalculatorScreenMini, null));
				break;

		}
		
	}

	public void TypeWriter(int inputChar)
	{

		
	}
