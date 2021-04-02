using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Buy : MonoBehaviour
{
    public List<GameObject> unlockObjects;
    public int price;
    public string objectName;
    public TMP_Text priceText;
    public TMP_Text nameText;

    private void Start()
    {
        priceText.text = price + " $";
        nameText.text = objectName;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player", StringComparison.OrdinalIgnoreCase))
        {
            PlayerUtils playerUtils = other.GetComponent<PlayerUtils>();
            if (playerUtils.RemoveMoney(price))
            {
                foreach (var unlockObject in unlockObjects)
                {
                    unlockObject.SetActive(true);
                }
                gameObject.SetActive(false);
                
            }
        }
    }
}
