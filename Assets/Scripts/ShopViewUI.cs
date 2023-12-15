using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopViewUI : MonoBehaviour
{
    [SerializeField] private LevelsView levelsView;

    [SerializeField] private Button buyCharecter1Button;
    [SerializeField] private Button buyCharecter2Button;

    [SerializeField] private Button buyLocations1Button;
    [SerializeField] private Button buyLocations2Button;
    [SerializeField] private Button buyLocations3Button;

    [SerializeField] private Button menuButton;
    [SerializeField] private List<ShopOffer> shopOffers = new List<ShopOffer>();
    private Wallet wallet;

    private void Awake()
    {
        menuButton.onClick.AddListener(() => Hide());

        buyCharecter1Button.onClick.AddListener(() => Buy(buyCharecter1Button));
        buyCharecter2Button.onClick.AddListener(() => Buy(buyCharecter2Button));

        buyLocations1Button.onClick.AddListener(() => Buy(buyLocations1Button));
        buyLocations2Button.onClick.AddListener(() => Buy(buyLocations2Button));
        buyLocations3Button.onClick.AddListener(() => Buy(buyLocations3Button));

        wallet = Wallet.Instance;
        levelsView.OnLevelPassed += LevelsView_OnLevelPassed;
        Hide();
    }

    private void Start()
    {
        CheakNecessaryLavel();
    }

    private void LevelsView_OnLevelPassed(object sender, System.EventArgs e)
    {
        CheakNecessaryLavel();
    }

    private void Buy(Button button)
    {
        ShopOffer shopOffer = button.GetComponent<ShopOffer>();

        if (shopOffer.IsBuyed()) return;

        if (levelsView.GetCurrentLavel() < shopOffer.GetNecessaryLavel()) return;

        if (wallet.GetTicketsCash() >= shopOffer.GetTicketsCost())
        {
            Wallet.Instance.subtractTickets(shopOffer.GetTicketsCost());
            shopOffer.lockButton();
        }
    }
    private void Hide()
    {
        gameObject.SetActive(false);
    }

    public void CheakNecessaryLavel()
    {
        print("cheak");
        foreach (ShopOffer offer in shopOffers)
        {
            if (levelsView.GetCurrentLavel() < offer.GetNecessaryLavel()) return;
            offer.ShowProduct();
        }
    }
}
