using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// _ for private variables
//Debug.Log($"Name: {gameObject.name}");
public class Buttons : MonoBehaviour
{
    [SerializeField] GameObject _mainPanel;
    [SerializeField] GameObject _playGamePanel;
    [SerializeField] GameObject _findMyPairPanel;
    [SerializeField] GameObject _helpPanel;
    [SerializeField] GameObject _loveShopPanel;

    void Start()
    {
        _mainPanel.SetActive(true);
        _playGamePanel.SetActive(false);
        _findMyPairPanel.SetActive(false);
        _helpPanel.SetActive(false);
        _loveShopPanel.SetActive(false);
    } 

    public void StartGameClick()
    {
        _mainPanel.SetActive(false);
        _playGamePanel.SetActive(true);
    }

    public void FindMyPairClick()
    {
        _mainPanel.SetActive(false);
        _findMyPairPanel.SetActive(true);
    }

    public void shopPanelClick()
    {
        _mainPanel.SetActive(false);
        _loveShopPanel.SetActive(true);
    }

    public void helpClick()
    {
        _mainPanel.SetActive(false);
        _helpPanel.SetActive(true);
    }

}
