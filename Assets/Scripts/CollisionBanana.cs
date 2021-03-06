using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBanana : MonoBehaviour
{
    [SerializeField] GameObject patlama;
    [SerializeField] GameObject hotDogS;
    [SerializeField] GameObject bananaS;
    private GameManagerScript gameManager;
    private void Awake()
    {
        gameManager = FindObjectOfType<GameManagerScript>();
    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BananaTag")
        {
            gameManager.liste.Add(gameObject);
            var patlamaClone = Instantiate(patlama, this.gameObject.transform.position, this.gameObject.transform.rotation);
            Destroy(patlamaClone, 3f);
            gameManager.NewObje(hotDogS);

        }

    }
}
