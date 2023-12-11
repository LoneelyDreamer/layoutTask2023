using System;
using UnityEngine;
using UnityEngine.Purchasing;

public class shopScript : MonoBehaviour, IStoreListener
{
    public ConsumableItemEpicChest epicChestItem;
    public ConsumableItemLuckyChest luckyChestItem;

    public IStoreController m_storeController;

    private void Start()
    {
        SetapBuilde();
    }

    private void SetapBuilde()
    {
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());

        builder.AddProduct(epicChestItem.Id, ProductType.Consumable);
        builder.AddProduct(luckyChestItem.Id, ProductType.Consumable);

        UnityPurchasing.Initialize(this, builder);
    }

    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
    {
        print("success");
        m_storeController = controller;
    }

    public void BuyLuckyChestButtonPresd()
    {
        m_storeController.InitiatePurchase(luckyChestItem.Id);
    }

    public void BuyEpicChestButtonPresd()
    {
        m_storeController.InitiatePurchase(epicChestItem.Id);
    }
    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs purchaseEvent)
    {
        var product = purchaseEvent.purchasedProduct;

        print("purches Complete" + product.definition.id);

        if(product.definition.id == epicChestItem.Id)
        {
            Wallet.Instance.AddTickets(500);
        }
        else if (product.definition.id == luckyChestItem.Id)
        {
            Wallet.Instance.AddTickets(1200);
        }

        return PurchaseProcessingResult.Complete;
    }

    public void OnInitializeFailed(InitializationFailureReason error)
    {
        print ("intialze failed" + error);
    }

    public void OnInitializeFailed(InitializationFailureReason error, string message)
    {
        print("intialze failed" + error + message);
    }

    public void OnPurchaseFailed(Product product, PurchaseFailureReason failureReason)
    {
        print("intialze failed");
    }

    
}

[Serializable]
public class ConsumableItemEpicChest
{
    public string Name;
    public string Description;
    public string Id;
    public float price;
}

[Serializable]
public class ConsumableItemLuckyChest
{
    public string Name;
    public string Description;
    public string Id;
    public float price;
}
