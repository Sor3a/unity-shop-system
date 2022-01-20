using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class attachItem : MonoBehaviour
{
    item Item;
    shope Shope;
    private void Awake()
    {
        Shope = FindObjectOfType<shope>();
    }
    public void setItem(item i)
    {
        if (Item == null)
        {
            Item = i;
            transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() => {Shope.buyItem(Item); });
        }

    }
}
