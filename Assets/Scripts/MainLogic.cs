using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainLogic : MonoBehaviour
{
    [SerializeField] GameObject _mainPanel;
    [SerializeField] GameObject _playGamePanel;
    [SerializeField] GameObject _findMyPairPanel;
    [SerializeField] GameObject _helpPanel;
    [SerializeField] GameObject _loveShopPanel;

    public void clickBackButtonGamePanel()
    {
        if (_playGamePanel == true) {
            _playGamePanel.SetActive(false);
            _mainPanel.SetActive(true);

        } 
    }

    public void clickBackButtonFindMyPairPanel()
    {
        if (_findMyPairPanel == true)
        {
            _findMyPairPanel.SetActive(false);
            _mainPanel.SetActive(true);
        }
    }

    public void clickBackButtonLoveShopPanel()
    {
        if (_loveShopPanel == true)
        {
            _loveShopPanel.SetActive(false);
            _mainPanel.SetActive(true);
        }
    }

    public void clickBackButtonHelpPanel()
    {
        if (_helpPanel == true)
        {
            _helpPanel.SetActive(false);
            _mainPanel.SetActive(true);
        }
    }
}
