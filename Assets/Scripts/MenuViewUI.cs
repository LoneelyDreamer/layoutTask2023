using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuViewUI : MonoBehaviour
{
    [SerializeField] private Button playButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button giftButton;
    [SerializeField] private Button shopButton;

    [SerializeField] private Transform dailyBonusView;
    [SerializeField] private Transform lavelsView;
    [SerializeField] private Transform settingsView;
    [SerializeField] private Transform shopView;

    [SerializeField] private TextMeshProUGUI ticketsNumber;
    private void Awake()
    {
        playButton.onClick.AddListener(() => lavelsView.gameObject.SetActive(true));
        giftButton.onClick.AddListener(() => dailyBonusView.gameObject.SetActive(true));
        settingsButton.onClick.AddListener(() => settingsView.gameObject.SetActive(true));
        shopButton.onClick.AddListener(() => shopView.gameObject.SetActive(true));

        Wallet.Instance.OnTicketsNumberChenged += Wallet_OnTicketsNumberChenged;

        UpdateView();
    }

    private void Wallet_OnTicketsNumberChenged(object sender, System.EventArgs e)
    {
        UpdateView();
    }

    public void UpdateView()
    {
        ticketsNumber.text = Wallet.Instance.GetTicketsCash().ToString();
    }
}
