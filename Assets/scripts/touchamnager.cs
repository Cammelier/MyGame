using UnityEngine.InputSystem;
using UnityEngine;
using System.Runtime.CompilerServices;

public class touchamnager : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    private PlayerInput playerinput;

    private InputAction touchPositionAction;
    private InputAction touchPressAction;


    private void Awake()
    {
       
 
        playerinput = GetComponent<PlayerInput>();
         touchPressAction = playerinput.actions["TouchPress"];
        touchPositionAction = playerinput.actions["TouchPosition"];
    }

    private void OnEnable()
    {
         
        touchPressAction.performed += TouchPressed; 
    }

    private void OnDisable()
    {
        touchPressAction.performed -= TouchPressed;
    }

    private void TouchPressed(InputAction.CallbackContext context)
    {
       Vector3 position = Camera.main.ScreenToWorldPoint(touchPositionAction.ReadValue<Vector2>());
        position.z = player.transform.position.z;
        player.transform.position = position;
    }

    private void Update()
    {
        touchPositionAction.ReadValue<Vector2>();
        if (touchPositionAction.WasPerformedThisFrame())
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(touchPositionAction.ReadValue<Vector2>());
            position.z = player.transform.position.z;
            player.transform.position = position;
        }
    }
}

