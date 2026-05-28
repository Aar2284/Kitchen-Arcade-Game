using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjScriptableObj kitchenObjectSO;
    [SerializeField] private Transform CounterTopPoint;
    [SerializeField] private ClearCounter secondClearCounter;
    [SerializeField] private bool testing;

    private KitchenObject kitchenObject;
    
    private void Update()
    {
        if(testing && Input.GetKeyDown(KeyCode.T) && kitchenObject != null)
        {
            kitchenObject.SetClearCounter(secondClearCounter);
        }
    }
    public void Interact()
    {
        if(kitchenObject == null)
        {
            Transform KitchenObjectTransform = Instantiate(kitchenObjectSO.prefab, CounterTopPoint);
            KitchenObjectTransform.GetComponent<KitchenObject>().SetClearCounter(this);
        }

        else
        {
            Debug.Log("Counter is empty");
        }  
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return CounterTopPoint;
    }

    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }
    
    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }

    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }
}
