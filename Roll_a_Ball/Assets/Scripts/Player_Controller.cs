using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{



    public float speed;
    public Text CountText;
    public Text WinText;


    private Rigidbody rb;
    private int count;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        WinText.text = "";
    }

    void Update()
    {

    }
    void FixedUpdate()
    {

        float moveHori = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 Movement = new Vector3(moveHori, 0.0f, moveVert);

        rb.AddForce(Movement * speed);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }
        void SetCountText () {
            CountText.text = "Count:" + count.ToString();
        if (count >= 6){
            WinText.text = "You Win!";
        }
        }

    }


