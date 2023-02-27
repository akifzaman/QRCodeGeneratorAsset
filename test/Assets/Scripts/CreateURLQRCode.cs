using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreateURLQRCode : CreateQRCode
{
    public TMP_InputField URLInputField;
    void Start()
    {
        GenerateText();
        GenerateQROutput();
    }

    public override string GenerateText()
    {
        Lastresult += ("http://" + URLInputField.text);
        Debug.Log(Lastresult);
        return Lastresult;
    }
}
