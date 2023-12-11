using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayliGift : MonoBehaviour
{
    [SerializeField] private int numberOfTickets;
    [SerializeField] private int dayOfWeek;

    public int GetTicketsNumber()
    {
        return numberOfTickets;
    }

    public int GetDayOfWeek()
    {
        return dayOfWeek;
    }
}
