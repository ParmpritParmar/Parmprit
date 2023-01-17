using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterSwapper : MonoBehaviour
{
    public GameObject ModelPlayer;
    public GameObject ModelDevil;

    public Avatar AvatarPlayer;
    public Avatar AvatarDevil;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (ModelPlayer.activeInHierarchy)
            {
                ModelPlayer.SetActive(false);
                ModelDevil.SetActive(true);

                other.GetComponent<Animator>().avatar = AvatarDevil;
            }
            else if (ModelDevil.activeInHierarchy)
            {
                ModelDevil.SetActive(false);
                ModelPlayer.SetActive(true);

                other.GetComponent<Animator>().avatar = AvatarPlayer;
            }
        }
    }
}
