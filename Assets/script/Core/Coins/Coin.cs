using Unity.Netcode;
using UnityEngine;

public abstract class Coin : NetworkBehaviour
{
    [SerializeField] private SpriteRenderer _spriteRenderer;

    protected int coinValue = 10;

    protected bool alreadyCollected;

    public abstract int Collect();

    public void SetValue(int value)
    {
        this.coinValue = value;
    }

    public void Show(bool show)
    {
        _spriteRenderer.enabled = show;
    }
}
