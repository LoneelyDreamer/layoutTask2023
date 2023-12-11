using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CongratsUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ticketsNumber;
    [SerializeField] private TextMeshProUGUI day;
    [SerializeField] private Button retornButton;

    private void Awake()
    {
        retornButton.onClick.AddListener(() => Hide());
    }

    public void WritTicketsText(int number)
    {
        ticketsNumber.text = "x" + number.ToString();
    }
    public void WritDaysText(int numberOfDay)
    {
        day.text = "DAY" + numberOfDay.ToString();
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
