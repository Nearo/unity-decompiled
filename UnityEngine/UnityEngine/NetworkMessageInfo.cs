﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.NetworkMessageInfo
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
  /// <summary>
  ///   <para>This data structure contains information on a message just received from the network.</para>
  /// </summary>
  [RequiredByNativeCode]
  public struct NetworkMessageInfo
  {
    private double m_TimeStamp;
    private NetworkPlayer m_Sender;
    private NetworkViewID m_ViewID;

    /// <summary>
    ///   <para>The time stamp when the Message was sent in seconds.</para>
    /// </summary>
    public double timestamp
    {
      get
      {
        return this.m_TimeStamp;
      }
    }

    /// <summary>
    ///   <para>The player who sent this network message (owner).</para>
    /// </summary>
    public NetworkPlayer sender
    {
      get
      {
        return this.m_Sender;
      }
    }

    /// <summary>
    ///   <para>The NetworkView who sent this message.</para>
    /// </summary>
    public NetworkView networkView
    {
      get
      {
        if (!(this.m_ViewID == NetworkViewID.unassigned))
          return NetworkView.Find(this.m_ViewID);
        Debug.LogError((object) "No NetworkView is assigned to this NetworkMessageInfo object. Note that this is expected in OnNetworkInstantiate().");
        return this.NullNetworkView();
      }
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal NetworkView NullNetworkView();
  }
}
