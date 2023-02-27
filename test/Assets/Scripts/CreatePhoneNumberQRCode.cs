using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CreatePhoneNumberQRCode : CreateQRCode
{
    public TMP_InputField PhoneNumberInputField;
    void Start()
    {
        GenerateText();
        GenerateQROutput();
    }

    public override string GenerateText()
    {
        Lastresult += ("tel:" + PhoneNumberInputField.text);
        Debug.Log(Lastresult);
        return Lastresult;
    }
}
