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
    [SerializeField] GameObject _proceedButton;

    void Start()
    {
        //_playGamePanel.SetActive(true);
        _actionPanel.SetActive(false);
    }

    void OnEnable()
    {
        cleanUp();
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

    public void ClickProceedButton()
    {
        _playGamePanel.SetActive(false);
        _actionPanel.SetActive(true);
    }

    public void cleanUp()
    {
        _angelCheckmark.SetActive(false);
        _devilCheckmark.SetActive(false);
    }


}
