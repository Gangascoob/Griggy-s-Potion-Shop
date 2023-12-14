using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class Select : MonoBehaviour
{

    private int Slot;
    private bool slotSelected = false;

    [SerializeField] private GameObject slotOne;
    [SerializeField] private GameObject slotTwo;

    private GameObject selectedSlot;

    private Image slotImage;
    private Sprite slotSprite;

    [SerializeField] private Sprite[] spriteArr;

    private Color _potionColor;
    private Color _emptyColor;

    // Start is called before the first frame update
    void Start()
    {
        _potionColor = new Color(209, 187, 125, 109);
        _emptyColor = new Color(209, 187, 125, 255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectSlot(int slot)
    {
        Slot = slot;
        slotSelected = true;
        if(slot == 1)
        {
            selectedSlot = slotOne;
        }
        if(slot == 2)
        {
            selectedSlot = slotTwo;
        }
        Debug.Log("Slot Selected");
    }

    public void SelectPotion(int slotID)
    {

        if(slotSelected == true)
        {
            slotSprite = spriteArr[slotID];
            slotImage = selectedSlot.GetComponent<Image>();
            slotImage.sprite = slotSprite;
            slotSelected = false;
            slotImage.color = _potionColor;
        }
        
        
    }
}
