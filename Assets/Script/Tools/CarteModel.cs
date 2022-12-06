using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarteModel : MonoBehaviour
{
    [Header("Carte variables")]
    [SerializeField] private Image carteBackground;
    [SerializeField] private Image cartePhoto;
    [SerializeField] private Text _carteName;
    [SerializeField] private Text _carteAttack;
    [SerializeField] private Text _carteDefense;
    [SerializeField] private Text _carteDescription;
    [Header("Carte Types variables")]
    [SerializeField] private Sprite _carteLegendaireImage;
    [SerializeField] private Sprite _carteRareImage;
    [SerializeField] private Sprite _carteCommunImage;
    [Header("Carte Scriptable Object")]
    public CarteSO carteSO;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
