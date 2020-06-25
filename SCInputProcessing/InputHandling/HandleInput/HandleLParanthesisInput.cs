using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCInputProcessing.InputHandling
{
    public class HandleLParanthesisInput
    {
        public void HandleInput(List<string> inputSequence)
        {
            int sLength = inputSequence.Count;

            if (inputSequence[0] == "")
            {
                inputSequence[0] += "(";
                inputSequence.Add("");
            }
            else if (inputSequence[sLength - 1] == "" && inputSequence[sLength - 2] != ")")
            {
                inputSequence[sLength - 1] += "(";
                inputSequence.Add("");
            }
            else if (inputSequence[sLength - 1] == "-")
            {
                inputSequence[sLength - 1] += "(";
                inputSequence.Add("");
            }
            else if (inputSequence[sLength - 1] != "")
            {
                inputSequence.Add("x");
                inputSequence.Add("(");
                inputSequence.Add("");
            }else if(inputSequence[sLength - 1] == "" && inputSequence[sLength - 2] == ")")
            {
                inputSequence[sLength - 1] += "x";
                inputSequence.Add("(");
                inputSequence.Add("");
            }
        }

        public bool CanHandle(List<string> inputSequence)
        {
            return true;
        }
    }
}
