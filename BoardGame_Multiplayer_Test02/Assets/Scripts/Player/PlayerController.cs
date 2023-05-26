using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody rb;

    [SerializeField]
    private Material Colors1;

    public int Coins;
    public int Power;
    public int Hability;

    //public TMP_Text CoinsText;
    //public TMP_Text PowerText;
    //public TMP_Text HabilityText;

    PhotonView view;


    public void Start()
    {
        rb = GetComponent<Rigidbody>();

        Coins = 100;
        Power = 30;
        Hability = 50;

        //CoinsText.text = Coins.ToString();
        //PowerText.text = Power.ToString();
        //HabilityText.text = Hability.ToString();

        view = GetComponent<PhotonView>();
    }

    //private void FixedUpdate()
    //{
    //    if (view.IsMine)
    //    {
    //        float moveHorizontal = Input.GetAxis("Horizontal");
    //        float moveVertical = Input.GetAxis("Vertical");

    //        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * moveSpeed;

    //        rb.velocity = movement;
    //    }
    //}

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Colors"))
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material = Colors1;

            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Coins"))
        {
            Coins++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Power"))
        {
            Power++;
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Hability"))
        {
            Hability++;
            Destroy(other.gameObject);
        }
    }

    public void Update()
    {
        if (view.IsMine)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical) * moveSpeed;

            rb.velocity = movement;
        }

        //CoinsText.text = Coins.ToString();
        //PowerText.text = Power.ToString();
        //HabilityText.text = Hability.ToString();
    }
}
