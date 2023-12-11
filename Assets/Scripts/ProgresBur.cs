using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ProgresBur : MonoBehaviour
{
    [SerializeField] private Image progressImage;
    [SerializeField] private DayilyBonusUI dayilyBonusUI;
    [SerializeField] private TextMeshProUGUI textProgress;

    private int bonusNumber;
    private const string BONUSPROGRESS = "bonusProgress";

    private void Start()
    {
        dayilyBonusUI.OnTakePrize += DayilyBonusUI_OnTakePrize;

        bonusNumber = PlayerPrefs.GetInt(BONUSPROGRESS);

        print(bonusNumber + " bonusNumber");
        UpdateProgressBur();
    }

    private void DayilyBonusUI_OnTakePrize(object sender, System.EventArgs e)
    {
        bonusNumber++;

        UpdateProgressBur();

        PlayerPrefs.SetInt(BONUSPROGRESS, bonusNumber);
    }

    public void UpdateProgressBur()
    {
        textProgress.text = bonusNumber.ToString() + " / 7";

        progressImage.fillAmount = (float)bonusNumber / (float)7;
    }
}
