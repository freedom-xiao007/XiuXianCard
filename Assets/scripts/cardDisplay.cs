using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cardDisplay : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI desText;

    public Card card;

    // Start is called before the first frame update
    void Start()
    {
        ShowCardInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowCardInfo()
    {
        nameText.text = card.name;
        desText.text = card.des;
    }
}
