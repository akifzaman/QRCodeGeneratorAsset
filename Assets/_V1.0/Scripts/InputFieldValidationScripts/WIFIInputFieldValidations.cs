using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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

    public TMP_Dropdown dropdown;
    public Toggle toggle;

    private string[] networkTypeOptions = { "WPA", "WEP", "No Encryption" };
    public void Start()
    {
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
        InputFields[3].text = "false";
        RegularExpressions.Add(ssidPattern);
        RegularExpressions.Add(networkPattern);
        RegularExpressions.Add(passwordPattern);
        RegularExpressions.Add(hiddenPattern);
    }
    public void ValidateInputFields()
    {
        for (int i = 0; i < InputFields.Count; i++)
        {
            Debug.Log(InputFields[i].text);
        }
        for (int i = 0; i < InputFields.Count; i++)
        {
            string ss = Regex.Replace(InputFields[i].text, @"\s", "");
            isFormInputFieldOkay = (isFormInputFieldOkay) && Regex.IsMatch(ss, RegularExpressions[i]);
            if (!isFormInputFieldOkay) break;
        }
        if (isFormInputFieldOkay) UIManager.Instance.isFormValid = true;
        isFormInputFieldOkay = true;
    }

    private void OnDropdownValueChanged(int value)
    {
        InputFields[1].text = networkTypeOptions[value];
    }
    public void OnToggleValueChanged(bool value)
    {
        InputFields[3].text = value.ToString().ToLower();
    }

}
