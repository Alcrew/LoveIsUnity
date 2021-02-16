using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RegisterValidation : MonoBehaviour
{
    [SerializeField] GameObject _registerNameField;
    [SerializeField] GameObject _registerPanel;
    [SerializeField] GameObject _mainPanel;
    //[SerializeField] GameObject _registerUserPhoto;
    [SerializeField] Button _signUpButton;
    [SerializeField] GameObject _maleCheckmark;
    [SerializeField] GameObject _femaleCheckmark;



    void Start()
    {
        _maleCheckmark.SetActive(false);
        _femaleCheckmark.SetActive(false);
        _mainPanel.SetActive(false);
        _signUpButton.interactable = false;
    }


    public void SelectMaleGender()
    {
        _maleCheckmark.SetActive(true);
        _femaleCheckmark.SetActive(false);
    }

    public void SelectFemaleGender()
    {
        _maleCheckmark.SetActive(false);
        _femaleCheckmark.SetActive(true);

    }

    public void OnValidateRegister()
    {
        var input = _registerNameField.GetComponent<TMP_InputField>().text;
        if (!string.IsNullOrEmpty(input) && (_maleCheckmark.activeSelf == true || _femaleCheckmark.activeSelf == true))
        {
            _signUpButton.interactable = true;
        } else
        {
            _signUpButton.interactable = false;

        }
    }

    public void clickSignUpButton()
    {
        if (_signUpButton.interactable == true)
        {
            _registerPanel.SetActive(false);
            _mainPanel.SetActive(true);
        }
    }

    /*    public void cleanUpRegistartion()
        {
            _maleCheckmark.SetActive(false);
            _femaleCheckmark.SetActive(false);
            var input = _registerNameField.GetComponent<TMP_InputField>().text;
            input.Insert(0, "");
        }*/
}
