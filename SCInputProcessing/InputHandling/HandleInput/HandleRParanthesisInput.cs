using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class HandleRParanthesisInput
    {
        public void HandleInput(List<string> inputSequence)
        {
            int sLength = inputSequence.Count;

            if (inputSequence[sLength - 2] == ")")
            {
                inputSequence[sLength-1] += ")";
                inputSequence.Add("");
            }
            else
            {
                inputSequence.Add(")");
                inputSequence.Add("");
            }
        }

        public bool CanHandle(List<string> inputSequence, List<string> binaryOperators)
        {
            int lParantheses = 0;
            int rParantheses = 0;
            int sLength = inputSequence.Count;

            foreach(string input in inputSequence)
            {
                if (input == "(" || input == "-(")
                    lParantheses++;
                if (input == ")")
                    rParantheses++;
            }

            if (rParantheses >= lParantheses)
                return false;

            if (sLength > 1)
                if (inputSequence[sLength - 1] == "" && inputSequence[sLength - 2] != ")")
                    return false;
            if (sLength > 1)
                if (inputSequence[sLength - 1] == "-" && (inputSequence[sLength - 2] == "(" || binaryOperators.Contains(inputSequence[sLength - 2])))
                    return false;

            return true;
        }
    }
}
