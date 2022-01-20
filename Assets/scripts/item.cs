using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "Item")]
public class item : ScriptableObject
{
    public new string name;
    public int price;
    public Sprite icon;

}
