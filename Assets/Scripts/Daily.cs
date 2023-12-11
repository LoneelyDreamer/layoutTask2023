using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Daily : MonoBehaviour
{
    private int lastDate;

    private int Day_1;
    [SerializeField] private DayliGift dayliGiftDay1;
    private int Day_2;
    [SerializeField] private DayliGift dayliGiftDay2;
    private int Day_3;
    [SerializeField] private DayliGift dayliGiftDay3;
    private int Day_4;
    [SerializeField] private DayliGift dayliGiftDay4;
    private int Day_5;
    [SerializeField] private DayliGift dayliGiftDay5;
    private int Day_6;
    [SerializeField] private DayliGift dayliGiftDay6;

    private const string DAY1 = "Day_1";
    private const string DAY2 = "Day_2";
    private const string DAY3 = "Day_3";
    private const string DAY4 = "Day_4";
    private const string DAY5 = "Day_5";
    private const string DAY6 = "Day_6";
    private const string LASTDATE = "LastDate";


    private void Start()
    {
        Day_1 = PlayerPrefs.GetInt(DAY1);       
        Day_2 = PlayerPrefs.GetInt(DAY2);
        Day_3 = PlayerPrefs.GetInt(DAY3);
        Day_4 = PlayerPrefs.GetInt(DAY4);
        Day_5 = PlayerPrefs.GetInt(DAY5);
        Day_6 = PlayerPrefs.GetInt(DAY6);
        lastDate = PlayerPrefs.GetInt(LASTDATE);

        Reword(Day_1, dayliGiftDay1);
        Reword(Day_2, dayliGiftDay2);
        Reword(Day_3, dayliGiftDay3);
        Reword(Day_4, dayliGiftDay4);
        Reword(Day_5, dayliGiftDay5);
        Reword(Day_6, dayliGiftDay6);

        if (lastDate != DateTime.Now.Day)
        {
            if (Day_1 == 0)
            {
                Day_1 = 1;
                Reword(Day_1, dayliGiftDay1);
            }
            else if (Day_2 == 0)
            {
                Day_2 = 1;
                Reword(Day_2, dayliGiftDay2);
            }
            else if(Day_3 == 0)
            {
                Day_3 = 1;
                Reword(Day_3, dayliGiftDay3);
            }
            else if(Day_4 == 0)
            {
                Day_4 = 1;
                Reword(Day_4, dayliGiftDay4);
            }
            else if(Day_5 == 0)
            {
                Day_5 = 1;
                Reword(Day_5, dayliGiftDay5);
            }
            else if(Day_6 == 0)
            {
                Day_6 = 1;
                Reword( Day_6, dayliGiftDay6);
            }
        }
    }

    public void Reword( int day, DayliGift dayliGift)
    {
        if (day == 0)
        {
            dayliGift.SetNotReadyState();
        }
        if (day == 1)
        {
            dayliGift.SetReadyState();
        }
        if (day == 2)
        {
            dayliGift.SetGotState();
        }
    }
    //public void GetReword_1()
    //{
    //    lastDate = DateTime.Now.Day;
    //    PlayerPrefs.SetInt(LASTDATE, lastDate);
    //    Day_1 = 2;
    //    Reword(Day_1, dayliGiftDay1);
    //    PlayerPrefs.SetInt(DAY1, 2);
    //}
    //public void GetReword_2()
    //{
    //    lastDate = DateTime.Now.Day;
    //    PlayerPrefs.SetInt(LASTDATE, lastDate);
    //    Day_2 = 2;
    //    Reword();
    //    PlayerPrefs.SetInt(DAY2, 2);
    //}

    public void GetReword(int dayNumber, DayliGift dayliGift)
    {
        if (dayNumber == 1)
        {
            lastDate = DateTime.Now.Day;
            PlayerPrefs.SetInt(LASTDATE, lastDate);
            //dayNumber = 2;
            Reword(2, dayliGift);
            PlayerPrefs.SetInt(DAY1, 2);
        }
        if (dayNumber == 2)
        {
            lastDate = DateTime.Now.Day;
            PlayerPrefs.SetInt(LASTDATE, lastDate);
           // dayNumber = 2;
            Reword(2, dayliGift);
            PlayerPrefs.SetInt(DAY2, 2);
        }
        if (dayNumber == 3)
        {
            lastDate = DateTime.Now.Day;
            PlayerPrefs.SetInt(LASTDATE, lastDate);
           // dayNumber = 2;
            Reword(2, dayliGift);
            PlayerPrefs.SetInt(DAY3, 2);
        }
        if (dayNumber == 4)
        {
            lastDate = DateTime.Now.Day;
            PlayerPrefs.SetInt(LASTDATE, lastDate);
            //dayNumber = 2;
            Reword(2, dayliGift);
            PlayerPrefs.SetInt(DAY4, 2);
        }
        if (dayNumber == 5)
        {
            lastDate = DateTime.Now.Day;
            PlayerPrefs.SetInt(LASTDATE, lastDate);
           // dayNumber = 2;
            Reword(2, dayliGift);
            PlayerPrefs.SetInt(DAY5, 2);
        }
        if (dayNumber == 6)
        {
            lastDate = DateTime.Now.Day;
            PlayerPrefs.SetInt(LASTDATE, lastDate);
            //dayNumber = 2;
            Reword(2, dayliGift);
            PlayerPrefs.SetInt(DAY6, 2);
        }
    }
}
