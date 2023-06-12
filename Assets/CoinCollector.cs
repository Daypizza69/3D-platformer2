using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public TMP_Text coinText;
    public int coinsCollected = 0;

    private const string coinCountKey = "CoinCount";

    private void Start()
    {
        LoadCoinCount();
        UpdateCoinText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coinsCollected++;
            Destroy(other.gameObject);
            UpdateCoinText();
            SaveCoinCount();
        }
    }

    private void UpdateCoinText()
    {
        coinText.text = coinsCollected.ToString();
    }

    private void SaveCoinCount()
    {
        PlayerPrefs.SetInt(coinCountKey, coinsCollected);
        PlayerPrefs.Save();
    }

    private void LoadCoinCount()
    {
        if (PlayerPrefs.HasKey(coinCountKey))
        {
            coinsCollected = PlayerPrefs.GetInt(coinCountKey);
        }
    }
}


