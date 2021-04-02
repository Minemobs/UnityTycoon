using UnityEngine;

public class BlockGen : MonoBehaviour
{
    public Generator generator;
    private bool isDupe = false;
    
    public bool IsDupe
    {
        get => isDupe;
        set => isDupe = value;
    }
}
