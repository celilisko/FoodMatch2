using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseController : MonoBehaviour
{
    [SerializeField] Rigidbody physicCheese;
    [SerializeField] float speed;
    [SerializeField] GameObject patlama;
    [SerializeField] GameObject watermelon;
    [SerializeField] GameObject cheeseS;
    private GameManagerScript gameManager;
    [SerializeField] GameObject LastScreen;
    void Start()
    {
        physicCheese = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");
        Vector3 vector = new Vector3(yatay, 0, dikey);
        physicCheese.velocity = vector * speed;
    }
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManagerScript>();
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CheeseTag")
        {
            //gameManager.liste.Add(gameObject);
            Destroy(gameObject);
            Destroy(collision.gameObject);
            var patlamaClone = Instantiate(patlama, this.gameObject.transform.position, this.gameObject.transform.rotation);
            Destroy(patlamaClone, 3f);
            //gameManager.NewObje(watermelon);
            Instantiate(watermelon, (this.transform.position), this.gameObject.transform.rotation);
            LastScreen.SetActive(true);
        }

    }
}
