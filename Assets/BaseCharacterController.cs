using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class BaseCharacterController : MonoBehaviour
{
    private Vector2 movementInput;
    [SerializeField] float movementSpeed;

    
    public void Movement(CallbackContext ctx)
    {
        // Debug.Log($"Context: {ctx.ReadValue<Vector2>()}");
        movementInput = ctx.ReadValue<Vector2>();
    }

    /* multiple row commentsssssssssssssssssssssssss are made like thisssssssssss okayyyyyyyyyyyyyyy, put themmmmmmmmmmmmmmmmmm
     heeeeereeeeee */
    private void Update()
    {
        
        transform.position += new Vector3(movementInput.x, movementInput.y, 0) * Time.deltaTime * movementSpeed; // comment
    }
}
