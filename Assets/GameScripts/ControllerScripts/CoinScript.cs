using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinScript : MonoBehaviour
{

    private int Gold = 0;

    [SerializeField] private TextMeshProUGUI goldText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int ReturnGold()
    {
        return Gold;
    }

    public void IncrementGold(int addValue)
    {
        Gold += addValue;
        UpdateGoldText();
    }

    public void DecrementGold(int removeValue)
    {
        Gold -= removeValue;
        UpdateGoldText();
    }

    public void UpdateGoldText()
    {
        goldText.text = Gold.ToString();
    }
}
