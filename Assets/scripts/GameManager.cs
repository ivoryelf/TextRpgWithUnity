using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI MainText;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("------- Text Rpg Start ------------");
        MainText.text = "Rpg Game Start~~~";
    }

    // Update is called once per frame
    void Update()
    {
        float fr = Input.GetAxisRaw("Horizontal");
        Debug.Log("axis hori: " + fr);
    }
}
