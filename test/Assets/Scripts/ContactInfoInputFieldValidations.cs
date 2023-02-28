using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ContactInfoInputFieldValidations : MonoBehaviour
{
    public List<TMP_InputField> InputFields; // Reference to the InputField component

    [SerializeField] private bool isFormInputFieldOkay = true;
    // Regex pattern for validating email addresses
    private string namePattern = @"^[A-Za-z]+((\s)?((\'|\-|\.)?([A-Za-z])+))*$";
    private string phonePattern = @"^\+?[0-9]{0,3}[ -]?\(?[0-9]{3}\)?[ -]?[0-9]{3}[ -]?[0-9]{4}$";
    private string urlPattern = @"^(https?://)?(www\.)?([a-zA-Z0-9]+)\.([a-zA-Z]{2,})(\.[a-zA-Z]{2,})?$";
    private string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

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

        if (Regex.IsMatch(input, namePattern))
        {
            return true;
        }
        else if (Regex.IsMatch(input, phonePattern))
        {
            return true;
        }
        else if (Regex.IsMatch(input, urlPattern))
        {
            return true;
        }
        else if (Regex.IsMatch(input, emailPattern))
        {
            return true;
        }
        return false;
    }
}
