using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOffer : MonoBehaviour
{
    [SerializeField] private Transform okImage;
    [SerializeField] private Transform costText;
    [SerializeField] private Transform ticketsImage;

    [SerializeField] private Transform productImage;
    [SerializeField] private Transform lockLavelText;
    [SerializeField] private Transform lockImage;
    [SerializeField] private Transform productText;

    [SerializeField] private int costOfTickets;
    [SerializeField] private bool isBuyed = false;
    [SerializeField] private int necessaryLavel;

    private const string ISBUYED = "isBuyed";

    private void Start()
    {
        if (PlayerPrefs.HasKey(ISBUYED))
        {
            lockButton();
            ShowProduct();
        }
    }

    public int GetTicketsCost()
    {
        return costOfTickets;
    }

    public bool IsBuyed()
    {
        return isBuyed;
    }

    public int GetNecessaryLavel()
    {
        return necessaryLavel;
    }

    public void lockButton()
    {
        okImage.gameObject.SetActive(true);

        costText.gameObject.SetActive(false);

        ticketsImage.gameObject.SetActive(false);

        isBuyed = true;

        PlayerPrefs.SetInt(ISBUYED, 1);
    }

    public void ShowProduct()
    {
        productImage.gameObject.SetActive(true);

        if (productText != null)
        {
            productText.gameObject.SetActive(true);
        }

        lockLavelText.gameObject.SetActive(false);

        lockImage.gameObject.SetActive(false);
    }

}
