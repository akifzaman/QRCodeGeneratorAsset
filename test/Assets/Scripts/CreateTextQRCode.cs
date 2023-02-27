using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreateTextQRCode : CreateQRCode
{
    public TMP_InputField TextInputField;
    public void GenerateTextToConvert()
    {
        GenerateText();
    }
    public override string GenerateText()
    {
        Lastresult += TextInputField.text;
        Debug.Log(Lastresult);
        return Lastresult;
    }
}
