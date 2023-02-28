using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using UnityEngine;

public class GeoLocationInputFieldValidations : MonoBehaviour
{
    public List<TMP_InputField> InputFields; // Reference to the InputField component

    [SerializeField] private bool isFormInputFieldOkay = true;

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
        if (input != null)
        {
            return true;
        }
        return false;
    }
}
