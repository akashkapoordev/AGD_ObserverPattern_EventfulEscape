using UnityEngine;

public class KeyView : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        int currenKey = GameService.Instance.GetPlayerController().KeysEquipped;
        GameService.Instance.GetInstructionView().HideInstruction();
        GameService.Instance.GetSoundView().PlaySoundEffects(SoundType.KeyPickUp);
        currenKey++;
        EventService.Instance.OnKeyPickup.InvokeEvent(currenKey);
        gameObject.SetActive(false);
    }
}
