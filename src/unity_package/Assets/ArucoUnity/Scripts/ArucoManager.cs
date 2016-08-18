﻿using UnityEngine;
using System.Runtime.InteropServices;

public partial class ArucoUnity : MonoBehaviour
{
  public partial class Dictionary { }

  public enum PREDEFINED_DICTIONARY_NAME
  {
    DICT_4X4_50 = 0,
    DICT_4X4_100,
    DICT_4X4_250,
    DICT_4X4_1000,
    DICT_5X5_50,
    DICT_5X5_100,
    DICT_5X5_250,
    DICT_5X5_1000,
    DICT_6X6_50,
    DICT_6X6_100,
    DICT_6X6_250,
    DICT_6X6_1000,
    DICT_7X7_50,
    DICT_7X7_100,
    DICT_7X7_250,
    DICT_7X7_1000,
    DICT_ARUCO_ORIGINAL
  }

  [DllImport("aruco_unity_lib")]
  static extern System.IntPtr getPredefinedDictionary(PREDEFINED_DICTIONARY_NAME name);

  public static Dictionary GetPredefinedDictionary(PREDEFINED_DICTIONARY_NAME name)
  {
    return new Dictionary(getPredefinedDictionary(name));
  }
}