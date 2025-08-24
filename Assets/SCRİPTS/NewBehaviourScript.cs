using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject secimEkrani; // Inspector'dan atanacak

    public void SecimEkraniniAc()
    {
        if (secimEkrani != null)
            secimEkrani.SetActive(true);
    }
}
    