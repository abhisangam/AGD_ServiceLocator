using ServiceLocator.Events;
using ServiceLocator.Map;
using ServiceLocator.Player;
using ServiceLocator.Sound;
using ServiceLocator.UI;
using ServiceLocator.Utilities;
using ServiceLocator.Wave;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameService : GenericMonoSingleton<GameService>
{
    [SerializeField] private PlayerService playerService;
    public PlayerService PlayerService {  get { return playerService; } }

    [SerializeField] private MapService mapService;
    public MapService MapService { get {  return mapService; } }

    [SerializeField] private UIService uiService;

    public UIService UIService { get {  return uiService; } }

    [SerializeField] private WaveService waveService;
    public WaveService WaveService { get { return waveService; } }

    [SerializeField] private EventService eventService;
    public EventService EventService { get { return eventService; } }

    [SerializeField] private SoundService soundService;
    public SoundService SoundService { get { return soundService; } }

}
