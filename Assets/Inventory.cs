using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public List<string> items = new List<string>();

    [Header("UI")]
    public TextMeshProUGUI itemText; // 🔹 Перетягни сюди TMP Text

    public void AddItem(string itemName)
    {
        items.Add(itemName);
        Debug.Log("Added to inventory: " + itemName);
        UpdateUI(); // 🔹 Оновлюємо текст
    }

    private void UpdateUI()
    {
        if (itemText != null)
        {
            itemText.text = "Items: " + items.Count;
        }
    }
}
