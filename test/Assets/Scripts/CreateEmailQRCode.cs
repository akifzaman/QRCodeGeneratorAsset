using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreateEmailQRCode : CreateQRCode
{
    public TMP_InputField EmailAddressInputField;
    void Start()
    {
        GenerateText();
        GenerateQROutput();
    }

    public override string GenerateText()
    {
        if (EmailAddressInputField.text != null) Lastresult += ("mailto:" + EmailAddressInputField.text);
        Debug.Log(Lastresult);
        return Lastresult;
    }
}
