using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaleScript : MonoBehaviour
{
    private CoinScript Currency;
    [SerializeField] private Select select;

    void Start()
    {
        Currency = this.GetComponent<CoinScript>();
    }


    public void SetSale(float saleRate, int salePrice, int slot)
    {
        StartCoroutine(Sale(saleRate, salePrice, slot));
    }

    private IEnumerator Sale(float saleRate, int salePrice, int slot)
    {
        float waitTime = 5 * saleRate;
        Debug.Log("Potion put up for sale");
        yield return new WaitForSeconds(waitTime);
        Currency.IncrementGold(salePrice);
        select.EmptySlot(slot);
    }

}
