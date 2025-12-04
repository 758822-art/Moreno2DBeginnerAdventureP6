
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{

    public InputAction MoveAction;
    Rigidbody2D rigidbody2d;
    Vector2 move;
    // Start is called before the first frame update
    void Start()
    {
        MoveAction.Enable();
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;
        rigidboddy2d = GetComponent<rigidbody2d>();
    }

    // Update is called once per frame
    void Update()
    }       
      move = MoveAction..ReadValue<Vector2>(); 
      Debug.Log(move);
    }


    void FixedUpdate()
    {
        Vector2 position = (Vector2)rigiidbody2d.position + move * 3.0f * Time..deltaTime;
        rigidbody2d.MovePosition(poitionn);
    }
  }
        