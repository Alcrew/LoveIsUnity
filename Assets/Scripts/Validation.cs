using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Validation : MonoBehaviour
{
    [SerializeField] GameObject _idField;
    [SerializeField] GameObject _userPhoto;
    void Start()
    {
        _userPhoto.SetActive(false);
    }

    public void OnValidate()
    {
        if (_idField != null)
        {
            _userPhoto.SetActive(true);
        }
    }

}
