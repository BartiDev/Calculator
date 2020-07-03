using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class HandlePreUnaryOperatorInput
    {
        public void HandleInput(List<string> inputSequence, List<string> preUnaryOperators, string input)
        {
            int sLength = inputSequence.Count;

            if (inputSequence[0] == "")
            {
                inputSequence[0] = input;
                //inputSequence.Add("(");
                inputSequence.Add("");
            }
            else if (inputSequence[sLength - 1] == "" && preUnaryOperators.Contains(inputSequence[sLength - 2]))
            {
                inputSequence[sLength - 1] = "(";
                inputSequence.Add(input);
                inputSequence.Add("");
            }
            else if (inputSequence[sLength - 1] == "-" && preUnaryOperators.Contains(inputSequence[sLength - 2]))
            {
                inputSequence[sLength - 1] = "(";
                inputSequence.Add("0");
                inputSequence.Add("-");
                inputSequence.Add(input);
                inputSequence.Add("");
            }
            else if((inputSequence[sLength - 1] == "-") ||
                (inputSequence[0] == "-" && inputSequence[1] == ""))
            {
                inputSequence[sLength - 1] = "0";
                inputSequence.Add("-");
                inputSequence.Add(input);
                //inputSequence.Add("(");
                inputSequence.Add("");
            }
            else if(inputSequence[sLength-1] != "" ||
                inputSequence[sLength-2]==")")
            {
                inputSequence.Add("x");
                inputSequence.Add(input);
                //inputSequence.Add("(");
                inputSequence.Add("");
            }
            else if((inputSequence.Count > 2 && inputSequence[sLength-1] == "") || 
                (inputSequence[sLength - 1] == "" && inputSequence[sLength - 2] == "("))
            {
                inputSequence[sLength-1] = input;
                //inputSequence.Add("(");
                inputSequence.Add("");
            }

        }

        public bool CanHandle(List<string> inputSequence)
        {
            return true;
        }
    }
}
