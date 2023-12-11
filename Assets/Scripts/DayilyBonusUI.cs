using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DayilyBonusUI : MonoBehaviour
{
    public event EventHandler OnTakePrize;

    [SerializeField] private Button dayBonusButton1;
    [SerializeField] private Button dayBonusButton2;
    [SerializeField] private Button dayBonusButton3;
    [SerializeField] private Button dayBonusButton4;
    [SerializeField] private Button dayBonusButton5;
    [SerializeField] private Button dayBonusButton6;
    [SerializeField] private Button retornToMenuButton;

    [SerializeField] private Transform cangratsView;
    [SerializeField] private CongratsUI congratsUI;
    [SerializeField] private Daily daily;

    private int ticketsNumber;
    private int dayNumber;

    private void Awake()
    {
        dayBonusButton1.onClick.AddListener(() => TakePrize(dayBonusButton1));
        dayBonusButton2.onClick.AddListener(() => TakePrize(dayBonusButton2));
        dayBonusButton3.onClick.AddListener(() => TakePrize(dayBonusButton3));
        dayBonusButton4.onClick.AddListener(() => TakePrize(dayBonusButton4));
        dayBonusButton5.onClick.AddListener(() => TakePrize(dayBonusButton5));
        dayBonusButton6.onClick.AddListener(() => TakePrize(dayBonusButton6));

        retornToMenuButton.onClick.AddListener(() => Hide());
    }

    private void TakePrize(Button dayBonusButton)
    {
        ticketsNumber = dayBonusButton.GetComponent<DayliGift>().GetTicketsNumber();
        dayNumber = dayBonusButton.GetComponent<DayliGift>().GetDayOfWeek();
        daily.GetReword(dayNumber, dayBonusButton.GetComponent<DayliGift>());
        SetCongratsScene();
        AddTicketsInWallet();
        OnTakePrize?.Invoke(this, EventArgs.Empty);
    }
    private void SetCongratsScene()
    {
        congratsUI.WritTicketsText(ticketsNumber);
        congratsUI.WritDaysText(dayNumber);

        cangratsView.gameObject.SetActive(true);
    }

    private void AddTicketsInWallet()
    {
        Wallet.Instance.AddTickets(ticketsNumber);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

}
