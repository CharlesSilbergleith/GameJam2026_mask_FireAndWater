using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public InputActionAsset inputs;
    public PlayerStun stun;
    public Vector2 moveInput()
    {
        if (stun.getIsStunned()) return Vector2.zero;
        return inputs["Move"].ReadValue<Vector2>();
    }
    public float mouseInput()
    {
        return inputs["Look"].ReadValue<Vector2>().x;
    }
    public bool jumpInput()
    {
        if (stun.getIsStunned()) return false;
        return inputs["Jump"].triggered;
    }
    public bool shootInput()
    {
        if (stun.getIsStunned()) return false;
        return inputs["Attack"].triggered;
    }
}
