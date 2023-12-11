using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallet : MonoBehaviour 
{
    public static Wallet Instance { get; private set; }
    private int ticketsCash;
    private const string TICKETS = "Tickets";

    public event EventHandler OnTicketsNumberChenged;

    private void Awake()
    {
        Instance = this;
        if(!PlayerPrefs.HasKey(TICKETS))
        {
            PlayerPrefs.SetInt(TICKETS, 100);
            ticketsCash = 100;
        }
        else
        {
            ticketsCash = PlayerPrefs.GetInt(TICKETS);
        }
    }

    public int GetTicketsCash()
    {
        return ticketsCash;
    }
    public void AddTickets(int number)
    {
        ticketsCash += number;

        PlayerPrefs.SetInt(TICKETS, ticketsCash);

        OnTicketsNumberChenged?.Invoke(this, EventArgs.Empty);
    }

    public void subtractTickets(int number)
    {
        ticketsCash -= number;

        if(ticketsCash < 0)
        {
            ticketsCash = 0;
        }

        PlayerPrefs.SetInt(TICKETS, ticketsCash);

        OnTicketsNumberChenged?.Invoke(this, EventArgs.Empty);
    }
}
