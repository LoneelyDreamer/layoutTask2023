using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsViewUI : MonoBehaviour
{
    [SerializeField] private Button volumeOnButton;
    [SerializeField] private Button volumeOffButton;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Button retornToMenuButton;

    private void Awake()
    {
        volumeOnButton.onClick.AddListener(() =>
        {
            if (audioSource.isPlaying) return;

            audioSource.Play();
        });
        volumeOffButton.onClick.AddListener(() => audioSource.Pause());
        retornToMenuButton.onClick.AddListener(() => Hide());
        Hide();
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
