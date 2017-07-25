using System;
using System.Collections;

namespace TextMatch
{
	class MainClass
	{
		public static void Main(string[] args)
		{
            
	        //"Polly put the kettle on, polly put the kettle on, polly put the kettle on we’ll all have tea"
            //for debugging purposes

            //Only accept 2 input arguments
			if (args.Length != 2)
			{
				Console.Write("provide 2 arguments only");
                return;
			}


			ArrayList matchIndices = textMatches(args[0], args[1]);

            if (matchIndices.Count == 0)
			{
				Console.Write("There is no output");
			}
			else
                foreach (int i in matchIndices)
				{
                if (i ==  (int)matchIndices[matchIndices.Count-1]){
                        Console.Write(i);
                    }
                else{
                    Console.Write(i+",");
                }
				}
		}



	
		public static ArrayList textMatches(String Text, String subText)
		{

			Boolean doesMatch;
			ArrayList textPositionList = new ArrayList(); //ArrayList to hold position values 
            int matchStartIndex;

			Text = Text.ToLower(); 
            subText = subText.ToLower(); //convert both strings to lower case to allow matching

           // char[] subArray = subText.ToCharArray(); not required
           // char[] textArray = Text.ToCharArray();


            if (Text == subText){
                textPositionList.Add(1);
                return textPositionList;
            }


			for (int i = 0; i < Text.Length; i++)
			{
				doesMatch = true; //default matching state is true
                matchStartIndex = 0;

                //Iterate through both strings, if they match add starting point of match to list
				for (int k = 0; k < subText.Length; k++)
				{     
					if (subText[k] == Text[i + k])
					{
                        matchStartIndex = i;
						//continue;
					}
					else
					{
						doesMatch = false;
						break; //escape inner loop
					}
				}
				if (doesMatch)
					textPositionList.Add(matchStartIndex + 1); //+1 because initial index is 0

			}
            //return list of positions
			return textPositionList;
		}

	}


}
