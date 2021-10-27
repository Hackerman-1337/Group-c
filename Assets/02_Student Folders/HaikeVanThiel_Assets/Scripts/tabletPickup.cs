using UnityEngine;

[RequireComponent(typeof(Pickup))]
public class tabletPickup : MonoBehaviour
{
    [Tooltip("The prefab for the weapon that will be added to the player on pickup")]
    public GameObject tablet;

    Pickup m_Pickup;

    void Start()
    {
        m_Pickup = GetComponent<Pickup>();
        DebugUtility.HandleErrorIfNullGetComponent<Pickup, tabletPickup>(m_Pickup, this, gameObject);

        // Subscribe to pickup action
        m_Pickup.onPick += OnPicked;
    }

	
    void OnPicked(PlayerCharacterController byPlayer)
    {
	    m_Pickup.PlayPickupFeedback();
	    Destroy(gameObject);
	    tablet.SetActive(true);
    }
   
}
