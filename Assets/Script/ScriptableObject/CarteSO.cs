using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Carte", menuName ="EFREI/ScriptableObjects/Cartes")]
public class CarteSO : ScriptableObject
{
    public string carteName;
    public int Attack;
    public int Defense;
    public CarteType carteType;
    public string Description;
    public Sprite carteImage;
}

public enum CarteType{Commun,Rare, Legendaire}