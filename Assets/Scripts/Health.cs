using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int healthAmount = 50;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Vze helta manqche");
            PlayerControler.instance.currentHealth += healthAmount;
            PlayerControler.instance.UpdateHealth();
            Destroy(gameObject);
        }
    }
}
