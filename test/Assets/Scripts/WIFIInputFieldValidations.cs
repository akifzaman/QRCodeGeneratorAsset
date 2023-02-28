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
    private string ssidPattern = @"^[a-zA-Z0-9_-]{1,32}$";
    private string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$";

    public void ValidateInputFields()
    {
        foreach (var input in InputFields)
        {
            isFormInputFieldOkay = (isFormInputFieldOkay) && Validate(input.text);
        }
        if (isFormInputFieldOkay) UIManager.Instance.isFormValid = true;
        isFormInputFieldOkay = true;
    }
    public bool Validate(string input)
    {
        if (Regex.IsMatch(input, ssidPattern))
        {
            return true;
        }
        else if (Regex.IsMatch(input, passwordPattern))
        {
            return true;
        }
        else if (input != null)
        {
            return true;
        }
        return false;
    }
}
