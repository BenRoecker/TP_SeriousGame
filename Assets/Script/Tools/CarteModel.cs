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
        InitializeCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InitializeCard()
    {
        _carteName.text = carteSO.carteName;
        _carteAttack.text = carteSO.Attack.ToString();
        _carteDefense.text = carteSO.Defense.ToString();
        _carteDescription.text = carteSO.Description;
        cartePhoto.sprite = carteSO.carteImage;

        switch (carteSO.carteType)
        {
            case CarteType.Commun:
                carteBackground.sprite = _carteCommunImage;
                break;
            case CarteType.Rare:
                carteBackground.sprite = _carteRareImage;
                break;
            case CarteType.Legendaire:
                carteBackground.sprite = _carteLegendaireImage;
                break;
            default:
                carteBackground.sprite = _carteCommunImage;
                break;
        }
    }
}
