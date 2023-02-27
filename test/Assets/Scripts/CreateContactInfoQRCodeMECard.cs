using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateContactInfoQRCodeMECard : CreateQRCode
{
    public List<string> Tags = new List<string>{"N:", "ORG:", "TEL:", "URL:", "EMAIL:", "ADR:", "NOTE:"};
   
    void Start()
    {
        GenerateText();
        GenerateQROutput();
    }

    public override string GenerateText()
    {
        Lastresult += "MECARD:";
        for (int i = 0; i < inputFields.Count; i++)
        {
            if (inputFields[i].text != null)
            {
                Lastresult += (Tags[i] + inputFields[i].text + ";");
            }
        }
        Lastresult += ";";
        Debug.Log(Lastresult);
        return Lastresult;
    }
}
