using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ShowTrophies : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // get objects with tag "Trophy"
        GameObject[] trophies = GameObject.FindGameObjectsWithTag("Trophy").OrderBy(go => go.name).ToArray();

        // disable trophies
        for (int i = 0; i < trophies.Length; i++)
        {
            trophies[i].SetActive(false);
        }

        // enable trophies
        // if strawberries global is equal to 16 (all strawberries collected)
        if (PlayerLife.strawberriesGlobal == 16)
        {
            trophies[0].SetActive(true);
        } else
        // if lives is equal to 5 (no lives lost)
        if (PlayerLife.strawberriesGlobal > 10)
        {
            trophies[0].SetActive(true);
            trophies[1].SetActive(true);
        } else if (PlayerLife.strawberriesGlobal > 5)
        {
            trophies[0].SetActive(true);
            trophies[1].SetActive(true);
            trophies[2].SetActive(true);
        }
    }
}
