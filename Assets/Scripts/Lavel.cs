using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Lavel : MonoBehaviour
{   
    [SerializeField] private int level;
    [SerializeField] private Transform lockImagr;
    [SerializeField] private Transform lavelText;
    [SerializeField] private bool isOpen = false;

    public void OpenLavel()
    {        
        lockImagr.gameObject.SetActive(false);

        lavelText.gameObject.SetActive(true);

        isOpen = true;
    }

    public int GetLavel()
    {
        return level;
    }

    public void lockLavel()
    {
        lockImagr.gameObject.SetActive(true);

        lavelText.gameObject.SetActive(false);
    }

    public bool IsOpen()
    { 
        return isOpen;
    }

}
