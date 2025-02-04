using UnityEngine;

public class LightsOffByGhostEvent : MonoBehaviour
{
    [SerializeField] int keysRequired;
    [SerializeField] SoundType soundType;

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerView>() != null && keysRequired == GameService.Instance.GetPlayerController().KeysEquipped)
        {
            EventService.Instance.OnLightsOffByGhostEvent.InvokeEvent();
            GameService.Instance.GetSoundView().PlaySoundEffects(soundType);
            this.enabled = false;
        }
    }
}