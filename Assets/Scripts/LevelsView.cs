using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsView : MonoBehaviour
{
    public static LevelsView Instance { get; private set; }

    public event EventHandler OnLevelPassed;

    [SerializeField] private List<Lavel> _levels = new List<Lavel>();
    [SerializeField] private Button lavelButton1;
    [SerializeField] private Button lavelButton2;
    [SerializeField] private Button lavelButton3;
    [SerializeField] private Button lavelButton4;
    [SerializeField] private Button lavelButton5;
    [SerializeField] private Button lavelButton6;
    [SerializeField] private Button lavelButton7;
    [SerializeField] private Button lavelButton8;
    [SerializeField] private Button lavelButton9;
    [SerializeField] private Button lavelButton10;
    [SerializeField] private Button lavelButton11;
    [SerializeField] private Button lavelButton12;
    [SerializeField] private Button lavelButton13;
    [SerializeField] private Button lavelButton14;
    [SerializeField] private Button lavelButton15;
    [SerializeField] private Button lavelButton16;
    [SerializeField] private Button lavelButton17;
    [SerializeField] private Button lavelButton18;
    [SerializeField] private Button lavelButton19;
    [SerializeField] private Button lavelButton20;

    [SerializeField] private Button menuButton;

    private int nextLevel = 1;
    private const string NEXTLAVEL = "nextLevel";

    private void Awake()
    {
        Instance = this;

        lavelButton1.onClick.AddListener(() => PassLavel(lavelButton1));
        lavelButton2.onClick.AddListener(() => PassLavel(lavelButton2));
        lavelButton3.onClick.AddListener(() => PassLavel(lavelButton3));
        lavelButton4.onClick.AddListener(() => PassLavel(lavelButton4));
        lavelButton5.onClick.AddListener(() => PassLavel(lavelButton5));
        lavelButton6.onClick.AddListener(() => PassLavel(lavelButton6));
        lavelButton7.onClick.AddListener(() => PassLavel(lavelButton7));
        lavelButton8.onClick.AddListener(() => PassLavel(lavelButton8));
        lavelButton9.onClick.AddListener(() => PassLavel(lavelButton9));
        lavelButton10.onClick.AddListener(() => PassLavel(lavelButton10));
        lavelButton11.onClick.AddListener(() => PassLavel(lavelButton11));
        lavelButton12.onClick.AddListener(() => PassLavel(lavelButton12));
        lavelButton13.onClick.AddListener(() => PassLavel(lavelButton13));
        lavelButton14.onClick.AddListener(() => PassLavel(lavelButton14));
        lavelButton15.onClick.AddListener(() => PassLavel(lavelButton15));
        lavelButton16.onClick.AddListener(() => PassLavel(lavelButton16));
        lavelButton17.onClick.AddListener(() => PassLavel(lavelButton17));
        lavelButton18.onClick.AddListener(() => PassLavel(lavelButton18));
        lavelButton19.onClick.AddListener(() => PassLavel(lavelButton19));
        lavelButton20.onClick.AddListener(() => PassLavel(lavelButton20));

        menuButton.onClick.AddListener(() => Hide());

        nextLevel = PlayerPrefs.GetInt(NEXTLAVEL);
        Hide();
    }

    private void Start()
    {       
        UnlockAllSaveLavels();
    }
    private void Hide()
    {
        gameObject.SetActive(false);
    }

    public void PassLavel(Button lavelButton)
    {
        Lavel lavel = lavelButton.GetComponent<Lavel>();

        nextLevel = lavel.GetLavel();
        PlayerPrefs.SetInt(NEXTLAVEL, nextLevel);

        if (nextLevel < _levels.Count && _levels[nextLevel - 1].IsOpen())
        {
            _levels[nextLevel].OpenLavel();
        }
        OnLevelPassed?.Invoke(this, EventArgs.Empty);
    }

    public void UnlockAllSaveLavels()
    {
        for (int i = 0; i <= nextLevel; i++)
        {
            _levels[i].OpenLavel();
        }
    }

    public int GetCurrentLavel()
    {
        return nextLevel;
    }


  

}
