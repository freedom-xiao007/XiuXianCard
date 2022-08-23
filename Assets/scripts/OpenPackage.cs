using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPackage : MonoBehaviour
{

    public GameObject cardPreftab;
    public GameObject cardPool;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickOpen()
    {
        for (int i=0; i < 3; i++)
        {
            GameObject newCard = GameObject.Instantiate(cardPreftab, cardPool.transform);
            Card card = new AttackCard(i, "1", "1", i);
            newCard.GetComponent<cardDisplay>().card = card;
        }
    }
}
