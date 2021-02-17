using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Validation : MonoBehaviour
{
    [SerializeField] GameObject _idField;
    [SerializeField] GameObject _userPhotoCheckmark;
    void Start()
    {
        _userPhotoCheckmark.SetActive(false);
    }

/*    public void OnValidate()
    {
        var input = _idField.GetComponent<TMP_InputField>().text;
        if (input.Length < 4)
        {
            _userPhotoCheckmark.SetActive(true);
        } else
        {
            _userPhotoCheckmark.SetActive(false);
        }
    }*/

}
