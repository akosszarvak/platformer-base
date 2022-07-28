using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{

  private Vector2 movementInput;
    public void onMoveInput(InputAction.CallbackContext context)
  {
    movementInput = context.ReadValue<Vector2>();

    if (context.performed)
    {
      Debug.Log(movementInput);
    }
  }

  

  public void onJumpInput(InputAction.CallbackContext context)
  {
    if(context.started){
      Debug.Log("Jump pushed");
    }
    if (context.performed)
    {
      Debug.Log("Jump is held down");
    }

    if(context.canceled){
      Debug.Log("Jump is released");
    }
  }
}
