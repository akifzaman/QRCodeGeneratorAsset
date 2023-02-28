using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class URLInputFieldValidations : MonoBehaviour
{
    public List<TMP_InputField> InputFields; // Reference to the InputField component

    [SerializeField] private bool isFormInputFieldOkay = true;
    // Regex pattern for validating email addresses
    private string urlPattern = @"^(https?://)?(www\.)?([a-zA-Z0-9]+)\.([a-zA-Z]{2,})(\.[a-zA-Z]{2,})?$";

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
        if (Regex.IsMatch(input, urlPattern))
        {
            return true;
        }
        return false;
    }
}