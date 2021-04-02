using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellScript : MonoBehaviour
{

    public PlayerUtils playerUtils;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent(out BlockGen blockGen))
        {
            if (blockGen.IsDupe)
            {
                Debug.Log(blockGen.generator.generateMoney * 2);
                playerUtils.AddMoney(blockGen.generator.generateMoney * 2);
            }
            else
            {
                Debug.Log(blockGen.generator.generateMoney);
                playerUtils.AddMoney(blockGen.generator.generateMoney);
            }
            Destroy(other.gameObject);
        }
    }
}
