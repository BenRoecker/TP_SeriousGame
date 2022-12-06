using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarteManager : MonoBehaviour
{
    [SerializeField] private GameObject CardModel;
    [SerializeField] private Transform _cardContent;
    [SerializeField] private List<CarteSO> cartes;
    // Start is called before the first frame update
    void Start()
    {
        Initializecards();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Initializecards()
    {
        for(int i = 0; i < 3; i++)
        {
            GameObject cardObject = Instantiate(CardModel, _cardContent);
            CarteModel cartemodel = cardObject.GetComponent<CarteModel>();
            cartemodel.carteSO = cartes[i];
            cartemodel.InitializeCard();
        }
    }
}
