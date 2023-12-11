using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayliGift : MonoBehaviour
{
    [SerializeField] private int numberOfTickets;
    [SerializeField] private int dayOfWeek;

    [SerializeField] private Transform unActiveImage;
    [SerializeField] private Transform unActiveTicketsImage;
    [SerializeField] private Transform TicketsImage;
    [SerializeField] private Transform textNumber;
    [SerializeField] private Transform textDay;
    [SerializeField] private Transform okImage;

    public void SetNotReadyState()
    {
        unActiveImage.gameObject.SetActive(true);
        unActiveTicketsImage.gameObject.SetActive(true);
        okImage.gameObject.SetActive(false);
        gameObject.GetComponent<Button>().enabled = false;
    }
    public void SetReadyState()
    {
        unActiveImage.gameObject.SetActive(false);
        unActiveTicketsImage.gameObject.SetActive(false);
        okImage.gameObject.SetActive(false);
        gameObject.GetComponent<Button>().enabled = true;
    }
    public void SetGotState()
    {
        unActiveImage.gameObject.SetActive(false);
        unActiveTicketsImage.gameObject.SetActive(false);
        okImage.gameObject.SetActive(true);
        gameObject.GetComponent<Button>().enabled = false;
    }

    public int GetTicketsNumber()
    {
        return numberOfTickets;
    }

    public int GetDayOfWeek()
    {
        return dayOfWeek;
    }
}
