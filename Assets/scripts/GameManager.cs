using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI MainText;
    public TextMeshProUGUI DialogText;


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
        //Debug.Log("axis hori: " + fr);
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            //
            DialogText.text = "�Ʒ��� ��ĭ �̵�";
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //
            DialogText.text = "���� ��ĭ �̵�";
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //
            DialogText.text = "�������� ��ĭ �̵�";
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //
            DialogText.text = "���������� ��ĭ �̵�";
        }
    }
}
