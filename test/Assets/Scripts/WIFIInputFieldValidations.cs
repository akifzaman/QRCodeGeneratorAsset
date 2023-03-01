using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

public class WIFIInputFieldValidations : MonoBehaviour
{
    public List<TMP_InputField> InputFields; // Reference to the InputField component

    [SerializeField] private bool isFormInputFieldOkay = true;
    // Regex pattern for validating
    //private string ssidPattern = @"^[a-zA-Z0-9_-]{1,32}$";
    private string ssidPattern = @"^[a-zA-Z0-9_$@-]{1,32}$";
    private string networkPattern = @"^(WPA|WEP|No Encryption)$";
    private string passwordPattern = @"^[a-zA-Z0-9_$@-]{1,32}$";
    private string hiddenPattern = @"^(true|false)$";
    public List<string> RegularExpressions;

    public void Start()
    {
        RegularExpressions.Add(ssidPattern);
        RegularExpressions.Add(networkPattern);
        RegularExpressions.Add(passwordPattern);
        RegularExpressions.Add(hiddenPattern);
    }
    public void ValidateInputFields()
    {
        for (int i = 0; i < InputFields.Count; i++)
        {
            string ss = Regex.Replace(InputFields[i].text, @"\s", "");
            isFormInputFieldOkay = (isFormInputFieldOkay) && Regex.IsMatch(ss, RegularExpressions[i]);
            if (!isFormInputFieldOkay) break;
        }
        if (isFormInputFieldOkay) UIManager.Instance.isFormValid = true;
        isFormInputFieldOkay = true;
    }
}
