using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUtils : MonoBehaviour
{
    public int money = 500;
    public TMP_Text moneyText;
    public TMP_Text waydText;

    private void Start()
    {
        UpdateMoney();
    }

    private void Update()
    {
        if (transform.position.y <= -1.5f && !GetComponent<PlayerMovement>().Crouching) {
            transform.position = new Vector3(0f, 1.6f, -13.9f);
            StartCoroutine(ShowWAYDText());
        } else if (transform.position.y <= -1f && GetComponent<PlayerMovement>().Crouching) {
            transform.position = new Vector3(0f, 1.6f, -13.9f);
            StartCoroutine(ShowWAYDText());
        }
    }

    private IEnumerator ShowWAYDText()
    {
        waydText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        waydText.gameObject.SetActive(false);
    }

    public void SetMoney(int money)
    {
        this.money = money;
        UpdateMoney();
    }

    public bool RemoveMoney(int money)
    {
        if (this.money < money)
        {
            Debug.Log("Vous n'avez pas assez d'argent. Il vous manque " + (money - this.money) + " $");
            return false;
        }
        this.money -= money;
        StartCoroutine(ChangeColor(Color.red));
        UpdateMoney();
        return true;
    }
    
    public void AddMoney(int money)
    {
        this.money += money;
        StartCoroutine(ChangeColor(Color.green));
        UpdateMoney();
    }

    private IEnumerator ChangeColor(Color color)
    {
        moneyText.color = color;
        yield return new WaitForSeconds(1);
        moneyText.color = Color.white;
    }

    private void UpdateMoney()
    {
        Debug.Log("Vous avez " + money + " $");
        moneyText.text = money + " $";
    }
}
