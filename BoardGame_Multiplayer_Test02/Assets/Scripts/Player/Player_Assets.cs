using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class Player_Assets : MonoBehaviour
{
    public int Coins;
    public int Power;
    public int Hability;

    public TMP_Text CoinsText;
    public TMP_Text PowerText;
    public TMP_Text HabilityText;

    [SerializeField]
    private Material Colors1;

    PhotonView view;


    public void Start()
    {
        Coins = 100;
        Power = 30;
        Hability = 50;

        view = GetComponent<PhotonView>();
    }

    public void Update()
    {
        CoinsText.text = Coins.ToString();
        PowerText.text = Power.ToString();
        HabilityText.text = Hability.ToString();
    }

    private void OnTriggerEnter(Collider other)
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
}
