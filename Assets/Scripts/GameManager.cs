using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerControler.instance.hasDied)
        {
            UnlockCursor();
        }
        else
        {
            LockCursor();
        }
        
    }

    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
