using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickyButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Image _img;
    [SerializeField] private Sprite _PlayButton;
    [SerializeField] private AudioClip _compressClip;
    [SerializeField] private AudioSource _source;

    public void OnPointerDown(PointerEventData eventData)
    {
        _img.sprite = _PlayButton;
        _source.PlayOneShot(_compressClip);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _img.sprite = _PlayButton;
    }
}
