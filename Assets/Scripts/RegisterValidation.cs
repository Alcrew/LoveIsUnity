using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegisterValidation : MonoBehaviour
{
    [SerializeField] GameObject _registerNameField;
    //[SerializeField] GameObject _registerGender;
    //[SerializeField] GameObject _registerUserPhoto;
    [SerializeField] Image _signUpButton;
    [SerializeField] GameObject _maleCheckmark;
    [SerializeField] GameObject _femaleCheckmark;

    void Start()
    {
        _maleCheckmark.SetActive(false);
        _femaleCheckmark.SetActive(false);
        Debug.Log($"Name: {_registerNameField.name}");
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

        if (!string.IsNullOrEmpty(_registerNameField.name))
            //(_registerNameField != null) && (_maleCheckmark.activeSelf == true || _femaleCheckmark.activeSelf == true))
        {
            _signUpButton.color = new Color32(69, 155, 255, 255);
        }
    }

    /*    public void cleanUpRegistartion()
        {
            _maleCheckmark.SetActive(false);
            _femaleCheckmark.SetActive(false);
        }*/
}
