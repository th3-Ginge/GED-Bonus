using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public GameObject character;
    public int playerhealth;
    public Text textbox;

    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            playerhealth++;
        }
        if (Input.GetKey(KeyCode.E))
        {
            playerhealth--;
        }

        
        if (playerhealth > 0)
        {
            
            textbox.text = "" +playerhealth;
        }
        if (playerhealth <= 0)
            Destroy(gameObject);
    }

}
