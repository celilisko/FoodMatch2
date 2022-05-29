using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    [SerializeField] GameObject nesne;
    public List<GameObject> liste;
    
    void Start()
    {
        float belirliPozisyonX = -8f;
        float belirliPozisyonZ= -8f;
        int i = 0;
        do
        {

            if (belirliPozisyonX <= 8f)
            {
                Vector3 pozisyonOlusturma = new Vector3(belirliPozisyonX, 0, belirliPozisyonZ);
                Instantiate(nesne, pozisyonOlusturma, Quaternion.identity);
                belirliPozisyonX += 3;
                i++;
            }
            else
            {
                belirliPozisyonZ += 2.5f;
                belirliPozisyonX = -8f;
            }
        }
        while (i < 32);
    }

    public void NewObje(GameObject obje)
    {
        if (liste.Count == 2)
        {
            Instantiate(obje, (liste[0].transform.position+liste[1].transform.position)/2, this.gameObject.transform.rotation);
            Destroy(liste[0]);
            Destroy(liste[1]);
            liste.Clear();
            
        }
        
    }
}
