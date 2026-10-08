using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    //プレイヤーの入力（WASD,矢印キー）が入力されたらstageを回転させる
    private InputAction _playerInput;

    [SerializeField]
    private GameObject _stage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerInput = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = _playerInput.ReadValue<Vector2>().x;
        float verticalInput = _playerInput.ReadValue<Vector2>().y;

        _stage.transform.Rotate(horizontalInput*0.1f, 0f, verticalInput*0.1f);
    }
}
