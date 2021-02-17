using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngelDevilButtons : MonoBehaviour
{

    [SerializeField] GameObject _angelCheckmark;
    [SerializeField] GameObject _devilCheckmark;
    [SerializeField] GameObject _playGamePanel;
    [SerializeField] GameObject _actionPanel;
    [SerializeField] Button _proceedButton;


    void Start()
    {
        _angelCheckmark.SetActive(false);
        _devilCheckmark.SetActive(false);
        _proceedButton.interactable = false;
    }

    public void ClickAngel()
    {
        _angelCheckmark.SetActive(true);
        _devilCheckmark.SetActive(false);
    }
    public void ClickDevil()
    {
        _devilCheckmark.SetActive(true);
        _angelCheckmark.SetActive(false);
    }

    public void OnValidateProceedButton()
    {
        if (_angelCheckmark.activeSelf == true || _devilCheckmark.activeSelf == true)
        {
            _proceedButton.interactable = true;
        } else
        {
            _proceedButton.interactable = false;
        }
    }

    public void clickProceedButton()
    {
        if (_proceedButton.interactable == true)
        {
            _playGamePanel.SetActive(false);
            _actionPanel.SetActive(true);
        }
    }
    /*
        public void cleanUp()
        {
            _angelCheckmark.SetActive(false);
            _devilCheckmark.SetActive(false);
        }*/


}
