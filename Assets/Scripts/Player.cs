using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private GameInput gameInput;
    [SerializeField] private LayerMask countersLayerMask;
    private bool isWalking;
    private Vector3 lastInteractDir;

    private void Update()
    {
        HandleMovement();
        HandelInteractions();
    }

    public bool IsWalking()
    {
        return isWalking;
    }
    private void HandelInteractions()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);

        if(moveDir != lastInteractDir)
        {
            lastInteractDir = moveDir;
        }
        float interactDistance = 2f;

        if(Physics.Raycast(transform.position, lastInteractDir, out RaycastHit raycastHit, interactDistance, countersLayerMask))
        {
            if(raycastHit.transform.TryGetComponent(out ClearCounter clearCounter))
            {
                //Has ClearCounter
                clearCounter.Interact();
            }
        }
    }

    private void HandleMovement()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);

        float moveDistance = moveSpeed * Time.deltaTime;
        float playerRadius = .7f;
        float playerHeight = 2f;
        bool canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDir, moveDistance);

        if(!canMove)
        {
            // Cannot move towards moveDir
            //Attempt only X movement

            Vector3 moveDirX = new Vector3(moveDir.x, 0, 0).normalized;
            bool canMoveX = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDirX, moveDistance);

            if(canMoveX)
            {
                //Can move only on the X
                moveDir = moveDirX;
            }

            else
            {
                //Cannot move only on the X
                //Attempt only the Z movement
                Vector3 moveDirZ = new Vector3(0, 0, moveDir.z).normalized;
                bool canMoveZ = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDirZ, moveDistance);

                if(canMoveZ)
                {
                    //Can move only on the Z
                    moveDir = moveDirZ;
                }

                else
                {
                    //Cannot move in any direction
                    moveDir = Vector3.zero;
                }
            }
        }

        if(canMove)
        {
            transform.position += moveDir * moveDistance;
        }

        isWalking = moveDir != Vector3.zero;
        if(isWalking)
        {
            float rotateSpeed = 10f;
            transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotateSpeed);
        }
    }
}
