using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBehaviour : MonoBehaviour
{
    Rigidbody rb;
    public float jumpforce =10f;
    public float movementSpeed =5f;
    public int coins =0;
    public TextMeshProUGUI coinsText;
    public AudioClip coinSFX;
    public AudioClip specialcoinSFX;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * jumpforce, ForceMode.Impulse);
        }
        Vector3 movement = new Vector3 ();
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");

        rb.AddForce(movement * Time.deltaTime * movementSpeed, ForceMode.Impulse);

    }
    private void OnTriggerEnter(Collider  other)
    {

        if (other.CompareTag("CoinItem"))
        {
            Debug.Log("He tocado una moneda");
            coins++;
            AudioSource.PlayClipAtPoint(coinSFX, transform.position);  //transform.position hace que el sonido se reproduzca m�s alto o m�s bajo seg�n la distancia donde est� el sonido de la c�mara.
        }
        else if (other.CompareTag("SpecialCoin"))
        {
            Debug.Log("He tocado una moneda especial");
            coins+=5;
            AudioSource.PlayClipAtPoint(specialcoinSFX, transform.position);
        }
        if (other.tag.Contains("Coin"))
        {
            coinsText.text = coins.ToString() ;
            other.gameObject.SetActive(false);
            

        }

    }

}
