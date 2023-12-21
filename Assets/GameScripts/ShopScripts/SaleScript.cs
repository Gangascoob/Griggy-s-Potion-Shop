using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaleScript : MonoBehaviour
{
    private CoinScript Currency;

    void Start()
    {
        Currency = this.GetComponent<CoinScript>();
    }


    public void SetSale(float saleRate, int salePrice)
    {
        StartCoroutine(Sale(saleRate, salePrice));
    }

    private IEnumerator Sale(float saleRate, int salePrice)
    {
        float waitTime = 5 * saleRate;
        yield return new WaitForSeconds(waitTime);
        Currency.IncrementGold(salePrice);
    }

}
